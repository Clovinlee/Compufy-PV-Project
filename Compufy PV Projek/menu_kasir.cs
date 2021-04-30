using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Compufy_PV_Projek
{
    public partial class menu_kasir : Form
    {
        public menu_kasir()
        {
            InitializeComponent();
        }

        public login frm_login;
        DataSet ds_barang;
        public string id_login;

        private void menu_kasir_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1014, 639);
            lbl_subtotal.Text = "Rp 0";
            lbl_discount.Text = "Rp 0";
            lbl_grandtotal.Text = "Rp 0";

            ds_barang = new DataSet();
            string q = "SELECT * FROM barang";
            frm_login.executeDataSet(ds_barang, q, "barang");

            foreach(DataRow r in ds_barang.Tables["barang"].Rows)
            {
                Panel p_container = new Panel();
                p_container.Size = new Size(154, 180);

                Label l_judul = new Label();
                p_container.Controls.Add(l_judul);
                l_judul.Font = new Font("Nirmala UI", 10);
                l_judul.Size = new Size(156, 40);
                l_judul.Text = r[2].ToString();
                l_judul.TextAlign = ContentAlignment.MiddleCenter;
                l_judul.Location = new Point(0, 115);
                l_judul.Tag = "judul";
                l_judul.Click += new EventHandler(buttonItemAdd_Click);


                Label l_harga = new Label();
                p_container.Controls.Add(l_harga);
                l_harga.AutoSize = false;
                l_harga.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                l_harga.Size = new Size(163, 21);
                l_harga.Text = "Rp " + Convert.ToDecimal(r[3]).ToString("#,##");
                l_harga.TextAlign = ContentAlignment.MiddleCenter;
                l_harga.Location = new Point(0, 155);
                l_harga.Tag = "harga";

                Panel p_picture = new Panel();
                p_container.Controls.Add(p_picture);
                p_picture.Location = new Point(27, 12);
                p_picture.Size = new Size(100, 100);
                p_picture.BackColor = Color.Peru;
                try
                {
                    p_picture.BackgroundImage = Image.FromFile(@"product_picture\"+r[5].ToString());
                    p_picture.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception)
                {
                    Console.WriteLine(r[5].ToString() + " Error!");
                }
                p_picture.Click += new EventHandler(buttonItemAdd_Click);
                //ID_Barang-ID_Kategori-Nama-Harga-QTY-Image
               
                p_container.Tag = $"{r[0]}={r[1]}={r[2]}={r[3]}={r[4]}={r[5]}";

                fpl_products.Controls.Add(p_container);
            }
            DataSet ds_categories = new DataSet();
            q = "SELECT id_kategori, nama_kategori FROM KATEGORI";
            frm_login.executeDataSet(ds_categories, q, "kategori");
            cb_categories.DataSource = ds_categories.Tables[0];
            cb_categories.ValueMember = "id_kategori";
            cb_categories.DisplayMember = "nama_kategori";
            cb_categories.SelectedIndex = -1;

            setToolTip();
            readLogoDirectory();
        }

        private void pl_menulogo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle container = new Rectangle(0, 0, pl_menulogo.Width - 1, pl_menulogo.Height - 1);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            //g.DrawImage(new Bitmap(materials.compufy_0), 0,0,pl_menulogo.Width, pl_menulogo.Height);
            g.DrawString("<Logo>", new Font("Arial", 20), Brushes.White, container, format);
        }

        bool logout = false;
        private void link_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frm_login.Show();
                frm_login.resetLogin();
                login.frm_kasir = null;
                logout = true;
                this.Close();
            }
        }

        private void menu_kasir_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logout == false)
            {
                Application.Exit();
            }
        }

        public Boolean isAngka(string exp)
        {
            if (exp == "")
            {
                return false;
            }
            foreach (char x in exp)
            {
                if (!Char.IsDigit(x))
                {
                    return false;
                }
            }
            return true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
            //ID_Barang-ID_Kategori-Nama-Harga-QTY-Image
            foreach (Panel p in fpl_products.Controls)
            {
                string[] info = p.Tag.ToString().Split('=');
                if (isAngka(tb_inputsearch.Text))
                {
                    if (info[0] == tb_inputsearch.Text)
                    {
                        p.Visible = true;
                    }
                    else
                    {
                        p.Visible = false;
                    }
                }
                else
                {
                    if (info[2].Contains(tb_inputsearch.Text))
                    {
                        p.Visible = true;
                    }
                    else
                    {
                        p.Visible = false;
                    }
                }
                
            }
        }

        private void buttonItemAdd_Click(object sender, EventArgs e)
        {
            Panel p_parent;
            if(sender.GetType().Name == "Label")
            {
                p_parent = (Panel)((Label)sender).Parent;
            }
            else
            {
                p_parent = (Panel)((Panel)sender).Parent;
            }
            string[] info = p_parent.Tag.ToString().Split('=');
            bool valid = true;
            foreach(Panel p in flp_checkout.Controls)
            {
                if(info[0] == p.Tag.ToString().Split('=')[0])
                {
                    MessageBox.Show("Barang sudah ada di checkout!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valid = false;
                }
            }
            if (valid == true)
            {
                Panel p_container = new Panel();
                p_container.Size = new Size(374, 42);
                p_container.Tag = p_parent.Tag.ToString();

                // 
                // label judul
                // 
                Label l_judul = new Label();
                p_container.Controls.Add(l_judul);
                l_judul.TextAlign = ContentAlignment.MiddleLeft;
                l_judul.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
                l_judul.ForeColor = Color.FromArgb(64, 64, 64);
                l_judul.Location = new Point(6, 4);
                l_judul.MaximumSize = new Size(130, 33);
                l_judul.Size = new Size(130, 33);
                l_judul.Text = info[2];

                // 
                // label harga
                // 
                Label l_harga = new Label();
                p_container.Controls.Add(l_harga);
                l_harga.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                l_harga.ForeColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                l_harga.Location = new Point(215, 12);
                l_harga.Size = new Size(98, 30);
                l_harga.Tag = info[3];
                l_harga.Text = "Rp " + Convert.ToInt32(info[3]).ToString("#,##");

                // 
                // qty textbox
                // 
                TextBox tb_input = new TextBox();
                p_container.Controls.Add(tb_input);
                tb_input.BackColor = Color.AntiqueWhite;
                tb_input.BorderStyle = BorderStyle.None;
                tb_input.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
                tb_input.Location = new Point(159, 8);
                tb_input.Size = new Size(25, 20);
                tb_input.Text = "1";
                tb_input.TextAlign = HorizontalAlignment.Center;
                tb_input.TextChanged += new EventHandler(checkQTY);

                // 
                // Underline
                // 
                Label underline = new Label();
                p_container.Controls.Add(underline);
                underline.BackColor = Color.Silver;
                underline.Location = new Point(161, 29);
                underline.Size = new Size(22, 1);

                // 
                // button +
                // 
                FontAwesome.Sharp.IconButton b_add = new FontAwesome.Sharp.IconButton();
                p_container.Controls.Add(b_add);
                b_add.FlatAppearance.BorderSize = 0;
                b_add.FlatStyle = FlatStyle.Flat;
                b_add.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
                b_add.IconColor = Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(234)))), ((int)(((byte)(104)))));
                b_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
                b_add.IconSize = 22;
                b_add.Location = new Point(137, 7);
                b_add.Size = new Size(16, 25);
                b_add.Tag = "+";
                b_add.UseVisualStyleBackColor = true;
                b_add.Click += new EventHandler(b_modify_Click);


                // 
                // button -
                // 
                FontAwesome.Sharp.IconButton b_minus = new FontAwesome.Sharp.IconButton();
                p_container.Controls.Add(b_minus);
                b_minus.FlatAppearance.BorderSize = 0;
                b_minus.FlatStyle = FlatStyle.Flat;
                b_minus.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
                b_minus.IconColor = Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(234)))), ((int)(((byte)(104)))));
                b_minus.IconFont = FontAwesome.Sharp.IconFont.Auto;
                b_minus.IconSize = 22;
                b_minus.Location = new Point(190, 7);
                b_minus.Size = new Size(16, 25);
                b_minus.Tag = "-";
                b_minus.UseVisualStyleBackColor = true;
                b_minus.Click += new EventHandler(b_modify_Click);

                // 
                // button trash
                // 
                FontAwesome.Sharp.IconButton b_trash = new FontAwesome.Sharp.IconButton();
                p_container.Controls.Add(b_trash);
                b_trash.FlatAppearance.BorderSize = 0;
                b_trash.FlatStyle = FlatStyle.Flat;
                b_trash.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
                b_trash.IconColor = Color.Red;
                b_trash.IconFont = FontAwesome.Sharp.IconFont.Auto;
                b_trash.IconSize = 30;
                b_trash.Location = new Point(332, 4);
                b_trash.Size = new Size(26, 32);
                b_trash.UseVisualStyleBackColor = true;
                b_trash.Click += new EventHandler(b_trash_Click);

                p_container.Tag = info[0];

                flp_checkout.Controls.Add(p_container);
                sumHarga();
            }
        }

        private void b_trash_Click(object sender, EventArgs e)
        {
            FontAwesome.Sharp.IconButton b = (FontAwesome.Sharp.IconButton)sender;
            Panel p = (Panel)b.Parent;
            string[] info = p.Tag.ToString().Split('=');
            if(MessageBox.Show($"Yakin menghapus item {info[0]} dari checkout?","Konfirmasi Hapus Order",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                flp_checkout.Controls.Remove(p);
                sumHarga();
            }
        }
        decimal subtotal = 0;
        decimal discount = 0;
        decimal total = 0;

        public void sumHarga()
        {
            subtotal = 0;
            discount = 0;
            total = 0;
            foreach(var p in flp_checkout.Controls)
            {
                if (p is Panel)
                {
                    decimal harga = 1;
                    int jumlah = 1;
                    foreach (var child in ((Panel)p).Controls)
                    {
                        if (child is Label)
                        {
                            if (((Label)child).Tag != null)
                            {
                                harga = Convert.ToInt32(((Label)child).Tag);
                            }
                        }
                        else if (child is TextBox)
                        {
                            jumlah = Convert.ToInt32(((TextBox)child).Text);
                        }
                    }
                    subtotal += harga * jumlah;
                }
            }
            if(id_member != -1)
            {
                discount = subtotal * 5 / 100;
            }
            total = subtotal - discount;
            lbl_subtotal.Text = subtotal == 0 ? "Rp 0" : "Rp " + subtotal.ToString("#,##");
            lbl_discount.Text = discount == 0 ? "Rp 0" : "Rp " +  (discount).ToString("#,##");
            lbl_grandtotal.Text = (subtotal - discount) == 0 ? "Rp 0" : "Rp " + total.ToString("#,##");
        }

        private void checkQTY(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            bool digit = true;
            foreach(char c in t.Text)
            {
                if (!Char.IsDigit(c))
                {
                    digit = false;
                }
            }
            if(digit == false)
            {
                t.Text = "1";
            }
        }

        private void b_modify_Click(object sender, EventArgs e)
        {
            FontAwesome.Sharp.IconButton b = (FontAwesome.Sharp.IconButton)sender;
            Panel p = (Panel)b.Parent;
            foreach(var itm in p.Controls)
            {
                if (itm is TextBox)
                {
                    if(b.Tag.ToString() == "+")
                    {
                        ((TextBox)itm).Text = $"{Convert.ToInt32(((TextBox)itm).Text) + 1}";
                    }
                    else
                    {
                        if(Convert.ToInt32(((TextBox)itm).Text)-1 <= 0)
                        {
                        }
                        else
                        {
                            ((TextBox)itm).Text = $"{Convert.ToInt32(((TextBox)itm).Text) - 1}";
                        }
                    }
                }
            }
            sumHarga();
        }

        

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Yakin reset checkout?","Reset Checkout",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                resetCheckout();
            }
        }

        public kasir_registermember frm_registermember;
        public kasir_addmember frm_addmember;

        private void btn_member_Click(object sender, EventArgs e)
        {
            if(frm_registermember == null)
            {
                frm_registermember = new kasir_registermember();
            }
            frm_registermember.frm_kasir = this;
            frm_registermember.frm_login = frm_login;
            frm_registermember.ShowDialog();
        }

        public int id_member = -1;
        public string nama_member = "";

        private void btn_inputMember_Click(object sender, EventArgs e)
        {
            if (frm_addmember == null)
            {
                frm_addmember = new kasir_addmember();
            }
            frm_addmember.id = id_member;
            frm_addmember.frm_kasir = this;
            frm_addmember.frm_login = frm_login;
            frm_addmember.ShowDialog();
            Console.WriteLine(id_member);
            Console.WriteLine(nama_member);
        }

        public decimal bayar = -1;
        public string metode = "";
        public kasir_bayar frm_kasirbayar;
        public kasir_nota frm_nota;
        private void btn_checkout_Click(object sender, EventArgs e)
        {
            int h_id = -1;
            List<string> id_barang = new List<string>();
            if (flp_checkout.Controls.Count == 0)
            {
                MessageBox.Show("Tidak ada item!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (frm_kasirbayar == null)
                {
                    frm_kasirbayar = new kasir_bayar();
                }

                frm_kasirbayar.total = total;
                frm_kasirbayar.frm_kasir = this;
                frm_kasirbayar.ShowDialog();

                if(bayar != -1)
                {
                    //Insert H_transaksi
                    string q;
                    if (id_member == -1)
                    {
                        q = $"INSERT INTO h_transaksi(id_user,total_trans,tgl_trans,metode_trans,diskon) VALUES('{id_login}','{subtotal}',CONVERT(datetime,'{System.DateTime.Now}',103),'{metode}','{discount}')";
                    }
                    else
                    {
                        q = $"INSERT INTO h_transaksi(id_user,id_member,total_trans,tgl_trans,metode_trans,diskon) VALUES('{id_login}','{id_member}','{subtotal}',CONVERT(datetime,'{System.DateTime.Now}',103),'{metode}','{discount}')";
                    }
                    frm_login.executeQuery(q);
                    h_id = frm_login.execScalar("SELECT MAX(id_trans) FROM h_transaksi");

                    foreach (Panel p in flp_checkout.Controls)
                    {
                        int jumlah = 1;
                        foreach (var child in p.Controls)
                        {
                            if (child is TextBox)
                            {
                                jumlah = Convert.ToInt32(((TextBox)child).Text);
                            }
                        }
                        //INSERT D_transaksi
                        string[] info = p.Tag.ToString().Split('=');
                        id_barang.Add(info[0]);

                        q = $"INSERT INTO d_transaksi(id_barang, id_trans, jumlah_barang) VALUES('{info[0]}','{h_id}','{jumlah}')";
                        frm_login.executeQuery(q);

                        q = $"UPDATE Barang SET stok_barang = stok_barang - {jumlah} WHERE id_barang = {info[0]}";
                        frm_login.executeQuery(q);

                    }
                    if(frm_nota == null)
                    {
                        frm_nota = new kasir_nota();
                    }
                    frm_nota.frm_login = frm_login;
                    frm_nota.frm_kasir = this;
                    frm_nota.h_id = h_id;
                    frm_nota.id_barang = id_barang;
                    frm_nota.bayar = bayar;
                    frm_nota.nama_member = nama_member;
                    frm_nota.metode = metode;
                    this.Hide();
                    resetCheckout();
                    frm_nota.Show();
                }
            }
        }

        public void resetCheckout()
        {
            flp_checkout.Controls.Clear();
            id_member = -1;
            cb_member.Enabled = true;
            if (cb_member.Checked == true)
            {
                cb_member.Checked = false;
            }
            cb_member.Enabled = false;
            bayar = -1;
            nama_member = "";
            metode = "";
            sumHarga();
        }

        private void cb_member_Click(object sender, EventArgs e)
        {
            if (cb_member.Checked == true)
            {
                cb_member.Checked = false;
            }
            else
            {
                id_member = -1;
                sumHarga();
            }
        }

        private void cb_categories_DropDownClosed(object sender, EventArgs e)
        {
            lbl_namauser.Focus();
        }

        private void cb_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Panel p in fpl_products.Controls)
            {
                string[] info = p.Tag.ToString().Split('=');
                if (cb_categories.SelectedIndex == -1 || info[1] == cb_categories.SelectedValue.ToString())
                {
                    p.Visible = true;
                }
                else
                {
                    p.Visible = false;
                }
            }
        }

        private void btn_restartcategory_Click(object sender, EventArgs e)
        {
            cb_categories.SelectedIndex = -1;
        }

        private void setToolTip()
        {
            ToolTip panelToolTip = new ToolTip();
            panelToolTip.ToolTipTitle = "Ganti Logo";
            panelToolTip.UseFading = true;
            panelToolTip.UseAnimation = true;
            panelToolTip.IsBalloon = true;
            panelToolTip.ShowAlways = true;
            panelToolTip.AutoPopDelay = 5000;
            panelToolTip.InitialDelay = 500;
            panelToolTip.ReshowDelay = 500;
            panelToolTip.SetToolTip(pl_menulogo, "Klik untuk ganti logo");
        }

        private void pl_menulogo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images (*.PNG;*.JPG)|*.PNG;*.JPG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string directory = "logo_picture\\";
                Directory.CreateDirectory(directory);

                if (!File.Exists(Application.StartupPath + "\\logo_picture\\" + openFileDialog1.SafeFileName))
                {
                    File.Copy(openFileDialog1.FileName, directory + openFileDialog1.SafeFileName, true);
                }

                Bitmap logo = new Bitmap(Application.StartupPath + "\\logo_picture\\" + openFileDialog1.SafeFileName);
                writeLogoDirectory();

                pl_menulogo.BackgroundImage = logo;
                pl_menulogo.Refresh();
            }
            else
            {
                MessageBox.Show("No File",
                    "No File Choosen",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void writeLogoDirectory()
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "/dirLogoKasir.txt");
            sw.Write(Application.StartupPath + "\\logo_picture\\" + openFileDialog1.SafeFileName);
            sw.Close();
        }

        StreamReader sr;
        private void readLogoDirectory()
        {
            try
            {
                sr = new StreamReader(Application.StartupPath + "/dirLogoKasir.txt");
                while (!sr.EndOfStream)
                {
                    string directory = sr.ReadLine();
                    Bitmap logo = new Bitmap(directory);
                    pl_menulogo.BackgroundImage = logo;
                }
            }
            catch
            {

            }
            sr.Close();
        }
    }
}
