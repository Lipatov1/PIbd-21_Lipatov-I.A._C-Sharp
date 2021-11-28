using System;
using System.Drawing;
using System.Windows.Forms;
using NLog;

namespace WindowsFormsTechnic {
    public partial class FormBase : Form {
        // Объект от класса-коллекции баз
        private readonly BaseCollection baseCollection;

        // Логгер
        private readonly Logger logger;

        public FormBase() {
            InitializeComponent();
            baseCollection = new BaseCollection(pictureBoxBase.Width, pictureBoxBase.Height);
            logger = NLog.Web.NLogBuilder.ConfigureNLog("..\\..\\..\\App.config").GetCurrentClassLogger();
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
            logger.Info($"Добавили базу {textBoxNewLevelName.Text}");
            baseCollection.AddBase(textBoxNewLevelName.Text);
            ReloadLevels();
        }

        // Обработка нажатия кнопки "Удалить базу"
        private void buttonDelBase_Click(object sender, EventArgs e) {
            if (listBoxBases.SelectedIndex > -1) {
                if (MessageBox.Show($"Удалить базу {listBoxBases.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    logger.Info($"Удалили базу {listBoxBases.SelectedItem.ToString()}");
                    baseCollection.DelBase(listBoxBases.SelectedItem.ToString());
                    ReloadLevels();
                }
                Draw();
            }
        }

        // Обработка нажатия кнопки "Забрать"
        private void buttonTakeMilitaryEquipment_Click(object sender, EventArgs e) {
            if (listBoxBases.SelectedIndex > -1 && maskedTextBoxPlace.Text != "") {
                try {
                    var militaryEquipment = baseCollection[listBoxBases.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                    if (militaryEquipment != null) {
                        FormMilitaryEquipment form = new FormMilitaryEquipment();
                        form.SetTransport(militaryEquipment);
                        form.ShowDialog();
                        logger.Info($"Изъята техника {militaryEquipment} с места {maskedTextBoxPlace.Text}");
                        Draw();
                    }
                }
                catch (BaseNotFoundException ex) {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
            }
        }

        // Метод обработки выбора элемента на listBoxLevels
        private void listBoxBases_SelectedIndexChanged(object sender, EventArgs e) {
            logger.Info($"Перешли на базу {listBoxBases.SelectedItem.ToString()}");
            Draw();
        }

        // Обработка нажатия кнопки "Добавить военную технику"
        private void buttonSetMilitaryEquipment_Click(object sender, EventArgs e) {
            var formMilitaryEquipmentConfig = new FormMilitaryEquipmentConfig();
            formMilitaryEquipmentConfig.AddEvent(AddMilitaryEquipment);
            formMilitaryEquipmentConfig.Show();
        }

        // Метод добавления военной техники
        private void AddMilitaryEquipment(Vehicle militaryEquipment) {
            if (militaryEquipment != null && listBoxBases.SelectedIndex > -1) {
                try {
                    if ((baseCollection[listBoxBases.SelectedItem.ToString()]) + militaryEquipment != -1) {
                        Draw();
                        logger.Info($"Добавлена техника {militaryEquipment}");
                    } else {
                        MessageBox.Show("Технику не удалось поставить");
                    }
                    Draw();
                    }
                catch (BaseOverflowException ex) {
                    MessageBox.Show(ex.Message, "Переполнение базы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e) {
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    baseCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try
                {
                    baseCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (BaseOverflowException ex) {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
            }
        }
    }
}