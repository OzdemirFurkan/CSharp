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
    public partial class FormGenericCollection : Form
    {
        public FormGenericCollection()
        {
            InitializeComponent();
        }

        private void FormGenericCollection_Load(object sender, EventArgs e)
        {

            IList<string> marka = new List<string>();
              marka.Add("Fiat");
              marka.Add("Bmw");
              marka.Add("Mercedes");
              marka.Add("Seat");
              marka.Add("e");
              marka.Insert(2,"Ford");

            bool m = marka.Any(item => item.StartsWith("M"));

            int r1 = marka.Count(x => x.Contains("e"));
            bool r = marka.All(x => x.Contains("e")); // Butun degerler "e" mi

            int c = marka.Count;
            int c1 = marka.Count(x => x.EndsWith("t"));

            int[] s1 = {3, 5, 6};

            List<int> sayilar = new List<int>();
            sayilar.AddRange(s1);
            bool HepsiTekMi = sayilar.TrueForAll(x => x % 2 == 1);

            sayilar.ForEach(item => MessageBox.Show(item.ToString()));
            
        }
    }
}
