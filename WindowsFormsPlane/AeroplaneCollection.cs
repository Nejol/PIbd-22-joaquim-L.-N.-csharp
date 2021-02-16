using System;
using System.Collections.Generic;
using System.IO;
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

        private readonly char separator = ':';

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

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write($"AeroplaneCollection{Environment.NewLine}", fs);
                    foreach (var level in aeroplaneStages)
                    {
                        //Начинаем парковку
                        writer.Write($"Aeroplane{separator}{level.Key}{Environment.NewLine}", fs);
                        ITransport plane = null;
                        for (int i = 0; (plane = level.Value.GetNext(i)) != null; i++)
                        {
                            if (plane != null)
                            {
                                //если место не пустое
                                //Записываем тип машины
                                if (plane.GetType().Name == "Plane")
                                {
                                    writer.Write($"Plane{separator}", fs);
                                }
                                if (plane.GetType().Name == "Warplane")
                                {
                                    writer.Write($"Warplane{separator}", fs);
                                }
                                //Записываемые параметры
                                writer.Write(plane + Environment.NewLine, fs);
                            }
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }

            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                if (line.Contains("AeroplaneCollection"))
                {
                    //очищаем записи
                    aeroplaneStages.Clear();
                }

                else
                {
                    //если нет такой записи, то это не те данные
                    return false;
                }

                line = sr.ReadLine();
                Vehicle plane = null;
                string key = string.Empty;
                while (line != null && line.Contains("Aeroplane"))
                {
                    key = line.Split(separator)[1];
                    aeroplaneStages.Add(key, new Aeroplane<Vehicle>(pictureWidth, pictureHeight));
                    line = sr.ReadLine();
                    while (line != null && (line.Contains("Plane") || line.Contains("Warplane")))
                    {
                        if (line.Split(separator)[0] == "Plane")
                        {
                            plane = new Plane(line.Split(separator)[1]);
                        }

                        else if (line.Split(separator)[0] == "Warplane")
                        {
                            plane = new Warplane(line.Split(separator)[1]);
                        }

                        var result = aeroplaneStages[key] + plane;
                        if (!result)
                        {
                            return false;
                        }

                        line = sr.ReadLine();
                    }
                }
            }
            return true;
        }
    }
}
