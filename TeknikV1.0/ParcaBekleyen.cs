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
    public partial class ParcaBekleyen : DevExpress.XtraEditors.XtraForm
    {
        public ParcaBekleyen()
        {
            InitializeComponent();
        }

        private void ParcaBekleyen_Load(object sender, EventArgs e)
        {
            listele();
        }
        
        void listele()
        {
            using (var db = new Database1Entities())
            {
                dataGridView1.DataSource = db.Kayitlar.Where(x => x.Durum.Contains("Parça Bekliyor")).ToList();
                İslemler.gridduzenle2(dataGridView1);
            }
        }
    }
}