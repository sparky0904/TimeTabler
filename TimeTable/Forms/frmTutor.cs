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

        #region Methods

        public frmTutor()
        {
            InitializeComponent();

            // Set buton state
            SetButtonStateAtLoad();
        }

        void SetButtonStateAtLoad()
        {
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnCancel.Enabled = false;
        }

        void SetDirtyData(bool theState)
        {
            dirtyData = theState;
            btnAdd.Enabled = !theState;
            btnCancel.Enabled = theState;
            btnSave.Enabled = theState;
        }
        
        #endregion

        #region Event Handlers
        
        private void evtFormLoad(object sender, EventArgs e)
        {
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
            SetDirtyData(true);
        } 

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Reload the data for current record

            // Reset dirty data flag
            SetDirtyData(false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        #endregion




    }
}
