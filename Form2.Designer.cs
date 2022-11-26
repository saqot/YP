
namespace YP
{
    partial class Form2
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
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSimptomi = new System.Windows.Forms.TextBox();
            this.labelSimptomi = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridListUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychenikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medpunktDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychenikiBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridListUsers
            // 
            this.gridListUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListUsers.Location = new System.Drawing.Point(1, 265);
            this.gridListUsers.Name = "gridListUsers";
            this.gridListUsers.RowHeadersWidth = 51;
            this.gridListUsers.Size = new System.Drawing.Size(986, 248);
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
            this.dateTimeStart_Data.Location = new System.Drawing.Point(743, 77);
            this.dateTimeStart_Data.Name = "dateTimeStart_Data";
            this.dateTimeStart_Data.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimeStart_Data.Size = new System.Drawing.Size(126, 20);
            this.dateTimeStart_Data.TabIndex = 131;
            // 
            // dateTimeDataRozhdeniia
            // 
            this.dateTimeDataRozhdeniia.Location = new System.Drawing.Point(134, 155);
            this.dateTimeDataRozhdeniia.Name = "dateTimeDataRozhdeniia";
            this.dateTimeDataRozhdeniia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimeDataRozhdeniia.Size = new System.Drawing.Size(126, 20);
            this.dateTimeDataRozhdeniia.TabIndex = 130;
            // 
            // labelStart_Data
            // 
            this.labelStart_Data.AutoSize = true;
            this.labelStart_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart_Data.Location = new System.Drawing.Point(636, 72);
            this.labelStart_Data.Name = "labelStart_Data";
            this.labelStart_Data.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStart_Data.Size = new System.Drawing.Size(94, 34);
            this.labelStart_Data.TabIndex = 128;
            this.labelStart_Data.Text = "Дата начала\r\nбольничного";
            this.labelStart_Data.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDiagnoz
            // 
            this.labelDiagnoz.AutoSize = true;
            this.labelDiagnoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiagnoz.Location = new System.Drawing.Point(294, 127);
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
            this.labelKlass.Location = new System.Drawing.Point(294, 104);
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
            this.labelPol.Location = new System.Drawing.Point(294, 78);
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
            this.labelDataRozhdeniia.Location = new System.Drawing.Point(2, 157);
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
            this.labelOtchestvo.Location = new System.Drawing.Point(2, 131);
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
            this.labelIma.Location = new System.Drawing.Point(2, 106);
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
            this.labelFamilia.Location = new System.Drawing.Point(2, 80);
            this.labelFamilia.Name = "labelFamilia";
            this.labelFamilia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFamilia.Size = new System.Drawing.Size(70, 17);
            this.labelFamilia.TabIndex = 121;
            this.labelFamilia.Text = "Фамилия";
            // 
            // textBoxDiagnoz
            // 
            this.textBoxDiagnoz.Location = new System.Drawing.Point(375, 131);
            this.textBoxDiagnoz.Multiline = true;
            this.textBoxDiagnoz.Name = "textBoxDiagnoz";
            this.textBoxDiagnoz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxDiagnoz.Size = new System.Drawing.Size(211, 43);
            this.textBoxDiagnoz.TabIndex = 120;
            // 
            // textBoxKlass
            // 
            this.textBoxKlass.Location = new System.Drawing.Point(375, 103);
            this.textBoxKlass.Name = "textBoxKlass";
            this.textBoxKlass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxKlass.Size = new System.Drawing.Size(56, 20);
            this.textBoxKlass.TabIndex = 119;
            // 
            // textBoxPol
            // 
            this.textBoxPol.Location = new System.Drawing.Point(375, 76);
            this.textBoxPol.Name = "textBoxPol";
            this.textBoxPol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPol.Size = new System.Drawing.Size(56, 20);
            this.textBoxPol.TabIndex = 118;
            // 
            // textBoxOtchestvo
            // 
            this.textBoxOtchestvo.Location = new System.Drawing.Point(134, 129);
            this.textBoxOtchestvo.Name = "textBoxOtchestvo";
            this.textBoxOtchestvo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxOtchestvo.Size = new System.Drawing.Size(125, 20);
            this.textBoxOtchestvo.TabIndex = 117;
            // 
            // textBoxIma
            // 
            this.textBoxIma.Location = new System.Drawing.Point(134, 104);
            this.textBoxIma.Name = "textBoxIma";
            this.textBoxIma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxIma.Size = new System.Drawing.Size(125, 20);
            this.textBoxIma.TabIndex = 116;
            // 
            // textBoxFamilia
            // 
            this.textBoxFamilia.Location = new System.Drawing.Point(134, 80);
            this.textBoxFamilia.Name = "textBoxFamilia";
            this.textBoxFamilia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxFamilia.Size = new System.Drawing.Size(125, 20);
            this.textBoxFamilia.TabIndex = 115;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(917, 188);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(59, 31);
            this.button5.TabIndex = 114;
            this.button5.Text = "Отчёт";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 110;
            this.label1.Text = "Список больных";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(902, 151);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDelete.Size = new System.Drawing.Size(74, 31);
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
            this.buttonEdit.Location = new System.Drawing.Point(902, 115);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEdit.Size = new System.Drawing.Size(74, 31);
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
            this.buttonAddNew.Location = new System.Drawing.Point(896, 78);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAddNew.Size = new System.Drawing.Size(80, 31);
            this.buttonAddNew.TabIndex = 109;
            this.buttonAddNew.Text = "Добавить";
            this.buttonAddNew.UseVisualStyleBackColor = false;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // dateTimeEnd_Data
            // 
            this.dateTimeEnd_Data.Location = new System.Drawing.Point(743, 131);
            this.dateTimeEnd_Data.Name = "dateTimeEnd_Data";
            this.dateTimeEnd_Data.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimeEnd_Data.Size = new System.Drawing.Size(126, 20);
            this.dateTimeEnd_Data.TabIndex = 133;
            // 
            // labelEnd_Data
            // 
            this.labelEnd_Data.AutoSize = true;
            this.labelEnd_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnd_Data.Location = new System.Drawing.Point(613, 126);
            this.labelEnd_Data.Name = "labelEnd_Data";
            this.labelEnd_Data.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEnd_Data.Size = new System.Drawing.Size(117, 34);
            this.labelEnd_Data.TabIndex = 132;
            this.labelEnd_Data.Text = "Дата окончания\r\nбольничного";
            this.labelEnd_Data.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxPoisk
            // 
            this.textBoxPoisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPoisk.ForeColor = System.Drawing.Color.Black;
            this.textBoxPoisk.Location = new System.Drawing.Point(3, 41);
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
            this.label9.Location = new System.Drawing.Point(10, 45);
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
            this.labelTelefon.Location = new System.Drawing.Point(2, 185);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTelefon.Size = new System.Drawing.Size(121, 17);
            this.labelTelefon.TabIndex = 136;
            this.labelTelefon.Text = "Номер телефона";
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(134, 185);
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
            this.button6.Location = new System.Drawing.Point(890, 41);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 34);
            this.panel1.TabIndex = 141;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // textBoxSimptomi
            // 
            this.textBoxSimptomi.Location = new System.Drawing.Point(375, 185);
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
            this.labelSimptomi.Location = new System.Drawing.Point(294, 182);
            this.labelSimptomi.Name = "labelSimptomi";
            this.labelSimptomi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSimptomi.Size = new System.Drawing.Size(76, 17);
            this.labelSimptomi.TabIndex = 143;
            this.labelSimptomi.Text = "Симптомы";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(5, 239);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 144;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 515);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.gridListUsers);
            this.Controls.Add(this.labelSimptomi);
            this.Controls.Add(this.textBoxSimptomi);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPoisk);
            this.Controls.Add(this.dateTimeEnd_Data);
            this.Controls.Add(this.labelEnd_Data);
            this.Controls.Add(this.dateTimeStart_Data);
            this.Controls.Add(this.dateTimeDataRozhdeniia);
            this.Controls.Add(this.labelStart_Data);
            this.Controls.Add(this.labelDiagnoz);
            this.Controls.Add(this.labelKlass);
            this.Controls.Add(this.labelPol);
            this.Controls.Add(this.labelDataRozhdeniia);
            this.Controls.Add(this.labelOtchestvo);
            this.Controls.Add(this.labelIma);
            this.Controls.Add(this.labelFamilia);
            this.Controls.Add(this.textBoxDiagnoz);
            this.Controls.Add(this.textBoxKlass);
            this.Controls.Add(this.textBoxPol);
            this.Controls.Add(this.textBoxOtchestvo);
            this.Controls.Add(this.textBoxIma);
            this.Controls.Add(this.textBoxFamilia);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Медпункт";
            ((System.ComponentModel.ISupportInitialize)(this.gridListUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychenikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medpunktDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychenikiBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSimptomi;
        private System.Windows.Forms.Label labelSimptomi;
        private System.Windows.Forms.TextBox textBoxId;
    }
}