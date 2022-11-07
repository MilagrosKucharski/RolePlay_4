namespace RoleplayGame.Items
{
    /// <summary>
    /// Breastplate. Permite defender.
    /// </summary>
    public class Breastplate : IDefenseItem
    {
       /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 50;
            }
        }

        public override string ToString()
        {
            return "Breastplate";
        }
    }
}