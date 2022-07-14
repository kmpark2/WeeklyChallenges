
using System;

namespace ChallengesWithTestsMark8
{
    public class Business
    {
        public string Name { get; set; }
        public double TotalRevenue { get; set; }
        public double TotalExpenses { get; set; }
        public Business ParentCompany { get; set; }

        public static implicit operator Business(string v)
        {
            throw new NotImplementedException();
        }
    }
}
