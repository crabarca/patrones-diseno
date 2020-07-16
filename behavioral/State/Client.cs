using System;

namespace State
{
    public class Client
    {
        public string Name { get; }
        
        public AbstractMembership MembershipType { get; set; }

        public Client(string name, AbstractMembership membershipType)
        {
            Name = name;
            MembershipType = membershipType;
        }

        public double MultiplierDiscount()
        {
            return MembershipType.MultiplierDiscount();
        }
    }
}