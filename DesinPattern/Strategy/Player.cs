﻿using System;
namespace DesinPattern.Strategy
{
    public class Player
    {
        private string name;
        private Strategy strategy;
        private int wincount;
        private int losecount;
        private int gamecount;

        public Player(string name, Strategy strategy)
        {
            this.name = name;
            this.strategy = strategy;
        }

        public Hand NextHand()
        {
            return strategy.NextHand();
        }

        public void Win()
        {
            strategy.Study(true);
            gamecount++;
            wincount++;
        }

        public void Lose()
        {
            strategy.Study(false);
            gamecount++;
            losecount++;
        }

        public void Even()
        {
            gamecount++;
        }

        public override string ToString()
        {
            return $"{name}:{gamecount} games, {wincount} win , {losecount} lose";
        }
    }
}
