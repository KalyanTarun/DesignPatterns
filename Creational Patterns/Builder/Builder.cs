using System;

namespace DesignPatterns
{
    abstract class ComputerBuilder {
        public virtual void BuildRam() { }
        public virtual void BuildProcessor() { }
        public virtual void BuildCpu(){ }
        public virtual void BuildMousePad() { }
    }
    class DesktopBuilder : ComputerBuilder
    {
        public override void BuildRam()
        {
            Console.WriteLine("Building Ram for Desktop");
        }
        public override void BuildProcessor()
        {
            Console.WriteLine("Building processor for Desktop");
        }
        public override void BuildCpu()
        {
            Console.WriteLine("Building CPU for Desktop");
        }

    }
    class LaptopBuilder : ComputerBuilder
    {
        public override void BuildRam()
        {
            Console.WriteLine("Building Ram for Laptop");
        }
        public override void BuildProcessor()
        {
            Console.WriteLine("Building processor for Laptop");
        }
        public override void BuildMousePad()
        {
            Console.WriteLine("Building MousePad for Laptop");
        }
    }

    abstract class Director
    {
        public abstract void build(ComputerBuilder computerBuilder);
    }

    class DesktopDirector : Director
    {
        public override void build(ComputerBuilder desktopBuilder)
        {
            desktopBuilder.BuildRam();
            desktopBuilder.BuildProcessor();
            desktopBuilder.BuildCpu();
        }
    }

    class LaptopDirector : Director
    {
        public override void build(ComputerBuilder desktopBuilder)
        {
            desktopBuilder.BuildRam();
            desktopBuilder.BuildProcessor();
            desktopBuilder.BuildMousePad();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ComputerBuilder computerBuilder = new LaptopBuilder();
            Director laptopDirector = new LaptopDirector();
            laptopDirector.build(computerBuilder);
            Console.ReadKey();
        }
    }
}
