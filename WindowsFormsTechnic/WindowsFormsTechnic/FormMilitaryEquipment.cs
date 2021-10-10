using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTechnic {
	public partial class FormMilitaryEquipment : Form {
		private ITransport militaryEquipment;

		// Конструктор		
		public FormMilitaryEquipment() {
			InitializeComponent();
		}

		// Метод отрисовки техники
		private void Draw() {
			Bitmap bmp = new Bitmap(pictureBoxTechnic.Width, pictureBoxTechnic.Height);
			Graphics gr = Graphics.FromImage(bmp);
			militaryEquipment.DrawTransport(gr);
			pictureBoxTechnic.Image = bmp;
		}

		// Обработка нажатия кнопки "Создать бронированный автомобиль"
		private void buttonCreateArmoredCar_Click(object sender, EventArgs e) {
			Random rnd = new Random();
			militaryEquipment = new ArmoredCar(rnd.Next(100, 300), rnd.Next(1000, 2000), ColorTranslator.FromHtml("#35391f"));
			militaryEquipment.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTechnic.Width, pictureBoxTechnic.Height);
			Draw();
		}

		// Обработка нажатия кнопки "Создать cамоходную артиллерийскую установку"
		private void buttonCreateSelfPropArtilleryInstal_Click(object sender, EventArgs e) {
			Random rnd = new Random();
			militaryEquipment = new SelfPropArtilleryInstal(rnd.Next(100, 300), rnd.Next(1000, 2000), ColorTranslator.FromHtml("#35391f"), Color.Red, true, true, true);
			militaryEquipment.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTechnic.Width, pictureBoxTechnic.Height);
			Draw();
		}

		// Обработка нажатия кнопок управления
		private void buttonMove_Click(object sender, EventArgs e) {
			string name = (sender as Button).Name;
			switch (name) {
				case "buttonUp":
					militaryEquipment.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					militaryEquipment.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					militaryEquipment.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					militaryEquipment.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
	}
}