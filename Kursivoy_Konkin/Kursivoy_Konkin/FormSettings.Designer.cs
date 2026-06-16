namespace Kursivoy_Konkin
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.numericTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblCurrentTimeout = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // numericTimeout
            // 
            this.numericTimeout.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.numericTimeout.Location = new System.Drawing.Point(815, 17);
            this.numericTimeout.Name = "numericTimeout";
            this.numericTimeout.Size = new System.Drawing.Size(146, 55);
            this.numericTimeout.TabIndex = 0;
            // 
            // lblCurrentTimeout
            // 
            this.lblCurrentTimeout.AutoSize = true;
            this.lblCurrentTimeout.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.lblCurrentTimeout.Location = new System.Drawing.Point(616, 19);
            this.lblCurrentTimeout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentTimeout.Name = "lblCurrentTimeout";
            this.lblCurrentTimeout.Size = new System.Drawing.Size(122, 47);
            this.lblCurrentTimeout.TabIndex = 1;
            this.lblCurrentTimeout.Text = "Логин";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.lblDescription.Location = new System.Drawing.Point(13, 19);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(541, 47);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Таймаут бездействия (минуты):";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.btnSave.Location = new System.Drawing.Point(18, 453);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(316, 70);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.button1.Location = new System.Drawing.Point(393, 453);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 47);
            this.label2.TabIndex = 7;
            this.label2.Text = "Хост";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.label1.Location = new System.Drawing.Point(377, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 47);
            this.label1.TabIndex = 9;
            this.label1.Text = "Пользователь";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.label3.Location = new System.Drawing.Point(10, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 47);
            this.label3.TabIndex = 11;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.label4.Location = new System.Drawing.Point(385, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 47);
            this.label4.TabIndex = 13;
            this.label4.Text = "Имя БД";
            // 
            // txtUid
            // 
            this.txtUid.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.txtUid.Location = new System.Drawing.Point(385, 189);
            this.txtUid.Margin = new System.Windows.Forms.Padding(4);
            this.txtUid.MaxLength = 50;
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(331, 55);
            this.txtUid.TabIndex = 15;
            // 
            // txtDB
            // 
            this.txtDB.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.txtDB.Location = new System.Drawing.Point(385, 325);
            this.txtDB.Margin = new System.Windows.Forms.Padding(4);
            this.txtDB.MaxLength = 50;
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(331, 55);
            this.txtDB.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.txtPassword.Location = new System.Drawing.Point(22, 325);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(308, 55);
            this.txtPassword.TabIndex = 17;
            // 
            // txtHost
            // 
            this.txtHost.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.txtHost.Location = new System.Drawing.Point(18, 189);
            this.txtHost.Margin = new System.Windows.Forms.Padding(4);
            this.txtHost.MaxLength = 50;
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(312, 55);
            this.txtHost.TabIndex = 18;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1063, 612);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCurrentTimeout);
            this.Controls.Add(this.numericTimeout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericTimeout;
        private System.Windows.Forms.Label lblCurrentTimeout;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtHost;
    }
}