using System.Drawing;

namespace WindowsFormsTechnic {
    public abstract class Vehicle : ITransport {
        // Левая и правая координаты отрисовки военной техники
        protected float startPosX;
        protected float startPosY;

        // Ширина и высота окна отрисовки
        protected int pictureWidth;
        protected int pictureHeight;

        // Максимальная скорость военной техники
        public int MaxSpeed { protected set; get; }

        // Вес военной техники
        public float Weight { protected set; get; }

        // Основной цвет военной техники
        public Color MainColor { protected set; get; }

        // Установка позиции техники
        public void SetPosition(int x, int y, int width, int height) {
            startPosX = x;
            startPosY = y;
            pictureWidth = width;
            pictureHeight = height;
        }

        public void SetMainColor(Color color) {
            MainColor = color;
        }

        // Отрисовка военной техники
        public abstract void DrawTransport(Graphics g);

        // Изменение направления пермещения
        public abstract void MoveTransport(Direction direction);
    }
}