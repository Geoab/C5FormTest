using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C5;
using Wintellect.PowerCollections;
using System.Windows.Forms;
using MyTest.InternalClasses;

namespace MyTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // C5
            ArrayList<IndexedObjects.Person> alsPerson = new ArrayList<IndexedObjects.Person>();
            C5.LinkedList<IndexedObjects.Person> llsPerson = new C5.LinkedList<IndexedObjects.Person>();


            // PowerCollections
            Deque<InternalClasses.Auto> dqAuto = new Deque<InternalClasses.Auto>();
            BigList<InternalClasses.Auto> blAuto = new BigList<InternalClasses.Auto>();
            HashBag<InternalClasses.Auto> hbAuto = new HashBag<InternalClasses.Auto>();



        }
    }
}
