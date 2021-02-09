using System;
namespace DesinPattern.Factory
{
    public class IDCard : Product
    {
        private string owner;
        private int serial;

        public IDCard(string owner,int serial)
        {
            this.owner = owner;
            this.serial = serial;
        }

        public override void Use()
        {
            Console.WriteLine(owner + serial + "のIDカードを使います");
        }

        public string GetOwner()
        {
            return owner;
        }
    }
}
