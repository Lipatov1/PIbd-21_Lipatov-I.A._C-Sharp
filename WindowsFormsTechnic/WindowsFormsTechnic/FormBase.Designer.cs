
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
            this.buttonSetArmoredCar = new System.Windows.Forms.Button();
            this.buttonSetArtillery = new System.Windows.Forms.Button();
            this.groupBoxTakeTechnic = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.buttonTakeTechnic = new System.Windows.Forms.Button();
            this.pictureBoxBase = new System.Windows.Forms.PictureBox();
            this.groupBoxTakeTechnic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetArmoredCar
            // 
            this.buttonSetArmoredCar.Location = new System.Drawing.Point(931, 12);
            this.buttonSetArmoredCar.Name = "buttonSetArmoredCar";
            this.buttonSetArmoredCar.Size = new System.Drawing.Size(121, 60);
            this.buttonSetArmoredCar.TabIndex = 0;
            this.buttonSetArmoredCar.Text = "Припарковать бронированный автомобиль";
            this.buttonSetArmoredCar.UseVisualStyleBackColor = true;
            this.buttonSetArmoredCar.Click += new System.EventHandler(this.buttonSetArmoredCar_Click);
            // 
            // buttonSetArtillery
            // 
            this.buttonSetArtillery.Location = new System.Drawing.Point(931, 78);
            this.buttonSetArtillery.Name = "buttonSetArtillery";
            this.buttonSetArtillery.Size = new System.Drawing.Size(121, 73);
            this.buttonSetArtillery.TabIndex = 1;
            this.buttonSetArtillery.Text = "Припарковать cамоходную артиллерийскую установку";
            this.buttonSetArtillery.UseVisualStyleBackColor = true;
            this.buttonSetArtillery.Click += new System.EventHandler(this.buttonSetArtillery_Click);
            // 
            // groupBoxTakeTechnic
            // 
            this.groupBoxTakeTechnic.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxTakeTechnic.Controls.Add(this.labelPlace);
            this.groupBoxTakeTechnic.Controls.Add(this.buttonTakeTechnic);
            this.groupBoxTakeTechnic.Location = new System.Drawing.Point(931, 157);
            this.groupBoxTakeTechnic.Name = "groupBoxTakeTechnic";
            this.groupBoxTakeTechnic.Size = new System.Drawing.Size(121, 87);
            this.groupBoxTakeTechnic.TabIndex = 2;
            this.groupBoxTakeTechnic.TabStop = false;
            this.groupBoxTakeTechnic.Text = "Забрать технику";
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
            // buttonTakeTechnic
            // 
            this.buttonTakeTechnic.Location = new System.Drawing.Point(24, 54);
            this.buttonTakeTechnic.Name = "buttonTakeTechnic";
            this.buttonTakeTechnic.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeTechnic.TabIndex = 0;
            this.buttonTakeTechnic.Text = "Забрать";
            this.buttonTakeTechnic.UseVisualStyleBackColor = true;
            this.buttonTakeTechnic.Click += new System.EventHandler(this.buttonTakeTechnic_Click);
            // 
            // pictureBoxBase
            // 
            this.pictureBoxBase.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxBase.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBase.Name = "pictureBoxBase";
            this.pictureBoxBase.Size = new System.Drawing.Size(925, 461);
            this.pictureBoxBase.TabIndex = 3;
            this.pictureBoxBase.TabStop = false;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 461);
            this.Controls.Add(this.pictureBoxBase);
            this.Controls.Add(this.groupBoxTakeTechnic);
            this.Controls.Add(this.buttonSetArtillery);
            this.Controls.Add(this.buttonSetArmoredCar);
            this.Name = "FormBase";
            this.Text = "Техника";
            this.groupBoxTakeTechnic.ResumeLayout(false);
            this.groupBoxTakeTechnic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSetArmoredCar;
        private System.Windows.Forms.Button buttonSetArtillery;
        private System.Windows.Forms.GroupBox groupBoxTakeTechnic;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button buttonTakeTechnic;
        private System.Windows.Forms.PictureBox pictureBoxBase;
    }
}