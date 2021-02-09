using System;
using System.Text;

namespace DesinPattern.Decorate
{
    public class UpDownBorder : Border
    {
        private char borderchar;
        public UpDownBorder(Display display,char ch) : base(display)
        {
            borderchar = ch;
        }

        public override int GetColumns()
        {
            return 1 + display.GetColumns() + 1;
        }

        public override int GetRows()
        {
            return 1 + display.GetRows() + 1;
        }

        public override string GetRowText(int row)
        {
            if (row == 0 || row == GetRows() - 1)
            {
                return MakeLine(borderchar, GetColumns());
            }
            else
            {
                return display.GetRowText(row - 1);
            }
        }

        private string MakeLine(char ch, int count)
        {
            var buf = new StringBuilder();
            for (var i = 0; i < count; i++)
            {
                buf.Append(ch);
            }
            return buf.ToString();
        }

    }
}
