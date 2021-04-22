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
    public partial class menu_kasir : Form
    {
        public menu_kasir()
        {
            InitializeComponent();
        }

        public login frm_login;

        private void menu_kasir_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(820, 639);
            lbl_subtotal.Text = "0";
            lbl_discount.Text = "0";
            lbl_grandtotal.Text = "0";
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
                login.frm_admin = null;
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            Panel p_container = new Panel();
            p_container.Size = new Size(154, 180);

            Label l_judul = new Label();
            p_container.Controls.Add(l_judul);
            l_judul.Font = new Font("Nirmala UI", 10);
            l_judul.Size = new Size(156, 40);
            l_judul.Text = tb_inputsearch.Text;
            l_judul.TextAlign = ContentAlignment.MiddleCenter;
            l_judul.Location = new Point(0,115);
            l_judul.Tag = "judul";
            l_judul.Click += new EventHandler(buttonItemAdd_Click);


            Label l_harga = new Label();
            p_container.Controls.Add(l_harga);
            l_harga.AutoSize = false;
            l_harga.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
            l_harga.Size = new Size(163, 21);
            l_harga.Text = "Rp 5.000.000";
            l_harga.TextAlign = ContentAlignment.MiddleCenter;
            l_harga.Location = new Point(0, 155);
            l_harga.Tag = "harga";

            Panel p_picture = new Panel();
            p_container.Controls.Add(p_picture);
            p_picture.Location = new Point(27, 12);
            p_picture.Size = new Size(100, 100);
            p_picture.BackColor = Color.Peru;
            p_picture.Click += new EventHandler(buttonItemAdd_Click);

            p_container.Tag = l_judul.Text + "=" + "5000000";

            fpl_products.Controls.Add(p_container);
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
            l_judul.Text = info[0];

            // 
            // label harga
            // 
            Label l_harga = new Label();
            p_container.Controls.Add(l_harga);
            l_harga.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            l_harga.ForeColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            l_harga.Location = new Point(215, 12);
            l_harga.Size = new Size(98, 30);
            l_harga.Tag = info[1];
            l_harga.Text = "Rp "+Convert.ToInt32(info[1]).ToString("#,##");

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

            flp_checkout.Controls.Add(p_container);
            sumHarga();
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

        public void sumHarga()
        {
            subtotal = 0;
            foreach(var p in flp_checkout.Controls)
            {
                if (p is Panel)
                {
                    decimal harga = 1;
                    int jumlah = 1;
                    foreach(var child in ((Panel)p).Controls)
                    {
                        if (child is Label)
                        {
                            if(((Label)child).Tag != null)
                            {
                                harga = Convert.ToInt32(((Label)child).Tag);
                            }
                        }
                        else if(child is TextBox)
                        {
                            jumlah = Convert.ToInt32(((TextBox)child).Text);
                        }
                    }
                    subtotal += harga * jumlah;
                }
            }
            lbl_subtotal.Text = "Rp "+subtotal.ToString("#,##");
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

        decimal subtotal = 0;
        decimal discount = 0;

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Yakin reset checkout?","Reset Checkout",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                flp_checkout.Controls.Clear();
                subtotal = 0;
                discount = 0;
            }
        }
    }
}
