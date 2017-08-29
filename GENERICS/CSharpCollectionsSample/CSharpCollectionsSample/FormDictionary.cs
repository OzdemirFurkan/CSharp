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
    public partial class FormDictionary : Form
    {
        public FormDictionary()
        {
            InitializeComponent();
        }

        Dictionary<string, string> cvr = new Dictionary<string, string>();

        private void FormDictionary_Load(object sender, EventArgs e)
        {
            /*
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Mouse");
            d.Add(2, "Klavye");
            d.Add(3, "Trackpad");

            foreach (KeyValuePair<int, string> item in d)
            {
                MessageBox.Show(string.Format(" Key :{0} , Value :{1}", item.Key, item.Value));  
            }
            */

            cvr.Add("Computer", "Bilgisayar");
            cvr.Add("Name", "Isim");
         // cvr.Add("Name", "Ad");  Ayni key tanimlayamayiz
            cvr.Add("Yas", "Age");

            comboBox1.Items.AddRange(cvr.Keys.ToArray());

           // string val = cvr["Name"]; isim yazar
           // MessageBox.Show(val);

           // string deger = null;
           // bool KeyDegeriVarMi = cvr.TryGetValue("Name", out deger);

           // double result = 0;

           // double.TryParse("10.a", out result);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = comboBox1.Text;

            MessageBox.Show(cvr[key]);
        }
    }
}
