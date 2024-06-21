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
    public partial class Grafikler : DevExpress.XtraEditors.XtraForm
    {
        private Database1Entities db = new Database1Entities();
        public Grafikler()
        {
            InitializeComponent();
            var model = db.StoklarTb.GroupBy(m => m.StokAdi).Select(s => new 
            {
            UrunAdi=s.Key,
            Miktar= s.Sum(m=> m.Kalan)
            }).ToList();

            foreach (var item in model)
            {
                chartControl1.Series["Series 1"].Points.AddPoint(item.UrunAdi, Convert.ToDouble(item.Miktar));
            }
        }

        private void Grafikler_Load(object sender, EventArgs e)
        {

        }
    }
}