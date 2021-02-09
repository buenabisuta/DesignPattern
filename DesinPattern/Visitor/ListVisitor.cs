using System;
namespace DesinPattern.Visitor
{
    public class ListVisitor : Visitor
    {
        private string currentdir = "";

        public override void Visit(File file)
        {
            Console.WriteLine($"{currentdir}/{file}");
        }

        public override void Visit(Directory directory)
        {
            Console.WriteLine($"{currentdir}/{directory}");
            var savedir = currentdir;
            currentdir = currentdir + "/" + directory.GetName();

            foreach(var item in directory.GetEntries())
            {
                item.Accept(this);
            }

            currentdir = savedir;
        }
    }
}
