using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace WindowsFormsTechnic {
    // Класс-коллекция баз
    public class BaseCollection {
        // Словарь (хранилище) с базами
        readonly Dictionary<string, Base<Vehicle>> baseStages;

        // Возвращение списка названий баз
        public List<string> Keys => baseStages.Keys.ToList();

        // Ширина и высота окна отрисовки
        private readonly int pictureWidth;
        private readonly int pictureHeight;

        // Разделитель для записи информации в файл
        private readonly char separator = ':';

        // Конструктор
        public BaseCollection(int pictureWidth, int pictureHeight) {
            baseStages = new Dictionary<string, Base<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        // Добавление базы
        public void AddBase(string name) {
            if (baseStages.ContainsKey(name)) {
                return;
            }
            baseStages.Add(name, new Base<Vehicle>(pictureWidth, pictureHeight));
        }

        // Удаление базы
        public void DelBase(string name) {
            if (baseStages.ContainsKey(name)) {
                baseStages.Remove(name);
            }
        }

        // Доступ к базе
        public Base<Vehicle> this[string ind] {
            get {
                if (baseStages.ContainsKey(ind)) {
                    return baseStages[ind];
                }
                return null;
            }
        }

        // Сохранение информации по технике на базах в файл
        public bool SaveData(string filename) {
            if (File.Exists(filename)) {
                File.Delete(filename);
            }

            using (StreamWriter sw = new StreamWriter(filename)) {
                sw.WriteLine("BaseCollection");
                foreach (var level in baseStages) {
                    sw.WriteLine("Base" + separator + level.Key);

                    ITransport militaryEquipment = null;
                    for (int i = 0; (militaryEquipment = level.Value.GetNext(i)) != null; i++) {
                        if (militaryEquipment != null)  {
                            if (militaryEquipment.GetType().Name == "ArmoredCar") {
                                sw.Write("ArmoredCar" + separator);
                            } else if (militaryEquipment.GetType().Name == "SelfPropArtilleryInstal") {
                                sw.Write("SelfPropArtilleryInstal" + separator);
                            }

                            sw.WriteLine(militaryEquipment);
                        }
                    }
                }
                return true;
            }
        }

        // Загрузка информации по техникам на базах из файла
        public bool LoadData(string filename) {
            if (!File.Exists(filename)) {
                return false;
            }

            using (StreamReader sr = new StreamReader(filename)) {
                if (sr.ReadLine().Contains("BaseCollection")) {
                    baseStages.Clear();
                } else {
                    return false;
                }

                Vehicle militaryEquipment = null;
                string key = string.Empty;
                string line;

                for (int i = 0; (line = sr.ReadLine()) != null; i++) {
                    if (line.Contains("Base")) {
                        key = line.Split(separator)[1];
                        baseStages.Add(key, new Base<Vehicle>(pictureWidth, pictureHeight));
                    } else if (line.Contains(separator)) {
                        if (line.Contains("ArmoredCar")) {
                            militaryEquipment = new ArmoredCar(line.Split(separator)[1]);
                        } else if (line.Contains("SelfPropArtilleryInstal")) {
                            militaryEquipment = new SelfPropArtilleryInstal(line.Split(separator)[1]);
                        }

                        if (baseStages[key] + militaryEquipment == -1) {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }
}