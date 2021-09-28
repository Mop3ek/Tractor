using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbt.Test.Refactoring
{
    /// <summary>
    /// Реализация логики позиции и игрового поля
    /// </summary>
    public class Positioner: IPosition
    {
        int[] _position = new int[] { 0, 0 };
        int[] _field = new int[] { 5, 5 };

        public int[] Position
        {

            get => _position;
            set => _position = value;
        }

        public int GetPositionX()
        {
            return _position[0];
        }

        public int GetPositionY()
        {
            return _position[1];
        }

         public int[] Field { get => _field; set => _field = value; }
    }
}
