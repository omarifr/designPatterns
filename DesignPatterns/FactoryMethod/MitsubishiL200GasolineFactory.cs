using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class MitsubishiL200GasolineFactory : MotorFactory
    {
        public override IMotor CreateMotor()
        {
            return new MitsubishiL200Gasoline("Gasoline");
        }
    }
}
