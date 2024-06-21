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
    public partial class KayitEkle : DevExpress.XtraEditors.XtraForm
    {
        public KayitEkle()
        {
            InitializeComponent();
        }

        private void KayitEkle_Load(object sender, EventArgs e)
        {

            combokayitdurumu();
            comboaksesuar();
            combocihaz();
            listele();
        }
        void combohizmet()
        {
            using (var db = new Database1Entities())
            {
                var x = from item in db.Hizmetler
                        select new { item.Hizmet };
                durumu.DataSource = x.ToList();
                durumu.DisplayMember = "Hizmet";
            }
        }

        void combocihaz()
        {
            using (var db = new Database1Entities())
            {
                var x = from item in db.Cihazlar
                        select new { item.Cihaz };
                cihzturu.DataSource = x.ToList();
                cihzturu.DisplayMember = "Cihaz";
            }
        }
        void combokayitdurumu()
        {
            using (var db = new Database1Entities())
            {
                var x = from item in db.KayitDurumu
                        select new { item.Durum };
                durumu.DataSource = x.ToList();
                durumu.DisplayMember = "Durum";
            }
        }

        void comboaksesuar()
        {
            using (var db = new Database1Entities())
            {
                var x = from item in db.Aksesuar
                        select new { item.Aksesuar1 };
                aksesuar.DataSource = x.ToList();
                aksesuar.DisplayMember = "Aksesuar1";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new Database1Entities())
            {
                Kayitlar musteri = new Kayitlar();
                musteri.AdiSoyadi = adsoyad.Text;
                musteri.Aksesuar = aksesuar.Text;
                musteri.Aktif = aktifpasif.Text;
                musteri.Ariza = arizatanim.Text;
                musteri.CihazTuru = cihzturu.Text;
                musteri.Durum = durumu.Text;
                musteri.Not = not.Text;
                musteri.Telefon = telefon.Text;
                musteri.İletisim = iletisim.Text;
                musteri.Tarih = DateTime.Now.Date;
                db.Kayitlar.Add(musteri);
                db.SaveChanges();
                XtraMessageBox.Show("Kayıt Ekleme Başarılı", "Uyarı", MessageBoxButtons.OK);
                dataGridView1.DataSource = db.Kayitlar.OrderByDescending(x => x.Id).ToList();
                dataGridView2.Visible = false;

            }
        }

        void listele()
        {
            using (var db = new Database1Entities())
            {
                dataGridView1.DataSource = db.Kayitlar.OrderByDescending(x => x.Id).ToList();
                İslemler.gridduzenle2(dataGridView1);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label10.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            adsoyad.Text = dataGridView1.CurrentRow.Cells["AdiSoyadi"].Value.ToString();
            telefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            iletisim.Text = dataGridView1.CurrentRow.Cells["İletisim"].Value.ToString();
            cihzturu.Text = dataGridView1.CurrentRow.Cells["CihazTuru"].Value.ToString();
            arizatanim.Text = dataGridView1.CurrentRow.Cells["Ariza"].Value.ToString();
            aksesuar.Text = dataGridView1.CurrentRow.Cells["Aksesuar"].Value.ToString();
            durumu.Text = dataGridView1.CurrentRow.Cells["Durum"].Value.ToString();
            aktifpasif.Text = dataGridView1.CurrentRow.Cells["Aktif"].Value.ToString();
            not.Text = dataGridView1.CurrentRow.Cells["Not"].Value.ToString();
            dataGridView2.Visible = false;
        }

        private void adsoyad_TextChanged(object sender, EventArgs e)
        {

            using (var db = new Database1Entities())
            {
                dataGridView2.Visible = true;
                dataGridView2.DataSource = db.Musteri.Where(x => x.Unvan.Contains(textBox1.Text) || x.Adi.Contains(textBox1.Text) || x.Cep.Contains(textBox1.Text)).ToList();
                İslemler.gridduzenle3(dataGridView2);
            }


        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label10.Text = dataGridView2.CurrentRow.Cells["Id"].Value.ToString();
            adsoyad.Text = dataGridView2.CurrentRow.Cells["Adi"].Value.ToString();
            telefon.Text = dataGridView2.CurrentRow.Cells["Cep"].Value.ToString();
            iletisim.Text = dataGridView2.CurrentRow.Cells["Tel"].Value.ToString();
            dataGridView2.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new Database1Entities())
            {
                int id = int.Parse(label10.Text);
                var musteri = db.Kayitlar.FirstOrDefault(x => x.Id == id);
                musteri.AdiSoyadi = adsoyad.Text;
                musteri.Aksesuar = aksesuar.Text;
                musteri.Aktif = aktifpasif.Text;
                musteri.Ariza = arizatanim.Text;
                musteri.CihazTuru = cihzturu.Text;
                musteri.Durum = durumu.Text;
                musteri.Not = not.Text;
                musteri.Telefon = telefon.Text;
                musteri.İletisim = iletisim.Text;
                db.SaveChanges();
                XtraMessageBox.Show("Düzenleme Başarılı", "Uyarı", MessageBoxButtons.OK);
                dataGridView1.DataSource = db.Kayitlar.OrderByDescending(x => x.Id).ToList();
                dataGridView2.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var db = new Database1Entities())
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                var model = db.Kayitlar.FirstOrDefault(x => x.Id == id);
                db.Kayitlar.Remove(model);
                db.SaveChanges();
                XtraMessageBox.Show("Silme Başarılı", "Uyarı", MessageBoxButtons.OK);
                dataGridView2.Visible = false;
                listele();
            }
        }
    }
}
