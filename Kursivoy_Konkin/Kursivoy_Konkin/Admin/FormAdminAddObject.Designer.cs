namespace Kursivoy_Konkin
{
    partial class FormAdminAddObject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminAddObject));
            this.label7 = new System.Windows.Forms.Label();
            this.labelcost = new System.Windows.Forms.Label();
            this.txt_Square = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_float = new System.Windows.Forms.TextBox();
            this.labelspace = new System.Windows.Forms.Label();
            this.txtParkingSpace = new System.Windows.Forms.TextBox();
            this.buttonAddObject = new System.Windows.Forms.Button();
            this.txtDateDay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddPhoto = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameObject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprocent_prepay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.label7.Location = new System.Drawing.Point(19, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 47);
            this.label7.TabIndex = 44;
            this.label7.Text = "Площадь";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelcost
            // 
            this.labelcost.AutoSize = true;
            this.labelcost.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.labelcost.Location = new System.Drawing.Point(241, 141);
            this.labelcost.Name = "labelcost";
            this.labelcost.Size = new System.Drawing.Size(101, 47);
            this.labelcost.TabIndex = 42;
            this.labelcost.Text = "Цена";
            // 
            // txt_Square
            // 
            this.txt_Square.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.txt_Square.Location = new System.Drawing.Point(27, 191);
            this.txt_Square.MaxLength = 4;
            this.txt_Square.Name = "txt_Square";
            this.txt_Square.Size = new System.Drawing.Size(177, 55);
            this.txt_Square.TabIndex = 40;
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.txtCost.Location = new System.Drawing.Point(249, 191);
            this.txtCost.MaxLength = 10;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(205, 55);
            this.txtCost.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.label1.Location = new System.Drawing.Point(19, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 47);
            this.label1.TabIndex = 47;
            this.label1.Text = "Количество комнат";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_float
            // 
            this.txt_float.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.txt_float.Location = new System.Drawing.Point(27, 300);
            this.txt_float.MaxLength = 3;
            this.txt_float.Name = "txt_float";
            this.txt_float.Size = new System.Drawing.Size(329, 55);
            this.txt_float.TabIndex = 46;
            // 
            // labelspace
            // 
            this.labelspace.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelspace.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.labelspace.Location = new System.Drawing.Point(19, 358);
            this.labelspace.Name = "labelspace";
            this.labelspace.Size = new System.Drawing.Size(546, 71);
            this.labelspace.TabIndex = 49;
            this.labelspace.Text = "Площадь парковочного места";
            this.labelspace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtParkingSpace
            // 
            this.txtParkingSpace.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.txtParkingSpace.Location = new System.Drawing.Point(27, 432);
            this.txtParkingSpace.MaxLength = 4;
            this.txtParkingSpace.Name = "txtParkingSpace";
            this.txtParkingSpace.Size = new System.Drawing.Size(379, 55);
            this.txtParkingSpace.TabIndex = 48;
            // 
            // buttonAddObject
            // 
            this.buttonAddObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.buttonAddObject.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.buttonAddObject.Location = new System.Drawing.Point(691, 662);
            this.buttonAddObject.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddObject.Name = "buttonAddObject";
            this.buttonAddObject.Size = new System.Drawing.Size(459, 85);
            this.buttonAddObject.TabIndex = 52;
            this.buttonAddObject.Text = "Добавить объект";
            this.buttonAddObject.UseVisualStyleBackColor = false;
            this.buttonAddObject.Click += new System.EventHandler(this.buttonAddObject_Click);
            // 
            // txtDateDay
            // 
            this.txtDateDay.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.txtDateDay.Location = new System.Drawing.Point(27, 540);
            this.txtDateDay.MaxLength = 3;
            this.txtDateDay.Name = "txtDateDay";
            this.txtDateDay.Size = new System.Drawing.Size(538, 55);
            this.txtDateDay.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.label4.Location = new System.Drawing.Point(19, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(556, 47);
            this.label4.TabIndex = 51;
            this.label4.Text = "Количество дней для постройки";
            // 
            // buttonAddPhoto
            // 
            this.buttonAddPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.buttonAddPhoto.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.buttonAddPhoto.Location = new System.Drawing.Point(690, 432);
            this.buttonAddPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddPhoto.Name = "buttonAddPhoto";
            this.buttonAddPhoto.Size = new System.Drawing.Size(459, 85);
            this.buttonAddPhoto.TabIndex = 55;
            this.buttonAddPhoto.Text = "Добавить фото";
            this.buttonAddPhoto.UseVisualStyleBackColor = false;
            this.buttonAddPhoto.Click += new System.EventHandler(this.buttonAddPhoto_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.button3.Location = new System.Drawing.Point(690, 525);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(459, 85);
            this.button3.TabIndex = 56;
            this.button3.Text = "Удалить фото";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursivoy_Konkin.Properties.Resources.picture;
            this.pictureBox1.InitialImage = global::Kursivoy_Konkin.Properties.Resources.picture;
            this.pictureBox1.Location = new System.Drawing.Point(691, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(279, 622);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.button2.Location = new System.Drawing.Point(27, 622);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 125);
            this.button2.TabIndex = 73;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.label2.Location = new System.Drawing.Point(19, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 47);
            this.label2.TabIndex = 76;
            this.label2.Text = "Наименование объекта";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNameObject
            // 
            this.txtNameObject.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.txtNameObject.Location = new System.Drawing.Point(27, 71);
            this.txtNameObject.MaxLength = 3;
            this.txtNameObject.Name = "txtNameObject";
            this.txtNameObject.Size = new System.Drawing.Size(639, 55);
            this.txtNameObject.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.label3.Location = new System.Drawing.Point(376, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 47);
            this.label3.TabIndex = 78;
            this.label3.Text = "% Предоплаты";
            // 
            // txtprocent_prepay
            // 
            this.txtprocent_prepay.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.txtprocent_prepay.Location = new System.Drawing.Point(384, 300);
            this.txtprocent_prepay.MaxLength = 10;
            this.txtprocent_prepay.Name = "txtprocent_prepay";
            this.txtprocent_prepay.Size = new System.Drawing.Size(205, 55);
            this.txtprocent_prepay.TabIndex = 77;
            // 
            // FormAdminAddObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 766);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtprocent_prepay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameObject);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonAddPhoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAddObject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelspace);
            this.Controls.Add(this.txtParkingSpace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_float);
            this.Controls.Add(this.txtDateDay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelcost);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txt_Square);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdminAddObject";
            this.Text = "Добавление объекта - Админ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdminAddObject_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelcost;
        private System.Windows.Forms.TextBox txt_Square;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_float;
        private System.Windows.Forms.Label labelspace;
        private System.Windows.Forms.TextBox txtParkingSpace;
        private System.Windows.Forms.Button buttonAddObject;
        private System.Windows.Forms.TextBox txtDateDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAddPhoto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameObject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprocent_prepay;
    }
}