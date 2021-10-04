using System.Drawing;

namespace WindowsFormsTechnic {
    // Параметризованный класс для хранения набора объектов от интерфейса ITransport
    public class Base<T> where T : class, ITransport {
        // Массив объектов, которые храним
        private readonly T[] places;

        // Ширина и высота окна отрисовки
        private readonly int pictureWidth;
        private readonly int pictureHeight;

        // Ширина и высота парковочного места
        private readonly int widthParkingPlace = 460;
        private readonly int heightParkingPlace = 105;

        public Base(int picWidth, int picHeight) {
            int width = picWidth / widthParkingPlace;
            int height = picHeight / heightParkingPlace;
            places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        // Перегрузка оператора сложения
        public static int operator +(Base<T> basePark, T technic) {
            int rowsNumber = basePark.pictureHeight / basePark.heightParkingPlace;
            int columnNumber = basePark.pictureWidth / basePark.widthParkingPlace;
            for (int i = 0; i < basePark.places.Length; i++) {
                if (basePark.places[i] == null) {
                    technic.SetPosition(10 + basePark.widthParkingPlace * (i % columnNumber), 10 + basePark.heightParkingPlace * (i / columnNumber), 884, 461);
                    basePark.places[i] = technic;
                    return i;
                }
            }
            return -1;
        }

        // Перегрузка оператора вычитания
        public static T operator -(Base<T> basePark, int index) {
            if (index >= 0 && index < basePark.places.Length && basePark.places[index] != null) {
                T technic = basePark.places[index];
                technic.SetPosition(50, 50, 884, 461);
                basePark.places[index] = null;
                return technic;
            }
            return null;
        }

        // Метод отрисовки парковки
        public void Draw(Graphics g) {
            DrawMarking(g);
            for (int i = 0; i < places.Length; i++) {
                places[i]?.DrawTransport(g);
            }
        }

        // Метод отрисовки разметки парковочных мест
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