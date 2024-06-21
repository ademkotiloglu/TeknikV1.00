using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Globalization;
using System.IO;
using System.Windows.Forms;


namespace TeknikV1._0
{
    class İslemler
    {
        public static void gridduzenle1(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    switch (dgv.Columns[i].HeaderText)
                    {


                        case "Id":
                            dgv.Columns[i].Visible = false; break;

                        case "Unvan":
                            dgv.Columns[i].HeaderText = "Ünvanı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "Adi":
                            dgv.Columns[i].HeaderText = "Adı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "Soyadi":
                            dgv.Columns[i].HeaderText = "Soyadı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "Cep":
                            dgv.Columns[i].HeaderText = "Cep Telefonu";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "Tel":
                            dgv.Columns[i].HeaderText = "Sabit Telefon";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "Adres":
                            dgv.Columns[i].Visible = false; break;
                        case "Email":
                            dgv.Columns[i].HeaderText = "E-Mail";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "Not":
                            dgv.Columns[i].Visible = false; break;
                        case "Hizmet":
                            dgv.Columns[i].HeaderText = "Hizmet Adı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "Fiyat":
                            dgv.Columns[i].HeaderText = "Fiyatı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "OzelKodu":
                            dgv.Columns[i].HeaderText = "Özel Kodu";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "StokKodu":
                            dgv.Columns[i].HeaderText = "Stok Kodu";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "StokAdi":
                            dgv.Columns[i].HeaderText = "Stok Adı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "Aksesuar1":
                            dgv.Columns[i].HeaderText = "Aksesuar Adı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "Durum":
                            dgv.Columns[i].HeaderText = "Durum";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                    }
                }
            }
        }

        public static void gridduzenle2(DataGridView dgv)
        {

            if (dgv.Columns.Count > 0)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    switch (dgv.Columns[i].HeaderText)
                    {


                        case "Id":
                            dgv.Columns[i].Visible = false; break;
                        case "İletisim":
                            dgv.Columns[i].Visible = false; break;
                        case "Aksesuar":
                            dgv.Columns[i].Visible = false; break;
                        case "Not":
                            dgv.Columns[i].Visible = false; break;

                        case "AdiSoyadi":
                            dgv.Columns[i].HeaderText = "Adı Soyadı";
                            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "CihazTuru":
                            dgv.Columns[i].HeaderText = "Cihaz Türü";
                            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "Ariza":
                            dgv.Columns[i].HeaderText = "Arıza";
                            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "Durum":
                            dgv.Columns[i].HeaderText = "Durumu";
                            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;

                        case "Aktif":
                            dgv.Columns[i].HeaderText = "Aktif - Pasif";
                            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "Tarih":
                            dgv.Columns[i].HeaderText = "Tarih";
                            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                    }
                }
            }
        }
        public static void gridduzenle3(DataGridView dgv)
        {

            if (dgv.Columns.Count > 0)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    switch (dgv.Columns[i].HeaderText)
                    {


                        case "Id":
                            dgv.Columns[i].Visible = false; break;
                        case "Adres":
                            dgv.Columns[i].Visible = false; break;
                        case "Email":
                            dgv.Columns[i].Visible = false; break;
                        case "Not":
                            dgv.Columns[i].Visible = false; break;

                        case "Unvan":
                            dgv.Columns[i].HeaderText = "Ünvanı";
                            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;

                        case "Adi":
                            dgv.Columns[i].HeaderText = "Adı Soyadı";
                            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "Cep":
                            dgv.Columns[i].HeaderText = "Telefon";
                            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "Tel":
                            dgv.Columns[i].HeaderText = "İletişim";
                            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;




                    }
                }
            }
        }
    }
}