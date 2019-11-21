using System;
using System.Collections.Generic;
using System.Text;
using ControlEx.Model;

namespace ControlEx.Data
{
   public class FruitData
    {
        public IList<Fruit> GetFruits()
        {
            return new List<Fruit>
            {
                new Fruit
                {
                    Name="Apple",
                    Details = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).",
                    ImgUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/f/f4/Honeycrisp.jpg/220px-Honeycrisp.jpg"

                },

                 new Fruit
                 {
                    Name = "Mango",
                    Details = "Mangoes are juicy stone fruit (drupe) from numerous species of tropical trees belonging to the flowering plant genus Mangifera, cultivated mostly for their edible fruit.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Mangoes_pic.jpg/220px-Mangoes_pic.jpg"

                 },

                 new Fruit
                 {
                     Name = "Banana",
                     Details = "A banana is an edible fruit – botanically a berry – produced by several kinds of large herbaceous flowering plants in the genus Musa.",
                     ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/ff/Banana_and_cross_section.jpg/250px-Banana_and_cross_section.jpg"
                 },

            };
        }

    }
}
