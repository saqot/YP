
namespace YP
{
    partial class FormZapisiVse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridListUsers = new System.Windows.Forms.DataGridView();
            this.ychenikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medpunktDataSet = new YP.MedpunktDataSet();
            this.ychenikiTableAdapter = new YP.MedpunktDataSetTableAdapters.YchenikiTableAdapter();
            this.dateTimeStart_Data = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDataRozhdeniia = new System.Windows.Forms.DateTimePicker();
            this.labelStart_Data = new System.Windows.Forms.Label();
            this.labelDiagnoz = new System.Windows.Forms.Label();
            this.labelKlass = new System.Windows.Forms.Label();
            this.labelPol = new System.Windows.Forms.Label();
            this.labelDataRozhdeniia = new System.Windows.Forms.Label();
            this.labelOtchestvo = new System.Windows.Forms.Label();
            this.labelIma = new System.Windows.Forms.Label();
            this.labelFamilia = new System.Windows.Forms.Label();
            this.textBoxDiagnoz = new System.Windows.Forms.TextBox();
            this.textBoxKlass = new System.Windows.Forms.TextBox();
            this.textBoxPol = new System.Windows.Forms.TextBox();
            this.textBoxOtchestvo = new System.Windows.Forms.TextBox();
            this.textBoxIma = new System.Windows.Forms.TextBox();
            this.textBoxFamilia = new System.Windows.Forms.TextBox();
            this.buttonOtchetExel = new System.Windows.Forms.Button();
            this.labelZagolovok = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.dateTimeEnd_Data = new System.Windows.Forms.DateTimePicker();
            this.labelEnd_Data = new System.Windows.Forms.Label();
            this.textBoxPoisk = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.ychenikiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelVerh = new System.Windows.Forms.Panel();
            this.labelFio = new System.Windows.Forms.Label();
            this.textBoxSimptomi = new System.Windows.Forms.TextBox();
            this.labelSimptomi = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.groupBoxUchenik = new System.Windows.Forms.GroupBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.groupBoxIstoria = new System.Windows.Forms.GroupBox();
            this.textBoxZpId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridListUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychenikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medpunktDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychenikiBindingSource1)).BeginInit();
            this.panelVerh.SuspendLayout();
            this.groupBoxUchenik.SuspendLayout();
            this.groupBoxIstoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridListUsers
            // 
            this.gridListUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListUsers.Location = new System.Drawing.Point(1, 293);
            this.gridListUsers.Name = "gridListUsers";
            this.gridListUsers.RowHeadersWidth = 51;
            this.gridListUsers.Size = new System.Drawing.Size(986, 238);
            this.gridListUsers.TabIndex = 1;
            this.gridListUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListUsers_CellClick);
            this.gridListUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListUsers_CellClick);
            // 
            // ychenikiBindingSource
            // 
            this.ychenikiBindingSource.DataMember = "Ycheniki";
            this.ychenikiBindingSource.DataSource = this.medpunktDataSet;
            // 
            // medpunktDataSet
            // 
            this.medpunktDataSet.DataSetName = "MedpunktDataSet";
            this.medpunktDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ychenikiTableAdapter
            // 
            this.ychenikiTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimeStart_Data
            // 
            this.dateTimeStart_Data.Location = new System.Drawing.Point(215, 128);
            this.dateTimeStart_Data.Name = "dateTimeStart_Data";
            this.dateTimeStart_Data.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimeStart_Data.Size = new System.Drawing.Size(126, 20);
            this.dateTimeStart_Data.TabIndex = 131;
            // 
            // dateTimeDataRozhdeniia
            // 
            this.dateTimeDataRozhdeniia.Location = new System.Drawing.Point(139, 99);
            this.dateTimeDataRozhdeniia.Name = "dateTimeDataRozhdeniia";
            this.dateTimeDataRozhdeniia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimeDataRozhdeniia.Size = new System.Drawing.Size(126, 20);
            this.dateTimeDataRozhdeniia.TabIndex = 130;
            // 
            // labelStart_Data
            // 
            this.labelStart_Data.AutoSize = true;
            this.labelStart_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart_Data.Location = new System.Drawing.Point(8, 133);
            this.labelStart_Data.Name = "labelStart_Data";
            this.labelStart_Data.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStart_Data.Size = new System.Drawing.Size(146, 17);
            this.labelStart_Data.TabIndex = 128;
            this.labelStart_Data.Text = "Начало больничного";
            this.labelStart_Data.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDiagnoz
            // 
            this.labelDiagnoz.AutoSize = true;
            this.labelDiagnoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiagnoz.Location = new System.Drawing.Point(8, 21);
            this.labelDiagnoz.Name = "labelDiagnoz";
            this.labelDiagnoz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDiagnoz.Size = new System.Drawing.Size(63, 17);
            this.labelDiagnoz.TabIndex = 127;
            this.labelDiagnoz.Text = "Диагноз";
            // 
            // labelKlass
            // 
            this.labelKlass.AutoSize = true;
            this.labelKlass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKlass.Location = new System.Drawing.Point(289, 51);
            this.labelKlass.Name = "labelKlass";
            this.labelKlass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelKlass.Size = new System.Drawing.Size(47, 17);
            this.labelKlass.TabIndex = 126;
            this.labelKlass.Text = "Класс";
            // 
            // labelPol
            // 
            this.labelPol.AutoSize = true;
            this.labelPol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPol.Location = new System.Drawing.Point(289, 25);
            this.labelPol.Name = "labelPol";
            this.labelPol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPol.Size = new System.Drawing.Size(34, 17);
            this.labelPol.TabIndex = 125;
            this.labelPol.Text = "Пол";
            // 
            // labelDataRozhdeniia
            // 
            this.labelDataRozhdeniia.AutoSize = true;
            this.labelDataRozhdeniia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataRozhdeniia.Location = new System.Drawing.Point(7, 101);
            this.labelDataRozhdeniia.Name = "labelDataRozhdeniia";
            this.labelDataRozhdeniia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDataRozhdeniia.Size = new System.Drawing.Size(111, 17);
            this.labelDataRozhdeniia.TabIndex = 124;
            this.labelDataRozhdeniia.Text = "Дата рождения";
            // 
            // labelOtchestvo
            // 
            this.labelOtchestvo.AutoSize = true;
            this.labelOtchestvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOtchestvo.Location = new System.Drawing.Point(7, 75);
            this.labelOtchestvo.Name = "labelOtchestvo";
            this.labelOtchestvo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelOtchestvo.Size = new System.Drawing.Size(71, 17);
            this.labelOtchestvo.TabIndex = 123;
            this.labelOtchestvo.Text = "Отчество";
            // 
            // labelIma
            // 
            this.labelIma.AutoSize = true;
            this.labelIma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIma.Location = new System.Drawing.Point(7, 50);
            this.labelIma.Name = "labelIma";
            this.labelIma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelIma.Size = new System.Drawing.Size(35, 17);
            this.labelIma.TabIndex = 122;
            this.labelIma.Text = "Имя";
            // 
            // labelFamilia
            // 
            this.labelFamilia.AutoSize = true;
            this.labelFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFamilia.Location = new System.Drawing.Point(7, 24);
            this.labelFamilia.Name = "labelFamilia";
            this.labelFamilia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFamilia.Size = new System.Drawing.Size(70, 17);
            this.labelFamilia.TabIndex = 121;
            this.labelFamilia.Text = "Фамилия";
            // 
            // textBoxDiagnoz
            // 
            this.textBoxDiagnoz.Location = new System.Drawing.Point(130, 25);
            this.textBoxDiagnoz.Multiline = true;
            this.textBoxDiagnoz.Name = "textBoxDiagnoz";
            this.textBoxDiagnoz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxDiagnoz.Size = new System.Drawing.Size(211, 43);
            this.textBoxDiagnoz.TabIndex = 120;
            // 
            // textBoxKlass
            // 
            this.textBoxKlass.Location = new System.Drawing.Point(357, 51);
            this.textBoxKlass.Name = "textBoxKlass";
            this.textBoxKlass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxKlass.Size = new System.Drawing.Size(56, 20);
            this.textBoxKlass.TabIndex = 119;
            // 
            // textBoxPol
            // 
            this.textBoxPol.Location = new System.Drawing.Point(357, 24);
            this.textBoxPol.Name = "textBoxPol";
            this.textBoxPol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPol.Size = new System.Drawing.Size(56, 20);
            this.textBoxPol.TabIndex = 118;
            // 
            // textBoxOtchestvo
            // 
            this.textBoxOtchestvo.Location = new System.Drawing.Point(139, 73);
            this.textBoxOtchestvo.Name = "textBoxOtchestvo";
            this.textBoxOtchestvo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxOtchestvo.Size = new System.Drawing.Size(125, 20);
            this.textBoxOtchestvo.TabIndex = 117;
            // 
            // textBoxIma
            // 
            this.textBoxIma.Location = new System.Drawing.Point(139, 48);
            this.textBoxIma.Name = "textBoxIma";
            this.textBoxIma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxIma.Size = new System.Drawing.Size(125, 20);
            this.textBoxIma.TabIndex = 116;
            // 
            // textBoxFamilia
            // 
            this.textBoxFamilia.Location = new System.Drawing.Point(139, 24);
            this.textBoxFamilia.Name = "textBoxFamilia";
            this.textBoxFamilia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxFamilia.Size = new System.Drawing.Size(125, 20);
            this.textBoxFamilia.TabIndex = 115;
            // 
            // buttonOtchetExel
            // 
            this.buttonOtchetExel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonOtchetExel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOtchetExel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOtchetExel.Location = new System.Drawing.Point(883, 233);
            this.buttonOtchetExel.Name = "buttonOtchetExel";
            this.buttonOtchetExel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonOtchetExel.Size = new System.Drawing.Size(86, 31);
            this.buttonOtchetExel.TabIndex = 114;
            this.buttonOtchetExel.Text = "Отчёт";
            this.buttonOtchetExel.UseVisualStyleBackColor = false;
            this.buttonOtchetExel.Click += new System.EventHandler(this.buttonOtchetExel_Click);
            // 
            // labelZagolovok
            // 
            this.labelZagolovok.AutoSize = true;
            this.labelZagolovok.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZagolovok.Location = new System.Drawing.Point(9, 7);
            this.labelZagolovok.Name = "labelZagolovok";
            this.labelZagolovok.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelZagolovok.Size = new System.Drawing.Size(203, 29);
            this.labelZagolovok.TabIndex = 110;
            this.labelZagolovok.Text = "Список больных";
            this.labelZagolovok.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelVerh_MouseDown);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(883, 196);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDelete.Size = new System.Drawing.Size(86, 31);
            this.buttonDelete.TabIndex = 112;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(883, 160);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEdit.Size = new System.Drawing.Size(86, 31);
            this.buttonEdit.TabIndex = 111;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddNew.Location = new System.Drawing.Point(883, 123);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAddNew.Size = new System.Drawing.Size(86, 31);
            this.buttonAddNew.TabIndex = 109;
            this.buttonAddNew.Text = "Добавить";
            this.buttonAddNew.UseVisualStyleBackColor = false;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // dateTimeEnd_Data
            // 
            this.dateTimeEnd_Data.Location = new System.Drawing.Point(216, 156);
            this.dateTimeEnd_Data.Name = "dateTimeEnd_Data";
            this.dateTimeEnd_Data.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimeEnd_Data.Size = new System.Drawing.Size(126, 20);
            this.dateTimeEnd_Data.TabIndex = 133;
            // 
            // labelEnd_Data
            // 
            this.labelEnd_Data.AutoSize = true;
            this.labelEnd_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnd_Data.Location = new System.Drawing.Point(8, 159);
            this.labelEnd_Data.Name = "labelEnd_Data";
            this.labelEnd_Data.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEnd_Data.Size = new System.Drawing.Size(170, 17);
            this.labelEnd_Data.TabIndex = 132;
            this.labelEnd_Data.Text = "Окончание больничного";
            this.labelEnd_Data.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxPoisk
            // 
            this.textBoxPoisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPoisk.ForeColor = System.Drawing.Color.Black;
            this.textBoxPoisk.Location = new System.Drawing.Point(13, 41);
            this.textBoxPoisk.Multiline = true;
            this.textBoxPoisk.Name = "textBoxPoisk";
            this.textBoxPoisk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPoisk.Size = new System.Drawing.Size(144, 27);
            this.textBoxPoisk.TabIndex = 134;
            this.textBoxPoisk.TextChanged += new System.EventHandler(this.textBoxPoisk_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(20, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 135;
            this.label9.Text = "Поиск";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTelefon.Location = new System.Drawing.Point(7, 129);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTelefon.Size = new System.Drawing.Size(121, 17);
            this.labelTelefon.TabIndex = 136;
            this.labelTelefon.Text = "Номер телефона";
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(139, 129);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTelefon.Size = new System.Drawing.Size(125, 20);
            this.textBoxTelefon.TabIndex = 137;
            // 
            // ychenikiBindingSource1
            // 
            this.ychenikiBindingSource1.DataMember = "Ycheniki";
            this.ychenikiBindingSource1.DataSource = this.medpunktDataSet;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(883, 86);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(86, 31);
            this.button6.TabIndex = 138;
            this.button6.Text = "Подробно";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(954, 3);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 140;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelVerh
            // 
            this.panelVerh.Controls.Add(this.labelFio);
            this.panelVerh.Controls.Add(this.button4);
            this.panelVerh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVerh.Location = new System.Drawing.Point(0, 0);
            this.panelVerh.Name = "panelVerh";
            this.panelVerh.Size = new System.Drawing.Size(988, 34);
            this.panelVerh.TabIndex = 141;
            this.panelVerh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelVerh_MouseDown);
            // 
            // labelFio
            // 
            this.labelFio.AutoSize = true;
            this.labelFio.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFio.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelFio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFio.Location = new System.Drawing.Point(218, 11);
            this.labelFio.Name = "labelFio";
            this.labelFio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFio.Size = new System.Drawing.Size(111, 23);
            this.labelFio.TabIndex = 145;
            this.labelFio.Text = "тут будет фио";
            this.labelFio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelVerh_MouseDown);
            // 
            // textBoxSimptomi
            // 
            this.textBoxSimptomi.Location = new System.Drawing.Point(130, 79);
            this.textBoxSimptomi.Multiline = true;
            this.textBoxSimptomi.Name = "textBoxSimptomi";
            this.textBoxSimptomi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSimptomi.Size = new System.Drawing.Size(211, 43);
            this.textBoxSimptomi.TabIndex = 142;
            // 
            // labelSimptomi
            // 
            this.labelSimptomi.AutoSize = true;
            this.labelSimptomi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSimptomi.Location = new System.Drawing.Point(8, 76);
            this.labelSimptomi.Name = "labelSimptomi";
            this.labelSimptomi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSimptomi.Size = new System.Drawing.Size(76, 17);
            this.labelSimptomi.TabIndex = 143;
            this.labelSimptomi.Text = "Симптомы";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(357, 77);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(56, 20);
            this.textBoxId.TabIndex = 144;
            // 
            // groupBoxUchenik
            // 
            this.groupBoxUchenik.Controls.Add(this.labelLogin);
            this.groupBoxUchenik.Controls.Add(this.labelId);
            this.groupBoxUchenik.Controls.Add(this.textBoxLogin);
            this.groupBoxUchenik.Controls.Add(this.labelDataRozhdeniia);
            this.groupBoxUchenik.Controls.Add(this.textBoxFamilia);
            this.groupBoxUchenik.Controls.Add(this.textBoxId);
            this.groupBoxUchenik.Controls.Add(this.textBoxIma);
            this.groupBoxUchenik.Controls.Add(this.textBoxOtchestvo);
            this.groupBoxUchenik.Controls.Add(this.labelFamilia);
            this.groupBoxUchenik.Controls.Add(this.labelIma);
            this.groupBoxUchenik.Controls.Add(this.textBoxTelefon);
            this.groupBoxUchenik.Controls.Add(this.labelOtchestvo);
            this.groupBoxUchenik.Controls.Add(this.labelTelefon);
            this.groupBoxUchenik.Controls.Add(this.labelKlass);
            this.groupBoxUchenik.Controls.Add(this.dateTimeDataRozhdeniia);
            this.groupBoxUchenik.Controls.Add(this.labelPol);
            this.groupBoxUchenik.Controls.Add(this.textBoxPol);
            this.groupBoxUchenik.Controls.Add(this.textBoxKlass);
            this.groupBoxUchenik.Location = new System.Drawing.Point(14, 78);
            this.groupBoxUchenik.Name = "groupBoxUchenik";
            this.groupBoxUchenik.Size = new System.Drawing.Size(429, 187);
            this.groupBoxUchenik.TabIndex = 145;
            this.groupBoxUchenik.TabStop = false;
            this.groupBoxUchenik.Text = "Ученик";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelLogin.Location = new System.Drawing.Point(289, 104);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLogin.Size = new System.Drawing.Size(43, 17);
            this.labelLogin.TabIndex = 147;
            this.labelLogin.Text = "Login";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelId.Location = new System.Drawing.Point(289, 80);
            this.labelId.Name = "labelId";
            this.labelId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelId.Size = new System.Drawing.Size(21, 17);
            this.labelId.TabIndex = 146;
            this.labelId.Text = "ID";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(339, 102);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.ReadOnly = true;
            this.textBoxLogin.Size = new System.Drawing.Size(74, 20);
            this.textBoxLogin.TabIndex = 145;
            // 
            // groupBoxIstoria
            // 
            this.groupBoxIstoria.Controls.Add(this.textBoxZpId);
            this.groupBoxIstoria.Controls.Add(this.textBoxSimptomi);
            this.groupBoxIstoria.Controls.Add(this.textBoxDiagnoz);
            this.groupBoxIstoria.Controls.Add(this.labelDiagnoz);
            this.groupBoxIstoria.Controls.Add(this.labelSimptomi);
            this.groupBoxIstoria.Controls.Add(this.dateTimeStart_Data);
            this.groupBoxIstoria.Controls.Add(this.labelStart_Data);
            this.groupBoxIstoria.Controls.Add(this.labelEnd_Data);
            this.groupBoxIstoria.Controls.Add(this.dateTimeEnd_Data);
            this.groupBoxIstoria.Location = new System.Drawing.Point(466, 78);
            this.groupBoxIstoria.Name = "groupBoxIstoria";
            this.groupBoxIstoria.Size = new System.Drawing.Size(374, 187);
            this.groupBoxIstoria.TabIndex = 146;
            this.groupBoxIstoria.TabStop = false;
            this.groupBoxIstoria.Text = "История болезни";
            // 
            // textBoxZpId
            // 
            this.textBoxZpId.Location = new System.Drawing.Point(270, -1);
            this.textBoxZpId.Name = "textBoxZpId";
            this.textBoxZpId.ReadOnly = true;
            this.textBoxZpId.Size = new System.Drawing.Size(72, 20);
            this.textBoxZpId.TabIndex = 147;
            this.textBoxZpId.Visible = false;
            // 
            // FormZapisiVse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 533);
            this.Controls.Add(this.groupBoxIstoria);
            this.Controls.Add(this.groupBoxUchenik);
            this.Controls.Add(this.gridListUsers);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPoisk);
            this.Controls.Add(this.buttonOtchetExel);
            this.Controls.Add(this.labelZagolovok);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.panelVerh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormZapisiVse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Медпункт";
            ((System.ComponentModel.ISupportInitialize)(this.gridListUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychenikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medpunktDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychenikiBindingSource1)).EndInit();
            this.panelVerh.ResumeLayout(false);
            this.panelVerh.PerformLayout();
            this.groupBoxUchenik.ResumeLayout(false);
            this.groupBoxUchenik.PerformLayout();
            this.groupBoxIstoria.ResumeLayout(false);
            this.groupBoxIstoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridListUsers;
        private MedpunktDataSet medpunktDataSet;
        private System.Windows.Forms.BindingSource ychenikiBindingSource;
        private MedpunktDataSetTableAdapters.YchenikiTableAdapter ychenikiTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimeStart_Data;
        private System.Windows.Forms.DateTimePicker dateTimeDataRozhdeniia;
        private System.Windows.Forms.Label labelStart_Data;
        private System.Windows.Forms.Label labelDiagnoz;
        private System.Windows.Forms.Label labelKlass;
        private System.Windows.Forms.Label labelPol;
        private System.Windows.Forms.Label labelDataRozhdeniia;
        private System.Windows.Forms.Label labelOtchestvo;
        private System.Windows.Forms.Label labelIma;
        private System.Windows.Forms.Label labelFamilia;
        private System.Windows.Forms.TextBox textBoxDiagnoz;
        private System.Windows.Forms.TextBox textBoxKlass;
        private System.Windows.Forms.TextBox textBoxPol;
        private System.Windows.Forms.TextBox textBoxOtchestvo;
        private System.Windows.Forms.TextBox textBoxIma;
        private System.Windows.Forms.TextBox textBoxFamilia;
        private System.Windows.Forms.Button buttonOtchetExel;
        private System.Windows.Forms.Label labelZagolovok;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.DateTimePicker dateTimeEnd_Data;
        private System.Windows.Forms.Label labelEnd_Data;
        private System.Windows.Forms.TextBox textBoxPoisk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.BindingSource ychenikiBindingSource1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelVerh;
        private System.Windows.Forms.TextBox textBoxSimptomi;
        private System.Windows.Forms.Label labelSimptomi;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelFio;
        private System.Windows.Forms.GroupBox groupBoxUchenik;
        private System.Windows.Forms.GroupBox groupBoxIstoria;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxZpId;
    }
}