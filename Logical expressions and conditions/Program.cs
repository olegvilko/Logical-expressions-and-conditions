using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_expressions_and_conditions
{
    class Program
    {
        static bool ShouldFire2(bool enemyInFront, string enemyName, int robotHealth)
        {
            return enemyInFront && (enemyName != "boss" || robotHealth >= 50);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ShouldFire2(true, "boss", 50));
        }
    }
}
