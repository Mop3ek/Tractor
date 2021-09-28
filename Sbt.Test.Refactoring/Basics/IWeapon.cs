namespace Sbt.Test.Refactoring
{
    /// <summary>
    /// Интерфейс вооружения
    /// </summary>
    public interface IWeapon
    {
        int AmmunitionCount { get; set; }
        void Fire();
    }
}
