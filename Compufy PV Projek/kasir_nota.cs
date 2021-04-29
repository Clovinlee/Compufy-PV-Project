using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compufy_PV_Projek
{
    public partial class kasir_nota : Form
    {
        public kasir_nota()
        {
            InitializeComponent();
        }
        public menu_kasir frm_kasir;
        public login frm_login;
        public int h_id;
        public List<string> id_barang;
        public decimal bayar;
        public string nama_member;
        public string metode;

        ds_nota ds_checkout;
        private void kasir_nota_Load(object sender, EventArgs e)
        {
            string barang = "(";
            for(int x = 0; x < id_barang.Count-1;x++)
            {
                barang += id_barang[x] + ",";
            }
            barang += id_barang[id_barang.Count - 1] + ")";
            string q;
            ds_checkout = new ds_nota();
            q = $"SELECT * FROM h_transaksi WHERE id_trans = '{h_id}'";
            frm_login.executeDataSet(ds_checkout, q, "h_transaksi");

            q = $"SELECT * FROM d_transaksi WHERE id_trans = '{h_id}'";
            frm_login.executeDataSet(ds_checkout, q, "d_transaksi");

            q = $"SELECT * FROM Barang WHERE id_barang IN {barang}";
            frm_login.executeDataSet(ds_checkout, q, "barang");

            cr_nota nota = new cr_nota();
            nota.SetDataSource(ds_checkout);
            nota.SetParameterValue("Pid_trans", h_id.ToString());
            nota.SetParameterValue("Pnama_cust", nama_member);
            nota.SetParameterValue("Pbayar", bayar);
            nota.SetParameterValue("Pmetode", metode);

            creport.ReportSource = nota;
        }

        private void kasir_nota_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_kasir.frm_nota = null;
            frm_kasir.Show();
        }
    }
}
