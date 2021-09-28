namespace Sbt.Test.Refactoring
{
    /// <summary>
    /// Интерфейс транспортного средства
    /// </summary>
    public interface IVehicle: IRotatableUnit
    {
        IEngine Engine { get; set; }
        void Move(string command);
    }
}
