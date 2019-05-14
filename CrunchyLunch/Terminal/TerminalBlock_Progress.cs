using System;

using CrunchyDough;
using CrunchyBun;

namespace CrunchyLunch
{
    public class TerminalBlock_Progress : TerminalBlock
    {
        private int bar_width;

        private float progress;
        private Timer progress_timer;

        protected override void RenderInternal(int x, int y, int width, Terminal terminal)
        {
            int percent = (int)(GetProgress() * 100);

            string bar = "";
            if (bar_width > 0)
                bar = Strings.Gauge(GetProgress(), bar_width, "[", "]", '=', ' ');

            terminal.Raster(x, y, width, bar + "(" + percent + "% " + GetRemainingTime() + ")");
        }

        public TerminalBlock_Progress(int bw) : base(bw + 15)
        {
            bar_width = bw;

            progress = 0.0f;
            progress_timer = new Timer();
        }

        public TerminalBlock_Progress() : this(0) { }

        public void StartProgress()
        {
            UpdateProgress(0.0f);
            progress_timer.Restart();
        }

        public void FinishProgress()
        {
            UpdateProgress(1.0f);
            progress_timer.Pause();
        }

        public void UpdateProgress(float p)
        {
            if (progress_timer.IsStopped())
                progress_timer.Restart();

            progress = p.BindBetween(0.0f, 1.0f);
            Render();
        }
        public void UpdateProgress(double current, double all)
        {
            UpdateProgress((float)(current / all));
        }

        public float GetProgress()
        {
            return progress;
        }

        public float GetRemaining()
        {
            return 1.0f - GetProgress();
        }

        public float GetRemainingAsMultiple()
        {
            return GetRemaining() / GetProgress();
        }

        public Duration GetRemainingTime()
        {
            return Duration.Milliseconds(GetRemainingAsMultiple() * progress_timer.GetElapsedTimeInMilliseconds());
        }
    }
}