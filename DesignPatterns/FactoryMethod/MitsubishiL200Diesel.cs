using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class MitsubishiL200Diesel : IMotor
    {
        public MitsubishiL200Diesel(string motorType)
        {
            MotorType = motorType;
        }

        public string MotorType { get; }
    }
}
