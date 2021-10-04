using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTechnic {
	public partial class FormTechnic : Form {
		private ITransport artillery;

		// Конструктор		
		public FormTechnic() {
			InitializeComponent();
		}

		// Метод отрисовки cамоходной артиллерийской установки
		private void Draw() {
			Bitmap bmp = new Bitmap(pictureBoxTechnic.Width, pictureBoxTechnic.Height);
			Graphics gr = Graphics.FromImage(bmp);
			artillery.DrawTransport(gr);
			pictureBoxTechnic.Image = bmp;
		}

		// Обработка нажатия кнопки "Создать бронированный автомобиль"
		private void buttonCreate_Click(object sender, EventArgs e) {
		}
		private void buttonCreateArmoredCar_Click(object sender, EventArgs e) {
			Random rnd = new Random();
			artillery = new ArmoredCar(rnd.Next(100, 300), rnd.Next(1000, 2000), ColorTranslator.FromHtml("#35391f"));
			artillery.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTechnic.Width, pictureBoxTechnic.Height);
			Draw();
		}

		// Обработка нажатия кнопки "Создать cамоходную артиллерийскую установку"
		private void buttonCreateArtillery_Click(object sender, EventArgs e) {
			Random rnd = new Random();
			artillery = new Artillery(rnd.Next(100, 300), rnd.Next(1000, 2000), ColorTranslator.FromHtml("#35391f"), Color.Red, true, true, true);
			artillery.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTechnic.Width, pictureBoxTechnic.Height);
			Draw();
		}

		// Обработка нажатия кнопок управления
		private void buttonMove_Click(object sender, EventArgs e) {
			string name = (sender as Button).Name;
			switch (name) {
				case "buttonUp":
					artillery.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					artillery.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					artillery.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					artillery.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
	}
}