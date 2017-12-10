using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_First_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindEntities db = new NorthwindEntities();
            List<Category> kategoriler = db.Categories.OrderBy(x => x.CategoryName).ToList();
            lstCategory.DisplayMember = "CategoryName";
            lstCategory.ValueMember = "CategoryID";
            lstCategory.DataSource = kategoriler;
        }

        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategory.SelectedItem == null) return;
            seciliKategori = lstCategory.SelectedItem as Category;
            txtKad.Text = seciliKategori?.CategoryName;
            rtxtKacik.Text = seciliKategori?.Description;

            List<Product> urunlerim = seciliKategori?.Products.ToList();
            lstProduct.DisplayMember = "ProductName";
            lstProduct.DataSource = urunlerim;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            NorthwindEntities db = new NorthwindEntities();
            try
            {
                db.Categories.Add(new Category()
                {
                    CategoryName = txtKad.Text,
                    Description = rtxtKacik.Text
                });
                db.SaveChanges();
                lstCategory.DataSource = db.Categories.OrderBy(x => x.CategoryName).ToList();
                
                MessageBox.Show("Kategori Ekleme Islemi Basarili...");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir Hata Olustu : {ex.Message}"); 
            }
        }

        private Category seciliKategori;
        private ListBox seciliListBox;

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seciliListBox==lstCategory)
            {
                if (lstCategory.SelectedItem == null) return;
                try
                {
                    seciliKategori = lstCategory.SelectedItem as Category;
                    DialogResult cevap =
                        MessageBox.Show(seciliKategori.CategoryName + "  Isimli kategori silinecek emin misiniz?",
                            "Silme Islemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes)
                    {
                        NorthwindEntities db = new NorthwindEntities();
                        seciliKategori = db.Categories.Find(seciliKategori.CategoryID);
                        db.Categories.Remove(seciliKategori);
                        db.SaveChanges();
                        MessageBox.Show("Silme islemi basarili");
                        lstCategory.DataSource = db.Categories.OrderBy(x => x.CategoryName).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Silme islemi iptal edildi...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Islem basarisiz" + ex.Message);
                }
            }else if (seciliListBox == lstProduct)
            {
                if (lstProduct.SelectedItem == null) return;
                try
                {

                }
                catch (Exception ex)
                {
                    
                }
            }
        }

        private void btnGnc_Click(object sender, EventArgs e)
        {
            if (seciliKategori == null) return;    
            try
            {
                NorthwindEntities db = new NorthwindEntities();
                seciliKategori = db.Categories.Find(seciliKategori.CategoryID);
                seciliKategori.CategoryName = txtKad.Text;
                seciliKategori.Description = rtxtKacik.Text;
                db.SaveChanges();
                lstCategory.DataSource = db.Categories.OrderBy(x => x.CategoryName).ToList();
                MessageBox.Show("Guncelleme islemi basarili...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("GUncelleme isleminde hata olustu...");
            }
        }

        private Product seciliUrun;
        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProduct.SelectedItem == null) return;
            seciliUrun = lstProduct.SelectedItem as Product;
            txtUrnad.Text = seciliUrun?.ProductName;
            numFiyat.Value = (seciliUrun.UnitPrice.HasValue ? seciliUrun.UnitPrice.Value : 0);
            numStok.Value = (seciliUrun.UnitsInStock.HasValue ? seciliUrun.UnitsInStock.Value : 0);
            cbSatisDurum.Checked = seciliUrun.Discontinued;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numFiyat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnuEkle_Click(object sender, EventArgs e)
        {
            try
            {
                NorthwindEntities db = new NorthwindEntities();
                db.Products.Add(new Product()
                {
                    Discontinued = cbSatisDurum.Checked,
                    ProductName = txtUrnad.Text,
                    UnitPrice = numFiyat.Value,
                    UnitsInStock = Convert.ToInt16(numStok.Value),
                    CategoryID = seciliKategori.CategoryID
                });
                db.SaveChanges();
                lstCategory.DataSource = db.Categories.OrderBy(x => x.CategoryName).ToList();
                MessageBox.Show("Urun eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Urun ekleme basarisiz" + ex.Message);
            }
        }

    }
}
