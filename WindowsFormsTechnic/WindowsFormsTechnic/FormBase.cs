using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTechnic {
    public partial class FormBase : Form {
        // Объект от класса-коллекции баз
        private readonly BaseCollection baseCollection;

        public FormBase() {
            InitializeComponent();
            baseCollection = new BaseCollection(pictureBoxBase.Width, pictureBoxBase.Height);
        }

        // Заполнение listBoxLevels
        private void ReloadLevels() {
            int index = listBoxBases.SelectedIndex;
            listBoxBases.Items.Clear();

            /*for (int i = 0; i < baseCollection.Keys.Count; i++) {
                listBoxBases.Items.Add(baseCollection.Keys[i]);
            }*/
            foreach (var key in baseCollection.Keys) {
                listBoxBases.Items.Add(key);
            }

            if (listBoxBases.Items.Count > 0 && (index == -1 || index >= listBoxBases.Items.Count)) {
                listBoxBases.SelectedIndex = 0;
            } else if (listBoxBases.Items.Count > 0 && index > -1 && index < listBoxBases.Items.Count) {
                listBoxBases.SelectedIndex = index;
            }
        }

        // Метод отрисовки базы
        private void Draw() {
            //если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
            Bitmap bmp = new Bitmap(pictureBoxBase.Width, pictureBoxBase.Height);
            Graphics gr = Graphics.FromImage(bmp);
            if (listBoxBases.SelectedIndex > -1) {
                baseCollection[listBoxBases.SelectedItem.ToString()].Draw(gr);
                pictureBoxBase.Image = bmp;
            }
            pictureBoxBase.Image = bmp;
        }

        // Обработка нажатия кнопки "Добавить базу"
        private void buttonAddBase_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text)) {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            baseCollection.AddBase(textBoxNewLevelName.Text);
            ReloadLevels();
        }

        // Обработка нажатия кнопки "Удалить базу"
        private void buttonDelBase_Click(object sender, EventArgs e) {
            if (listBoxBases.SelectedIndex > -1) {
                if (MessageBox.Show($"Удалить парковку {listBoxBases.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    baseCollection.DelBase(listBoxBases.SelectedItem.ToString());
                    ReloadLevels();
                }
                Draw();
            }
        }

        // Обработка нажатия кнопки "Припарковать бронированный автомобиль"
        private void buttonSetArmoredCar_Click(object sender, EventArgs e) {
            if (listBoxBases.SelectedIndex > -1) {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK) {
                    var armoredCar = new ArmoredCar(100, 1000, dialog.Color);
                    if (baseCollection[listBoxBases.SelectedItem.ToString()] + armoredCar != -1) {
                        Draw();
                    } else {
                        MessageBox.Show("База переполнена");
                    }
                }
            }
        }

        // Обработка нажатия кнопки "Припарковать cамоходную артиллерийскую установку"
        private void buttonSetSelfPropArtilleryInstal_Click(object sender, EventArgs e) {
            if (listBoxBases.SelectedIndex > -1) {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK) {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK) {
                        var artillery = new SelfPropArtilleryInstal(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                        if (baseCollection[listBoxBases.SelectedItem.ToString()] + artillery != -1) {
                            Draw();
                        } else {
                            MessageBox.Show("База переполнена");
                        }
                    }
                }
            }
        }

        // Обработка нажатия кнопки "Забрать"
        private void buttonTakeMilitaryEquipment_Click(object sender, EventArgs e) {
            if (listBoxBases.SelectedIndex > -1 && maskedTextBoxPlace.Text != "") {
                var militaryEquipment = baseCollection[listBoxBases.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (militaryEquipment != null) {
                    FormMilitaryEquipment form = new FormMilitaryEquipment();
                    form.SetTransport(militaryEquipment);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        // Метод обработки выбора элемента на listBoxLevels
        private void listBoxBases_SelectedIndexChanged(object sender, EventArgs e) {
            Draw();
        }
    }
}