using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTechnic {
    public partial class FormBase : Form {
        // Объект от класса-базы
        private readonly Base<Vehicle> baseMilitaryEquipment;

        public FormBase() {
            InitializeComponent();
            baseMilitaryEquipment = new Base<Vehicle>(pictureBoxBase.Width, pictureBoxBase.Height);
            Draw();
        }

        // Метод отрисовки базы
        private void Draw() {
            Bitmap bmp = new Bitmap(pictureBoxBase.Width, pictureBoxBase.Height);
            Graphics gr = Graphics.FromImage(bmp);
            baseMilitaryEquipment.Draw(gr);
            pictureBoxBase.Image = bmp;
        }

        // Обработка нажатия кнопки "Припарковать бронированный автомобиль"
        private void buttonSetArmoredCar_Click(object sender, EventArgs e) {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                var armoredCar = new ArmoredCar(100, 100, dialog.Color);
                if ((baseMilitaryEquipment + armoredCar) != -1) {
                    Draw();
                } else {
                    MessageBox.Show("База переполнена");
                }
            }
        }

        // Обработка нажатия кнопки "Припарковать cамоходную артиллерийскую установку"
        private void buttonSetSelfPropArtilleryInstal_Click(object sender, EventArgs e) {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK) {
                    var artillery = new SelfPropArtilleryInstal(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                    if ((baseMilitaryEquipment + artillery) != -1) {
                        Draw();
                    } else {
                        MessageBox.Show("База переполнена");
                    }
                }
            }
        }

        // Обработка нажатия кнопки "Забрать"
        private void buttonTakeMilitaryEquipment_Click(object sender, EventArgs e) {
            if (maskedTextBoxPlace.Text != "") {
                var militaryEquipment = baseMilitaryEquipment - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (militaryEquipment != null) {
                    FormMilitaryEquipment form = new FormMilitaryEquipment();
                    form.SetTransport(militaryEquipment);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}