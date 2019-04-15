using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Service
{
    public class TicketChecker
    {
       
            public bool HaveGotTicket(string from, string to, List<string> fromList, List<string> toList)
            {

                if (!fromList.Contains(from) || !toList.Contains(to))
                {
                    Console.WriteLine("We havent got tickets with this parameters!");
                    Console.Clear();
                    return false;
                }
                else
                {
                    return true;
                }

            }
        
    }
}
