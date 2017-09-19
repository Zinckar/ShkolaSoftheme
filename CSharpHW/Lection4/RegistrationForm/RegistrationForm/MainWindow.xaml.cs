using System;
using System.Text.RegularExpressions;
using System.Windows;


namespace RegistrationForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        const string phone_lenght_error = "Lenght must be less than 12";
        const string addinfo_lenght_error = "Lenght must be less than 2000";
        const string lenght_error = "Lenght must be less than 255";
        const string letters_error = "Field must contain only letters";
        const string number_error = "Field must contain only numbers";
        const string year_error = "Year must be between 1990 and current year";
        const string gender_error = "Incorrect gender";
        const string email_error = "Email should contain @";
        const string approved = "OK";
        const string default_field_text = "Fill in blank";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Validate(object sender, RoutedEventArgs e)
        {
            ValidateFirstName();
            ValidateLastName();
            ValidateBirthDate();
            ValidateGender();
            ValidateEmail();
            ValidatePhoneNumber();
            ValidateAdditionalInfo();
        }

        private void ValidateFirstName()
        {
            var firstName = txtFirstName.Text;
            if (String.IsNullOrEmpty(firstName))
            {
                firstNameVal.Text = default_field_text;
            }
            else if (firstName.Length > 255)
            {
                firstNameVal.Text = lenght_error;
            }
            else if (!Regex.IsMatch(firstName, @"^[a-zA-Z]+$"))
            {
                firstNameVal.Text = letters_error;
            }
            else
            {
                firstNameVal.Text = approved;
            }
        }

        private void ValidateLastName()
        {
            var lastName = txtLastName.Text;
            if (String.IsNullOrEmpty(lastName))
            {
                lastNameVal.Text = default_field_text;
            }
            else if (lastName.Length > 255)
            {
                lastNameVal.Text = lenght_error;
            }
            else if (!Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))
            {
                lastNameVal.Text = letters_error;
            }
            else
            {
                lastNameVal.Text = approved;
            }
        }

        private void ValidateBirthDate()
        {
            var birthDate = txtBirthDate.Text;
            string exMessage = "";
            DateTime birthDateDt = DateTime.Now;
            try
            {
                birthDateDt = DateTime.Parse(birthDate);
            }
            catch (FormatException e)
            {
                exMessage = e.Message;
            }
            if (!Regex.IsMatch(birthDate, @"[0-9]+"))
            {
                birthDateVal.Text = number_error;
            }
            else if (birthDateDt.Year < 1990)
            {
                birthDateVal.Text = year_error;
            }
            else if (birthDateDt.Year > DateTime.Now.Year)
            {
                birthDateVal.Text = year_error;
            }
            else
            {
                if (string.IsNullOrEmpty(exMessage))
                {
                    birthDateVal.Text = approved;
                }
                else
                {
                    birthDateVal.Text = exMessage;
                }

            }

        }

        private void ValidateGender()
        {
            var gender = txtGender.Text;

            if (String.IsNullOrEmpty(gender))
            {
                genderVal.Text = default_field_text;
            }
            else if (gender == "male" || gender == "female")
            {
                genderVal.Text = approved;
            }
            else
            {
                genderVal.Text = gender_error;
            }
        }

        private void ValidateEmail()
        {
            var email = txtEmail.Text;
            if (String.IsNullOrEmpty(email))
            {
                emailVal.Text = default_field_text;
            }
            else if (!email.Contains("@"))
            {
                emailVal.Text = email_error;
            }
            else if (email.Length > 255)
            {
                emailVal.Text = lenght_error;
            }
            else
            {
                emailVal.Text = approved;
            }
        }

        private void ValidatePhoneNumber()
        {
            var phoneNumber = txtPhoneNumber.Text;
            if (String.IsNullOrEmpty(phoneNumber))
            {
                phoneNumberVal.Text = default_field_text;
            }
            else if (phoneNumber.Length > 12)
            {
                phoneNumberVal.Text = phone_lenght_error;
            }
            else if (!Regex.IsMatch(phoneNumber, @"[0-9]+"))
            {
                phoneNumberVal.Text = number_error;
            }
            else
            {
                phoneNumberVal.Text = approved;
            }
        }

        private void ValidateAdditionalInfo()
        {
            var addInfo = txtAdditionalInfo.Text;
            if (String.IsNullOrEmpty(addInfo))
            {
                addInfoVal.Text = default_field_text;
            }
            else if (addInfo.Length > 2000)
            {
                addInfoVal.Text = addinfo_lenght_error;
            }
            else
            {
                addInfoVal.Text = approved;
            }
        }

        private void FirstName_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (txtFirstName.Text.Length > 0)
            {
                firstNameVal.Text = "";
            }
            else if (txtFirstName.Text.Length == 0)
            {
                firstNameVal.Text = default_field_text;
            }
        }

        private void LastName_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (txtLastName.Text.Length > 0)
            {
                lastNameVal.Text = "";
            }
            else if (txtLastName.Text.Length == 0)
            {
                lastNameVal.Text = default_field_text;
            }
        }

        private void BirthDate_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (txtBirthDate.Text.Length > 0)
            {
                birthDateVal.Text = "";
            }
            else if (txtBirthDate.Text.Length == 0)
            {
                birthDateVal.Text = default_field_text;
            }
        }

        private void Gender_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (txtGender.Text.Length > 0)
            {
                genderVal.Text = "";
            }
            else if (txtGender.Text.Length == 0)
            {
                genderVal.Text = default_field_text;
            }
        }

        private void Email_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (txtEmail.Text.Length > 0)
            {
                emailVal.Text = "";
            }
            else if (txtEmail.Text.Length == 0)
            {
                emailVal.Text = default_field_text;
            }
        }

        private void PhoneNumber_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (txtPhoneNumber.Text.Length > 0)
            {
                phoneNumberVal.Text = "";
            }
            else if (txtPhoneNumber.Text.Length == 0)
            {
                phoneNumberVal.Text = default_field_text;
            }
        }

        private void AdditionalInfo_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (txtAdditionalInfo.Text.Length > 0)
            {
                addInfoVal.Text = "";
            }
            else if (txtAdditionalInfo.Text.Length == 0)
            {
                addInfoVal.Text = default_field_text;
            }
        }

    }
}
