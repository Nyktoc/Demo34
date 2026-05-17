using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace demochka
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        Tovar tovarForm = new Tovar();
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Demo;Integrated Security=True";

        private void buttoAuth_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = @"select top 1 [Роль сотрудника] as RoleName, 
                                          LTRIM(RTRIM(ISNULL([Фамилия],'')))+' '+
                                          LTRIM(RTRIM(ISNULL([Имя],'')))+' '+
                                          LTRIM(RTRIM(ISNULL([Отчество],''))) as FIO 
                                   from [user] 
                                   where [Логин] = @login and [Пароль] = @password";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string roleName = Convert.ToString(reader["RoleName"]);
                                string fio = Convert.ToString(reader["FIO"]);

                                CurrentUser.Login = login;
                                CurrentUser.Role = roleName;

                                MessageBox.Show($"Добро пожаловать, {fio}!\nВаша роль: {roleName}",
                                    "Успешный вход", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       
                                tovarForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль!", "Ошибка авторизации",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                                // Очищаем поле пароля для повторного ввода
                                textBoxPassword.Text = "";
                                textBoxPassword.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к базе данных:\n" + ex.Message,
                    "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            CurrentUser.Login = "";
            CurrentUser.Role = "Гость";
            CurrentUser.LastName = "";
            CurrentUser.FirstName = "";
            CurrentUser.Patronymic = "";

            tovarForm.Show();

            this.Hide();
        }

    }
}