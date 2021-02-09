using System;
using System.Collections.Generic;

namespace DesinPattern.Factory
{
    public class IDCardFactory : Factory
    {
        private List<string> owners = new List<string>();
        private List<IDCard> iDCards = new List<IDCard>();

        private int serial = 100;

        public IDCardFactory()
        {
        }

        public override Product CreateProduct(string owner)
        {
            return new IDCard(owner,serial++);
        }

        public override void RegisterProduct(Product product)
        {
            owners.Add(((IDCard)product).GetOwner());
            iDCards.Add(((IDCard)product));
        }

        public List<IDCard> GetOwners()
        {
            return iDCards;
        }
    }
}
