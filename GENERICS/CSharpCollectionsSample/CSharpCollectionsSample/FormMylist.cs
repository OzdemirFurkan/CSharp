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
    public partial class FormMylist : Form
    {
        public FormMylist()
        {
            InitializeComponent();
        }

        private void FormMylist_Load(object sender, EventArgs e)
        {
            Mylist<int> MyList = new Mylist<int>();
            MyList.myAdd(1);
            int cap = MyList.Capacity;
            int num = MyList.Numberofmember;

            Mylist<double> mylist1 = new Mylist<double>();
            mylist1.myAdd(2.5);
            mylist1.myAdd(5.5);
            mylist1.myAdd(4.5);

            int c = mylist1.Capacity;
            int cnum = mylist1.Numberofmember;

        }
    }
}
