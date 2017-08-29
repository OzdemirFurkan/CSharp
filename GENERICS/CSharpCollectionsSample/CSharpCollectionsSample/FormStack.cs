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
    public partial class FormStack : Form
    {
        public FormStack()
        {
            InitializeComponent();
        }

        private void FormStack_Load(object sender, EventArgs e)
        {

            Stack st = new Stack();
            st.Push(5);
            st.Push(6);
            st.Push(7);
            st.Push(8);
            st.Push(9);
            st.Push(15);
            st.Push(25);

            st.Pop(); // Dizinin ilk elemanini diziden cikardi. En son giren dizinin ilk elamaniydi. (LIFO)

            object v = st.Peek();

            st.Clear();
            int a = st.Count;
            bool b = st.Contains(5);

        }
    }
}
