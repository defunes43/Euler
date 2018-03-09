using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.UserInterface
{
    class ConsoleUI : IUserInterface
    {
        string IUserInterface.ReadLine()
        {
            return Console.ReadLine();
        }

        void IUserInterface.WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
