using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DesignPatterns
{
    abstract class Stationary
    {
        public virtual int cost { get; }
       public virtual string desc { get; }
        public abstract void AddItem(Stationary item);
        public abstract void RemoveItem(Stationary item);
    }
    class Pen : Stationary
    {
        public override int cost
        {
            get { return 10; }
        }
        public override String desc{
            get{ return "Pen"; }
        }
        public override void AddItem(Stationary item) { }
        public override void RemoveItem(Stationary item) { }
        public override string ToString()
        {
            return desc + "  " + cost;
        }
    }
    class Pencil : Stationary
    {
        public override int cost
        {
            get { return 5; }
        }
        public override String desc
        {
            get { return "Pencil"; }
        }
        public override void AddItem(Stationary item) { }
        public override void RemoveItem(Stationary item) { }
        public override string ToString()
        {
            return desc + "  " + cost;
        }
    }
    class PencilBox : Stationary
    {
       IList<Stationary> items = new List<Stationary>();
        string stationary = "";
        int cost_total = 0;
        public override void AddItem(Stationary item) {
       
            items.Add(item);
        }
        public override void RemoveItem(Stationary item)
        {
            items.Remove(item);
        }
        public override int cost
        {
            get
            {
                foreach(Stationary item in items){
                    
                    cost_total += item.cost;
                }
                return cost_total;
            }
        }
        public override string ToString()
        {
            foreach(Stationary item in items)
            {
                stationary += item + " ";
            }
            return stationary+" \n"+cost;
        }
    }


    class CompositePattern
    {
        public static void Main(string[] args)
        {
            Stationary pen = new Pen();
            Console.WriteLine(pen);
            Stationary pencil = new Pencil();
            Console.WriteLine(pencil);
            //Creating a pencilBox
            Stationary pencilbox = new PencilBox();
            pencilbox.AddItem(pen);
            pencilbox.AddItem(pencil);
            Console.WriteLine(pencilbox);
            
        }
    }
}
