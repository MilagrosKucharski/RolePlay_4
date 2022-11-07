namespace RoleplayGame.Items
{
    /// <summary>
    /// Magia. Permite atacar y defender.
    /// </summary>
    public class MagicStick : IAttackItem, IDefenseItem
    {
        Magic Magic = new Magic();
        Stick Stick = new Stick ();
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return Magic.AttackPower + Stick.AttackPower;
            }
        }

        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return Magic.DefensePower ;
            }
        }

        public override string ToString()
        {
            return "MagicStick";
        }
    }
}