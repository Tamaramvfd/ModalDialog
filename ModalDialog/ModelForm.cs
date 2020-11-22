using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalDialog
{
    public partial class ModelForm : Form
    {
        public ModelForm()
        {
            InitializeComponent();
        }

        private void createNewDIalogButton_Click(object sender, EventArgs e)
        {
            Person person = new Person { 
                FirstName = firstNameText.Text, 
                LastName = lastNameText.Text, 
                Age = ageText.Text
            };
            DetailsForm df = new DetailsForm(person);
            DialogResult result = df.ShowDialog();
            if (result == DialogResult.OK)
            {
                Console.WriteLine("Dialog returned with ok");
            }
            else if (result == DialogResult.Cancel)
            {
                Console.WriteLine("Dialog returned with cancel");
            }
            else
            {
                Console.WriteLine("Dialog returned " + result);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
