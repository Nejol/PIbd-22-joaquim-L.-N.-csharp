using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    class PlaneComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is Warplane && y is Warplane)
            {
                return ComparerWarplane((Warplane)x, (Warplane)y);
            }
            if (x is Plane && y is Plane)
            {
                return -1;
            }
            if (x is Plane && y is Warplane)
            {
                return 1;
            }
            if (x is Plane && y is Plane)
            {
                return ComparerPlane((Plane)x, (Plane)y);
            }
            return 0;
        }

        private int ComparerPlane(Plane x, Plane y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerWarplane(Warplane x, Warplane y)
        {
            var res = ComparerPlane(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Missele != y.Missele)
            {
                return x.Missele.CompareTo(y.Missele);
            }
            if (x.Foguete != y.Foguete)
            {
                return x.Foguete.CompareTo(y.Foguete);
            }
            return 0;
        }
    }
}
