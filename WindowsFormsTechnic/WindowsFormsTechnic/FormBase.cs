using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTechnic {
    public partial class FormBase : Form {
        // Объект от класса-парковки
        private readonly Base<ArmoredCar> baseTechnic;

        public FormBase() {
            InitializeComponent();
            baseTechnic = new Base<ArmoredCar>(pictureBoxBase.Width, pictureBoxBase.Height);
            Draw();
        }

        // Метод отрисовки парковки
        private void Draw() {
            Bitmap bmp = new Bitmap(pictureBoxBase.Width, pictureBoxBase.Height);
            Graphics gr = Graphics.FromImage(bmp);
            baseTechnic.Draw(gr);
            pictureBoxBase.Image = bmp;
        }

        // Обработка нажатия кнопки "Припарковать бронированный автомобиль"
        private void buttonSetArmoredCar_Click(object sender, EventArgs e) {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                var armoredCar = new ArmoredCar(100, 1000, dialog.Color);
                if ((baseTechnic + armoredCar) != -1) {
                    Draw();
                } else {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        // Обработка нажатия кнопки "Припарковать cамоходную артиллерийскую установку"
        private void buttonSetArtillery_Click(object sender, EventArgs e) {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK) {
                    var artillery = new Artillery(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                    if ((baseTechnic + artillery) != -1) {
                        Draw();
                    } else {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }

        // Обработка нажатия кнопки "Забрать"
        private void buttonTakeTechnic_Click(object sender, EventArgs e) {
            if (maskedTextBoxPlace.Text != "") {
                var technic = baseTechnic - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (technic != null) {
                    FormTechnic form = new FormTechnic();
                    form.SetTransport(technic);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
