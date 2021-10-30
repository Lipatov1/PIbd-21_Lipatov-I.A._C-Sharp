using System.Drawing;
using System.Collections.Generic;

namespace WindowsFormsTechnic {
    // Параметризованный класс для хранения набора объектов от интерфейса ITransport
    public class Base<T> where T : class, ITransport {
        // Список объектов, которые храним
        private readonly List<T> places;

        // Максимальное количество мест на базе
        private readonly int maxCount;

        // Ширина и высота окна отрисовки
        private readonly int pictureWidth;
        private readonly int pictureHeight;

        // Ширина и высота парковочного места
        private readonly int widthParkingPlace = 460;
        private readonly int heightParkingPlace = 105;

        // Конструктор
        public Base(int picWidth, int picHeight) {
            int width = picWidth / widthParkingPlace;
            int height = picHeight / heightParkingPlace;
            maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            places = new List<T>();
        }

        // Перегрузка оператора сложения
        public static int operator +(Base<T> basePark, T militaryEquipment) {
            if (basePark.places.Count < basePark.maxCount) {
                basePark.places.Add(militaryEquipment);
                return 1;
            }
            return -1;
        }

        // Перегрузка оператора вычитания
        public static T operator -(Base<T> basePark, int index) {
            if (index >= 0 && index < basePark.places.Count) {
                T militaryEquipment = basePark.places[index];
                basePark.places.RemoveAt(index);
                return militaryEquipment;
            }
            return null;
        }

        // Метод отрисовки базы
        public void Draw(Graphics g) {
            DrawMarking(g);
            for (int i = 0; i < places.Count; ++i) {
                int columnNumber = pictureWidth / widthParkingPlace;
                places[i].SetPosition(10 + widthParkingPlace * (i % columnNumber), 10 + heightParkingPlace * (i / columnNumber), 884, 461);
                places[i].DrawTransport(g);
            }
        }

        // Метод отрисовки разметки парковочных мест базы
        private void DrawMarking(Graphics g) {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / widthParkingPlace; i++) {
                for (int j = 0; j < pictureHeight / heightParkingPlace + 1; ++j) {
                    g.DrawLine(pen, i * widthParkingPlace, j * heightParkingPlace, i * widthParkingPlace + widthParkingPlace / 2, j * heightParkingPlace);
                }
                g.DrawLine(pen, i * widthParkingPlace, 0, i * widthParkingPlace, (pictureHeight / heightParkingPlace) * heightParkingPlace);
            }
        }
    }
}