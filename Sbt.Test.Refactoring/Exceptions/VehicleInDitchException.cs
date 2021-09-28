using System;
using System.Runtime.CompilerServices;

namespace Sbt.Test.Refactoring
{
    public class VehicleInDitchException: Exception
    {
        public VehicleInDitchException([CallerMemberName] string memberName = "")
        {
            Name = memberName;
        }
        public string Name { get; set; }
    }
}
