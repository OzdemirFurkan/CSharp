using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCollectionsSample
{
    public partial class FormHashSet : Form
    {
        public FormHashSet()
        {
            InitializeComponent();
        }

        private void FormHashSet_Load(object sender, EventArgs e)
        {
           // Hashtable -> Key , Hashset -> Value
           // Tamamen aynisi var ise eklemez
           // Kontrolden dolayi islem biraz yavas gerceklesir
           // Arama islemlerinde tercih edilir arama icin list genericden daha performansli. Koleksiyona eleman ekleme islemi ise dusuk performansli


            HashSet<string> hayvanlar = new HashSet<string>();
            bool h = hayvanlar.Add("Kedi");
            bool h1 = hayvanlar.Add("Kopek");
            hayvanlar.Add("Sincap");
            hayvanlar.Add("Civciv");
            bool h2 = hayvanlar.Add("Kopek");

            var hayvan = hayvanlar.FirstOrDefault(x => x == "Mustafa");

            foreach (var item in hayvanlar)
            {
                MessageBox.Show(item + " "+ item.GetHashCode().ToString());
            }
        }
    }
}
