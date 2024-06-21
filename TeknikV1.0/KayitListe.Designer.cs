
namespace TeknikV1._0
{
    partial class KayitListe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dbaslangic = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.cihzturu = new System.Windows.Forms.ComboBox();
            this.aksesuar = new System.Windows.Forms.ComboBox();
            this.durumu = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ara ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(222, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 432);
            this.panel2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(609, 432);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 21);
            this.textBox1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dbaslangic);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cihzturu);
            this.panel1.Controls.Add(this.aksesuar);
            this.panel1.Controls.Add(this.durumu);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textEdit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 432);
            this.panel1.TabIndex = 4;
            // 
            // dbaslangic
            // 
            this.dbaslangic.Location = new System.Drawing.Point(12, 152);
            this.dbaslangic.Name = "dbaslangic";
            this.dbaslangic.Size = new System.Drawing.Size(196, 21);
            this.dbaslangic.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cihzturu
            // 
            this.cihzturu.FormattingEnabled = true;
            this.cihzturu.Location = new System.Drawing.Point(74, 39);
            this.cihzturu.Name = "cihzturu";
            this.cihzturu.Size = new System.Drawing.Size(134, 21);
            this.cihzturu.TabIndex = 13;
            // 
            // aksesuar
            // 
            this.aksesuar.FormattingEnabled = true;
            this.aksesuar.Location = new System.Drawing.Point(74, 66);
            this.aksesuar.Name = "aksesuar";
            this.aksesuar.Size = new System.Drawing.Size(134, 21);
            this.aksesuar.TabIndex = 18;
            // 
            // durumu
            // 
            this.durumu.FormattingEnabled = true;
            this.durumu.Location = new System.Drawing.Point(74, 93);
            this.durumu.Name = "durumu";
            this.durumu.Size = new System.Drawing.Size(134, 21);
            this.durumu.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Aktif-Pasif";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Durumu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cihaz Türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Aksesuar";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(75, 120);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit1.Properties.Items.AddRange(new object[] {
            "Açık",
            "Kapalı"});
            this.textEdit1.Size = new System.Drawing.Size(133, 20);
            this.textEdit1.TabIndex = 22;
            // 
            // KayitListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 432);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IconOptions.Image = global::TeknikV1._0.Properties.Resources.Gartoon_Team_Gartoon_Action_Vim_session_save_32;
            this.Name = "KayitListe";
            this.Text = "Kayıtlar";
            this.Load += new System.EventHandler(this.KayitListe_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cihzturu;
        private System.Windows.Forms.ComboBox aksesuar;
        private System.Windows.Forms.ComboBox durumu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.ComboBoxEdit textEdit1;
        private System.Windows.Forms.DateTimePicker dbaslangic;
    }
}