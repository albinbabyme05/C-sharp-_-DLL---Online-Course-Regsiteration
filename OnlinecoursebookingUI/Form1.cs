using Online_Course_Registration_System.Model;
using Online_Course_Registration_System.Service;
using Online_Course_Registration_System.User;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OnlinecoursebookingUI
{
    public partial class Form1 : Form
    {
        string selectedUserType = "Guest"; // default
        CourseManager courseManager = new CourseManager();
        User? currentUser = null; // Declare as nullable, fixed nullability issue

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;

            // Ensure columns are set up before interacting with DataGridView
            SetupCourseGrid();

            cmbCourseType.SelectedIndexChanged += cmbCourseType_SelectedIndexChanged;
            btnCreateAccount.Click += btnCreateAccount_Click;
            btnRegisterCourse.Click += btnRegisterCourse_Click;
            btnAddAmount.Click += btnAddAmount_Click;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            // Add sample courses
            courseManager.AddCourse(new FreeCourse("Intro to C#", "Alice", "3 weeks"));
            courseManager.AddCourse(new PaidCourse("Advanced C#", "Bob", "6 weeks", 15.99));
            courseManager.AddCourse(new FreeCourse("HTML Basics", "Charlie", "2 weeks"));
            courseManager.AddCourse(new PaidCourse("Data Science", "Dave", "8 weeks", 29.99));

            cmbCourseType.Items.AddRange(new[] { "Free", "Paid" });
            cmbCourseType.SelectedIndex = 0;

            rdoGuest.Checked = true;
            LoadCourses("Free");
        }

        // Setup columns for DataGridView
        private void SetupCourseGrid()
        {
            dgvCourses.Columns.Clear();

            dgvCourses.Columns.Add("CourseId", "Course ID");
            dgvCourses.Columns.Add("Title", "Title");
            dgvCourses.Columns.Add("Instructor", "Instructor");
            dgvCourses.Columns.Add("Duration", "Duration");
            dgvCourses.Columns.Add("Price", "Price");

            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.ReadOnly = true;
            dgvCourses.AllowUserToAddRows = false;
        }

        // Load courses based on the selected type (Free/Paid)
        private void LoadCourses(string type)
        {
            dgvCourses.Rows.Clear();

            if (type == "Free")
            {
                foreach (var course in courseManager.GetFreeCourses())
                {
                    dgvCourses.Rows.Add(course.GetCourseId(), course.GetTitle(), course.GetInstructor(), course.Duration, "$0.00");
                }
            }
            else // Paid
            {
                foreach (var course in courseManager.GetPaidCourses())
                {
                    dgvCourses.Rows.Add(course.GetCourseId(), course.GetTitle(), course.GetInstructor(), course.Duration, $"${course.GetPrice()}");
                }
            }
        }

        // Handle course type selection change event
        private void cmbCourseType_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string selectedType = cmbCourseType.SelectedItem?.ToString() ?? "Free";
            LoadCourses(selectedType);
        }

        // Create account when button is clicked
        private void btnCreateAccount_Click(object? sender, EventArgs e)
        {
            string name = txtUserName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a user name.");
                return;
            }

            if (rdoGuest.Checked)
            {
                currentUser = new GuestUser(name, $"{name}@guest.com");
            }
            else if (rdoRegistered.Checked)
            {
                currentUser = new RegisteredUser(name, $"{name}@registered.com");
            }

            lblStatus.Text = $"Account created: {currentUser.GetType().Name}";
            UpdateBalanceDisplay();
        }

        // Register for course when button is clicked
        private void btnRegisterCourse_Click(object? sender, EventArgs e)
        {
            if (currentUser == null)
            {
                MessageBox.Show("Please create an account first.");
                return;
            }

            if (dgvCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to register.");
                return;
            }

            string selectedCourseIdStr = dgvCourses.SelectedRows[0].Cells["CourseId"].Value.ToString();
            if (!Guid.TryParse(selectedCourseIdStr, out Guid selectedCourseId))
            {
                lblStatus.Text = "Invalid course selected.";
                return;
            }

            var selectedCourse = courseManager.DisplayAllCourse()
                .FirstOrDefault(c => c.GetCourseId() == selectedCourseId);

            if (selectedCourse == null)
            {
                lblStatus.Text = "Course not found.";
                return;
            }

            string result = currentUser.RegsiterCourse(selectedCourse);
            lblStatus.Text = result;
            UpdateBalanceDisplay();
        }

        // Add balance to the account when the button is clicked
        private void btnAddAmount_Click(object? sender, EventArgs e)
        {
            if (currentUser is not RegisteredUser registered)
            {
                MessageBox.Show("Only registered users can add balance.");
                return;
            }

            if (!double.TryParse(txtAddAmount.Text, out double amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.");
                return;
            }

            registered.AddBalance(amount);
            UpdateBalanceDisplay();
        }

        // Update balance display in the TextBox
        private void UpdateBalanceDisplay()
        {
            if (currentUser is RegisteredUser registered)
            {
                lblBalance.Text = $"{registered.GetBalance():0.00}";
            }
            else
            {
                lblBalance.Text = "0.00";
            }
        }
    }
}
