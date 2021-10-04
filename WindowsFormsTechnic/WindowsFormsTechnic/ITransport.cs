using System.Drawing;

namespace WindowsFormsTechnic {
    public interface ITransport {
        // Установка позиции техники
        void SetPosition(int x, int y, int width, int height);

        // Изменение направления пермещения
        void MoveTransport(Direction direction);

        // Отрисовка техники
        void DrawTransport(Graphics g);
    }
}
