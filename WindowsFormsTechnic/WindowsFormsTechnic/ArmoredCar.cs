using System.Drawing;

namespace WindowsFormsTechnic {
    public class ArmoredCar : Vehicle {
        // Ширина и высота отрисовки бронированной машины
        protected readonly int armoredCarWidth = 210;
        protected readonly int armoredCarHeight = 85;

        // Конструктор
        public ArmoredCar(int maxSpeed, float weight, Color mainColor) {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        // Конструктор с изменением размеров бронированной машины
        protected ArmoredCar(int maxSpeed, float weight, Color mainColor, int carWidth, int carHeight) {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.armoredCarWidth = carWidth;
            this.armoredCarHeight = carHeight;
        }

        // Изменение направления пермещения
        public override void MoveTransport(Direction direction) {
            float step = MaxSpeed * 100 / Weight;
            switch (direction) {
                case Direction.Right:
                    if (startPosX + step < pictureWidth - armoredCarWidth) {
                        startPosX += step;
                    }
                    break;

                case Direction.Left:
                    if (startPosX - step > 0) {
                        startPosX -= step;
                    }
                    break;

                case Direction.Up:
                    if (startPosY - step > 0) {
                        startPosY -= step;
                    }
                    break;

                case Direction.Down:
                    if (startPosY + step < pictureHeight - armoredCarHeight) {
                        startPosY += step;
                    }
                    break;
            }
        }

        // Отрисовка бронированной машины
        public override void DrawTransport(Graphics g) {
            Pen penBlack = new Pen(Color.Black, 3);
            Brush brBlack = new SolidBrush(Color.Black);
            Brush brMain = new SolidBrush(MainColor);
            Brush brTower = new SolidBrush(ColorTranslator.FromHtml("#424724"));
            Brush brCamouflage = new SolidBrush(ColorTranslator.FromHtml("#595677"));

            // Отрисовываем колеса
            g.FillEllipse(brMain, startPosX, startPosY + 40, 45, 45);
            g.FillEllipse(brMain, startPosX + 165, startPosY + 40, 45, 45);
            g.FillRectangle(brMain, startPosX + 25, startPosY + 40, 160, 25);
            g.DrawEllipse(penBlack, startPosX + 5, startPosY + 45, 35, 35);
            g.DrawEllipse(penBlack, startPosX + 170, startPosY + 45, 35, 35);

            // Отрисовываем башню
            g.FillRectangle(brTower, startPosX + 7, startPosY + 30, 198, 20);
            g.FillRectangle(brTower, startPosX + 60, startPosY, 90, 30);
        }
    }
}