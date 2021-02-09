using System;
using System.Collections.Generic;

namespace DesinPattern.Builder
{
    public class Director
    {
        private Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void Constructor()
        {
            builder.MakeTitle("Greeting");
            builder.MakeString("朝から夜にかけて");
            builder.MakeItems(new List<string>() { "おはよう","こんにちは" });

            builder.MakeTitle("night");
            builder.MakeString("夜に");
            builder.MakeItems(new List<string>() { "こんばんは", "おやすみ" });
            builder.Close();

            Console.WriteLine(builder.GetResult());
        }
    }
}
