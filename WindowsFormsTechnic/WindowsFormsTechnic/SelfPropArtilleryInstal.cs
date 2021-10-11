using System.Drawing;

namespace WindowsFormsTechnic {
	// Класс отрисовки cамоходной артиллерийской установки
	public class SelfPropArtilleryInstal : ArmoredCar {
		// Дополнительный цвет cамоходной артиллерийской установки
		public Color DopColor { private set; get; }

		// Признак наличия камуфляжа
		public bool Camouflage { private set; get; }

		// Признак наличия звезды
		public bool Star { private set; get; }

		// Признак наличия гусеницы
		public bool Сaterpillar { private set; get; }

		// Конструктор
		public SelfPropArtilleryInstal(int maxSpeed, float weight, Color mainColor, Color dopColor, bool camouflage, bool star, bool caterpillar) :
		base(maxSpeed, weight, mainColor, 210, 85) {
			DopColor = dopColor;
			Camouflage = camouflage;
			Star = star;
			Сaterpillar = caterpillar;
		}

		// Отрисовка cамоходной артиллерийской установки
		public override void DrawTransport(Graphics g) {
			Pen penBlack = new Pen(Color.Black, 3);
			Brush brBlack = new SolidBrush(Color.Black);
			Brush brMain = new SolidBrush(MainColor);
			Brush brDopColor = new SolidBrush(DopColor);
			Brush brDarkOlive = new SolidBrush(ColorTranslator.FromHtml("#35391f"));
			Brush brSteelBlue = new SolidBrush(ColorTranslator.FromHtml("#595677"));

			base.DrawTransport(g);

			// Отрисовываем гусеницу
			g.FillRectangle(brDarkOlive, startPosX + 25, startPosY + 50, 160, 35);
			g.DrawEllipse(penBlack, startPosX + 5, startPosY + 45, 35, 35);
			g.DrawEllipse(penBlack, startPosX + 170, startPosY + 45, 35, 35);
			g.DrawEllipse(penBlack, startPosX + 50, startPosY + 62, 20, 20);
			g.DrawEllipse(penBlack, startPosX + 80, startPosY + 62, 20, 20);
			g.DrawEllipse(penBlack, startPosX + 110, startPosY + 62, 20, 20);
			g.DrawEllipse(penBlack, startPosX + 140, startPosY + 62, 20, 20);
			g.FillEllipse(brBlack, startPosX + 70, startPosY + 45, 10, 10);
			g.FillEllipse(brBlack, startPosX + 100, startPosY + 45, 10, 10);
			g.FillEllipse(brBlack, startPosX + 130, startPosY + 45, 10, 10);
			g.FillRectangle(brMain, startPosX + 7, startPosY + 30, 198, 20);

			// Отрисовываем камуфляж
			if (Camouflage) {
				g.FillEllipse(brSteelBlue, startPosX + 12, startPosY + 34, 25, 12);
				g.FillEllipse(brSteelBlue, startPosX + 70, startPosY + 32, 12, 12);
				g.FillEllipse(brSteelBlue, startPosX + 70, startPosY + 8, 10, 10);
				g.FillEllipse(brSteelBlue, startPosX + 70, startPosY + 3, 15, 10);
				g.FillEllipse(brSteelBlue, startPosX + 130, startPosY + 3, 15, 15);
				g.FillEllipse(brSteelBlue, startPosX + 130, startPosY + 33, 20, 13);
				g.FillEllipse(brSteelBlue, startPosX + 180, startPosY + 33, 13, 13);
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