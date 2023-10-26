
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Code.UnitTest")]

namespace Code
{
    public class Class1
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        internal int Sub(int a, int b)
        {
            return a - b;
        }
    }
}