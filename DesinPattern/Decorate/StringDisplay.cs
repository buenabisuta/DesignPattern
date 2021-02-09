using System;
namespace DesinPattern.Decorate
{
    public class StringDisplay : Display
    {
        private string st;
        public StringDisplay(string st)
        {
            this.st = st;
        }

        public override int GetColumns()
        {
            return st.Length;
        }

        public override int GetRows()
        {
            return 1;
        }

        public override string GetRowText(int row)
        {
            return row == 0 ? st : null;
        }
    }
}
