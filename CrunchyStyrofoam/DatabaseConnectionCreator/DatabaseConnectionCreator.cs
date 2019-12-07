using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    
    public abstract class DatabaseConnectionCreator
    {
        public abstract SQLiteConnection CreateConnection();
    }
}