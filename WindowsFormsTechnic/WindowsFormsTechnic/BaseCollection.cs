using System.Collections.Generic;
using System.Linq;

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
    }
}