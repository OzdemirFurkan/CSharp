using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateSample
{
    public partial class FormDelegate : Form
    {
        public FormDelegate()
        {
            InitializeComponent();
        }

        public delegate void MyDelegate();
        public delegate void DelegateParameters(int p);

        public void Test1() { }

        public void Test2() { }

        public void Test3(int parametre) { }

        public bool Test4(MyDelegate del) {
            del.Invoke();
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyDelegate methodE = null;

            //methodE(); methodE.Invoke(); method cagirmak icin
            methodE += Test1;
            methodE += Test2;

            DelegateParameters d = Test3;

            methodE.GetInvocationList().ToList().ForEach(a => a.DynamicInvoke());

            methodE.GetInvocationList().Where(x => x.Method.Name == "Test1").ToList().ForEach(a => a.DynamicInvoke());

            //Method icinde method calistirmak icin delegate kullanilabilir
            //Callback = methodun methodu tetiklemesi

            Test4(Test1);

        }
    }
}
