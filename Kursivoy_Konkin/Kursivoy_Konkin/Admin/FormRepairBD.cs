using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace Kursivoy_Konkin.Admin
{
    public partial class FormRepairBD : Form
    {
        public FormRepairBD()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите восстановить базу данных?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Правильное формирование пути
                    string pathFile = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\dumb and dll\db.sql"));

                    // Проверяем существование файла
                    if (!File.Exists(pathFile))
                    {
                        MessageBox.Show($"Файл не найден:\n{pathFile}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string textFile = File.ReadAllText(pathFile);

                    // Подключаемся БЕЗ базы данных

                    MySqlConnection mySqlConnection = new MySqlConnection(connect.conNoDb);
                    mySqlConnection.Open();

                    // Создаем базу
                    MySqlCommand createDbCommand = new MySqlCommand("CREATE DATABASE IF NOT EXISTS mydb", mySqlConnection);
                    createDbCommand.ExecuteNonQuery();

                    // Выбираем базу
                    MySqlCommand useDbCommand = new MySqlCommand("USE mydb", mySqlConnection);
                    useDbCommand.ExecuteNonQuery();

                    // Выполняем скрипт
                    MySqlCommand mySqlCommand = new MySqlCommand(textFile, mySqlConnection);
                    mySqlCommand.ExecuteNonQuery();

                    mySqlConnection.Close();

                    MessageBox.Show("База данных успешно восстановлена!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminLocalNavigation f = new FormAdminLocalNavigation();
            this.Visible = false;
            f.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите создать резервную копию?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string backup = "backup build " + DateTime.Now + ".sql";
                backup = backup.Replace(":", "-");
                string file = Directory.GetCurrentDirectory() + "\\backup\\" + backup;
                try
                {
                    Data.GetBackup(file);
                    MessageBox.Show($"Резервная копия успешно создана по пути: {file}", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

