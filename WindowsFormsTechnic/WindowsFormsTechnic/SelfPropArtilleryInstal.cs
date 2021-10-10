using System.Drawing;

namespace WindowsFormsTechnic {
	// Класс отрисовки cамоходной артиллерийской установки
	class SelfPropArtilleryInstal {
		// Левая и правая координаты отрисовки cамоходной артиллерийской установки
		private float startPosX;
		private float startPosY;

		// Ширина и высота окна отрисовки
		private int pictureWidth;
		private int pictureHeight;

		// Ширина и высота отрисовки cамоходной артиллерийской установки
		private readonly int SelfPropArtilleryInstalWidth = 210;
		private readonly int SelfPropArtilleryInstalHeight = 85;

		// Максимальная скорость cамоходной артиллерийской установки
		public int MaxSpeed { private set; get; }

		// Вес cамоходной артиллерийской установки
		public float Weight { private set; get; }

		// Основной цвет cамоходной артиллерийской установки
		public Color MainColor { private set; get; }

		// Дополнительный цвет cамоходной артиллерийской установки
		public Color DopColor { private set; get; }

		// Признак наличия камуфляжа
		public bool Camouflage { private set; get; }

		// Признак наличия звезды
		public bool Star { private set; get; }

		// Инициализация свойств
		public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor, bool сamouflage, bool star) {
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			DopColor = dopColor;
			Camouflage = сamouflage;
			Star = star;
		}

		// Установка позиции cамоходной артиллерийской установки
		public void SetPosition(int x, int y, int width, int height) {
			startPosX = x;
			startPosY = y;
			pictureWidth = width;
			pictureHeight = height;
		}

		// Изменение направления пермещения
		public void MoveTransport(Direction direction) {
			float step = MaxSpeed * 100 / Weight;
			switch (direction) {
				case Direction.Right:
					if (startPosX + step < pictureWidth - SelfPropArtilleryInstalWidth) {
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
					if (startPosY + step < pictureHeight - SelfPropArtilleryInstalHeight) {
						startPosY += step;
					}
					break;
			}
		}

		// Отрисовка cамоходной артиллерийской установки
		public void DrawTransport(Graphics g) {
			Pen penBlack = new Pen(Color.Black, 3);
			Brush brBlack = new SolidBrush(Color.Black);
			Brush brMain = new SolidBrush(MainColor);
			Brush brDopColor = new SolidBrush(DopColor);
			Brush brTower = new SolidBrush(ColorTranslator.FromHtml("#424724"));
			Brush brCamouflage = new SolidBrush(ColorTranslator.FromHtml("#595677"));

			// Отрисовываем гусеницу
			g.FillEllipse(brMain, startPosX, startPosY + 40, 50, 45);
			g.FillEllipse(brMain, startPosX + 160, startPosY + 40, 50, 45);
			g.FillRectangle(brMain, startPosX + 25, startPosY + 40, 160, 45);

			// Отрисовывем колеса гусеницы
			g.DrawEllipse(penBlack, startPosX + 5, startPosY + 45, 35, 35);
			g.DrawEllipse(penBlack, startPosX + 170, startPosY + 45, 35, 35);
			g.DrawEllipse(penBlack, startPosX + 50, startPosY + 62, 20, 20);
			g.DrawEllipse(penBlack, startPosX + 80, startPosY + 62, 20, 20);
			g.DrawEllipse(penBlack, startPosX + 110, startPosY + 62, 20, 20);
			g.DrawEllipse(penBlack, startPosX + 140, startPosY + 62, 20, 20);
			g.FillEllipse(brBlack, startPosX + 70, startPosY + 45, 10, 10);
			g.FillEllipse(brBlack, startPosX + 100, startPosY + 45, 10, 10);
			g.FillEllipse(brBlack, startPosX + 130, startPosY + 45, 10, 10);

			// Отрисовываем башню
			g.FillRectangle(brTower, startPosX + 7, startPosY + 30, 198, 20);
			g.FillRectangle(brTower, startPosX + 60, startPosY, 90, 30);

			// Отрисовываем камуфляж
			if (Camouflage) {
				g.FillEllipse(brCamouflage, startPosX + 12, startPosY + 34, 25, 12);
				g.FillEllipse(brCamouflage, startPosX + 70, startPosY + 32, 12, 12);
				g.FillEllipse(brCamouflage, startPosX + 70, startPosY + 8, 10, 10);
				g.FillEllipse(brCamouflage, startPosX + 70, startPosY + 3, 15, 10);
				g.FillEllipse(brCamouflage, startPosX + 130, startPosY + 3, 15, 15);
				g.FillEllipse(brCamouflage, startPosX + 130, startPosY + 33, 20, 13);
				g.FillEllipse(brCamouflage, startPosX + 180, startPosY + 33, 13, 13);
			}

			// Отрисовываем звезду
			if (Star) {
				g.FillPolygon(brDopColor, new PointF[] {
					new PointF(startPosX + 105, startPosY + 2),
					new PointF(startPosX + 111, startPosY + 17),
					new PointF(startPosX + 124, startPosY + 17),
					new PointF(startPosX + 113, startPosY + 24),
					new PointF(startPosX + 117, startPosY + 38),
					new PointF(startPosX + 105, startPosY + 30),
					new PointF(startPosX + 93, startPosY + 38),
					new PointF(startPosX + 97, startPosY + 24),
					new PointF(startPosX + 86, startPosY + 17),
					new PointF(startPosX + 99, startPosY + 17)
				});
			}
		}
	}
}