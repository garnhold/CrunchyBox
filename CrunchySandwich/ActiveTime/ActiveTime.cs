using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class ActiveTime
    {
        private GameTimer timer;

        static public float time { get{ return GetActiveTime().GetTimeInSeconds(); } }
        static public float deltaTime { get { return GetActiveTime().GetDeltaTime(); } }

        static public bool StartTime()
        {
            return GetActiveTime().Start();
        }

        static public bool PauseTime()
        {
            return GetActiveTime().Pause();
        }

        static private ActiveTime INSTANCE;
        static public ActiveTime GetActiveTime()
        {
            if (INSTANCE == null)
                INSTANCE = new ActiveTime();

            return INSTANCE;
        }

        private ActiveTime()
        {
            timer = new GameTimer();
            timer.Start();
        }

        public bool Start()
        {
            return timer.Start();
        }

        public bool Pause()
        {
            return timer.Pause();
        }

        public bool IsRunning()
        {
            return timer.IsRunning();
        }

        public float GetTimeInSeconds()
        {
            return timer.GetElapsedTimeInSeconds();
        }

        public long GetTimeInMilliseconds()
        {
            return timer.GetElapsedTimeInMilliseconds();
        }

        public float GetDeltaTime()
        {
            if (IsRunning())
                return Time.deltaTime;

            return 0.0f;
        }
    }
}