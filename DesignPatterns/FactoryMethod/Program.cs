using System;
using System.Runtime.InteropServices.ComTypes;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var motorTypeSelected = "S";

            while (motorTypeSelected!="E")
            {
                Console.WriteLine("What kind of motor you want? (G-Gasoline, D-Diesel, E-Exit)");
                motorTypeSelected = Console.ReadLine();
                MotorFactory motorFactory = null;

                motorFactory = motorTypeSelected switch
                {
                    "G" => new MitsubishiL200GasolineFactory(),
                    "D" => new MitsubishiL200DieselFactory(),
                    _ => new MitsubishiL200DieselFactory()
                };

                var motor = motorFactory.CreateMotor();
                Console.WriteLine($"Motor Type Created: {motor.MotorType}{Environment.NewLine}");

            }
        }
    }
}
