namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType
    {
        Magic = 1,
        Robes = 2,
        MedievalShield = 3,
        Stick = 4,
        WalkingStick = 5,
        Stone = 6,
        Breastplate = 7,
        MagicStick = 8,

    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItem GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Magic: return new Magic();
                case ItemType.Robes: return new Robes();
                case ItemType.MedievalShield: return new MedievalShield();
                case ItemType.Stick: return new Stick();
                case ItemType.WalkingStick: return new WalkingStick();
                case ItemType.Stone: return new Stone();
                case ItemType.Breastplate: return new Breastplate();
                case ItemType.MagicStick: return new MagicStick();

                

                default: return null;
            }
        }
    }
}