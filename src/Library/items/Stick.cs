namespace RoleplayGame.Items
{
    /// <summary>
    /// stick. Permite atacar.
    /// </summary>
    public class Stick : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 15;
            }
        }

        public override string ToString()
        {
            return "Stick";
        }
    }
}