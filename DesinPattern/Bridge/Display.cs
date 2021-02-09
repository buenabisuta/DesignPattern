using System;
namespace DesinPattern.Bridge
{
    public class Display
    {
        private DisplayImpl displayImpl;
        public Display(DisplayImpl impl)
        {
            this.displayImpl = impl;
        }

        public void Open()
        {
            displayImpl.RawOpen();
        }

        public void Print()
        {
            displayImpl.RawPrint();
        }

        public void Close()
        {
            displayImpl.RawClose();
        }

        public void ShowDisplay()
        {
            Open();
            Print();
            Close();
        }
    }
}
