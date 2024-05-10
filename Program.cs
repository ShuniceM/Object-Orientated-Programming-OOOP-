class Program
{
    static void Main(string[] args)
    {
         Vehicle obj = new Vehicle();
        Vehicle obj2 = new Vehicle(2);

       // VehicleTwo objTwo = new VehicleTwo();
    }
    
}

public class Vehicle
{
    public Vehicle()
    {
        Console.WriteLine("This is a brand new Vehicle");
    }
    public Vehicle(int Tyrecount)
    {
        Console.WriteLine("Vehicle has two tyres");
    }

   
  
}

//public class VehicleTwo
//{
   // public VehicleTwo()
 //   {
   //     Console.WriteLine("this is our second car");
 //   }
//}

