using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.UserInterface
{
    public class InputOutput
    {
        private IUserInterface userInterface;

        public InputOutput(IUserInterface userInterface)
        {
            this.userInterface = userInterface;
        }

        public int ReadInteger()
        {
            userInterface.WriteLine("Entrez un nombre entier");
            return int.Parse(userInterface.ReadLine());
        }

        public void WriteLine(String line)
        {
            userInterface.WriteLine(line);
        }
    }
}
