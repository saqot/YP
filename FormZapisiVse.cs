using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices.ComTypes;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace YP
{
    public partial class FormZapisiVse : Form
    {
        public FormZapisiVse()
        {
            InitializeComponent();
            this.labelFio.Text = ClassUser.getUserName();
            LoadGrid();
        }

        private void LoadGrid()
        {
            gridListUsers.DataSource = ClassDB.selectForZapisiGrid(); 
            gridListUsers.Columns["u.id"].Visible = false;
            gridListUsers.Columns["zp.id"].Visible = false;
            gridListUsers.Columns["login"].Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string sqlZapisi = $"UPDATE [dbo].[{ClassDB.TABLE_ZAPISI}] SET " +
                $" [diagnoz] ='{textBoxDiagnoz.Text}'," +
                $" [simptomi] ='{textBoxSimptomi.Text}'," +
                $" [date_start] ='{dateTimeStart_Data.Value}'," +
                $" [date_end] ='{dateTimeEnd_Data.Value}'" +
                $" WHERE id = '{textBoxZpId.Text}';";

            string sqlUchenik = $"UPDATE [dbo].[{ClassDB.TABLE_UCHENIKI}] SET " +
                $" [familia] ='{textBoxFamilia.Text}'," +
                $" [ima] ='{textBoxIma.Text}'," +
                $" [otchestvo] ='{textBoxOtchestvo.Text}'," +
                $" [date_rozhdeniia] ='{dateTimeDataRozhdeniia.Value}'," +
                $" [pol] ='{textBoxPol.Text}'," +
                $" [klass] ='{textBoxKlass.Text}'" +
                $" WHERE id = '{textBoxId.Text}';";

            ClassDB.Query(sqlZapisi);
            ClassDB.Query(sqlUchenik);
          
            LoadGrid();
            ClassMessage.showInfo("Запись изменена.");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ClassDB.Query($"DELETE FROM [dbo].[{ClassDB.TABLE_ZAPISI}] WHERE id = '{textBoxZpId.Text}';"); 
            
            LoadGrid();
            ClassMessage.showInfo("Запись удалена.");
         }

        private void buttonOtchetExel_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = ClassDB.buldExcelApp();
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }


        /**
         * клик по елементу списка юзеров
         */
        private void gridListUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = gridListUsers.CurrentRow.Cells["u.id"].Value.ToString();
            textBoxZpId.Text = gridListUsers.CurrentRow.Cells["zp.id"].Value.ToString();
            textBoxLogin.Text = gridListUsers.CurrentRow.Cells["login"].Value.ToString();
            textBoxFamilia.Text = gridListUsers.CurrentRow.Cells["familia"].Value.ToString();
            textBoxIma.Text = gridListUsers.CurrentRow.Cells["ima"].Value.ToString();
            textBoxOtchestvo.Text = gridListUsers.CurrentRow.Cells["otchestvo"].Value.ToString();
            textBoxTelefon.Text = gridListUsers.CurrentRow.Cells["telefon"].Value.ToString();
            textBoxPol.Text = gridListUsers.CurrentRow.Cells["pol"].Value.ToString();
            textBoxKlass.Text = gridListUsers.CurrentRow.Cells["klass"].Value.ToString();
            textBoxDiagnoz.Text = gridListUsers.CurrentRow.Cells["diagnoz"].Value.ToString();
            textBoxSimptomi.Text = gridListUsers.CurrentRow.Cells["simptomi"].Value.ToString();
            if (gridListUsers.CurrentRow.IsNewRow != true)
            {
                dateTimeDataRozhdeniia.Value = (DateTime)gridListUsers.CurrentRow.Cells["date_rozhdeniia"].Value;
                dateTimeStart_Data.Value = (DateTime)gridListUsers.CurrentRow.Cells["date_start"].Value;
                dateTimeEnd_Data.Value = (DateTime)gridListUsers.CurrentRow.Cells["date_end"].Value;
            }           
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            ClassMessage.showInfo("Запись НЕ добавлена. Необходимо написать логику");
            
            /*
            gridListUsers.DataSource = ClassDB.Query($@"INSERT INTO [dbo].[table_med_users]
                ([familia],
                [ima],
                [otchestvo],
                [telefon],
                [data_rozhdeniia],
                [pol],
                [klass],
                [diagnoz],
                [simptomi],
                [start_data],
                [end_data] )
            VALUES
               ('{textBoxFamilia.Text}',
                '{textBoxIma.Text}',
                '{textBoxOtchestvo.Text}',
                '{textBoxTelefon.Text}',
                '{dateTimeDataRozhdeniia.Value}',
                '{textBoxPol.Text}',
                '{textBoxKlass.Text}',
                '{textBoxDiagnoz.Text}',
                '{textBoxSimptomi.Text}',
                '{dateTimeStart_Data.Value}',
                '{dateTimeEnd_Data.Value}')"
            ); 
            
            LoadGrid();
            ClassMessage.showInfo("Запись добавлена.");
            */
        }

        private void textBoxPoisk_TextChanged(object sender, EventArgs e)
        {
            if(textBoxPoisk.Text.Length > 0)
            {
                label9.Visible = false;
            }
            else
            {
                label9.Visible = true;
            }

            gridListUsers.DataSource = ClassDB.selectPoisk(textBoxPoisk.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new FormPodrobno().Show();
            this.Hide();
        }

        // необходимо для перемещения окна
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelVerh_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
