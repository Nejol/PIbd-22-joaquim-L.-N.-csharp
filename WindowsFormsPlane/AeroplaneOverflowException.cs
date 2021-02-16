using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    class AeroplaneOverflowException : Exception
    {
        public AeroplaneOverflowException() : base("На аэроплан нет свободных мест")
        { }
    }
}
