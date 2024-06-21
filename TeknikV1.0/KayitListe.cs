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
    public partial class KayitListe : DevExpress.XtraEditors.XtraForm
    {
        public KayitListe()
        {
            InitializeComponent();
        }

        void listele()
        {
            using (var db = new Database1Entities())
            {
                dataGridView1.DataSource = db.Kayitlar.OrderByDescending(x => x.Id).ToList();
                İslemler.gridduzenle2(dataGridView1);
            }
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
        private void KayitListe_Load(object sender, EventArgs e)
        {
            listele();
            combokayitdurumu();
            comboaksesuar();
            combocihaz();
        }
        void listele1()
        {
            using (var db = new Database1Entities())
            {
                DateTime baslangic = DateTime.Parse(dbaslangic.Value.ToShortDateString());
                dataGridView1.DataSource = db.Kayitlar.Where(x => x.Aktif.Contains(textEdit1.Text) && x.Durum.Contains(durumu.Text) && x.CihazTuru.Contains(cihzturu.Text) && x.AdiSoyadi.Contains(textBox1.Text) && x.Tarih == baslangic).ToList();
                İslemler.gridduzenle2(dataGridView1);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listele1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}