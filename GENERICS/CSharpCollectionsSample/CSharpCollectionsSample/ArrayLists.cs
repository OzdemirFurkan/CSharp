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
    public partial class ArrayLists : Form
    {
        public ArrayLists()
        {
            InitializeComponent();
        }

        private void ArrayList_Load(object sender, EventArgs e)
        {
            ArrayList arr = new ArrayList();
            arr.Add("Ahmet");
            arr.Add(5.5);
            arr.Add("Remove");
            arr.Add(5);
            arr.Add(true);

            arr.Remove("Remove");
            arr.RemoveAt(3);
            arr.Reverse();

            bool r = arr.Contains(5.5);

            arr.Insert(2, "mehmet");
            //arr.Sort();

            int adet = arr.Count;

            arr.Clear();

            adet = arr.Count;
        }
    }
}
