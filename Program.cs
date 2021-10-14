using System;


namespace Lesson_09
{
  
    class Program
    {
        static void Main(string[] args)
        {
            AirConditioning airConditioning = new AirConditioning();

            Room room = new Room();
           
            Pultte pultte = new Pultte(new AirConditioning());
            pultte.Notify += Console.WriteLine;
            
            pultte.PowerConditioning_On();
            System.Threading.Thread.Sleep(4500);
            pultte.PowerConditioning_Off();
       
            pultte.IncreaseTemp();
            pultte.IncreaseTemp();
            pultte.IncreaseTemp();
            pultte.IncreaseTemp();
            Console.WriteLine("-------");
            pultte.DecreaseTemp();
            pultte.DecreaseTemp();
            pultte.DecreaseTemp();
            Console.WriteLine("*************");
            
            Console.WriteLine("*************");
            Console.WriteLine(" Задайте температуру в комнате ");
            room.TempRoom = double.Parse(Console.ReadLine());
            airConditioning.ConditioningAvtoTemp(room);
            Console.WriteLine("*************");



            System.Console.ReadKey();
            
        }
    }
}
