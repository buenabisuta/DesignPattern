using System;
namespace DesinPattern.Bridge
{
    public class FileTextDisplayImpl : DisplayImpl
    {
        private string text;
        public FileTextDisplayImpl(string text)
        {
            this.text = text;
        }

        public override void RawClose()
        {
            Console.WriteLine("ファイルを閉じます");
        }

        public override void RawOpen()
        {
            Console.WriteLine("ファイル開きます");
        }

        public override void RawPrint()
        {
            Console.WriteLine(text);
        }
    }
}
