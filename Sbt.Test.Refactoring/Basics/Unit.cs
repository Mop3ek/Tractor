namespace Sbt.Test.Refactoring
{
    /// <summary>
    /// Базовая реализация юнита
    /// </summary>
    public class Unit : IUnit
    {
        private IPosition Positioner = new Positioner();

        public int[] Position { get => Positioner.Position; set => Positioner.Position = value; }
        public int[] Field { get => Positioner.Field; set => Positioner.Field = value; }

        public int GetPositionX()
        {
            return Positioner.GetPositionX();
        }

        public int GetPositionY()
        {
            return Positioner.GetPositionY();
        }
    }
}
