using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveBibliotek
{
    public class Class1
    {
        private const string _goal = "mål";
        public Class1()
        {
            
        }

        private string HowHappyAreWeAboutThePasses(int passes)
        {
            if (passes < 0)
                return "ERROR - Are your team playing backwords???";
            else if (passes < 1)
                return "Shh";
            else if (passes > 10)
                return "High five!!!";
            else
            {
                var str = string.Empty;

                for (int i = 0; i < passes; i++) str += "Huh!";

                return str.TrimEnd();
            }
        }

        public string WeCheerIfGoalOrPasses(string goal, int passes)
        {
            if (goal.ToLower() == _goal)
                return WeCheerIfGoal(goal);

            else
                return HowHappyAreWeAboutThePasses(passes);
        }

        private string WeCheerIfGoal(string goal)
        {
            throw new NotImplementedException();
        }
    }
}
