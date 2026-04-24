namespace HomeAffairsDigitalIdentityProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbCitizenship.SelectedIndex = 0;
        }

        // Validate ID button click
        private void btnValidate_Click(object sender, EventArgs e)
        {
            // Check that name and ID are not empty
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtID.Text))
            {
                lblValidationResult.Text = "Please enter both name and ID number.";
                return;
            }

            // Create a CitizenProfile object
            CitizenProfile profile = new CitizenProfile(
                txtName.Text,
                txtID.Text,
                cmbCitizenship.SelectedItem?.ToString() ?? "Citizen"
            );

            // Show validation message outside the box
            lblValidationResult.Text = profile.ValidateID();
        }

        // Generate Profile button click
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Check that name and ID are not empty
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtResults.Text = "Please enter both name and ID number.";
                return;
            }

            // Create a CitizenProfile object
            CitizenProfile profile = new CitizenProfile(
                txtName.Text,
                txtID.Text,
                cmbCitizenship.SelectedItem?.ToString() ?? "Citizen"
            );

            // Generate and display full profile summary
            txtResults.Text =
                $"===== Digital Identity Profile =====\r\n" +
                $"Full Name: {profile.FullName}\r\n" +
                $"ID Number: {profile.IDNumber}\r\n" +
                $"Age: {profile.Age} years old\r\n" +
                $"Citizenship Status: {profile.CitizenshipStatus}\r\n" +
                $"Validation Result:  {profile.ValidateID()}\r\n" +
                $"Processed at: Home Affairs Digital Desk\r\n" +
                $"Timestamp: {DateTime.Now:yyyy/MM/dd HH:mm:ss}\r\n "+
                $"====================================\r\n";
               
        }
    }
}