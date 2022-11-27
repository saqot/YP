using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace YP
{
    public partial class FormPodrobno : Form
    {
        public FormPodrobno()
        {
            InitializeComponent();
            LoadGrid();
            LoadGrid1();
        }

        private void LoadGrid()
        {
            dataGridView1.DataSource = ClassDB.selectForZapisiGrid("WHERE [date_end] < GETDATE()");
        }
        private void LoadGrid1()
        {
            dataGridView2.DataSource = ClassDB.selectForZapisiGrid("WHERE [date_end] > GETDATE()");
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormZapisiVse().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = ClassDB.buldExcelApp("WHERE [date_end] < GETDATE()");
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = ClassDB.buldExcelApp("WHERE [date_end] > GETDATE()");
            excelApp.Visible = true;
            excelApp.UserControl = true;
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
    }
}
