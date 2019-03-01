using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{

    interface IWindows
    {
        string version { get; }
        void Open(string app);
    }
    class Windows10 : IWindows
    {

        public virtual string version
        {
            get
            {
                return "Windows 10.0.1";
            }
        }
        public virtual void Open(string app)
        {
            Console.WriteLine("Click Windows Start Button-->Search for" + app + "-->Click on the icon");
        }
        public override string ToString()
        {
            return version;
        }
    }
    interface ILinux
    {
        string build { get; }
        void CommandShell(String command);
    }

    class Ubuntu : ILinux
    {
        public  string build { get { return "Ubuntu 7.0.1"; } }
        public void CommandShell(String command)
        {
            Console.WriteLine("Opening Command shell-->Entering command-->open " + command);
        }
        public override string ToString()
        {
            return build;
        }
    }
    class LinuxToWindowsAdapter:Windows10{
        ILinux os;
        public LinuxToWindowsAdapter(ILinux os)
        {
            this.os = os;
        }
        public override string version
        {
            get { return os.build; }
        }
        public override void Open(string app)
        {
            os.CommandShell(app);
        }
    }

    class Adapter
    {
        public static void Main(string[] args)
        {
            IWindows windows = new Windows10();
            windows.Open("Visual Studio");
            ILinux ubuntu = new Ubuntu();
            IWindows linuxInWindows = new LinuxToWindowsAdapter(ubuntu);
            linuxInWindows.Open("Visual Studio");
        }
    }
}
