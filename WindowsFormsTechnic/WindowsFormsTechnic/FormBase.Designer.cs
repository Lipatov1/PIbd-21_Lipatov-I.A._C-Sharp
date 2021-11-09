
namespace WindowsFormsTechnic
{
    partial class FormBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SetMilitaryEquipment = new System.Windows.Forms.Button();
            this.groupBoxTakeMilitaryEquipment = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.buttonTakeMilitaryEquipment = new System.Windows.Forms.Button();
            this.pictureBoxBase = new System.Windows.Forms.PictureBox();
            this.labelBases = new System.Windows.Forms.Label();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonAddBase = new System.Windows.Forms.Button();
            this.listBoxBases = new System.Windows.Forms.ListBox();
            this.buttonRemoveBase = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxTakeMilitaryEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetMilitaryEquipment
            // 
            this.SetMilitaryEquipment.Location = new System.Drawing.Point(934, 240);
            this.SetMilitaryEquipment.Name = "SetMilitaryEquipment";
            this.SetMilitaryEquipment.Size = new System.Drawing.Size(121, 60);
            this.SetMilitaryEquipment.TabIndex = 0;
            this.SetMilitaryEquipment.Text = "Добавить военную технику";
            this.SetMilitaryEquipment.UseVisualStyleBackColor = true;
            this.SetMilitaryEquipment.Click += new System.EventHandler(this.buttonSetMilitaryEquipment_Click);
            // 
            // groupBoxTakeMilitaryEquipment
            // 
            this.groupBoxTakeMilitaryEquipment.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxTakeMilitaryEquipment.Controls.Add(this.labelPlace);
            this.groupBoxTakeMilitaryEquipment.Controls.Add(this.buttonTakeMilitaryEquipment);
            this.groupBoxTakeMilitaryEquipment.Location = new System.Drawing.Point(934, 306);
            this.groupBoxTakeMilitaryEquipment.Name = "groupBoxTakeMilitaryEquipment";
            this.groupBoxTakeMilitaryEquipment.Size = new System.Drawing.Size(121, 87);
            this.groupBoxTakeMilitaryEquipment.TabIndex = 2;
            this.groupBoxTakeMilitaryEquipment.TabStop = false;
            this.groupBoxTakeMilitaryEquipment.Text = "Забрать технику";
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(67, 25);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(32, 23);
            this.maskedTextBoxPlace.TabIndex = 3;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(24, 28);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(45, 15);
            this.labelPlace.TabIndex = 1;
            this.labelPlace.Text = "Место:";
            // 
            // buttonTakeMilitaryEquipment
            // 
            this.buttonTakeMilitaryEquipment.Location = new System.Drawing.Point(24, 54);
            this.buttonTakeMilitaryEquipment.Name = "buttonTakeMilitaryEquipment";
            this.buttonTakeMilitaryEquipment.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeMilitaryEquipment.TabIndex = 0;
            this.buttonTakeMilitaryEquipment.Text = "Забрать";
            this.buttonTakeMilitaryEquipment.UseVisualStyleBackColor = true;
            this.buttonTakeMilitaryEquipment.Click += new System.EventHandler(this.buttonTakeMilitaryEquipment_Click);
            // 
            // pictureBoxBase
            // 
            this.pictureBoxBase.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxBase.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxBase.Name = "pictureBoxBase";
            this.pictureBoxBase.Size = new System.Drawing.Size(925, 437);
            this.pictureBoxBase.TabIndex = 3;
            this.pictureBoxBase.TabStop = false;
            // 
            // labelBases
            // 
            this.labelBases.AutoSize = true;
            this.labelBases.Location = new System.Drawing.Point(978, 32);
            this.labelBases.Name = "labelBases";
            this.labelBases.Size = new System.Drawing.Size(37, 15);
            this.labelBases.TabIndex = 4;
            this.labelBases.Text = "Базы:";
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(934, 50);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(121, 23);
            this.textBoxNewLevelName.TabIndex = 5;
            // 
            // buttonAddBase
            // 
            this.buttonAddBase.Location = new System.Drawing.Point(934, 79);
            this.buttonAddBase.Name = "buttonAddBase";
            this.buttonAddBase.Size = new System.Drawing.Size(121, 23);
            this.buttonAddBase.TabIndex = 6;
            this.buttonAddBase.Text = "Добавить базу";
            this.buttonAddBase.UseVisualStyleBackColor = true;
            this.buttonAddBase.Click += new System.EventHandler(this.buttonAddBase_Click);
            // 
            // listBoxBases
            // 
            this.listBoxBases.FormattingEnabled = true;
            this.listBoxBases.ItemHeight = 15;
            this.listBoxBases.Location = new System.Drawing.Point(934, 108);
            this.listBoxBases.Name = "listBoxBases";
            this.listBoxBases.Size = new System.Drawing.Size(121, 94);
            this.listBoxBases.TabIndex = 7;
            this.listBoxBases.SelectedIndexChanged += new System.EventHandler(this.listBoxBases_SelectedIndexChanged);
            // 
            // buttonRemoveBase
            // 
            this.buttonRemoveBase.Location = new System.Drawing.Point(934, 208);
            this.buttonRemoveBase.Name = "buttonRemoveBase";
            this.buttonRemoveBase.Size = new System.Drawing.Size(121, 23);
            this.buttonRemoveBase.TabIndex = 8;
            this.buttonRemoveBase.Text = "Удалить базу";
            this.buttonRemoveBase.UseVisualStyleBackColor = true;
            this.buttonRemoveBase.AutoSizeChanged += new System.EventHandler(this.buttonDelBase_Click);
            this.buttonRemoveBase.Click += new System.EventHandler(this.buttonDelBase_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 461);
            this.Controls.Add(this.buttonRemoveBase);
            this.Controls.Add(this.listBoxBases);
            this.Controls.Add(this.buttonAddBase);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.labelBases);
            this.Controls.Add(this.pictureBoxBase);
            this.Controls.Add(this.groupBoxTakeMilitaryEquipment);
            this.Controls.Add(this.SetMilitaryEquipment);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormBase";
            this.Text = "База";
            this.groupBoxTakeMilitaryEquipment.ResumeLayout(false);
            this.groupBoxTakeMilitaryEquipment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetMilitaryEquipment;
        private System.Windows.Forms.GroupBox groupBoxTakeMilitaryEquipment;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button buttonTakeMilitaryEquipment;
        private System.Windows.Forms.PictureBox pictureBoxBase;
        private System.Windows.Forms.Label labelBases;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonAddBase;
        private System.Windows.Forms.ListBox listBoxBases;
        private System.Windows.Forms.Button buttonRemoveBase;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}