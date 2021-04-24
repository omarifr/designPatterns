using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class MitsubishiL200DieselFactory : MotorFactory
    {
        public override IMotor CreateMotor()
        {
            return new MitsubishiL200Diesel("Diesel");
        }
    }
}
