namespace RoleplayGame.Items
{
    /// <summary>
    /// Magia. Permite atacar y defender.
    /// </summary>
    public class MedievalShield : IDefenseItem
    {
    
        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 30;
            }
        }

        public override string ToString()
        {
            return "MedievalShield";
        }
    }
}