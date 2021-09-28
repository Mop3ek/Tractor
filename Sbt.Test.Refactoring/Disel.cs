namespace Sbt.Test.Refactoring
{
    /// <summary>
    /// Дизельный двигатель
    /// </summary>
    public class Disel : IEngine
    {
        /// <summary>
        /// Команда мереместиться вперед
        /// </summary>
        public void MoveForwards(IVehicle vehicle)
        {
            if (vehicle.Orientation == Orientation.North)
            {
                vehicle.Position = new int[] { vehicle.Position[0], vehicle.Position[1] + 1 };
            }
            else if (vehicle.Orientation == Orientation.East)
            {
                vehicle.Position = new int[] { vehicle.Position[0] + 1, vehicle.Position[1] };
            }
            else if (vehicle.Orientation == Orientation.South)
            {
                vehicle.Position = new int[] { vehicle.Position[0], vehicle.Position[1] - 1 };
            }
            else if (vehicle.Orientation == Orientation.West)
            {
                vehicle.Position = new int[] { vehicle.Position[0] - 1, vehicle.Position[1] };
            }

            if (vehicle.Position[0] > vehicle.Field[0] || vehicle.Position[1] > vehicle.Field[1])
            {
                throw new VehicleInDitchException();
            }
        }
    }
}
