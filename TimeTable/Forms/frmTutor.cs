using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTable.HelperClasses;
using TimeTable.AppLogic;

namespace TimeTable.Forms
{
    public partial class frmTutor : Form
    {
        public frmTutor()
        {
            InitializeComponent();
        }

        private void evtFormClosing(object sender, FormClosingEventArgs e)
        {

           
        }

        private void evtFormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void evtFormLoad(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.spTutorSelectListByLastName' table. You can move, or remove it, as needed.
            
            clsFormPreperation.SetUpForm(this);
            this.DataList.DisplayMember = "TutorDisplayName";
            this.DataList.ValueMember = "Id";
            this.DataList.DataSource = clsTutor.GetList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void spTutorSelectListByLastNameBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
