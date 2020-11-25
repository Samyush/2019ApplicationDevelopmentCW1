using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StudentRegistrationSLN
{
    public partial class RegistrationFrom : Form
    {
        //initializing components below
        public RegistrationFrom()
        {
            InitializeComponent();
            GridBinder();
            
        }

        //this method validates the input data and adds the value in write to text file method
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool value = true;

            Registration r = new Registration();

            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            //validating name
            if (!firstName.Equals("") && !lastName.Equals(""))
            {
                //concatinates first name and last name into one.
                r.Name = firstName + " " + lastName;
                
            }
            else
            {
                MessageBox.Show("Please enter first name and last name.");
                value = false;

            }
            //validating address
            if (txtAddress.Text.Equals(""))
            {
                MessageBox.Show("Please enter the address.");
                value = false;
            }
            else
            {
                r.Address = txtAddress.Text;
                
            }


            //validating phone number
            Regex validatorPhone = new Regex("^[9]{1}[0-9]{9}$");
            string matchPhone = validatorPhone.Match(txtContactNo.Text).Value.ToString();

            if (matchPhone.Length == 10)
            {
                r.ContactNo = txtContactNo.Text;
                
            }
            else
            {
                MessageBox.Show("Please enter a valid Phone Number.");
                value = false;
            }
            //validating email
            const string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            bool isValid = regex.IsMatch(txtEmail.Text);

            if (isValid == true)
            {
                r.Email = txtEmail.Text;
                
            }
            else
            {
                MessageBox.Show("Please enter a valid Email Address, in abc@abc.abc format.");
                value = false;
            }
            //validating program enroll
            if (cbProgramEnroll.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a program to enrol.");
                value = false;
            }
            else
            {
                r.ProgramEnroll = cbProgramEnroll.SelectedItem.ToString();
            }
            r.RegistrationDate = dpRegistrationDate.Value;
            r.DateOfBirth = dpDateOfBirth.Value;

            //validating status
            if (cbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the status");
                value = false;
            }
            else
            {
                r.Status = cbStatus.SelectedItem.ToString();
            }
            //adds if the validation meets
            if (value == true)
            {
                r.Add(r);
                GridBinder();
                MessageBox.Show("The details have been added");
            }

        }
        //clicking the button clears all the input values
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        //method for clearing all the fields
        public void clear()
        {
            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtContactNo.Text = "";
            txtEmail.Text = "";
            dpDateOfBirth.Value = DateTime.Today;
            cbProgramEnroll.SelectedItem = null;
            dpRegistrationDate.Value = DateTime.Today;
            cbStatus.SelectedItem = null;

            btnAdd.Visible = true;
            btnUpdate.Visible = false;

        }
        //this method validates the input data and updates the value 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool correct = true;

            Registration r = new Registration();
            //validating id
            if (!txtId.Text.Equals(""))
            {
                r.Id = int.Parse(txtId.Text);
            }
            else {
                MessageBox.Show("Please Select a column");
            }

            //validating name
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            if (!firstName.Equals("") && !lastName.Equals(""))
            {
                //concatenates first name and last name into one
                r.Name = firstName + " " + lastName;
                
            }
            else
            {
                MessageBox.Show("Please enter both first name and last name.");
                correct = false;

            }
            //validating address
            if (txtAddress.Text.Equals(""))
            {
                MessageBox.Show("Please enter your address.");
                correct = false;
            }
            else
            {
                r.Address = txtAddress.Text;
                
            }
            //validating contact number
            Regex validatorPhone = new Regex("^[9]{1}[0-9]{9}$");
            string matchPhone = validatorPhone.Match(txtContactNo.Text).Value.ToString();

            if (matchPhone.Length == 10)
            {
                r.ContactNo = txtContactNo.Text;
                
            }
            else
            {
                MessageBox.Show("Please enter a valid Phone Number.");
                correct = false;
            }
            //validating email
            const string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            bool isValid = regex.IsMatch(txtEmail.Text);

            if (isValid == true)
            {
                r.Email = txtEmail.Text;
                
            }
            else
            {
                MessageBox.Show("Please enter a valid Email Address, in abc@abc.abc format.");
                correct = false;
            }
            //validating program enroll
            if (cbProgramEnroll.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a program to enrol.");
                correct = false;
            }
            else
            {
                r.ProgramEnroll = cbProgramEnroll.SelectedItem.ToString();
            }
            //validating status
            if (cbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the status");
                correct = false;
            }
            else
            {
                r.Status = cbStatus.SelectedItem.ToString();
            }
            r.RegistrationDate = dpRegistrationDate.Value;
            r.DateOfBirth = dpDateOfBirth.Value;
            //updates if the validation meets
            if (correct == true)
            {
                r.Edit(r);
                GridBinder();
                clear();
                MessageBox.Show("The details have been updated");
            }


            
        }

        
        //method to display data in data grid view
        private void GridBinder()
        {
            try
            {

                Registration r = new Registration();
                List<Registration> listRegisterStudent = r.List();
                DataTable data = Utility.ConvertToDataTable(listRegisterStudent);
                //assigning the source of data to the grid view
                studentGridView.DataSource = data;
                BindChart(r.List());
                BindNewGrid(r.List());
                BindTotalGrind(r.List());
            }
            catch (Exception) {
                MessageBox.Show("No Information Available");
            }

        }

        //method to call the data from cell of the data grid view to the fields
        private void studentGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Registration registrationObj = new Registration();
            if (e.ColumnIndex == 0)
            {

                string studentGridValue = studentGridView[2, e.RowIndex].Value.ToString();
                int id = 0;
                //condition if the data source is empty
                if (String.IsNullOrEmpty(studentGridValue))
                {
                    MessageBox.Show("The data is Invalid.");
                }
                //condition if the data is present
                else
                {
                    id = int.Parse(studentGridValue);
                    Registration r = registrationObj.List().Where(x => x.Id == id).FirstOrDefault();
                    txtId.Text = studentGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                    string name = studentGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                    string[] nameValue = name.Split(' ');//splitting the name into first name and last name since it was concatenated
                    txtFirstName.Text = nameValue[0];
                    txtLastName.Text = nameValue[1];
                    txtAddress.Text = studentGridView.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                    txtContactNo.Text = studentGridView.Rows[e.RowIndex].Cells["ContactNo"].FormattedValue.ToString();
                    txtEmail.Text = studentGridView.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                    cbProgramEnroll.Text = studentGridView.Rows[e.RowIndex].Cells["ProgramEnroll"].FormattedValue.ToString();
                    string getRegistrationDate = studentGridView.Rows[e.RowIndex].Cells["RegistrationDate"].FormattedValue.ToString();
                    string getDateOfBirth = studentGridView.Rows[e.RowIndex].Cells["DateOfBirth"].FormattedValue.ToString();
                    DateTime registrationDate = Convert.ToDateTime(getRegistrationDate);
                    DateTime dateOfBirth = Convert.ToDateTime(getDateOfBirth);
                    dpRegistrationDate.Value = registrationDate;
                    dpDateOfBirth.Value = dateOfBirth;
                    cbStatus.Text = studentGridView.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();

                    btnAdd.Visible = false;
                    btnUpdate.Visible = true;

                }
            }
            //condition if the delete column is clicked
            else if (e.ColumnIndex == 1) {
                string message = "Are you sure you want to Delete this Record?";
                string title = "Confirm Delete?";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult dialog = MessageBox.Show(message, title, buttons);
                if (dialog == DialogResult.OK) { 
                    //delete the selected row
                    string studentGridValue = studentGridView[2, e.RowIndex].Value.ToString();
                    registrationObj.Delete(int.Parse(studentGridValue));
                    GridBinder();
                    MessageBox.Show("Record Deleted!");

                }
                     
            }
            
        }


        //method to display the chart
        private void BindChart(List<Registration> lst)
        {           
            //try if the data is present
            try
            {
                //selecting which data to display on the chart
                var info = lst
                    .GroupBy(prog => prog.ProgramEnroll)
                    .Select(col => new
                    {
                        Program = col.First().ProgramEnroll,
                        Number = col.Count().ToString()                    
                    })                    
                    .ToList();                
                DataTable data = Utility.ConvertToDataTable(info);
                weeklyEnrollmentReport.DataSource = data;
                weeklyEnrollmentReport.Name = "Program Enroll";                
                weeklyEnrollmentReport.Series["Series1"].XValueMember = "Program";
                weeklyEnrollmentReport.Series["Series1"].YValueMembers = "Number";
                this.weeklyEnrollmentReport.Titles.Remove(this.weeklyEnrollmentReport.Titles.FirstOrDefault());
                this.weeklyEnrollmentReport.Titles.Add("Enrollment Chart");
                weeklyEnrollmentReport.Series["Series1"].IsValueShownAsLabel = true;
            }
            //carry this function if no data is present
            catch (Exception e) {
                Console.Write (e.Message);
                MessageBox.Show("No Information Available");
            }
        }
        //method to display the chart
        private void BindNewGrid(List<Registration> lst)
        {
            DateTime startDate = dpStartDate.Value;
            DateTime endDate = dpStartDate.Value.AddDays(7);
            //try if the data is present
            try
            {
                var info = lst
                    //selecting which data to display on the chart
                    .Where(date => date.RegistrationDate >= startDate && date.RegistrationDate <= endDate)
                    .GroupBy(prog => prog.ProgramEnroll)
                    .Select(col => new
                    {
                        Program = col.First().ProgramEnroll,
                        Number = col.Count().ToString()

                    })

                    .ToList();

                DataTable data = Utility.ConvertToDataTable(info);
                weeklyGridView.DataSource = data;
            }
            //carry this function if no data is present
            catch (Exception e)
            {
                Console.Write(e.Message);
                MessageBox.Show("No Information Available");
            }
        }
        //method to display the chart
        private void BindTotalGrind(List<Registration> lst)
        { 
            try
            {
                var info = lst
                    //selecting which data to display on the chart
                    .GroupBy(prog => prog.ProgramEnroll)
                    .Select(col => new
                    {
                        Program = col.First().ProgramEnroll,
                        Number = col.Count().ToString()
                    })
                    .ToList();
                DataTable data = Utility.ConvertToDataTable(info);
                totalProgramGridView.DataSource = data;
            }
            //carry this function if no data is present
            catch (Exception e)
            {
                Console.Write(e.Message);
                MessageBox.Show("No Information Available");
            }

        }  
        //method to generate the chart
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GridBinder();
        }

        //method to sort the table in ascending order by name
        private void sortNameAsc_Click(object sender, EventArgs e)
        {
            //using bubble sort algorithm
            Registration r = new Registration();
            List<Registration> listStudents = r.List();
            int n = listStudents.Count();
            bool change;
            Registration temp;
            do
            {
                change = false;
                for (int i = 0; i < n - 1; i++)
                {
                    //if the value is greater than 0 the data must be arranged in ascending manner
                    if (string.Compare(listStudents[i].Name, listStudents[i + 1].Name, true) > 0)
                    {
                        temp = listStudents[i];

                        listStudents[i] = listStudents[i + 1];
                        listStudents[i + 1] = temp;
                        
                        change = true;

                    }
                }
            }
            while (change == true);
                DataTable data = Utility.ConvertToDataTable(listStudents);
                studentGridView.DataSource = data;

            
        }
        //method to sort the table in descending order by name
        private void sortNameDesc_Click(object sender, EventArgs e)
        {
            //using bubble sort algorithm
            Registration r = new Registration();
            List<Registration> listStudents = r.List();
            int n = listStudents.Count();
            bool change;
            Registration temp;
            do
            {
                change = false;
                for (int i = 0; i < n - 1; i++)
                {
                    //if the value is less than 0 the data must be arranged in descending manner
                    if (string.Compare(listStudents[i].Name, listStudents[i + 1].Name, true) < 0)
                    {
                        temp = listStudents[i];
                       
                        listStudents[i] = listStudents[i + 1];
                        listStudents[i + 1] = temp;
                        change = true;

                    }
                }
            }
            while (change == true);
            DataTable data = Utility.ConvertToDataTable(listStudents);
            studentGridView.DataSource = data;

        }
        //method to sort the table in ascending order by date
        private void sortDateAsc_Click(object sender, EventArgs e)
        {
            //using bubble sort algorithm
            Registration r = new Registration();
            List<Registration> listStudents = r.List();
            int n = listStudents.Count();
            bool change;
            Registration temp;
            do
            {
                change = false;
                for (int i = 0; i < n - 1; i++)
                {
                    //if the value is greater than 0 the data must be arranged in ascending manner
                    if (string.Compare(listStudents[i].RegistrationDate.ToString(), listStudents[i + 1].RegistrationDate.ToString(), true) > 0)
                    {
                        temp = listStudents[i];

                        listStudents[i] = listStudents[i + 1];
                        listStudents[i + 1] = temp;

                        change = true;

                    }
                }
            }
            while (change == true);
            DataTable data = Utility.ConvertToDataTable(listStudents);
            studentGridView.DataSource = data;

        }


        //method to sort the table in descending order by date
        private void btnSortDateDesc_Click(object sender, EventArgs e)
        {
            //using bubble sort algorithm
            Registration r = new Registration();
            List<Registration> listStudents = r.List();
            int n = listStudents.Count();
            bool change;
            Registration temp;
            do
            {
                change = false;
                for (int i = 0; i < n - 1; i++)
                {
                    //if the value is less than 0 the data must be arranged in descending manner
                    if (string.Compare(listStudents[i].RegistrationDate.ToString(), listStudents[i + 1].RegistrationDate.ToString(), true) < 0)
                    {
                        temp = listStudents[i];

                        listStudents[i] = listStudents[i + 1];
                        listStudents[i + 1] = temp;

                        change = true;

                    }
                }
            }
            while (change == true);
            DataTable data = Utility.ConvertToDataTable(listStudents);
            studentGridView.DataSource = data;
        }


        //method to hide the panel chart
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelChart.Visible = false;
        }

        
        //method to display the panel chart
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelChart.Visible = true;
        }

        private void totalProgramGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
