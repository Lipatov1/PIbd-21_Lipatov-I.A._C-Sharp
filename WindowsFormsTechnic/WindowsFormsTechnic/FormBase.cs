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

            for (int i = 0; i < baseCollection.Keys.Count; i++) {
                listBoxBases.Items.Add(baseCollection.Keys[i]);
            }

            if (listBoxBases.Items.Count > 0 && (index == -1 || index >= listBoxBases.Items.Count)) {
                listBoxBases.SelectedIndex = 0;
            } else if (listBoxBases.Items.Count > 0 && index > -1 && index < listBoxBases.Items.Count) {
                listBoxBases.SelectedIndex = index;
            }
        }

        // Метод отрисовки базы
        private void Draw() {
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
                MessageBox.Show("Введите название базы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            baseCollection.AddBase(textBoxNewLevelName.Text);
            ReloadLevels();
        }

        // Обработка нажатия кнопки "Удалить базу"
        private void buttonDelBase_Click(object sender, EventArgs e) {
            if (listBoxBases.SelectedIndex > -1) {
                if (MessageBox.Show($"Удалить базу {listBoxBases.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    baseCollection.DelBase(listBoxBases.SelectedItem.ToString());
                    ReloadLevels();
                }
                Draw();
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

        // Обработка нажатия кнопки "Добавить военную технику"
        private void buttonSetMilitaryEquipment_Click(object sender, EventArgs e) {
            var formCarConfig = new FormMilitaryEquipmentConfig();
            formCarConfig.AddEvent(AddMilitaryEquipment);
            formCarConfig.Show();
        }

        // Метод добавления военной техники
        private void AddMilitaryEquipment(Vehicle car) {
            if (car != null && listBoxBases.SelectedIndex > -1) {
                if ((baseCollection[listBoxBases.SelectedItem.ToString()]) + car != -1) {
                    Draw();
                } else {
                    MessageBox.Show("Военную технику не удалось поставить");
                }
            }
        }
    }
}