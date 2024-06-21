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
    public partial class Hizmtler : DevExpress.XtraEditors.XtraForm
    {
        public Hizmtler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        void listele()
        {
            using (var db = new Database1Entities())
                dataGridView1.DataSource = db.Hizmetler.OrderByDescending(x => x.Id).ToList();
            İslemler.gridduzenle1(dataGridView1);

        }
        void kaydet()
        {
            using (var db = new Database1Entities())
            {
                Hizmetler hizmet = new Hizmetler();
                hizmet.Hizmet = textBox2.Text;
                hizmet.OzelKodu = textBox3.Text;
               hizmet.Fiyat = textEdit1.Text;
                
                db.Hizmetler.Add(hizmet);
                db.SaveChanges();
                XtraMessageBox.Show("Kayıt Ekleme Başarılı", "Uyarı", MessageBoxButtons.OK);
                dataGridView1.DataSource = db.Hizmetler.OrderByDescending(x => x.Id).ToList();
                temizle();
            }

        }

        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textEdit1.Text = "";
          

        }

        private void Hizmtler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new Database1Entities())
            {
                int id = int.Parse(label10.Text);
                var model = db.Hizmetler.FirstOrDefault(x => x.Id == id);
                model.Hizmet = textBox2.Text;
                model.OzelKodu = textBox3.Text;
                model.Fiyat = textEdit1.Text;
               
                db.SaveChanges();
                XtraMessageBox.Show("Düzenleme Başarılı", "Uyarı", MessageBoxButtons.OK);
                temizle();
                listele();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var db = new Database1Entities())
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                var silmek = db.Hizmetler.FirstOrDefault(x => x.Id == id);
                db.Hizmetler.Remove(silmek);
                db.SaveChanges();
                XtraMessageBox.Show("Silme Başarılı", "Uyarı", MessageBoxButtons.OK);
                temizle();
                listele();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (var db = new Database1Entities())
            {
                dataGridView1.DataSource = db.Hizmetler.Where(x => x.Hizmet.Contains(textBox1.Text) || x.OzelKodu.Contains(textBox1.Text) || x.Fiyat.Contains(textBox1.Text)).ToList();

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label10.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Hizmet"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["OzelKodu"].Value.ToString();
            textEdit1.Text = dataGridView1.CurrentRow.Cells["Fiyat"].Value.ToString();
        }
    }
}