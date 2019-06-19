using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsac_pr
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void PasswordButton_Click(object sender, EventArgs e)
        {
            Form MainTeach = new MainTeach();

            if (PasswordTextBox.Text == "bsac")
            {
                MainTeach.Show(); this.Hide();
            }

            else { MessageBox.Show("Пароль неверный!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error); Application.Exit(); }
        }      
    }
}
