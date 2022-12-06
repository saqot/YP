using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices.ComTypes;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;

namespace YP
{
    public partial class FormZapisiVse : Form
    {
        public FormZapisiVse()
        {
            InitializeComponent();
            this.labelFio.Text = ClassUser.getUserName();
            LoadGrids();
        }

        private void LoadGrids()
        {
            if (this.tabControlLists.SelectedIndex == 0)
            {
                LoadGridZapisi();
            }
            else
            {
                LoadGridUcheniki();
            }

        }

        private void LoadGridZapisi()
        {
            int curRow = 0;
            if (gridListZapisi.CurrentRow != null)
            {
                curRow = gridListZapisi.CurrentRow.Index;
            }

            gridListZapisi.DataSource = ClassDB.selectForZapisiGrid();
            gridListZapisi.Columns["u.id"].Visible = false;
            gridListZapisi.Columns["zp.id"].Visible = false;
            gridListZapisi.Columns["login"].Visible = false;

            this.clearFormZapisi();
            this.clearFormUcheniki();
            gridListZapisi.Rows[curRow].Selected = true;
            gridListZapisi.CurrentCell = gridListZapisi.Rows[curRow].Cells["ima"];
        }

        private void LoadGridUcheniki()
        {
            int curRow = 0;
            if (gridListUcheniki.CurrentRow != null)
            {
                curRow = gridListUcheniki.CurrentRow.Index;
            }
            gridListUcheniki.DataSource = ClassDB.selectForUchenikiGrid();
            gridListUcheniki.Columns["u.id"].Visible = false;

            this.clearFormZapisi();
            this.clearFormUcheniki();
            gridListUcheniki.Rows[curRow].Selected = true;
            gridListUcheniki.CurrentCell = gridListUcheniki.Rows[curRow].Cells["ima"];
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOtchetExel_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = ClassDB.buldExcelApp();
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }


        /**
         * клик по елементу списка записей
         */
        private void gridListZapisi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow сurRow = gridListZapisi.CurrentRow;
            bool IsNewRow = сurRow.IsNewRow == true;
            this.buttonToEditUchenik.Enabled = IsNewRow != true;
            this.buttonAddNewUchenik.Enabled = true;
            this.buttonToEditZapis.Enabled = IsNewRow != true;
            this.buttonAddNewZapis.Enabled = true;
            this.formUserToLock(true);
            this.formBoleznToLock(true);

            textBoxId.Text = сurRow.Cells["u.id"].Value.ToString();
            textBoxZpId.Text = сurRow.Cells["zp.id"].Value.ToString();
            textBoxLogin.Text = сurRow.Cells["login"].Value.ToString();
            textBoxFamilia.Text = сurRow.Cells["familia"].Value.ToString();
            textBoxIma.Text = сurRow.Cells["ima"].Value.ToString();
            textBoxOtchestvo.Text = сurRow.Cells["otchestvo"].Value.ToString();
            textBoxTelefon.Text = сurRow.Cells["telefon"].Value.ToString();
            textBoxPol.Text = сurRow.Cells["pol"].Value.ToString();
            textBoxKlass.Text = сurRow.Cells["klass"].Value.ToString();
            textBoxDiagnoz.Text = сurRow.Cells["diagnoz"].Value.ToString();
            textBoxSimptomi.Text = сurRow.Cells["simptomi"].Value.ToString();
            if (IsNewRow != true)
            {
                dateTimeDataRozhdeniia.Value = (DateTime)сurRow.Cells["date_rozhdeniia"].Value;
                dateTimeStart_Data.Value = (DateTime)сurRow.Cells["date_start"].Value;
                dateTimeEnd_Data.Value = (DateTime)сurRow.Cells["date_end"].Value;
            }           
        }

        /**
         * клик по елементу списка учеников
         */
        private void gridListUcheniki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow сurRow = gridListUcheniki.CurrentRow;
            bool IsNewRow = сurRow.IsNewRow == true;
            this.formUserToLock(true);
            this.formBoleznToLock(true);

