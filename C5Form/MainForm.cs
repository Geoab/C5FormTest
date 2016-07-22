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
using C5Form.InternalClasses;

namespace C5Form
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
            ArrayList<Person> alsPerson = new ArrayList<Person>();
            C5.LinkedList<Person> llsPerson = new C5.LinkedList<Person>();


            // PowerCollections
            Deque<Auto> dqAuto = new Deque<Auto>();
            BigList<Auto> blAuto = new BigList<Auto>();
            


        }
    }
}
