using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class MotorFactory
    {
        public abstract IMotor CreateMotor();

    }
}
