namespace State
{
    public class PremiumMembership : AbstractMembership
    {
        public override double MultiplierDiscount()
        {
            return 0.9;
        }
    }
}