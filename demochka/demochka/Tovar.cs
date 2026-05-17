using System;
using System;
using System.Windows.Forms;

namespace demochka
{
    public partial class Tovar : Form
    {
        orders Order = new orders();
        PVZ pvz = new PVZ();

        public Tovar()
        {
            InitializeComponent();
            UpdateUserInfo(); // Обновляем информацию о пользователе при загрузке формы
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tovar));
            this.Orderbutton = new System.Windows.Forms.Button();
            this.pvzbutton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.who = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Orderbutton
            this.Orderbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Orderbutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Orderbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Orderbutton.Location = new System.Drawing.Point(29, 319);
            this.Orderbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Orderbutton.Name = "Orderbutton";
            this.Orderbutton.Size = new System.Drawing.Size(249, 46);
            this.Orderbutton.TabIndex = 17;
            this.Orderbutton.Text = "Список заказов";
            this.Orderbutton.UseVisualStyleBackColor = false;
            this.Orderbutton.Click += new System.EventHandler(this.OrderButton_Click);

            // pvzbutton
            this.pvzbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pvzbutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pvzbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pvzbutton.Location = new System.Drawing.Point(29, 250);
            this.pvzbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pvzbutton.Name = "pvzbutton";
            this.pvzbutton.Size = new System.Drawing.Size(249, 46);
            this.pvzbutton.TabIndex = 16;
            this.pvzbutton.Text = "Пункты выдачи";
            this.pvzbutton.UseVisualStyleBackColor = false;
            this.pvzbutton.Click += new System.EventHandler(this.pvzbutton_Click);

            // username
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.username.Location = new System.Drawing.Point(13, 13);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(60, 23);
            this.username.TabIndex = 18;
            this.username.Text = "Гость";
            this.username.Click += new System.EventHandler(this.username_Click);

            // who
            this.who.AutoSize = true;
            this.who.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.who.Location = new System.Drawing.Point(13, 46);
            this.who.Name = "who";
            this.who.Size = new System.Drawing.Size(45, 20);
            this.who.TabIndex = 19;
            this.who.Text = "Гость";
            this.who.Click += new System.EventHandler(this.who_Click);

            // Tovar
            this.AccessibleName = "";
            this.ClientSize = new System.Drawing.Size(1101, 733);
            this.Controls.Add(this.who);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Orderbutton);
            this.Controls.Add(this.pvzbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tovar";
            this.Text = "Товар";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void pvzbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            pvz.Show();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order.Show();
        }

    
        private void UpdateUserInfo()
        {
         
            if (username != null)
            {
                if (CurrentUser.IsAuthenticated)
                {
                    username.Text = CurrentUser.FullName;
                    username.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    username.Text = "Гость";
                    username.ForeColor = System.Drawing.Color.Gray;
                }
            }

            if (who != null)
            {
                who.Text = CurrentUser.Role;
                if (CurrentUser.Role == "Администратор")
                    who.ForeColor = System.Drawing.Color.Red;
                else if (CurrentUser.Role == "Менеджер")
                    who.ForeColor = System.Drawing.Color.Blue;
                else if (CurrentUser.Role == "Авторизированный клиент")
                    who.ForeColor = System.Drawing.Color.Green;
                else
                    who.ForeColor = System.Drawing.Color.Gray;
            }
        }

 
        private void username_Click(object sender, EventArgs e)
        {
            if (CurrentUser.IsAuthenticated)
            {
                MessageBox.Show($"Информация о пользователе:\n\n" +
                              $"ФИО: {CurrentUser.FullName}\n" +
                              $"Роль: {CurrentUser.Role}\n" +
                              $"Логин: {CurrentUser.Login}",
                              "О пользователе",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Вы вошли как гость.\n\n" +
                              "Для полного доступа к функциям программы,\n" +
                              "пожалуйста, авторизуйтесь.",
                              "Гостевой режим",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
        }

      
        private void who_Click(object sender, EventArgs e)
        {
            switch (CurrentUser.Role)
            {
                case "Администратор":
                    MessageBox.Show("Права администратора:\n" +
                                  "✓ Просмотр всех товаров\n" +
                                  "✓ Добавление/удаление товаров\n" +
                                  "✓ Редактирование заказов\n" +
                                  "✓ Управление пользователями",
                                  "Ваши права доступа",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    break;

                case "Менеджер":
                    MessageBox.Show("Права менеджера:\n" +
                                  "✓ Просмотр всех товаров\n" +
                                  "✓ Добавление товаров\n" +
                                  "✓ Работа с заказами",
                                  "Ваши права доступа",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    break;

                case "Авторизированный клиент":
                    MessageBox.Show("Права клиента:\n" +
                                  "✓ Просмотр товаров\n" +
                                  "✓ Оформление заказов\n" +
                                  "✓ Просмотр своих заказов",
                                  "Ваши права доступа",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    break;

                default:
                    MessageBox.Show("Права гостя:\n" +
                                  "✓ Просмотр товаров\n\n" +
                                  "Для оформления заказов войдите в систему.",
                                  "Гостевой режим",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    break;
            }
        }
    }
}