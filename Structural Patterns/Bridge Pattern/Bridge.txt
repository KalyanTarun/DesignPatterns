using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    interface AndroidNoughat
    {
        void Drawer();
        void Pin();
    }
    class Redmi4 : AndroidNoughat
    {
        public void Drawer()
        {
            Console.WriteLine("Opening Drawer");
        }
        public void Pin()
        {
            Console.WriteLine("Enter the pin");
        }
    }
    class AndroidOreoBeta
    {
        AndroidNoughat android;
        public AndroidOreoBeta(AndroidNoughat android)
        {
            this.android=android;
        }
        public void dock()
        {
            android.Drawer();
        }
        public void passcode()
        {
            android.Pin();
        }
        public void faceUnlock()
        {
            Console.WriteLine("Unlocking by recognizing the face");
        }
        public void biometric()
        {
            Console.WriteLine("Unlocking by scanning finger prints");
        }
    }
    class Bridge
    {
        public static void Main(string[] args)
        {
            AndroidNoughat androidNoughat = new Redmi4();
            androidNoughat.Drawer();
            androidNoughat.Pin();
            //Trying androidOrea Beta version in AndroidNoughat
            AndroidOreoBeta androidOreoBeta = new AndroidOreoBeta(new Redmi4());
            androidOreoBeta.dock();
            androidOreoBeta.passcode();
            androidOreoBeta.faceUnlock();
            androidOreoBeta.biometric();
        }
    }
}
