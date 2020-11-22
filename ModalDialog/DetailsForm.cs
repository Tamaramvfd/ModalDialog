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
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {
            InitializeComponent();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {

        }
        public DetailsForm(string message)
        {
            InitializeComponent();
            textBox1.AppendText(message +  Environment.NewLine);
        }

        public DetailsForm(Person personData)
        {
            InitializeComponent();
            textBox1.AppendText($"{personData.LastName}, {personData.FirstName} is {personData.Age} years old.");
        }
    }
}
