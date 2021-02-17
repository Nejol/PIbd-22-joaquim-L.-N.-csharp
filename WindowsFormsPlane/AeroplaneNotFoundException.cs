using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    class AeroplaneNotFoundException : Exception
    {
        public AeroplaneNotFoundException(int i) : base("Не найден самолёт по месту " + i)
        { }
    }
}
