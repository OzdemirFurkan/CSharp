using System;
using System.Collections;
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
    public partial class FormHashtable : Form
    {
        public FormHashtable()
        {
            InitializeComponent();
        }

        private void FormHashtable_Load(object sender, EventArgs e)
        {

            //Dizideki elemanlar unique
            //Perfomansi dusuk cunku ayni eleman var mi kontrolu yapiyor
            //Her 
            Hashtable hash = new Hashtable();
            hash.Add("Bakkal", "Ahmet");
            hash.Add("Manav", "Hasan");
            hash.Add("Berber", "Avni");
            hash.Add("Kasap", "");
            hash.Add(1, 5);

            bool h1 = hash.ContainsKey("Bakkal");
            bool h2 = hash.ContainsValue("Hasan");

            hash.Add("Bakkal2", "Ahmet");// Ayni value

            bool h3 = hash.Contains("Berber");

            hash.Remove("Kasap");

            int a = 12.5.GetHashCode();
            int b = "Ali".GetHashCode();
            int c = "Ali".GetHashCode();
            int f = "ali".GetHashCode();
           



        }
    }
}
