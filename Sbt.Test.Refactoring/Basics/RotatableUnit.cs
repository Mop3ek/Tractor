namespace Sbt.Test.Refactoring
{
    /// <summary>
    /// Базовая реализация поворотного юнита
    /// </summary>
    public class RotatableUnit : Unit, IRotatableUnit
    {
        private IRotatable Rotator = new Rotator();
        public Orientation Orientation => Rotator.Orientation;

        public void TurnClockwise()
        {
            Rotator.TurnClockwise();
        }
    }
}
