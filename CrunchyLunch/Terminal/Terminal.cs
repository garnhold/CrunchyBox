using System;

using CrunchyDough;

namespace CrunchyLunch
{
    public abstract class Terminal
    {
        private int cursor_x;
        private int cursor_y;

        private int terminal_width;

        private int indent_level;
        private int spaces_per_indent_level;

        protected abstract void RasterInternal(int x, int y, string text);
        protected abstract void ClearInternal();

        private void UpdateIndentLevel()
        {
            SetCursorX(cursor_x.Max(GetIndentLevelWidth()));
        }

        public Terminal(int width, int indent_size)
        {
            cursor_x = 0;
            cursor_y = 0;

            terminal_width = width;

            indent_level = 0;
            spaces_per_indent_level = indent_size;
        }
        public Terminal(int width) : this(width, StringExtensions_Space.DEFAULT_NUMBER_SPACES_PER_TAB) { }

        public void Raster(int x, int y, int width, string text)
        {
            int maximum_width = terminal_width - x;
            int acting_width = width.Min(maximum_width);

            RasterInternal(x, y, text.MakeSingleLine().Truncate(acting_width));
        }

        public void Clear()
        {
            ClearInternal();
            SetCursor(0, 0);
        }

        public T PlaceTerminalBlock<T>(int x, int y, T terminal_block) where T : TerminalBlock
        {
            if (terminal_block != null)
                terminal_block.Place(x, y, this);

            return terminal_block;
        }

        public T AppendTerminalBlock<T>(T terminal_block) where T : TerminalBlock
        {
            if (terminal_block != null)
            {
                terminal_block.Place(cursor_x, cursor_y, this);
                AdjustCursorX(terminal_block.GetWidth());
            }

            return terminal_block;
        }

        public T AppendTerminalBlockNewline<T>(T terminal_block) where T : TerminalBlock
        {
            if (terminal_block != null)
            {
                terminal_block.SetWidth(GetCursorRemainingWidth());
                AppendTerminalBlock(terminal_block);
            }

            Newline();
            return terminal_block;
        }

        public void Indent()
        {
            AdjustIndentLevel(1);
        }

        public void Dedent()
        {
            AdjustIndentLevel(-1);
        }

        public void AdjustIndentLevel(int amount)
        {
            SetIndentLevel(GetIndentLevel() + amount);
        }

        public void SetIndentLevel(int level)
        {
            indent_level = level.BindAbove(0);

            UpdateIndentLevel();
        }

        public void Newline()
        {
            SetCursorX(0);
            AdjustCursorY(1);

            UpdateIndentLevel();
        }

        public void AdjustCursor(int dx, int dy)
        {
            AdjustCursorX(dx);
            AdjustCursorY(dy);
        }

        public void AdjustCursorX(int dx)
        {
            SetCursorX(GetCursorX() + dx);
        }

        public void AdjustCursorY(int dy)
        {
            SetCursorY(GetCursorY() + dy);
        }

        public void SetCursor(int nx, int ny)
        {
            SetCursorX(nx);
            SetCursorY(ny);
        }

        public void SetCursorX(int nx)
        {
            cursor_x = nx.BindBetween(0, terminal_width - 1);
        }

        public void SetCursorY(int ny)
        {
            cursor_y = ny.BindAbove(0);
        }

        public int GetCursorX()
        {
            return cursor_x;
        }

        public int GetCursorY()
        {
            return cursor_y;
        }

        public int GetCursorRemainingWidth()
        {
            return GetTerminalWidth() - GetCursorX();
        }

        public int GetTerminalWidth()
        {
            return terminal_width;
        }

        public int GetIndentLevel()
        {
            return indent_level;
        }

        public int GetIndentLevelWidth()
        {
            return indent_level * spaces_per_indent_level;
        }
    }
}