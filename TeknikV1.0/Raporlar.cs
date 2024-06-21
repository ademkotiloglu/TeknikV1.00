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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace TeknikV1._0
{
    public partial class Raporlar : DevExpress.XtraEditors.XtraForm
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text == "Kayıtlar")
            {
                listele();
            }
            if (textEdit1.Text == "Stoklar")
            {
                listele1();
            }
            if (textEdit1.Text == "Müşteriler")
            {
                listele2();
            }


        }

        void listele()
        {
            DateTime baslangic = DateTime.Parse(dbaslangic.Value.ToShortDateString());
            DateTime bitis = DateTime.Parse(dbitis.Value.ToShortDateString());
            using (var db = new Database1Entities())
            {
                var liste = db.Kayitlar.ToList();
                liste = db.Kayitlar.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).OrderByDescending(x => x.Tarih).ToList();
                dataGridView1.DataSource = liste;
                İslemler.gridduzenle2(dataGridView1);
            }
        }
        void listele1()
        {
            using (var db = new Database1Entities())
                dataGridView1.DataSource = db.StoklarTb.OrderByDescending(x => x.Id).ToList();
            İslemler.gridduzenle1(dataGridView1);

        }
        void listele2()
        {
            using (var db = new Database1Entities())
                dataGridView1.DataSource = db.Musteri.OrderByDescending(x => x.Id).ToList();
            İslemler.gridduzenle1(dataGridView1);
        }

    
        public void pdfyap(DataGridView dgw,string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);

            }
            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savedialog = new SaveFileDialog();
            savedialog.FileName = filename;
            savedialog.DefaultExt = ".pdf";
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savedialog.FileName,FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pdfyap(dataGridView1, "test");
        }
    }
}