namespace GameConsole
{
    public abstract class SpecialDefence
    {
        public abstract int CalculateDamageReduction(int totalDamage);

        public static SpecialDefence Null { get; } = new NullDefense();

        private class NullDefense : SpecialDefence
        {
            public override int CalculateDamageReduction(int totalDamage)
            {
                return 0; // no operation / " do nothing" behaviour
            }
        }
    }
}