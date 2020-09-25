using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Exo1:");
            //Exercise.One();
            //Console.WriteLine("Exo2:");
            //Exercise.Two();
            //Console.WriteLine("Exo3");
            //Exercise.Three();

            Human v_humain = new Human("valentin", "norro", 20); 
            Car v_car = new Car(v_humain, "peugeot", 4, 185);
            v_car.Accelerate(50);
            v_car.Accelerate(1524);
            Console.WriteLine(v_car.EngagedGear);
            v_car.SlowDown(40);
            Console.WriteLine(v_car.EngagedGear);
            Console.WriteLine(v_car.ShowVehiculePapers());
        }
    }
}
