
namespace WindowsFormsTechnic
{
    partial class FormTechnic
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxTechnic = new System.Windows.Forms.PictureBox();
            this.buttonCreateArmoredCar = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonCreateArtillery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTechnic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTechnic
            // 
            this.pictureBoxTechnic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTechnic.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTechnic.Name = "pictureBoxTechnic";
            this.pictureBoxTechnic.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxTechnic.TabIndex = 0;
            this.pictureBoxTechnic.TabStop = false;
            // 
            // buttonCreateArmoredCar
            // 
            this.buttonCreateArmoredCar.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateArmoredCar.Name = "buttonCreateArmoredCar";
            this.buttonCreateArmoredCar.Size = new System.Drawing.Size(228, 23);
            this.buttonCreateArmoredCar.TabIndex = 1;
            this.buttonCreateArmoredCar.Text = "Создать бронированный автомобиль";
            this.buttonCreateArmoredCar.UseVisualStyleBackColor = true;
            this.buttonCreateArmoredCar.Click += new System.EventHandler(this.buttonCreateArmoredCar_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::WindowsFormsTechnic.Properties.Resources.left;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(770, 419);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::WindowsFormsTechnic.Properties.Resources.down;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(806, 419);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::WindowsFormsTechnic.Properties.Resources.right;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(842, 419);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::WindowsFormsTechnic.Properties.Resources.up;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(806, 383);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateArtillery
            // 
            this.buttonCreateArtillery.Location = new System.Drawing.Point(246, 12);
            this.buttonCreateArtillery.Name = "buttonCreateArtillery";
            this.buttonCreateArtillery.Size = new System.Drawing.Size(292, 23);
            this.buttonCreateArtillery.TabIndex = 6;
            this.buttonCreateArtillery.Text = "Создать cамоходную артиллерийскую установку";
            this.buttonCreateArtillery.UseVisualStyleBackColor = true;
            this.buttonCreateArtillery.Click += new System.EventHandler(this.buttonCreateArtillery_Click);
            // 
            // FormTechnic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonCreateArtillery);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonCreateArmoredCar);
            this.Controls.Add(this.pictureBoxTechnic);
            this.Name = "FormTechnic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Техника";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTechnic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTechnic;
        private System.Windows.Forms.Button buttonCreateArmoredCar;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonCreateArtillery;
    }
}

