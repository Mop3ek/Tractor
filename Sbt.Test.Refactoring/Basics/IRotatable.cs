using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbt.Test.Refactoring
{
    /// <summary>
    /// Интерфейс логики вращения
    /// </summary>
    public interface IRotatable
    {
        Orientation Orientation { get; }
        void TurnClockwise();
    }
}
