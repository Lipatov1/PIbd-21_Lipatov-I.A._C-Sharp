using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTechnic {
    public partial class FormMilitaryEquipmentConfig : Form {
        // Переменная-выбранная военная техника
        Vehicle militaryEquipment = null;

        // Событие
        private Action<Vehicle> eventAddMilitaryEquipment;

        public FormMilitaryEquipmentConfig() {
            InitializeComponent();
            panelRed.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        // Отрисовать военную технику
        private void DrawMilitaryEquipment() {
            if (militaryEquipment != null) {
                Bitmap bmp = new Bitmap(pictureBoxMilitaryEquipment.Width, pictureBoxMilitaryEquipment.Height);
                Graphics gr = Graphics.FromImage(bmp);
                militaryEquipment.SetPosition(5, 5, pictureBoxMilitaryEquipment.Width, pictureBoxMilitaryEquipment.Height);
                militaryEquipment.DrawTransport(gr);
                pictureBoxMilitaryEquipment.Image = bmp;
            }
        }

        // Добавление события
        public void AddEvent(Action<Vehicle> ev) {
            if (eventAddMilitaryEquipment == null) {
                eventAddMilitaryEquipment = new Action<Vehicle>(ev);
            } else {
                eventAddMilitaryEquipment += ev;
            }
        }

        // Передаем информацию при нажатии на Label
        private void labelArmoredCar_MouseDown(object sender, MouseEventArgs e) {
            labelArmoredCar.DoDragDrop(labelArmoredCar.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        // Передаем информацию при нажатии на Label
        private void labelSelfPropArtilleryInstal_MouseDown(object sender, MouseEventArgs e) {
            labelSelfPropArtilleryInstal.DoDragDrop(labelSelfPropArtilleryInstal.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        // Проверка получаемой информации (ее типа на соответствие требуемому)
        private void panelMilitaryEquipment_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Text)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }

        // Действия при приеме перетаскиваемой информации
        private void panelMilitaryEquipment_DragDrop(object sender, DragEventArgs e) {
            switch (e.Data.GetData(DataFormats.Text).ToString()) {
                case "Бронированный автомобиль":
                    militaryEquipment = new ArmoredCar((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Самоходная артиллерийская установка":
                    militaryEquipment = new SelfPropArtilleryInstal((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black, checkBoxCamouflage.Checked, checkBoxStar.Checked, checkBoxСaterpillar.Checked);
                    break;
            }
            DrawMilitaryEquipment();
        }

        // Отправляем цвет с панели
        private void panelColor_MouseDown(object sender, MouseEventArgs e) {
            Control panelColor = (Control)sender;
            panelColor.DoDragDrop(panelColor.BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        // Проверка получаемой информации (ее типа на соответствие требуемому)
        private void labelColor_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(typeof(Color))) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }

        // Принимаем основной цвет
        private void labelMainColor_DragDrop(object sender, DragEventArgs e) {
            if (militaryEquipment != null) {
                militaryEquipment.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawMilitaryEquipment();
            }
        }

        // Принимаем дополнительный цвет
        private void labelDopColor_DragDrop(object sender, DragEventArgs e) {
            if (militaryEquipment is SelfPropArtilleryInstal) {
                ((SelfPropArtilleryInstal)militaryEquipment).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawMilitaryEquipment();
            }
        }

        // Добавление военной техники
        private void buttonOk_Click(object sender, EventArgs e) {
            eventAddMilitaryEquipment?.Invoke(militaryEquipment);
            Close();
        }
    }
}