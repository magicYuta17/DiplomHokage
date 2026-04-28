namespace Kursivoy_Konkin
{
    partial class FormAdminEditObject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminEditObject));
            this.button3 = new System.Windows.Forms.Button();
            this.buttonAddPhoto = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAddObject = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelspace = new System.Windows.Forms.Label();
            this.txtParkingSpace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_float = new System.Windows.Forms.TextBox();
            this.txtDateDayPlan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelcost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txt_Square = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDateDayFact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameObject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprocent_prepay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.button3.Location = new System.Drawing.Point(862, 541);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(459, 85);
            this.button3.TabIndex = 71;
            this.button3.Text = "Удалить фото";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonAddPhoto
            // 
            this.buttonAddPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.buttonAddPhoto.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.buttonAddPhoto.Location = new System.Drawing.Point(862, 448);
            this.buttonAddPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddPhoto.Name = "buttonAddPhoto";
            this.buttonAddPhoto.Size = new System.Drawing.Size(459, 85);
            this.buttonAddPhoto.TabIndex = 70;
            this.buttonAddPhoto.Text = "Редактировать фото";
            this.buttonAddPhoto.UseVisualStyleBackColor = false;
            this.buttonAddPhoto.Click += new System.EventHandler(this.buttonAddPhoto_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.button2.Location = new System.Drawing.Point(24, 678);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 85);
            this.button2.TabIndex = 68;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAddObject
            // 
            this.buttonAddObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.buttonAddObject.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.buttonAddObject.Location = new System.Drawing.Point(863, 678);
            this.buttonAddObject.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddObject.Name = "buttonAddObject";
            this.buttonAddObject.Size = new System.Drawing.Size(459, 85);
            this.buttonAddObject.TabIndex = 67;
            this.buttonAddObject.Text = "Редактировать объект";
            this.buttonAddObject.UseVisualStyleBackColor = false;
            this.buttonAddObject.Click += new System.EventHandler(this.buttonAddObject_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.label4.Location = new System.Drawing.Point(16, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(670, 47);
            this.label4.TabIndex = 66;
            this.label4.Text = "Количество дней для постройки (план)";
            // 
            // labelspace
            // 
            this.labelspace.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelspace.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.labelspace.Location = new System.Drawing.Point(12, 335);
            this.labelspace.Name = "labelspace";
            this.labelspace.Size = new System.Drawing.Size(576, 48);
            this.labelspace.TabIndex = 65;
            this.labelspace.Text = "Площадь парковочного места";
            this.labelspace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtParkingSpace
            // 
            this.txtParkingSpace.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.txtParkingSpace.Location = new System.Drawing.Point(24, 386);
            this.txtParkingSpace.MaxLength = 4;
            this.txtParkingSpace.Name = "txtParkingSpace";
            this.txtParkingSpace.Size = new System.Drawing.Size(379, 55);
            this.txtParkingSpace.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.label1.Location = new System.Drawing.Point(16, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 47);
            this.label1.TabIndex = 63;
            this.label1.Text = "Количество комнат";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_float
            // 
            this.txt_float.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.txt_float.Location = new System.Drawing.Point(24, 272);
            this.txt_float.MaxLength = 3;
            this.txt_float.Name = "txt_float";
            this.txt_float.Size = new System.Drawing.Size(329, 55);
            this.txt_float.TabIndex = 62;
            // 
            // txtDateDayPlan
            // 
            this.txtDateDayPlan.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.txtDateDayPlan.Location = new System.Drawing.Point(24, 503);
            this.txtDateDayPlan.MaxLength = 3;
            this.txtDateDayPlan.Name = "txtDateDayPlan";
            this.txtDateDayPlan.Size = new System.Drawing.Size(538, 55);
            this.txtDateDayPlan.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.label7.Location = new System.Drawing.Point(16, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 47);
            this.label7.TabIndex = 60;
            this.label7.Text = "Площадь";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelcost
            // 
            this.labelcost.AutoSize = true;
            this.labelcost.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.labelcost.Location = new System.Drawing.Point(238, 113);
            this.labelcost.Name = "labelcost";
            this.labelcost.Size = new System.Drawing.Size(101, 47);
            this.labelcost.TabIndex = 59;
            this.labelcost.Text = "Цена";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.txtCost.Location = new System.Drawing.Point(246, 163);
            this.txtCost.MaxLength = 10;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(205, 55);
            this.txtCost.TabIndex = 58;
            // 
            // txt_Square
            // 
            this.txt_Square.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.txt_Square.Location = new System.Drawing.Point(24, 163);
            this.txt_Square.MaxLength = 4;
            this.txt_Square.Name = "txt_Square";
            this.txt_Square.Size = new System.Drawing.Size(177, 55);
            this.txt_Square.TabIndex = 57;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursivoy_Konkin.Properties.Resources.picture;
            this.pictureBox1.InitialImage = global::Kursivoy_Konkin.Properties.Resources.picture;
            this.pictureBox1.Location = new System.Drawing.Point(862, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 369);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(276, 678);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.label2.Location = new System.Drawing.Point(16, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(668, 47);
            this.label2.TabIndex = 74;
            this.label2.Text = "Количество дней для постройки (факт)";
            // 
            // txtDateDayFact
            // 
            this.txtDateDayFact.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.txtDateDayFact.Location = new System.Drawing.Point(24, 617);
            this.txtDateDayFact.MaxLength = 3;
            this.txtDateDayFact.Name = "txtDateDayFact";
            this.txtDateDayFact.Size = new System.Drawing.Size(538, 55);
            this.txtDateDayFact.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.label3.Location = new System.Drawing.Point(8, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(576, 48);
            this.label3.TabIndex = 76;
            this.label3.Text = "Наименование объекта";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNameObject
            // 
            this.txtNameObject.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.txtNameObject.Location = new System.Drawing.Point(20, 55);
            this.txtNameObject.MaxLength = 4;
            this.txtNameObject.Name = "txtNameObject";
            this.txtNameObject.Size = new System.Drawing.Size(760, 55);
            this.txtNameObject.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.label5.Location = new System.Drawing.Point(387, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 47);
            this.label5.TabIndex = 80;
            this.label5.Text = "% Предоплаты";
            // 
            // txtprocent_prepay
            // 
            this.txtprocent_prepay.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.txtprocent_prepay.Location = new System.Drawing.Point(395, 272);
            this.txtprocent_prepay.MaxLength = 10;
            this.txtprocent_prepay.Name = "txtprocent_prepay";
            this.txtprocent_prepay.Size = new System.Drawing.Size(205, 55);
            this.txtprocent_prepay.TabIndex = 79;
            // 
            // FormAdminEditObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1335, 788);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtprocent_prepay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameObject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDateDayFact);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonAddPhoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddObject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelspace);
            this.Controls.Add(this.txtParkingSpace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_float);
            this.Controls.Add(this.txtDateDayPlan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelcost);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txt_Square);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdminEditObject";
            this.Text = "Редактирование объекта - Админ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdminEditObject_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonAddPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAddObject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelspace;
        private System.Windows.Forms.TextBox txtParkingSpace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_float;
        private System.Windows.Forms.TextBox txtDateDayPlan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelcost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txt_Square;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDateDayFact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameObject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprocent_prepay;
    }
}