using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    class AeroplaneCollection
    {
        readonly Dictionary<string, Aeroplane<Vehicle>> aeroplaneStages;

        public List<string> Keys => aeroplaneStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        public AeroplaneCollection(int pictureWidth, int pictureHeight)
        {
            aeroplaneStages = new Dictionary<string, Aeroplane<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddAeroplane(string name)
        {
            if (aeroplaneStages.ContainsKey(name))
            {
                return;
            }
            aeroplaneStages.Add(name, new Aeroplane<Vehicle>(pictureWidth, pictureHeight));
        }

        public void DelAeroplane(string name)
        {
            if (aeroplaneStages.ContainsKey(name))
            {
                aeroplaneStages.Remove(name);
            }
        }

        public Aeroplane<Vehicle> this[string ind]
        {
            get
            {
                if (aeroplaneStages.ContainsKey(ind))
                {
                    return aeroplaneStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
