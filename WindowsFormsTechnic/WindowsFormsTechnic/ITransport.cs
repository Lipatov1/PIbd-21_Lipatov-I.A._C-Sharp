using System.Drawing;

namespace WindowsFormsTechnic {
    public interface ITransport {
        // Установка позиции военной техники
        void SetPosition(int x, int y, int width, int height);

        // Изменение направления пермещения
        void MoveTransport(Direction direction);

        // Отрисовка военной техники
        void DrawTransport(Graphics g);

        // Смена основного цвета
        void SetMainColor(Color color);
    }
}