            textBoxId.Text = сurRow.Cells["u.id"].Value.ToString();
            textBoxLogin.Text = сurRow.Cells["login"].Value.ToString();
            textBoxFamilia.Text = сurRow.Cells["familia"].Value.ToString();
            textBoxIma.Text = сurRow.Cells["ima"].Value.ToString();
            textBoxOtchestvo.Text = сurRow.Cells["otchestvo"].Value.ToString();
            textBoxTelefon.Text = сurRow.Cells["telefon"].Value.ToString();
            textBoxPol.Text = сurRow.Cells["pol"].Value.ToString();
            textBoxKlass.Text = сurRow.Cells["klass"].Value.ToString();
            if (IsNewRow != true)
            {
                dateTimeDataRozhdeniia.Value = (DateTime)сurRow.Cells["date_rozhdeniia"].Value;
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

            gridListZapisi.DataSource = ClassDB.selectPoisk(textBoxPoisk.Text);
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



        private void formUserToLock(bool islocked)
        {
            this.buttonSaveUchenik.Enabled = !islocked;
            this.buttonDeleteUchenik.Enabled = true;
            this.buttonToEditUchenik.Enabled = islocked;
            this.buttonAddNewUchenik.Enabled = islocked;

            this.textBoxFamilia.ReadOnly = islocked;
            this.textBoxIma.ReadOnly = islocked;
            this.textBoxOtchestvo.ReadOnly = islocked;
            this.dateTimeDataRozhdeniia.Enabled = !islocked;
            this.textBoxTelefon.ReadOnly = islocked;
            this.textBoxPol.ReadOnly = islocked;
            this.textBoxKlass.ReadOnly = islocked;
            this.textBoxLogin.ReadOnly = islocked;
        }

        private void formBoleznToLock(bool islocked)
        {
            this.buttonSaveZapis.Enabled = !islocked;
            this.buttonDeleteZapis.Enabled = true;
            this.buttonToEditZapis.Enabled = islocked;
            this.buttonAddNewZapis.Enabled = islocked;

            if (this.textBoxZpId.Text == "")
            {
                this.buttonDeleteZapis.Enabled = false;
                this.buttonToEditZapis.Enabled = false;
            }

            this.textBoxDiagnoz.ReadOnly = islocked;
            this.textBoxSimptomi.ReadOnly = islocked;
            this.dateTimeStart_Data.Enabled = !islocked;
            this.dateTimeEnd_Data.Enabled = !islocked;
        }

        private void clearFormUcheniki()
        {
            textBoxFamilia.Text = "";
            textBoxIma.Text = "";
            textBoxOtchestvo.Text = "";
            dateTimeDataRozhdeniia.Value = DateTime.Now;
            textBoxTelefon.Text = "";
            textBoxPol.Text = "";
            textBoxKlass.Text = "";
            textBoxLogin.Text = "";
            textBoxId.Text = "";
        }

        private void clearFormZapisi()
        {
            textBoxDiagnoz.Text = "";
            textBoxSimptomi.Text = "";
            dateTimeStart_Data.Value = DateTime.Now;
            dateTimeStart_Data.Value = DateTime.Now;
            dateTimeEnd_Data.Text = "";
            textBoxZpId.Text = "";
        }

        private void buttonSaveUchenik_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text;

            if (id == "")
            {
                DataRow[] rows = ClassDB.findLoginUser(ClassDB.TABLE_UCHENIKI, textBoxLogin.Text);

                if (rows.Count() > 0)
                {
                    ClassMessage.showError("Такой логин уже существует!");
                    return;
                }
            }

            ClassDB.updateOrInsertUchenik(
                textBoxFamilia.Text,
                textBoxIma.Text,
                textBoxOtchestvo.Text,
                dateTimeDataRozhdeniia.Value,
                textBoxTelefon.Text,
                textBoxPol.Text,
                textBoxKlass.Text,
                textBoxLogin.Text,
                id
                );

            LoadGrids();
        }


        private void buttonToEditUchenik_Click(object sender, EventArgs e)
        {
            this.formUserToLock(false);
            this.formBoleznToLock(true);
        }

        private void buttonDeleteUchenik_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text.ToString();
            if (id != "")
            {
                ClassDB.Query($"DELETE FROM [dbo].[{ClassDB.TABLE_UCHENIKI}] WHERE id = '{textBoxId.Text}';");
                LoadGrids();
                ClassMessage.showInfo("Запись ученика удалена.");
            }
            
        }

        private void buttonAddNewUchenik_Click(object sender, EventArgs e)
        {
            this.clearFormUcheniki();
            this.formUserToLock(false);
        }

  
        private void buttonSaveZapis_Click(object sender, EventArgs e)
        {
            ClassDB.updateOrInsertZapisi(
                textBoxDiagnoz.Text,
                textBoxSimptomi.Text,
                dateTimeStart_Data.Value,
                dateTimeEnd_Data.Value,
                textBoxId.Text,
                textBoxZpId.Text
                );

            this.tabControlLists.SelectedIndex = 0;

            LoadGrids();
        }

        private void buttonToEditZapis_Click(object sender, EventArgs e)
        {
            this.formUserToLock(true);
            this.formBoleznToLock(false);
        }

        private void buttonDeleteZapis_Click(object sender, EventArgs e)
        {
            string id = textBoxZpId.Text.ToString();
            if (id != "")
            {
                ClassDB.Query($"DELETE FROM [dbo].[{ClassDB.TABLE_ZAPISI}] WHERE id = '{textBoxZpId.Text}';");
                LoadGrids();
                ClassMessage.showInfo("Запись болезни удалена.");
            }
        }

        private void buttonAddNewZapis_Click(object sender, EventArgs e)
        {
            this.clearFormZapisi();
            this.formBoleznToLock(false);
        }

        private void tabControlListsChangeIndex(object sender, EventArgs e)
        {
            LoadGrids();
        }
    }
}
