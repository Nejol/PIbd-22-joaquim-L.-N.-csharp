using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    class AeroplaneAlreadyHaveException : Exception
    {
        public AeroplaneAlreadyHaveException() : base("На аэроплан уже есть такой самолёт")
        { }
    }
}
