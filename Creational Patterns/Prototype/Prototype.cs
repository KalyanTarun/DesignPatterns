using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    interface IComputer : ICloneable
    {
        String ram { get; }
        String processor { get; }
        int version { get; }
    }
    class Desktop : IComputer
    {
        public String ram { get { return "Desktop Ram:8GB"; } }
        public String processor { get { return "Desktop processor:i5"; } }
        public int version { get { return 2; } }

       public virtual object Clone()
         {
                return this.MemberwiseClone();
         }

        public override string ToString()
        {
            return ram + "\n" + processor + "\n" + version;
        }
    }
    class Laptop : IComputer
    {
        public String ram { get { return "Laptop Ram:16GB"; } }
        public String processor { get { return "Laptop processor:i7"; } }
        public int version { get { return 3; } }

            public virtual object Clone()
            {
                return this.MemberwiseClone();
            }
        public override string ToString()
        {
            return ram + "\n" + processor + "\n" + version;
        }
    }
    class ComputerManager
    {
        Desktop desktop = null;
        Laptop laptop = null;
        public ComputerManager()
        {
            desktop = new Desktop();
            laptop = new Laptop();
        }
        public IComputer createDesktop()
        {
            return (IComputer)desktop.Clone();
        }
        public IComputer createLaptop()
        {
            return (IComputer)laptop.Clone();
        }
    }
    class Prototype
    {
        public static void Main(string[] args) {
            ComputerManager computerManager = new ComputerManager();
            String type = "Desktop";
            if (type.Equals("Desktop"))
            {
                IComputer desktop = computerManager.createDesktop();
                Console.WriteLine(desktop);
            }
            else if (type.Equals("Laptop"))
            {
                IComputer laptop = computerManager.createLaptop();
                Console.WriteLine(laptop);
            }
        }
    }
}
