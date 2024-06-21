using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikV1._0
{
    public partial class NotDefteri : DevExpress.XtraEditors.XtraForm
    {
        public NotDefteri()
        {
            InitializeComponent();
        }

        private void NotDefteri_Load(object sender, EventArgs e)
        {
            listele();
        }

        void listele()
        {
            using (var db = new Database1Entities())

            {
                var komisyon = db.Not.FirstOrDefault();
                if (komisyon != null)
                    richTextBox1.Text = komisyon.Not1;
            }
            
         
        }

        void kaydet()
        {
            using (var db = new Database1Entities())
            {
                var sirket = db.Not.FirstOrDefault();
                sirket.Not1 = richTextBox1.Text;
                db.SaveChanges();
              //  XtraMessageBox.Show("Kayıt Ekleme Başarılı", "Uyarı", MessageBoxButtons.OK);
                dataGridView1.DataSource = db.Not.OrderByDescending(x => x.Id).ToList();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kaydet();
        }

    }
}