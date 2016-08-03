using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC = C5;
using System.Windows.Forms;
using PC = Wintellect.PowerCollections;
using MyTest.InternalClasses;
using MoreLinq;

namespace MyTest
{
    public partial class MainForm : Form
    {
        BC.ArrayList<Person> alsPerson = new BC.ArrayList<Person>();
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

            alsPerson.Add(new Person() { PersonId = 1, PersonBirthDay = Convert.ToDateTime("1985-04-11"), PersonCode = "11048510981", PersonFirstName = "Vasja", PersonLasttName = "Krjuk" });
            alsPerson.Add(new Person() { PersonId = 2, PersonBirthDay = Convert.ToDateTime("1970-09-01"), PersonCode = "01097010881", PersonFirstName = "Fedja", PersonLasttName = "Zilberman" });
            alsPerson.Add(new Person() { PersonId = 3, PersonBirthDay = Convert.ToDateTime("1954-11-21"), PersonCode = "21115410971", PersonFirstName = "Kolja", PersonLasttName = "Treskov" });
            alsPerson.Add(new Person() { PersonId = 4, PersonBirthDay = Convert.ToDateTime("1979-07-05"), PersonCode = "05077913621", PersonFirstName = "Zjama", PersonLasttName = "Shifman" });
            this.grdPerson.DataSource = alsPerson;
        }

        private void btnShufle_Click(object sender, EventArgs e)
        {
            alsPerson.Shuffle();
            this.grdPerson.DataSource = alsPerson;
            this.Refresh();
        }
    }
}
