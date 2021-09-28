namespace Sbt.Test.Refactoring
{
    /// <summary>
    /// Пушка
    /// </summary>
    public class Cannon : IWeapon
    {
        private int _ammunitionCount;
        /// <summary>
        /// Боезапас
        /// </summary>
        public int AmmunitionCount
        {
            get => _ammunitionCount;
            set => _ammunitionCount = value;
        }
        /// <summary>
        /// Команда открыть огонь
        /// </summary>
        public void Fire()
        {
            if (_ammunitionCount > 0)
                _ammunitionCount--;
            else
                throw new OutOfAmmoException();
        }
    }
}
