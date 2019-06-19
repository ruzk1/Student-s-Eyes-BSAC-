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
    public partial class AboutProgram : Form
    {
        public AboutProgram()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) // Полное закрытие программы при нажатии на кнопку "Выход" в меню
        {
            Application.Exit();
        }
                
        private void button1_Click(object sender, EventArgs e) // Закрытие формы "О Программе" при нажатии кнопки "Закрыть"
        {
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Не удалять, сломает форму, чинить лень
        {

        }

        private void AboutProgram_FormClosing(object sender, FormClosingEventArgs e) // Закрытие формы при нажатии на "Крестик"
        {
            Hide();
        }
    }
}
