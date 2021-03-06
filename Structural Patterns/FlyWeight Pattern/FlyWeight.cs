using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    interface IBakery
    {
        string color { get; set; }

        void  Make();
    }

    class Muffin : IBakery
    {
       public string color { get; set; }  
        public Muffin(string color)
        {
            this.color = color;
        }
        public void Make()
        {
            Console.WriteLine("Baked " + color + " Muffin ");
        }
        public override string ToString()
        {
            return color + " Muffin";
        }

    }
    class BakeryFactory
    {
        IBakery item;
        //Dictionary holding the bakery items
        private static  Dictionary<string,IBakery> bakeryObjects;
        public BakeryFactory()
        {
            bakeryObjects = new Dictionary<string, IBakery>(); 
        }
        public IBakery GetBakeryItem(string color) {
            bool present= bakeryObjects.TryGetValue(color, out item);
            if (!present)
            {
                Console.WriteLine("New Item prepared");
                item = new Muffin(color);
                item.Make();
                bakeryObjects[color]=item;
            }
            else
            {
                Console.WriteLine("Item Already Present");
            }
           
            return item;
        }


    }
    class FlyWeight
    {
        public static void Main(string[] args)
        {
            BakeryFactory bakeryFactory = new BakeryFactory();
            IBakery bakery = bakeryFactory.GetBakeryItem("Red");
            Console.WriteLine(bakery);

            IBakery bakery2 = bakeryFactory.GetBakeryItem("Blue");
            Console.WriteLine(bakery2);
            //Returns already present Muffin
            IBakery bakery3 = bakeryFactory.GetBakeryItem("Red");
            Console.WriteLine(bakery3);
        }
    }
}
