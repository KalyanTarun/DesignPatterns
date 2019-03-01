using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    interface IComputer
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

        public override string ToString()
        {
            return ram + "\n" + processor + "\n" + version;
        }
    }
    abstract class ComputerFactory{
        public abstract IComputer build();
    }
    class DesktopFactory : ComputerFactory
    {
        public override IComputer build()
        {
            return new Desktop();
        }
    }
    class LaptopFactory : ComputerFactory
    {
        public override IComputer build()
        {
            return new Laptop();
        }
    }

    class FactoryPattern
    {
        static void Main(string[] args)
        {
            ComputerFactory computerFactory = null;
            String type = "Desktop";
            if (type.Equals("Desktop"))
            {
                computerFactory = new DesktopFactory();
                IComputer desktop = computerFactory.build();
                Console.WriteLine(desktop);
            }
            else  if (type.Equals("Laptop"))
            {
                computerFactory = new LaptopFactory();
                IComputer laptop = computerFactory.build();
                Console.WriteLine(laptop);
            }
        }
    }
}
