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
        public bool formLoaded = false;

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

        private void CheckIfShouldSaveData()
        {
            // check if dirty data flag is set
            bool SaveRecord = false;

            // As if to save data
            if (dirtyData)
            {
                // If yes ask if sure
                if (MessageBox.Show("Data has been changed, would you like to save changes?", "Data Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveRecord = true;
                }
            }

            if (SaveRecord)
            {
                // Save Data
            }
            else
            {
                // If sure then Reload the data for current record
                UpdateDataFields(clsTutor.GetSingleRecord(Convert.ToInt32(DataList.SelectedValue)));
            }
        }

        #endregion

        #region Event Handlers

        private void evtFormLoad(object sender, EventArgs e)
        {
            clsFormPreperation.SetUpForm(this);

            this.DataList.DisplayMember = "TutorDisplayName";
            this.DataList.ValueMember = "Id";
            this.DataList.DataSource = clsTutor.GetList();

            dirtyData = false;
            formLoaded = true;
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
            // check if should save data
            CheckIfShouldSaveData();

            // Reset dirty data flag
            SetDirtyData(false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void DataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formLoaded)
            {
                CheckIfShouldSaveData();
            }

            UpdateDataFields(clsTutor.GetSingleRecord(Convert.ToInt32(DataList.SelectedValue)));

            SetButtonStateAtLoad();
            dirtyData = false;

        }

        // Update the data fields based on a clsTutor object
        private void UpdateDataFields(clsTutor theTutor)
        {
            _FirstName.Text = theTutor.TutorFirstName;
            _LastName.Text = theTutor.TutorLastName;
            _Active.Checked = theTutor.Active;

        }




    }
}
