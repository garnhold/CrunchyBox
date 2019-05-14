using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchyPantry
{
    public abstract class NookSystem_StorageStructure<STRUCTURE_TYPE, FILE_TYPE> : NookSystem where FILE_TYPE : FileSnapshot where STRUCTURE_TYPE : StorageStructure<FILE_TYPE>
    {
        private STRUCTURE_TYPE structure;

        private RateLimiter initilize_rate_limiter;
        private RateLimiter update_rate_limiter;

        protected abstract bool DeleteInternal(FILE_TYPE snapshot);

        protected abstract bool ReadInternal(FILE_TYPE snapshot, Process<Stream> process);

        protected abstract bool CreateInternal(string path, string name, string mime_type, Process<Stream> process, out FILE_TYPE snapshot);
        protected abstract bool UpdateInternal(FILE_TYPE snapshot, Process<Stream> process);

        protected abstract bool TryGetLocalPathInternal(FILE_TYPE snapshot, out string local_path);

        protected abstract void InitilizeStructure();
        protected abstract void UpdateStructure();

        protected STRUCTURE_TYPE GetStructure()
        {
            return structure;
        }

        private J OperateOnSnapshot<J>(string path, J default_value, Operation<J, FILE_TYPE> operation)
        {
            FILE_TYPE file;

            Update();

            if(structure.TryGetFile(path, out file))
                return operation(file);

            return default_value;
        }

        private void Update()
        {
            initilize_rate_limiter.Process(delegate() {
                InitilizeStructure();
            });

            update_rate_limiter.Process(delegate() {
                UpdateStructure();
            });
        }

        public NookSystem_StorageStructure(STRUCTURE_TYPE s, Duration id, Duration ud)
        {
            structure = s;

            initilize_rate_limiter = new RateLimiter(id);
            update_rate_limiter = new RateLimiter(ud);

            update_rate_limiter.Reset();
        }

        public override bool Delete(string path)
        {
            return OperateOnSnapshot(path, false, s => DeleteInternal(s));
        }

        public override bool IsPresent(string path)
        {
            return OperateOnSnapshot(path, false, s => true);
        }

        public override string GetHash(string path)
        {
            return OperateOnSnapshot(path, null, s => s.GetHash());
        }

        public override bool Read(string path, Process<Stream> process)
        {
            return OperateOnSnapshot(path, false, s => ReadInternal(s, process));
        }

        public override bool Write(string path, Process<Stream> process)
        {
            FILE_TYPE file;

            if (OperateOnSnapshot(path, false, s => UpdateInternal(s, process)))
                return true;

            string name = Filename.GetFilenameWithExtension(path);
            string mime_type = MIMEType.GetMIMETypeFromFilename(name);

            if (CreateInternal(path, name, mime_type, process, out file))
            {
                structure.Add(file);
                return true;
            }

            return false;
        }

        public override bool TryGetLocalPath(string path, out string local_path)
        {
            string temp = null;
            bool result = OperateOnSnapshot(path, false, s => TryGetLocalPathInternal(s, out temp));

            local_path = temp;
            return result;
        }

        public override IEnumerable<string> GetPaths(string path)
        {
            Update();

            return structure.GetPaths(path);
        }
    }
}