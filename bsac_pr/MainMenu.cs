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
    public partial class MainMenu : Form
    {        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_student_Click(object sender, EventArgs e) // Переход к форме "Студент"
        {
            Form MainStudent = new MainStudent();
            MainStudent.Show(); this.Hide();            
            
        }

        private void button_teach_Click(object sender, EventArgs e) // Переход к форме "Преподаватель"
        {
            Form MainTeach = new MainTeach();
            MainTeach.Show(); this.Hide();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) // Открывает окно "О программе"
        {
            Form AboutProgram = new AboutProgram();
            AboutProgram.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) // Полное закрытие программы при нажатии на кнопку "Выход" в меню
        {
            Application.Exit();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e) // Полное закрытие программы при нажатии на "Крестик"
        {
            Application.Exit();
        }
    }
}
