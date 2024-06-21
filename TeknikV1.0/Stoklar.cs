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
    public partial class Stoklar : DevExpress.XtraEditors.XtraForm
    {
        public Stoklar()
        {
            InitializeComponent();
        }

        private void Stoklar_Load(object sender, EventArgs e)
        {
            listele();
        }
        void listele()
        {
            using (var db = new Database1Entities())
                dataGridView1.DataSource = db.StoklarTb.OrderByDescending(x => x.Id).ToList();
            İslemler.gridduzenle1(dataGridView1);

        }
        void kaydet()
        {
            using (var db = new Database1Entities())
            {
                StoklarTb stoklar = new StoklarTb();
                stoklar.Barkodu = textBox2.Text;
                stoklar.StokKodu = textBox3.Text;
                stoklar.StokAdi = textBox4.Text;
                stoklar.Birim = textBox5.Text;
                if (textBox6.Text == "")
                {
                    stoklar.Miktar = 0;
                    stoklar.Kalan = Convert.ToInt32(textBox7.Text);
                }
                if (textBox7.Text == "")
                {
                    stoklar.Miktar = Convert.ToInt32(textBox6.Text);
                    stoklar.Kalan = Convert.ToInt32(textBox6.Text);
                }
                stoklar.Detay = richTextBox1.Text;
                db.StoklarTb.Add(stoklar);
                db.SaveChanges();
                XtraMessageBox.Show("Kayıt Ekleme Başarılı", "Uyarı", MessageBoxButtons.OK); dataGridView1.DataSource = db.StoklarTb.OrderByDescending(x => x.Id).ToList();
                temizle();
            }

        }

        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            richTextBox1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label10.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Barkodu"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["StokKodu"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["StokAdi"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["Birim"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["Miktar"].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells["Kalan"].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells["Detay"].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (var db = new Database1Entities())
            {
                dataGridView1.DataSource = db.StoklarTb.Where(x => x.Barkodu.Contains(textBox1.Text) || x.StokAdi.Contains(textBox1.Text) || x.StokKodu.Contains(textBox1.Text) || x.Detay.Contains(textBox1.Text)).ToList();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new Database1Entities())
            {
                int id = int.Parse(label10.Text);
                var model = db.StoklarTb.FirstOrDefault(x => x.Id == id);
                model.Barkodu = textBox2.Text;
                model.StokKodu = textBox3.Text;
                model.StokAdi = textBox4.Text;
                model.Birim = textBox5.Text;
                model.Miktar = Convert.ToInt32(textBox6.Text);
                model.Kalan = Convert.ToInt32(textBox7.Text);

                model.Detay = richTextBox1.Text;
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
                var model = db.StoklarTb.FirstOrDefault(x => x.Id == id);
                db.StoklarTb.Remove(model);
                db.SaveChanges();
                XtraMessageBox.Show("Silme Başarılı", "Uyarı", MessageBoxButtons.OK);
                temizle();
                listele();
            }
        }

      

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}