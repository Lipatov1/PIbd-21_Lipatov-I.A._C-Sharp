using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTechnic {
	public partial class FormTechnic : Form {
		private Artillery SelfPropArtillery;

		// Конструктор		
		public FormTechnic() {
			InitializeComponent();
		}

		// Метод отрисовки cамоходной артиллерийской установки
		private void Draw() {
			Bitmap bmp = new Bitmap(pictureBoxArtillery.Width, pictureBoxArtillery.Height);
			Graphics gr = Graphics.FromImage(bmp);
			SelfPropArtillery.DrawTransport(gr);
			pictureBoxArtillery.Image = bmp;
		}

		// Обработка нажатия кнопки "Создать"
		private void buttonCreate_Click(object sender, EventArgs e) {
			Random rnd = new Random();
			SelfPropArtillery = new Artillery();
			SelfPropArtillery.Init(rnd.Next(100, 300), rnd.Next(1000, 2000), ColorTranslator.FromHtml("#35391f"), Color.Red, true, true); SelfPropArtillery.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxArtillery.Width, pictureBoxArtillery.Height);
			Draw();
		}

		// Обработка нажатия кнопок управления
		private void buttonMove_Click(object sender, EventArgs e) {
			string name = (sender as Button).Name;
			switch (name) {
				case "buttonUp":
					SelfPropArtillery.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					SelfPropArtillery.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					SelfPropArtillery.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					SelfPropArtillery.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
	}
}