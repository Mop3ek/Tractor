using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbt.Test.Refactoring
{
    public class Tractor : RotatableUnit, IVehicle
    {
        public Tractor()
        { 
        }
        IEngine _engine = new Disel();
        public IEngine Engine 
        { 
            get => _engine; 
            set => _engine = value; 
        }

        public void Move(string command)
        {
            try
            {

                if (command == "F")
                {
                    Engine?.MoveForwards(this);
                }
                else if (command == "T")
                {
                    TurnClockwise();
                }
            }
            catch (Exception ex)
            {
                if (ex is VehicleInDitchException)
                    throw new TractorInDitchException();
                throw;
            }

        }
    }
}
