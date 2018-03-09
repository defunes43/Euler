using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerTests.UserInterface
{
    public class MockUI: Euler.UserInterface.IUserInterface
    {
        string FakeInput;
        public string ReadLine()
        {
            return FakeInput;
        }

        public void WriteLine(string line)
        {
            throw new NotImplementedException();
        }

        public MockUI(String fakeInput)
        {
            FakeInput = fakeInput;
        }
    }
}
