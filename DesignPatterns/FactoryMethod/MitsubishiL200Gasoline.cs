using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class MitsubishiL200Gasoline : IMotor
    {
        public MitsubishiL200Gasoline(string motorType)
        {
            MotorType = motorType;
        }

        public string MotorType { get; }
    }
}
