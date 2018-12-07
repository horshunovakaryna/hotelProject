using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.Component
{
    class AdditionFunction
    {
        public static Random rand = new Random();

        public static string GenerateCardNumber()
        {       
            String card = "";
            for (int i = 0; i <= 10; i++)
            {
                card += rand.Next(1, 10);
            }
            return card;
        }
    }
}
