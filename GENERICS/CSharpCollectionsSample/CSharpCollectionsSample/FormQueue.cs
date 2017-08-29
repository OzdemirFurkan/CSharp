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
    public partial class FormQueue : Form
    {
        public FormQueue()
        {
            InitializeComponent();
        }

        private void Queue_Load(object sender, EventArgs e)
        {
            //Ilk giren ilk cikar

            Queue que = new Queue();
            que.Enqueue("Mehmet");
            que.Enqueue("Hasan");
            que.Enqueue("Ali");
            que.Enqueue("Veli");

            while (que.Count > 0)
            {
                MessageBox.Show(string.Format("{0} ekmek aldı", que.Peek()));
                //peek işlem yapılan elemanı atadı
                que.Dequeue();
                //Siradan cikardi
            }

            que.Clear();
            int c = que.Count;
            bool b = que.Contains("Ahmet");

        }
    }
}
