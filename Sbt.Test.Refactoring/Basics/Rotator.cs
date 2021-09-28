namespace Sbt.Test.Refactoring
{
    /// <summary>
    /// Релизация логики вращения
    /// </summary>
    public class Rotator : IRotatable
    {
        private Orientation _orientation = Orientation.North;
        public Orientation Orientation => _orientation;

        public void TurnClockwise()
        {
            if (_orientation == Orientation.North)
            {
                _orientation = Orientation.East;
            }
            else if (_orientation == Orientation.East)
            {
                _orientation = Orientation.South;
            }
            else if (_orientation == Orientation.South)
            {
                _orientation = Orientation.West;
            }
            else if (_orientation == Orientation.West)
            {
                _orientation = Orientation.North;
            }
        }
    }
}
