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
using System.Data.SqlClient;
using System.IO;
using System.Data.Entity;

namespace TeknikV1._0
{
    public partial class Ayarlar : DevExpress.XtraEditors.XtraForm
    {
        public Ayarlar()
        {
            InitializeComponent();
        }
        void kaydet()
        {
            using (var db = new Database1Entities())
            {
                KayitDurumu musteri = new KayitDurumu();
                musteri.Durum = textBox1.Text;

                db.KayitDurumu.Add(musteri);
                db.SaveChanges();
                XtraMessageBox.Show("Kayıt Ekleme Başarılı", "Uyarı", MessageBoxButtons.OK);
                dataGridView1.DataSource = db.KayitDurumu.OrderByDescending(x => x.Id).ToList();
                textBox1.Text = "";
            }

        }

        void kaydetaksesuar()
        {
            using (var db = new Database1Entities())
            {
                Aksesuar aksesuar = new Aksesuar();
                aksesuar.Aksesuar1 = textBox2.Text;

                db.Aksesuar.Add(aksesuar);
                db.SaveChanges();
                XtraMessageBox.Show("Kayıt Ekleme Başarılı", "Uyarı", MessageBoxButtons.OK);
                dataGridView2.DataSource = db.Aksesuar.OrderByDescending(x => x.Id).ToList();
                textBox2.Text = "";
            }
        }

        void kaydetcihaz()
        {
            using (var db = new Database1Entities())
            {
                Cihazlar cihaz = new Cihazlar();
                cihaz.Cihaz = textBox3.Text;

                db.Cihazlar.Add(cihaz);
                db.SaveChanges();
                XtraMessageBox.Show("Kayıt Ekleme Başarılı", "Uyarı", MessageBoxButtons.OK);
                dataGridView3.DataSource = db.Cihazlar.OrderByDescending(x => x.Id).ToList();
                textBox3.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            listele();
            listele1();
            listele2();
        }

        void listele()
        {
            using (var db = new Database1Entities())

                dataGridView1.DataSource = db.KayitDurumu.OrderByDescending(x => x.Id).ToList();

            İslemler.gridduzenle1(dataGridView1);

        }

        void listele1()
        {
            using (var db = new Database1Entities())

                dataGridView2.DataSource = db.Aksesuar.OrderByDescending(x => x.Id).ToList();

            İslemler.gridduzenle1(dataGridView2);

        }

        void listele2()
        {
            using (var db = new Database1Entities())

                dataGridView3.DataSource = db.Cihazlar.OrderByDescending(x => x.Id).ToList();

            İslemler.gridduzenle1(dataGridView3);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new Database1Entities())
            {
                int id = int.Parse(label5.Text);
                var model = db.KayitDurumu.FirstOrDefault(x => x.Id == id);
                model.Durum = textBox1.Text;

                db.SaveChanges();
                XtraMessageBox.Show("Düzenleme Başarılı", "Uyarı", MessageBoxButtons.OK);
                textBox1.Text = "";
                listele();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label5.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells["Durum"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var db = new Database1Entities())
            {
                if (textBox1.Text == "")
                {
                    XtraMessageBox.Show("Lütfen Seçim Yapınız !", "Uyarı", MessageBoxButtons.OK);

                }
                else
                {
                    int id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                    var model = db.KayitDurumu.FirstOrDefault(x => x.Id == id);
                    db.KayitDurumu.Remove(model);
                    db.SaveChanges();
                    XtraMessageBox.Show("Silme Başarılı", "Uyarı", MessageBoxButtons.OK);
                    textBox1.Text = "";
                    listele();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kaydetaksesuar();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label5.Text = dataGridView2.CurrentRow.Cells["Id"].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells["Aksesuar1"].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var db = new Database1Entities())
            {
                int id = int.Parse(label5.Text);
                var model = db.Aksesuar.FirstOrDefault(x => x.Id == id);
                model.Aksesuar1 = textBox2.Text;

                db.SaveChanges();
                XtraMessageBox.Show("Düzenleme Başarılı", "Uyarı", MessageBoxButtons.OK);
                textBox2.Text = "";
                listele1();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                XtraMessageBox.Show("Lütfen Seçim Yapınız !", "Uyarı", MessageBoxButtons.OK);

            }
            else
            {
                using (var db = new Database1Entities())
                {
                    int id = int.Parse(dataGridView2.CurrentRow.Cells["Id"].Value.ToString());
                    var model = db.Aksesuar.FirstOrDefault(x => x.Id == id);
                    db.Aksesuar.Remove(model);
                    db.SaveChanges();
                    XtraMessageBox.Show("Silme Başarılı", "Uyarı", MessageBoxButtons.OK);
                    textBox2.Text = "";
                    listele1();
                }
            }
        }

        void vtbackup()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Veri Yedek Dosyası|0.bak";
            save.FileName = "TeknikServis_" + DateTime.Now.ToShortDateString();
            if (save.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (File.Exists(save.FileName))
                    {
                        File.Delete(save.FileName);
                    }
                    var dbhedef = save.FileName;
                    string dbkaynak = Application.StartupPath + @"\Database1.mdf";
                    using (var db= new Database1Entities())
                    {
                        var cmd = @"BACKUP DATABASE[" + dbkaynak + "] TO DISK='" + dbhedef + "'";
                        db.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, cmd);
                    }
                    Cursor.Current = Cursors.Default;
                    XtraMessageBox.Show("Yedekleme Başarılı", "Uyarı", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString());

                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            kaydetcihaz();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                XtraMessageBox.Show("Lütfen Seçim Yapınız !", "Uyarı", MessageBoxButtons.OK);

            }
            else
            {
                using (var db = new Database1Entities())
                {
                    int id = int.Parse(dataGridView3.CurrentRow.Cells["Id"].Value.ToString());
                    var model = db.Cihazlar.FirstOrDefault(x => x.Id == id);
                    db.Cihazlar.Remove(model);
                    db.SaveChanges();
                    XtraMessageBox.Show("Silme Başarılı", "Uyarı", MessageBoxButtons.OK);
                    textBox3.Text = "";
                    listele2();
                }
            }
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label5.Text = dataGridView3.CurrentRow.Cells["Id"].Value.ToString();
            textBox3.Text = dataGridView3.CurrentRow.Cells["Cihaz"].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (var db = new Database1Entities())
            {
                int id = int.Parse(label5.Text);
                var model = db.Cihazlar.FirstOrDefault(x => x.Id == id);
                model.Cihaz = textBox3.Text;

                db.SaveChanges();
                XtraMessageBox.Show("Düzenleme Başarılı", "Uyarı", MessageBoxButtons.OK);
                textBox3.Text = "";
                listele2();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            vtbackup();
        }
    }
}