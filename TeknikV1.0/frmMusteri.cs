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
    public partial class frmMusteri : DevExpress.XtraEditors.XtraForm
    {
        public frmMusteri()
        {
            InitializeComponent();
        }

        private void frmMusteri_Load(object sender, EventArgs e)
        {
            listele();
        }

        void listele()
        {
            using (var db = new Database1Entities())
            dataGridView1.DataSource = db.Musteri.OrderByDescending(x => x.Id).ToList();
            İslemler.gridduzenle1(dataGridView1);

        }
        void kaydet()
        {
            using (var db = new Database1Entities())
            {
                Musteri musteri = new Musteri();
                musteri.Unvan = textBox2.Text;
                musteri.Adi = textBox3.Text;
                musteri.Cep = textBox5.Text;
                musteri.Tel = textBox6.Text;
                musteri.Adres = textBox7.Text;
                musteri.Email = textBox8.Text;
                musteri.Not = richTextBox1.Text;
                db.Musteri.Add(musteri);
                db.SaveChanges();
                XtraMessageBox.Show("Kayıt Ekleme Başarılı", "Uyarı", MessageBoxButtons.OK);
                dataGridView1.DataSource = db.Musteri.OrderByDescending(x => x.Id).ToList();
                temizle();
            }
    
        }

        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            richTextBox1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kaydet();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label10.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Unvan"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Adi"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["Cep"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["Tel"].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells["Not"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new Database1Entities())
            {
                int id = int.Parse(label10.Text);
                var model = db.Musteri.FirstOrDefault(x => x.Id == id);
                model.Unvan = textBox2.Text;
                model.Adi = textBox3.Text;
                model.Cep = textBox5.Text;
                model.Tel = textBox6.Text;
                model.Adres = textBox7.Text;
                model.Email = textBox8.Text;
                model.Not = richTextBox1.Text;
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
                var model = db.Musteri.FirstOrDefault(x => x.Id == id);
                db.Musteri.Remove(model);
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
                dataGridView1.DataSource = db.Musteri.Where(x => x.Unvan.Contains(textBox1.Text) || x.Adi.Contains(textBox1.Text)  || x.Cep.Contains(textBox1.Text)).ToList();
                    
                    }
                
        }
    }
}