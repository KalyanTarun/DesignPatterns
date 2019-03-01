using System;
interface IComputerBody{
 string compBody{get;}
}

interface IComputerHardDisk{
string compHardDisk{get;}
}

 class DesktopBody:IComputerBody{
	public string compBody{
	get{return "Desktop Body" ;}
	}
}

 class LaptopBody:IComputerBody{
	public string compBody{
	get{return "Laptop Body" ;}
	}
}

class DesktopHardDisk:IComputerHardDisk{
	public string compHardDisk{
	get{return "Desktop HardDisk" ;}
	}
}

 class LaptopHardDisk:IComputerHardDisk{
	public string compHardDisk{
	get{return "Laptop HardDisk" ;}
	}
}

abstract class ComputerFactory{
public abstract IComputerBody prepareComputerBody();
public abstract IComputerHardDisk prepareComputerHardDisk();
}

class DesktopFactory:ComputerFactory{
public override IComputerBody prepareComputerBody(){
	return new DesktopBody();
}
public override IComputerHardDisk prepareComputerHardDisk(){
    return new DesktopHardDisk();
}
}
class LaptopFactory:ComputerFactory{
public override IComputerBody prepareComputerBody(){
	return new LaptopBody();
}
public override IComputerHardDisk prepareComputerHardDisk(){
    return new LaptopHardDisk();
}


}
public class Program
{
	 String prepType;
     ComputerFactory computerfactory=null;
	
	public static void Main()
	{   Program p=new Program();
		p.prepType="Computer";
	    if(p.prepType.Equals("Laptop")){
         p.computerfactory=new DesktopFactory();		
		}
        else{
		p.computerfactory=new LaptopFactory();
		}
	    IComputerBody computerBody=p.computerfactory.prepareComputerBody();
	    IComputerHardDisk computerHardDisk=p.computerfactory.prepareComputerHardDisk();
	 
	   Console.WriteLine(computerBody.compBody+"   "+computerHardDisk.compHardDisk);		
	}
}