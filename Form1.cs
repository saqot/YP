using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace YP
{
    public partial class Form1 : Form
    {
        public const string USER_LOGIN = "1";
        public const string USER_PWD = "1";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

            if (textBoxLogin.Text != USER_LOGIN)
            {
                MessageBox.Show("Ошибка: Вы ввели не правельный логин!");
                return;
            }

            if (textBoxPassword.Text != USER_PWD)
            {
                MessageBox.Show("Ошибка: Вы ввели не правельный пароль!");
                return;
            }

            
            new Form2().Show();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

 

    }
}
