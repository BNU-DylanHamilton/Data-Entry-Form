using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Entry_Form
{
    public partial class dataEntryForm : Form
    {
        public dataEntryForm()
        {
            InitializeComponent();
        }

        private void closeApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showMessage(object sender, EventArgs e)
        {
            messageLabel.Text = "Hi " + firstNameTextBox.Text + " " +
            surnameTextBox.Text + " from " + townTextBox.Text + "\nHappy Programming";
        }

        private void clearMessage(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void upperCaseMessage(object sender, EventArgs e)
        {
            messageLabel.Text = messageLabel.Text.ToUpper();
        }

        private void lowerCaseMessage(object sender, EventArgs e)
        {
            messageLabel.Text = messageLabel.Text.ToLower();
        }

        private void changeMessage(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            firstNameTextBox.BackColor = Color.LightBlue;
            surnameTextBox.BackColor = Color.LightBlue;
            townTextBox.BackColor = Color.LightBlue;

            messageLabel.Text = messageLabel.Text + "\nGet on with it " + firstNameTextBox.Text;
        }
    }
}
