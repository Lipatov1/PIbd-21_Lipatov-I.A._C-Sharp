using System.Drawing;
using System;

namespace WindowsFormsTechnic {
	// Класс отрисовки cамоходной артиллерийской установки
	public class SelfPropArtilleryInstal : ArmoredCar, IEquatable<SelfPropArtilleryInstal> {
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

		// Конструктор для загрузки с файла
		public SelfPropArtilleryInstal(string info) : base(info) {
			string[] strs = info.Split(separator);
			if (strs.Length == 7) {
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromName(strs[2]);
				DopColor = Color.FromName(strs[3]);
				Camouflage = Convert.ToBoolean(strs[4]);
				Star = Convert.ToBoolean(strs[5]);
				Сaterpillar = Convert.ToBoolean(strs[6]);
			}
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
			if (Сaterpillar) {
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
			}

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

		// Смена дополнительного цвета
		public void SetDopColor(Color color) {
			DopColor = color;
		}

		public override string ToString() {
			return $"{base.ToString()}{separator}{DopColor.Name}{separator}{Camouflage}{separator}{Star}{separator}{Сaterpillar}";
		}
		// Метод интерфейса IEquatable для класса SelfPropArtilleryInstal
		public bool Equals(SelfPropArtilleryInstal other) {
			if (other == null) {
                return false;
            }
            if (GetType().Name != other.GetType().Name) {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed) {
                return false;
            }
            if (Weight != other.Weight) {
                return false;
            }
            if (MainColor != other.MainColor) {
                return false;
            }
			if (DopColor != other.DopColor) {
				return false;
			}
			if (Camouflage != other.Camouflage) {
				return false;
			}
			if (Star != other.Star) {
				return false;
			}
			if (Сaterpillar != other.Сaterpillar) {
				return false;
			}
			return true;
		}

		// Перегрузка метода от object
		public override bool Equals(Object obj) {
			if (obj == null) {
				return false;
			}
			if (!(obj is SelfPropArtilleryInstal militaryEquipmentObj)) {
				return false;
			} else {
				return Equals(militaryEquipmentObj);
			}
		}
	}
}