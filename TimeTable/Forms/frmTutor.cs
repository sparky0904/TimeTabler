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
        // Variables
        public bool dirtyData = false;

        public frmTutor()
        {
            InitializeComponent();
        }


        #region Event Handlers
        
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

        private void DataChanged(object sender, EventArgs e)
        {
            dirtyData = true;
        } 

        #endregion
    }
}
