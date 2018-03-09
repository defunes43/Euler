using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.UserInterface
{
    public interface IUserInterface
    {
        string ReadLine();
        void WriteLine(String line);
    }
}
