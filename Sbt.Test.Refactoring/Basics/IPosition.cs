using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbt.Test.Refactoring
{
    /// <summary>
    /// Интерфейс позиции
    /// </summary>
    public interface IPosition
    {
        int[] Position { get; set; }
        int GetPositionX();
        int GetPositionY();
        int[] Field { get; set; }
    }
}
