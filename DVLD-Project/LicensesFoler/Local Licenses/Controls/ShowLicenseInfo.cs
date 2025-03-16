using DVLD_BusinessAccess;
using DVLD_Project.GlobalClasses;
using System.IO;
using System.Windows.Forms;

namespace DVLD_Project.Resources
{
    public partial class ShowLicenseInfo : UserControl
    {
        public ShowLicenseInfo()
        {
            InitializeComponent();

            
        }
        private int _LicenseID;
        private clsLicense _License;
        public int LicenseID
        {
            get { return _LicenseID; }
        }

        public clsLicense SelectedLicenseInfo
        { get { return _License; } }

        private void _LoadPersonImage()
        {
            if (_License.DriverInfo.PersonInfo.Gendor)
                pbPersonImage.Image = Properties.Resources.woman;
            else
                pbPersonImage.Image = Properties.Resources.man;

            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation=ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public void LoadInfo(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = clsLicense.Find(_LicenseID);
            if (_License == null)
            {
                MessageBox.Show("Could not find License ID = " + _LicenseID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = -1;
                return;
            }

            lbLicenseID.Text = _License.LicenseID.ToString();
            lbActive.Text = _License.IsActive ? "Yes" : "No";
            lbDetained.Text = _License.IsDetained ? "Yes" : "No";
            lbClass.Text = _License.LicenseClassIfo.ClassName;
            lbName.Text = _License.DriverInfo.PersonInfo.FullName;
            lbNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
            lbGendor.Text = _License.DriverInfo.PersonInfo.Gendor  ? "Male" : "Female";
            LbDateOfBirth.Text = clsFormat.DateToShort(_License.DriverInfo.PersonInfo.DateOfBirth);

            lbDriverID.Text = _License.DriverID.ToString();
            lbIssueDate.Text = clsFormat.DateToShort(_License.IssueDate);
            lbExpirationDate.Text = clsFormat.DateToShort(_License.ExpirationDate);
            lbIssueReason.Text = _License.IssueReasonText;
            lbNotes.Texts = _License.Notes == "" ? "No Notes" : _License.Notes;
            _LoadPersonImage();



        }
    }
}
