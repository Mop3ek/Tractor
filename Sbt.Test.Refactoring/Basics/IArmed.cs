namespace Sbt.Test.Refactoring
{
    /// <summary>
    /// Интерфейс вооруженного юнита
    /// </summary>
    public interface IArmed
    {
        IWeapon Weapon { get; set; }
        void Fire();
    }
}
