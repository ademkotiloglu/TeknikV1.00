using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeknikV1._0
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Takvim altForm;
        private NotDefteri altForm1;
        public Form1()
        {
            InitializeComponent();
            altForm = new Takvim();
            altForm1 = new NotDefteri();
        }

        Stoklar fr1;
        frmMusteri fr2;
        Hizmtler fr3;
        KayitEkle fr4;
        KayitListe fr5;
        ParcaBekleyen fr6;
        Raporlar fr7;
        Grafikler fr8;
        Ayarlar fr9;
      

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frmMusteri existingfrmMusteri = null;

            // MDI parent form üzerindeki child formları kontrol et
            foreach (Form frmMusteri in this.MdiChildren)
            {
                if (frmMusteri is frmMusteri)
                {
                    existingfrmMusteri = (frmMusteri)frmMusteri;
                    break;
                }
            }

            if (existingfrmMusteri == null)
            {
                // Eğer child form daha önce açılmamışsa yeni bir instance oluştur
                frmMusteri newfrmMusteri = new frmMusteri();
                newfrmMusteri.MdiParent = this;
                newfrmMusteri.Show();
            }
            else
            {
                // Eğer child form zaten açıksa sadece ön plana getir
                existingfrmMusteri.Activate();
            }

        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Stoklar existingStoklar = null;

            // MDI parent form üzerindeki child formları kontrol et
            foreach (Form Stoklar in this.MdiChildren)
            {
                if (Stoklar is Stoklar)
                {
                    existingStoklar = (Stoklar)Stoklar;
                    break;
                }
            }

            if (existingStoklar == null)
            {
                // Eğer child form daha önce açılmamışsa yeni bir instance oluştur
                Stoklar newStoklar = new Stoklar();
                newStoklar.MdiParent = this;
                newStoklar.Show();
            }
            else
            {
                // Eğer child form zaten açıksa sadece ön plana getir
                existingStoklar.Activate();
            }

        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (altForm.Visible)
            {
                altForm.Close();
            }
            else
            {
                altForm = new Takvim();
                altForm.Show();
            }

        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (altForm1.Visible)
            {
                altForm1.Close();
            }
            else
            {
                altForm1 = new NotDefteri();
                altForm1.Show();
            }
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Hizmtler existingfrmMusteri = null;

            // MDI parent form üzerindeki child formları kontrol et
            foreach (Form frmMusteri in this.MdiChildren)
            {
                if (frmMusteri is Hizmtler)
                {
                    existingfrmMusteri = (Hizmtler)frmMusteri;
                    break;
                }
            }

            if (existingfrmMusteri == null)
            {
                // Eğer child form daha önce açılmamışsa yeni bir instance oluştur
                Hizmtler newfrmMusteri = new Hizmtler();
                newfrmMusteri.MdiParent = this;
                newfrmMusteri.Show();
            }
            else
            {
                // Eğer child form zaten açıksa sadece ön plana getir
                existingfrmMusteri.Activate();
            }
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KayitEkle existingKayitEkle = null;

            // MDI parent form üzerindeki child formları kontrol et
            foreach (Form KayitEkle in this.MdiChildren)
            {
                if (KayitEkle is KayitEkle)
                {
                    existingKayitEkle = (KayitEkle)KayitEkle;
                    break;
                }
            }

            if (existingKayitEkle == null)
            {
                // Eğer child form daha önce açılmamışsa yeni bir instance oluştur
                KayitEkle newKayitEkle = new KayitEkle();
                newKayitEkle.MdiParent = this;
                newKayitEkle.Show();
            }
            else
            {
                // Eğer child form zaten açıksa sadece ön plana getir
                existingKayitEkle.Activate();
            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KayitListe existingKayitListe = null;

            // MDI parent form üzerindeki child formları kontrol et
            foreach (Form KayitListe in this.MdiChildren)
            {
                if (KayitListe is KayitListe)
                {
                    existingKayitListe = (KayitListe)KayitListe;
                    break;
                }
            }

            if (existingKayitListe == null)
            {
                // Eğer child form daha önce açılmamışsa yeni bir instance oluştur
                KayitListe newKayitListe = new KayitListe();
                newKayitListe.MdiParent = this;
                newKayitListe.Show();
            }
            else
            {
                // Eğer child form zaten açıksa sadece ön plana getir
                existingKayitListe.Activate();
            }
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ParcaBekleyen existingParcaBekleyen = null;

            // MDI parent form üzerindeki child formları kontrol et
            foreach (Form ParcaBekleyen in this.MdiChildren)
            {
                if (ParcaBekleyen is ParcaBekleyen)
                {
                    existingParcaBekleyen = (ParcaBekleyen)ParcaBekleyen;
                    break;
                }
            }

            if (existingParcaBekleyen == null)
            {
                // Eğer child form daha önce açılmamışsa yeni bir instance oluştur
                ParcaBekleyen newParcaBekleyen = new ParcaBekleyen();
                newParcaBekleyen.MdiParent = this;
                newParcaBekleyen.Show();
            }
            else
            {
                // Eğer child form zaten açıksa sadece ön plana getir
                existingParcaBekleyen.Activate();
            }
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Raporlar existingRaporlar = null;

            // MDI parent form üzerindeki child formları kontrol et
            foreach (Form Raporlar in this.MdiChildren)
            {
                if (Raporlar is Raporlar)
                {
                    existingRaporlar = (Raporlar)Raporlar;
                    break;
                }
            }

            if (existingRaporlar == null)
            {
                // Eğer child form daha önce açılmamışsa yeni bir instance oluştur
                Raporlar newRaporlar = new Raporlar();
                newRaporlar.MdiParent = this;
                newRaporlar.Show();
            }
            else
            {
                // Eğer child form zaten açıksa sadece ön plana getir
                existingRaporlar.Activate();
            }
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Grafikler existingGrafikler = null;

            // MDI parent form üzerindeki child formları kontrol et
            foreach (Form Grafikler in this.MdiChildren)
            {
                if (Grafikler is Grafikler)
                {
                    existingGrafikler = (Grafikler)Grafikler;
                    break;
                }
            }

            if (existingGrafikler == null)
            {
                // Eğer child form daha önce açılmamışsa yeni bir instance oluştur
                Grafikler newGrafikler = new Grafikler();
                newGrafikler.MdiParent = this;
                newGrafikler.Show();
            }
            else
            {
                // Eğer child form zaten açıksa sadece ön plana getir
                existingGrafikler.Activate();
            }
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ayarlar existingAyarlar = null;

            // MDI parent form üzerindeki child formları kontrol et
            foreach (Form Ayarlar in this.MdiChildren)
            {
                if (Ayarlar is Ayarlar)
                {
                    existingAyarlar = (Ayarlar)Ayarlar;
                    break;
                }
            }

            if (existingAyarlar == null)
            {
                // Eğer child form daha önce açılmamışsa yeni bir instance oluştur
                Ayarlar newAyarlar = new Ayarlar();
                newAyarlar.MdiParent = this;
                newAyarlar.Show();
            }
            else
            {
                // Eğer child form zaten açıksa sadece ön plana getir
                existingAyarlar.Activate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new Database1Entities())
                if (db != null)
                {
                    barStaticItem1.Caption = "Veritabanı Bağlantısı Başarılı ..!";
                }
                else
                    barStaticItem1.Caption = "Veritabanı Bağlantısı Başarısız ..!";
        }
    }
}
