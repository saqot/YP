using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace YP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadGrid();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void LoadGrid()
        {
            gridListUsers.DataSource = Class1.Query(@"SELECT * FROM [dbo].[table_med_users]"); gridListUsers.Columns["id"].Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            gridListUsers.DataSource = Class1.Query($@"UPDATE [dbo].[table_med_users]
               SET 
                   [familia] = '{textBoxFamilia.Text}',
                   [ima] = '{textBoxIma.Text}',
                   [otchestvo] = '{textBoxOtchestvo.Text}',
                   [telefon] = '{textBoxTelefon.Text}',
                   [data_rozhdeniia] = '{dateTimeDataRozhdeniia.Value}',
                   [pol] = '{textBoxPol.Text}',
                   [klass] = '{textBoxKlass.Text}',
                   [diagnoz] ='{textBoxDiagnoz.Text}',
                   [simptomi] ='{textBoxSimptomi.Text}',
                   [start_data] ='{dateTimeStart_Data.Value}',
                   [end_data] ='{dateTimeEnd_Data.Value}'
                   WHERE id = {textBoxId.Text}"); 
            
            LoadGrid();
            
            {
                MessageBox.Show("Запись изменена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            gridListUsers.DataSource = Class1.Query($@"DELETE FROM [dbo].[table_med_users]
            WHERE id = {gridListUsers.CurrentRow.Cells["id"].Value}"); 
            
            LoadGrid();
            
            {
                MessageBox.Show("Запись удалена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = Class1.buldExcelApp("Select * from table_med_users");
            excelApp.Visible = true;
            excelApp.UserControl = true;

            {
                MessageBox.Show("Отчет сформирован.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        /**
         * клик по елементу списка юзеров
         */
        private void gridListUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = gridListUsers.CurrentRow.Cells["id"].Value.ToString();
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
                dateTimeDataRozhdeniia.Value = (DateTime)gridListUsers.CurrentRow.Cells["data_rozhdeniia"].Value;
                dateTimeStart_Data.Value = (DateTime)gridListUsers.CurrentRow.Cells["start_data"].Value;
                dateTimeEnd_Data.Value = (DateTime)gridListUsers.CurrentRow.Cells["end_data"].Value;
            }           
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            gridListUsers.DataSource = Class1.Query($@"INSERT INTO [dbo].[table_med_users]
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
            
            {
                MessageBox.Show("Запись добавлена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

            string poiskText = textBoxPoisk.Text;

            gridListUsers.DataSource = Class1.Query(@"SELECT *
                FROM [dbo].[table_med_users] where " +
                "[familia] LIKE '%" + poiskText + "%' " +
                "OR [ima] LIKE '%" + poiskText + "%' " +
                "OR [otchestvo] LIKE '%" + poiskText + "%' " +
                "OR [telefon] LIKE '%" + poiskText + "%' " +
                "OR [data_rozhdeniia] LIKE '%" + poiskText + "%' " +
                "OR [pol] LIKE '%" + poiskText + "%' " +
                "OR [klass] LIKE '%" + poiskText + "%' " +
                "OR [diagnoz] LIKE '%" + poiskText + "%' " +
                "OR [simptomi] LIKE '%" + poiskText + "%' " +
                "OR [start_data] LIKE '%" + poiskText + "%' " +
                "OR [end_data] LIKE '%" + poiskText + "%'");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
