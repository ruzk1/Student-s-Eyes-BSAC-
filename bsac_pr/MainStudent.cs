using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsac_pr
{
    public partial class MainStudent : Form
    {
        //Connection to MS ACCESS DB
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DatabaseTI.mdb;";

        private OleDbConnection AccessConnection;
                
        public MainStudent()
        {
            InitializeComponent();

            AccessConnection = new OleDbConnection(connectionString);

            AccessConnection.Open();            
        }

        //Load action
        private void MainStudent_Load(object sender, EventArgs e) 
        {
            OleDbDataReader AccessReader = null;
            
            {            
                
                {
                    //Teacher filling
                    {      
                        OleDbCommand command = new OleDbCommand("SELECT Teacher FROM Teachers GROUP BY Teacher", AccessConnection);
                        
                        AccessReader = command.ExecuteReader();

                        while (AccessReader.Read())
                        {
                            TeacherBox.Items.Add(Convert.ToString(AccessReader["Teacher"]));
                        }
                            
                    }

                    //Group filling
                    {
                        OleDbCommand command = new OleDbCommand("SELECT GroupName FROM Groups GROUP BY GroupName", AccessConnection);

                        AccessReader = command.ExecuteReader();

                        while (AccessReader.Read())
                        {
                            GroupBox.Items.Add(Convert.ToString(AccessReader["GroupName"]));
                        }
                    }

                    //Question filling
                    {
                        {//Que #1
                            OleDbCommand command = new OleDbCommand("SELECT Question, Id_ques FROM Questions WHERE Id_ques = 1", AccessConnection);

                            AccessReader = command.ExecuteReader();

                            while (AccessReader.Read())
                            {
                                QuL1.Text = (Convert.ToString(AccessReader["Question"]));

                                IdQuesTextBox1.Text = (Convert.ToString(AccessReader["Id_ques"]));
                            }
                        }
                        {//Que #2
                            OleDbCommand command = new OleDbCommand("SELECT Question, Id_ques FROM Questions WHERE Id_ques = 2", AccessConnection);

                            AccessReader = command.ExecuteReader();

                            while (AccessReader.Read())
                            {
                                QuL2.Text = (Convert.ToString(AccessReader["Question"]));

                                IdQuesTextBox2.Text = (Convert.ToString(AccessReader["Id_ques"]));
                            }
                        }
                        {//Que #3
                            OleDbCommand command = new OleDbCommand("SELECT Question, Id_ques FROM Questions WHERE Id_ques = 3", AccessConnection);

                            AccessReader = command.ExecuteReader();

                            while (AccessReader.Read())
                            {
                                QuL3.Text = (Convert.ToString(AccessReader["Question"]));

                                IdQuesTextBox3.Text = (Convert.ToString(AccessReader["Id_ques"]));
                            }
                        }
                        {//Que #4
                            OleDbCommand command = new OleDbCommand("SELECT Question, Id_ques FROM Questions WHERE Id_ques = 4", AccessConnection);

                            AccessReader = command.ExecuteReader();

                            while (AccessReader.Read())
                            {
                                QuL4.Text = (Convert.ToString(AccessReader["Question"]));

                                IdQuesTextBox4.Text = (Convert.ToString(AccessReader["Id_ques"]));
                            }
                        }
                        {//Que #5
                            OleDbCommand command = new OleDbCommand("SELECT Question, Id_ques FROM Questions WHERE Id_ques = 5", AccessConnection);

                            AccessReader = command.ExecuteReader();

                            while (AccessReader.Read())
                            {
                                QuL5.Text = (Convert.ToString(AccessReader["Question"]));

                                IdQuesTextBox5.Text = (Convert.ToString(AccessReader["Id_ques"]));
                            }
                        }
                        {//Que #6
                            OleDbCommand command = new OleDbCommand("SELECT Question, Id_ques FROM Questions WHERE Id_ques = 6", AccessConnection);

                            AccessReader = command.ExecuteReader();

                            while (AccessReader.Read())
                            {
                                QuL6.Text = (Convert.ToString(AccessReader["Question"]));

                                IdQuesTextBox6.Text = (Convert.ToString(AccessReader["Id_ques"]));
                            }
                        }
                        {//Que #7
                            OleDbCommand command = new OleDbCommand("SELECT Question, Id_ques FROM Questions WHERE Id_ques = 7", AccessConnection);

                            AccessReader = command.ExecuteReader();

                            while (AccessReader.Read())
                            {
                                QuL7.Text = (Convert.ToString(AccessReader["Question"]));

                                IdQuesTextBox7.Text = (Convert.ToString(AccessReader["Id_ques"]));
                            }
                        }
                        {//Que #8
                            OleDbCommand command = new OleDbCommand("SELECT Question, Id_ques FROM Questions WHERE Id_ques = 8", AccessConnection);

                            AccessReader = command.ExecuteReader();

                            while (AccessReader.Read())
                            {
                                QuL8.Text = (Convert.ToString(AccessReader["Question"]));

                                IdQuesTextBox8.Text = (Convert.ToString(AccessReader["Id_ques"]));
                            }
                        }
                        {//Que #9
                            OleDbCommand command = new OleDbCommand("SELECT Question, Id_ques FROM Questions WHERE Id_ques = 9", AccessConnection);

                            AccessReader = command.ExecuteReader();

                            while (AccessReader.Read())
                            {
                                QuL9.Text = (Convert.ToString(AccessReader["Question"]));

                                IdQuesTextBox9.Text = (Convert.ToString(AccessReader["Id_ques"]));
                            }
                        }
                        {//Que #10
                            OleDbCommand command = new OleDbCommand("SELECT Question, Id_ques FROM Questions WHERE Id_ques = 10", AccessConnection);

                            AccessReader = command.ExecuteReader();

                            while (AccessReader.Read())
                            {
                                QuL10.Text = (Convert.ToString(AccessReader["Question"]));

                                IdQuesTextBox10.Text = (Convert.ToString(AccessReader["Id_ques"]));
                            }
                        }
                    }
                }
            }

            //Elements visible
            {
                Label[] LabelVisible = { QuestionLabel, GroupLabel, TeacherLabel, MarkLabel, QuL1, QuL2, QuL3, QuL4, QuL5, QuL6, QuL7, QuL8, QuL9, QuL10 };

                TextBox[] TextBoxVisible = { MB1, MB2, MB3, MB4, MB5, MB6, MB7, MB8, MB9, MB10 };

                ComboBox[] ComboBoxVisible = { TeacherBox, GroupBox };

                for (int i = 0; i < LabelVisible.Length; i++)
                {
                    LabelVisible[i].Visible = true;
                }

                for (int i = 0; i < TextBoxVisible.Length; i++)
                {
                    TextBoxVisible[i].Visible = true;
                }

                for (int i = 0; i < ComboBoxVisible.Length; i++)
                {
                    ComboBoxVisible[i].Visible = true;
                }
            }

            AccessConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] TextBoxVisible = { MB1, MB2, MB3, MB4, MB5, MB6, MB7, MB8, MB9, MB10 };

            AccessConnection.Open();

            if (!string.IsNullOrEmpty(MB1.Text) && !string.IsNullOrWhiteSpace(MB1.Text) &&
                !string.IsNullOrEmpty(MB2.Text) && !string.IsNullOrWhiteSpace(MB2.Text) &&
                !string.IsNullOrEmpty(MB3.Text) && !string.IsNullOrWhiteSpace(MB3.Text) &&
                !string.IsNullOrEmpty(MB4.Text) && !string.IsNullOrWhiteSpace(MB4.Text) &&
                !string.IsNullOrEmpty(MB5.Text) && !string.IsNullOrWhiteSpace(MB5.Text) &&
                !string.IsNullOrEmpty(MB6.Text) && !string.IsNullOrWhiteSpace(MB6.Text) &&
                !string.IsNullOrEmpty(MB7.Text) && !string.IsNullOrWhiteSpace(MB7.Text) &&
                !string.IsNullOrEmpty(MB8.Text) && !string.IsNullOrWhiteSpace(MB8.Text) &&
                !string.IsNullOrEmpty(MB9.Text) && !string.IsNullOrWhiteSpace(MB9.Text) &&
                !string.IsNullOrEmpty(MB10.Text) && !string.IsNullOrWhiteSpace(MB10.Text) &&
                !string.IsNullOrEmpty(GroupBox.Text) && !string.IsNullOrWhiteSpace(GroupBox.Text) &&
                !string.IsNullOrEmpty(TeacherBox.Text) && !string.IsNullOrWhiteSpace(TeacherBox.Text))

            //Insert resuslt in DB
            {
                //Que #1
                {
                    OleDbCommand command = new OleDbCommand("INSERT INTO Result(Question, GroupName, Teacher, Mark, Id_ques)VALUES(@Question, @GroupName, @Teacher, @Mark, @Id_ques)", AccessConnection);

                    command.Parameters.AddWithValue("Question", QuL1.Text);

                    command.Parameters.AddWithValue("GroupName", GroupBox.Text);

                    command.Parameters.AddWithValue("Teacher", TeacherBox.Text);

                    command.Parameters.AddWithValue("Mark", MB1.Text);

                    command.Parameters.AddWithValue("Id_ques", IdQuesTextBox1.Text);

                    command.ExecuteNonQuery();
                }

                //Que #2
                {
                    OleDbCommand command = new OleDbCommand("INSERT INTO Result(Question, GroupName, Teacher, Mark, Id_ques)VALUES(@Question, @GroupName, @Teacher, @Mark, @Id_ques)", AccessConnection);

                    command.Parameters.AddWithValue("Question", QuL2.Text);

                    command.Parameters.AddWithValue("Group", GroupBox.Text);

                    command.Parameters.AddWithValue("Teacher", TeacherBox.Text);

                    command.Parameters.AddWithValue("Mark", MB2.Text);

                    command.Parameters.AddWithValue("Id_ques", IdQuesTextBox2.Text);

                    command.ExecuteNonQuery();
                }

                //Que #3
                {
                    OleDbCommand command = new OleDbCommand("INSERT INTO Result(Question, GroupName, Teacher, Mark, Id_ques)VALUES(@Question, @GroupName, @Teacher, @Mark, @Id_ques)", AccessConnection);

                    command.Parameters.AddWithValue("Question", QuL3.Text);

                    command.Parameters.AddWithValue("Group", GroupBox.Text);

                    command.Parameters.AddWithValue("Teacher", TeacherBox.Text);

                    command.Parameters.AddWithValue("Mark", MB3.Text);

                    command.Parameters.AddWithValue("Id_ques", IdQuesTextBox3.Text);

                    command.ExecuteNonQuery();
                }

                //Que #4
                {
                    OleDbCommand command = new OleDbCommand("INSERT INTO Result(Question, GroupName, Teacher, Mark, Id_ques)VALUES(@Question, @GroupName, @Teacher, @Mark, @Id_ques)", AccessConnection);

                    command.Parameters.AddWithValue("Question", QuL4.Text);

                    command.Parameters.AddWithValue("Group", GroupBox.Text);

                    command.Parameters.AddWithValue("Teacher", TeacherBox.Text);

                    command.Parameters.AddWithValue("Mark", MB4.Text);

                    command.Parameters.AddWithValue("Id_ques", IdQuesTextBox4.Text);

                    command.ExecuteNonQuery();
                }

                //Que #5
                {
                    OleDbCommand command = new OleDbCommand("INSERT INTO Result(Question, GroupName, Teacher, Mark, Id_ques)VALUES(@Question, @GroupName, @Teacher, @Mark, @Id_ques)", AccessConnection);

                    command.Parameters.AddWithValue("Question", QuL5.Text);

                    command.Parameters.AddWithValue("Group", GroupBox.Text);

                    command.Parameters.AddWithValue("Teacher", TeacherBox.Text);

                    command.Parameters.AddWithValue("Mark", MB5.Text);

                    command.Parameters.AddWithValue("Id_ques", IdQuesTextBox5.Text);

                    command.ExecuteNonQuery();
                }

                //Que #6
                {
                    OleDbCommand command = new OleDbCommand("INSERT INTO Result(Question, GroupName, Teacher, Mark, Id_ques)VALUES(@Question, @GroupName, @Teacher, @Mark, @Id_ques)", AccessConnection);

                    command.Parameters.AddWithValue("Question", QuL6.Text);

                    command.Parameters.AddWithValue("Group", GroupBox.Text);

                    command.Parameters.AddWithValue("Teacher", TeacherBox.Text);

                    command.Parameters.AddWithValue("Mark", MB6.Text);

                    command.Parameters.AddWithValue("Id_ques", IdQuesTextBox6.Text);

                    command.ExecuteNonQuery();
                }

                //Que #7
                {
                    OleDbCommand command = new OleDbCommand("INSERT INTO Result(Question, GroupName, Teacher, Mark, Id_ques)VALUES(@Question, @GroupName, @Teacher, @Mark, @Id_ques)", AccessConnection);

                    command.Parameters.AddWithValue("Question", QuL7.Text);

                    command.Parameters.AddWithValue("Group", GroupBox.Text);

                    command.Parameters.AddWithValue("Teacher", TeacherBox.Text);

                    command.Parameters.AddWithValue("Mark", MB7.Text);

                    command.Parameters.AddWithValue("Id_ques", IdQuesTextBox7.Text);

                    command.ExecuteNonQuery();
                }

                //Que #8
                {
                    OleDbCommand command = new OleDbCommand("INSERT INTO Result(Question, GroupName, Teacher, Mark, Id_ques)VALUES(@Question, @GroupName, @Teacher, @Mark, @Id_ques)", AccessConnection);

                    command.Parameters.AddWithValue("Question", QuL8.Text);

                    command.Parameters.AddWithValue("Group", GroupBox.Text);

                    command.Parameters.AddWithValue("Teacher", TeacherBox.Text);

                    command.Parameters.AddWithValue("Mark", MB8.Text);

                    command.Parameters.AddWithValue("Id_ques", IdQuesTextBox8.Text);

                    command.ExecuteNonQuery();
                }

                //Que #9
                {
                    OleDbCommand command = new OleDbCommand("INSERT INTO Result(Question, GroupName, Teacher, Mark, Id_ques)VALUES(@Question, @GroupName, @Teacher, @Mark, @Id_ques)", AccessConnection);

                    command.Parameters.AddWithValue("Question", QuL9.Text);

                    command.Parameters.AddWithValue("Group", GroupBox.Text);

                    command.Parameters.AddWithValue("Teacher", TeacherBox.Text);

                    command.Parameters.AddWithValue("Mark", MB9.Text);

                    command.Parameters.AddWithValue("Id_ques", IdQuesTextBox9.Text);

                    command.ExecuteNonQuery();

                }

                //Que #10
                {
                    OleDbCommand command = new OleDbCommand("INSERT INTO Result(Question, GroupName, Teacher, Mark, Id_ques)VALUES(@Question, @GroupName, @Teacher, @Mark, @Id_ques)", AccessConnection);

                    command.Parameters.AddWithValue("Question", QuL10.Text);

                    command.Parameters.AddWithValue("Group", GroupBox.Text);

                    command.Parameters.AddWithValue("Teacher", TeacherBox.Text);

                    command.Parameters.AddWithValue("Mark", MB10.Text);

                    command.Parameters.AddWithValue("Id_ques", IdQuesTextBox10.Text);

                    command.ExecuteNonQuery();
                }

                DialogResult dialogResult = MessageBox.Show("Спасибо что помогаете сделать нашу академию лучше!", "Спасибо", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.OK)
                {
                    Form MainMenu = new MainMenu();

                    MainMenu.Show();

                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AccessConnection.Close();
        }

        //Prev form
        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccessConnection.Close();

            Form MainMenu = new MainMenu();

            MainMenu.Show();

            this.Hide();
        }

        //Open window "О программе"
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            Form AboutProgram = new AboutProgram();

            AboutProgram.ShowDialog();
        }

        //Form close
        private void выходToolStripMenuItem_Click(object sender, EventArgs e) // Полное закрытие программы при нажатии на кнопку "Выход" в меню
        {
            AccessConnection.Close();              

            Application.Exit();
        }

        //From closing
        private void MainStudent_FormClosing(object sender, FormClosingEventArgs e) // Полное закрытие программы при нажатии на "Крестик"
        {
            AccessConnection.Close();

            Application.Exit();
        }

        /*
        Keypress processing
        */

        private void MB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MB1.MaxLength = 2;

            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b' | e.KeyChar == ',' | e.KeyChar == '.' | e.KeyChar == '/' | char.IsPunctuation(e.KeyChar))
            {
                return;
            }
            else
            {
                if (e.KeyChar == '2') MB2.Focus(); e.Handled = true;
            }
        }

        private void MB2_KeyPress(object sender, KeyPressEventArgs e)
        {
            MB2.MaxLength = 2;

            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b' | e.KeyChar == ',' | e.KeyChar == '.' | e.KeyChar == '/' | char.IsPunctuation(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void MB3_KeyPress(object sender, KeyPressEventArgs e)
        {
            MB3.MaxLength = 2;

            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b' | e.KeyChar == ',' | e.KeyChar == '.' | e.KeyChar == '/' | char.IsPunctuation(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void MB4_KeyPress(object sender, KeyPressEventArgs e)
        {
            MB4.MaxLength = 2;

            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b' | e.KeyChar == ',' | e.KeyChar == '.' | e.KeyChar == '/' | char.IsPunctuation(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void MB5_KeyPress(object sender, KeyPressEventArgs e)
        {
            MB5.MaxLength = 2;

            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b' | e.KeyChar == ',' | e.KeyChar == '.' | e.KeyChar == '/' | char.IsPunctuation(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void MB6_KeyPress(object sender, KeyPressEventArgs e)
        {
            MB6.MaxLength = 2;

            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b' | e.KeyChar == ',' | e.KeyChar == '.' | e.KeyChar == '/' | char.IsPunctuation(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void MB7_KeyPress(object sender, KeyPressEventArgs e)
        {
            MB7.MaxLength = 2;

            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b' | e.KeyChar == ',' | e.KeyChar == '.' | e.KeyChar == '/' | char.IsPunctuation(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void MB8_KeyPress(object sender, KeyPressEventArgs e)
        {
            MB8.MaxLength = 2;

            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b' | e.KeyChar == ',' | e.KeyChar == '.' | e.KeyChar == '/' | char.IsPunctuation(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void MB9_KeyPress(object sender, KeyPressEventArgs e)
        {
            MB9.MaxLength = 2;

            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b' | e.KeyChar == ',' | e.KeyChar == '.' | e.KeyChar == '/' | char.IsPunctuation(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
            
        }

        private void MB10_KeyPress(object sender, KeyPressEventArgs e)
        {
            MB10.MaxLength = 2;

            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b' | e.KeyChar == ',' | e.KeyChar == '.' | e.KeyChar == '/' | char.IsPunctuation(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}

