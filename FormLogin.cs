using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Linq;

namespace YP
{
    public partial class FormLogin : Form
    {
        public const string USER_LOGIN = "1";
        public const string USER_PWD = "1";

        public FormLogin()
        {
            InitializeComponent();
            this.comboBoxKto.Items.Add("Врач");
            this.comboBoxKto.Items.Add("Ученик");
            this.comboBoxKto.SelectedIndex = 0;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.ToString();
            if (login == "")
            {
                MessageBox.Show("Ошибка: логин надо заполнить!");
                return;
            }

            string pwd = textBoxPassword.Text.ToString();
            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Ошибка: пароль надо заполнить!");
                return;
            }

            string selectedItem = comboBoxKto.SelectedItem.ToString();
            string table = selectedItem == "Врач" ? ClassDB.TABLE_VRACHI : ClassDB.TABLE_UCHENIKI;

            DataRow[] rows = ClassDB.findLoginUser(table, login);
           
            if (rows.Count() == 0)
            {
                MessageBox.Show("Ошибка: Такого пользователя нет!");
                return;
            }

            DataRow user = rows[0];
            if (user["pwd"].ToString() != pwd)
            {
                MessageBox.Show("Ошибка: Вы ввели не правельный пароль!");
                return;
            }

            ClassUser._user = user;
            ClassUser.IsUchenik = selectedItem != "Врач";

            new FormZapisiVse().Show();
            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
              this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
       
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
       
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void comboBoxKto_Changed(object sender, EventArgs e)
        {
            string selectedItem = comboBoxKto.SelectedItem.ToString();

            if (selectedItem == "Врач")
            {
                textBoxLogin.Text = "n.vas";
                textBoxPassword.Text = "222";
            } else {
                textBoxLogin.Text = "artur";
                textBoxPassword.Text = "111";
            }

        }
    }
}
