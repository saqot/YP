
namespace YP
{
    partial class FormLogin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ychenikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medpunktDataSet = new YP.MedpunktDataSet();
            this.ychenikiTableAdapter = new YP.MedpunktDataSetTableAdapters.YchenikiTableAdapter();
            this.ychenikiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxKto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ychenikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medpunktDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychenikiBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonEnter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.Location = new System.Drawing.Point(0, 180);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(407, 51);
            this.buttonEnter.TabIndex = 9;
            this.buttonEnter.Text = "Вход";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(151, 137);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(126, 26);
            this.textBoxPassword.TabIndex = 8;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(151, 104);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(126, 26);
            this.textBoxLogin.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(61, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(61, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(62, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Вход в программу медпункт";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonClose.Location = new System.Drawing.Point(373, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonClose.Size = new System.Drawing.Size(29, 30);
            this.buttonClose.TabIndex = 114;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 34);
            this.panel1.TabIndex = 115;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // comboBoxKto
            // 
            this.comboBoxKto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKto.FormattingEnabled = true;
            this.comboBoxKto.Location = new System.Drawing.Point(156, 74);
            this.comboBoxKto.Name = "comboBoxKto";
            this.comboBoxKto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKto.TabIndex = 116;
            this.comboBoxKto.SelectedIndexChanged += new System.EventHandler(this.comboBoxKto_Changed);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 231);
            this.Controls.Add(this.comboBoxKto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Медпункт";
            ((System.ComponentModel.ISupportInitialize)(this.ychenikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medpunktDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychenikiBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource ychenikiBindingSource1;
        private MedpunktDataSet medpunktDataSet;
        private System.Windows.Forms.BindingSource ychenikiBindingSource;
        private MedpunktDataSetTableAdapters.YchenikiTableAdapter ychenikiTableAdapter;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxKto;
    }
}

