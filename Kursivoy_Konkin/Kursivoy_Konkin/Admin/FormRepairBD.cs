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
                    string pathFile = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\dumb and dll\only_structure.sql"));

                    if (!File.Exists(pathFile))
                    {
                        MessageBox.Show($"Файл не найден:\n{pathFile}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string textFile = File.ReadAllText(pathFile);

                    MySqlConnection mySqlConnection = new MySqlConnection(connect.conNoDb);
                    mySqlConnection.Open();

                    MySqlCommand createDbCommand = new MySqlCommand("CREATE DATABASE IF NOT EXISTS mydb", mySqlConnection);
                    createDbCommand.ExecuteNonQuery();

                    MySqlCommand useDbCommand = new MySqlCommand("USE mydb", mySqlConnection);
                    useDbCommand.ExecuteNonQuery();

                    string[] sqlCommands = textFile
                        .Split(new[] { ";;" }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string sqlCommand in sqlCommands)
                    {
                        string command = sqlCommand.Trim();
                        if (!string.IsNullOrEmpty(command) &&
                            !command.StartsWith("DELIMITER", StringComparison.OrdinalIgnoreCase))
                        {
                            MySqlCommand cmd = new MySqlCommand(command, mySqlConnection);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    

                    mySqlConnection.Close();

                    MessageBox.Show("База данных успешно восстановлена!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                
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

