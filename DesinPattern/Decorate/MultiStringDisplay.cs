using System;
using System.Collections.Generic;
using System.Text;

namespace DesinPattern.Decorate
{
    public class MultiStringDisplay : Display
    {
        private List<string> body = new List<string>();
        private int columns = 0;

        public override int GetColumns()
        {
            return columns;
        }

        public override int GetRows()
        {
            return body.Count;
        }

        public override string GetRowText(int row)
        {
            return body[row];
        }

        public void Add(string msg)
        {
            body.Add(msg);
            UpdateColumn(msg);
        }

        private void UpdateColumn(string msg)
        {
            if (msg.Length > columns)
            {
                columns = msg.Length;
            }

            for (var i = 0; i < body.Count; i++)
            {
                var files = columns - body[i].Length;
            }
        }

        private string Spaces(int count)
        {
            var sb = new StringBuilder();
            for(var i = 0; i < count; i++)
            {
                sb.Append(' ');
            }

            return sb.ToString();
        }
    }
}
