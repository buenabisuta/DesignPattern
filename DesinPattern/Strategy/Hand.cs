using System;
using System.Collections.Generic;

namespace DesinPattern.Strategy
{
    public class Hand
    {
        public static int Goo = 0; 
        public static int Choki = 1; 
        public static int Pa = 2;
        public static List<Hand> Hands = new List<Hand>()
        {
            new Hand(Goo),
            new Hand(Choki),
            new Hand(Pa),
        };
        public static List<string> name = new List<string>()
        {
            "グー","チョキ","パー"
        };
        private int handValue;

        public Hand(int handValue)
        {
            this.handValue = handValue;
        }

        public static Hand GetHand(int handValue)
        {
            return Hands[handValue];
        }

        public bool IsStrongThan(Hand h)
        {
            return Fight(h) == 1;
        }

        public bool IsWeakerThan(Hand h)
        {
            return Fight(h) == -1;
        }

        private int Fight(Hand h)
        {
            if (this == h) 
            {
                return 0;
            }
            else if((this.handValue + 1) / 3 == h.handValue)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return name[handValue];
        }
    }
}
