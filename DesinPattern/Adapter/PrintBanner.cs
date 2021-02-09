using System;
namespace DesinPattern.Adapter
{
    public class PrintBanner : Print
    {
        private Banner banner;
        public PrintBanner(Banner banner)
        {
            this.banner = banner;
        }

        public override void PrintStrong()
        {
            banner.showWithAster();
        }

        public override void PrintWeak()
        {
            banner.showWithParen();
        }
    }
}
