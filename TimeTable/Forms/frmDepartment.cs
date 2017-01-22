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
    public partial class frmDepartment : Form
    {
        // Variables
        bool dirtyData = false;
        bool formLoaded = false;
        int currentRecordId = 0;

        #region Methods

        public frmDepartment()
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

            // Ask if to save data
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
                UpdateDataFields(clsDepartment.GetSingleRecord(Convert.ToInt32(DataList.SelectedValue)));
            }
        }

        private void DataChanged(object sender, EventArgs e)
        {
            SetDirtyData(true);
        }

        // Update the data fields based on a clsDepartment object
        private void UpdateDataFields(clsDepartment theDepartment)
        {
            _Name.Text = theDepartment.Name;
            _Description.Text = theDepartment.Description;
            _CreatedTimestamp.Text = theDepartment.CreatedTimestamp.ToString();
            _ModifiedTimeStamp.Text = theDepartment.ModifiedTimestamp.ToString();

            currentRecordId = theDepartment.ID;
        }

        private void RefreshDataList()
        {
            formLoaded = false;
            this.DataList.DataSource = clsDepartment.GetList();
            formLoaded = true;

            //TODO: Make the select entry in the data list the one just amended or added, if deleted then the one below
        }

        private void SaveData()
        {
            int rowsUpdated = 0;

            clsDepartment theDepartment = new clsDepartment();
            theDepartment.ID = currentRecordId;
            theDepartment.Description= this._Description.Text;
            theDepartment.Name = this._Name.Text; 
            rowsUpdated = theDepartment.Save();

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
            this._Name.Text = "";
            this._Description.Text = "";
        }

        #endregion

        #region Event Handlers

        private void evtFormLoad(object sender, EventArgs e)
        {
            clsFormPreperation.SetUpForm(this);

            this.DataList.DisplayMember = "Name";
            this.DataList.ValueMember = "ID";
            this.DataList.DataSource = clsDepartment.GetList();

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
                clsDepartment.Delete(currentRecordId);
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

            //TODO: BUG: When clikcing cancel on a Addnew screen returns back to record seleteced however delete button is not enabled 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            blankFormFields();           
            SetDirtyData(false);
            btnAdd.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;

            currentRecordId = -1;
            this._Name.Focus();
        }

        private void DataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formLoaded)
            {
                CheckIfShouldSaveData();
            }

            UpdateDataFields(clsDepartment.GetSingleRecord(Convert.ToInt32(DataList.SelectedValue)));

            dirtyData = false;
            SetButtonStateAtLoad();
        }
        #endregion
    }
}
