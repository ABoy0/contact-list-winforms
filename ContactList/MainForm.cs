using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo một instance của AddContactForm
            AddContactForm addContactForm = new AddContactForm();

            // Hiển thị AddContactForm dưới dạng hộp thoại (modal)
            addContactForm.ShowDialog();
        }
    }
}
