using Kursivoy_Konkin.Admin;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursivoy_Konkin
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();    
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminLocalNavigation f = new FormAdminLocalNavigation();
            this.Visible = false;
            f.ShowDialog();
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {


            Properties.Settings.Default["host"] = txtHost.Text;
            Properties.Settings.Default["database"] = txtDB.Text;
            Properties.Settings.Default["uid"] = txtUid.Text;
            Properties.Settings.Default["pwd"] = txtPassword.Text;
            Properties.Settings.Default.Save();

            connect.con= $@"host={Properties.Settings.Default["host"]};
                                    uid={Properties.Settings.Default["uid"]};
                                    pwd={Properties.Settings.Default["pwd"]};
                                    database={Properties.Settings.Default["database"]};";

            MessageBox.Show("Соединение установлено!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Information);

          

            int minutes = (int)numericTimeout.Value;

            if (minutes < 1 || minutes > 60)
            {
                MessageBox.Show("Введите значение от 1 до 60 минут.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ActivityMonitor.SetTimeoutMinutes(minutes);

            MessageBox.Show($"Таймаут бездействия установлен: {minutes} мин.", "Готово",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblCurrentTimeout.Text = $"{minutes} мин.";

            FormAdminLocalNavigation authorizationForm = new FormAdminLocalNavigation();
            this.Visible = false;
            authorizationForm.ShowDialog();
            this.Close();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            txtHost.Text = Properties.Settings.Default["host"].ToString();
            txtUid.Text = Properties.Settings.Default["uid"].ToString();
            txtPassword.Text = Properties.Settings.Default["pwd"].ToString();
            txtDB.Text = Properties.Settings.Default["database"].ToString();

            var comicSans = new Font("Comic Sans MS", 14f, FontStyle.Regular, GraphicsUnit.Point);
            var comicSansBold = new Font("Comic Sans MS", 14f, FontStyle.Bold, GraphicsUnit.Point);

            numericTimeout.Minimum = 1;   
            numericTimeout.Maximum = 60;

            numericTimeout.Value = ActivityMonitor.GetTimeoutMinutes();


            lblCurrentTimeout.Text = $"{ActivityMonitor.GetTimeoutMinutes()} мин.";

           
        }
    
    }
}