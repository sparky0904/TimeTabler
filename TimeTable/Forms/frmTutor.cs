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
        bool dirtyData = false;
        bool formLoaded = false;
        int currentRecordId = 0;

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
                SaveData();
            }
            else
            {
                // If sure then Reload the data for current record
                UpdateDataFields(clsTutor.GetSingleRecord(Convert.ToInt32(DataList.SelectedValue)));
            }
        }

        private void DataChanged(object sender, EventArgs e)
        {
            SetDirtyData(true);
        }

        // Update the data fields based on a clsTutor object
        private void UpdateDataFields(clsTutor theTutor)
        {
            _FirstName.Text = theTutor.TutorFirstName;
            _LastName.Text = theTutor.TutorLastName;
            _Active.Checked = theTutor.Active;

            currentRecordId = theTutor.Id;
        }

        private void RefreshDataList()
        {
            formLoaded = false;
            this.DataList.DataSource = clsTutor.GetList();
            formLoaded = true;

            //TODO: Make the select entry in the data list the one just amended or added, if deleted then the one below
        }

        private void SaveData()
        {
            int rowsUpdated = 0;

            clsTutor theTutor = new clsTutor();
            theTutor.Id = currentRecordId;
            theTutor.Active = this._Active.Checked;
            theTutor.WorkingPatternID = 1;
            theTutor.TutorLastName = this._LastName.Text;
            theTutor.TutorFirstName = this._FirstName.Text; 
            rowsUpdated = theTutor.Save();

            RefreshDataList();

            if (rowsUpdated < 1)
            {
                MessageBox.Show("Error in saving record.", "Error Saving record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rowsUpdated > 1)
                {
                    MessageBox.Show("More than one record was updated, please ring support.", "Error Saving record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void blankFormFields()
        {
            this._Active.Checked = true;
            this._FirstName.Text = "";
            this._LastName.Text = "";
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
            SetButtonStateAtLoad();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            dirtyData = false;
            SetButtonStateAtLoad();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to delete this entry?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsTutor.Delete(currentRecordId);
            }

            dirtyData = false;
            SetButtonStateAtLoad();

            RefreshDataList();
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
            blankFormFields();
            SetDirtyData(true);
            currentRecordId = -1;
            this._FirstName.Focus();
        }

        private void DataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formLoaded)
            {
                CheckIfShouldSaveData();
            }

            UpdateDataFields(clsTutor.GetSingleRecord(Convert.ToInt32(DataList.SelectedValue)));

            dirtyData = false;
            SetButtonStateAtLoad();
        }
        #endregion
 }
}
