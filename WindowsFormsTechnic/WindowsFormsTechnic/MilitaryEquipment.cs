using System.Drawing;

namespace WindowsFormsTechnic {
    public abstract class MilitaryEquipment : ITransport {
        // Левая и правая координаты отрисовки техники
        protected float startPosX;
        protected float startPosY;

        // Ширина и высота окна отрисовки
        protected int pictureWidth;
        protected int pictureHeight;

        // Максимальная скорость техники
        public int MaxSpeed { protected set; get; }

        // Вес техники
        public float Weight { protected set; get; }

        // Основной цвет техники
        public Color MainColor { protected set; get; }

        // Установка позиции техники
        public void SetPosition(int x, int y, int width, int height) {
            startPosX = x;
            startPosY = y;
            pictureWidth = width;
            pictureHeight = height;
        }

        // Отрисовка техники
        public abstract void DrawTransport(Graphics g);

        // Изменение направления пермещения
        public abstract void MoveTransport(Direction direction);
    }
}