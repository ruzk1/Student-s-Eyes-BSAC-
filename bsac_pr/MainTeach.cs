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
    public partial class MainTeach : Form
    {
        //Connection to MS ACCESS DB
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DatabaseTI.mdb;";

        private OleDbConnection AccessConnection;

        public MainTeach()
        {
            InitializeComponent();

            AccessConnection = new OleDbConnection(connectionString);

            //Connection Check & Status
            try
            {
                AccessConnection.Open();

                DBConnectionStatus.Text = "Подключено";
            }
            catch
            {
                DBConnectionStatus.Text = "Нет соединения";

                MessageBox.Show("Нет соединения с базой данных!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Load action
        public void MainTeach_Load(object sender, EventArgs e)
        {
            OleDbDataReader AccessReader = null;

            //GeneralDGV filling
            {
                this.resultTableAdapter1.Fill(this.databaseTIDataSet1.Result); 

                this.resultTableAdapter.Fill(this.databaseTIDataSet.Result);
            }

            //TeacherTab filling
            {
                OleDbCommand command = new OleDbCommand("SELECT Teacher FROM Teachers GROUP BY Teacher", AccessConnection);

                try
                {
                    AccessReader = command.ExecuteReader();

                    while (AccessReader.Read())
                    {
                       EditTeacherComboBox.Items.Add(Convert.ToString(AccessReader["Teacher"]));

                       DeleteTeacherComboBox.Items.Add(Convert.ToString(AccessReader["Teacher"]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (AccessReader != null)
                    {
                        AccessReader.Close();
                    }
                }
            }

            //QuestionTab Filling
            {
                OleDbCommand command = new OleDbCommand("SELECT Id_ques FROM Questions", AccessConnection);

                try
                {
                    AccessReader = command.ExecuteReader();

                    while (AccessReader.Read())
                    {
                       QuestionComboBoxID.Items.Add(Convert.ToString(AccessReader["Id_ques"]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (AccessReader != null)
                    {
                        AccessReader.Close();
                    }
                }
            }

            //GroupTab Filling
            {
                OleDbCommand command = new OleDbCommand("SELECT GroupName FROM Groups GROUP BY GroupName", AccessConnection);
                {
                    try
                    {
                        AccessReader = command.ExecuteReader();

                        while (AccessReader.Read())
                        {
                           EditGroupComboBox.Items.Add(Convert.ToString(AccessReader["GroupName"]));

                           DeleteGroupComboBox.Items.Add(Convert.ToString(AccessReader["GroupName"]));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (AccessReader != null)
                        {
                            AccessReader.Close();
                        }
                    }
                }
            }

            //AVG Filling
            {
                //GeneralAvg
                {
                    OleDbCommand command = new OleDbCommand("SELECT ROUND(AVG(Mark),2) AS MarkAVG FROM Result", AccessConnection);
                    {
                        try
                        {
                            AccessReader = command.ExecuteReader();

                            while (AccessReader.Read())
                            {
                                AvgTextBox.Text = Convert.ToString(AccessReader["MarkAVG"]);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (AccessReader != null)
                            {
                                AccessReader.Close();
                            }
                        }
                    }
                }

                //TeacherAvg
                {
                    OleDbCommand command = new OleDbCommand("SELECT Teacher, ROUND(AVG(Mark),2) AS MarkAVG FROM [Result] GROUP BY Teacher", AccessConnection);
                    {
                        try
                        {
                            AccessReader = command.ExecuteReader();

                            while (AccessReader.Read())
                            {
                                AvgListBoxTeacher.Items.Add(Convert.ToString(AccessReader["Teacher"]) + ": " + Convert.ToString(AccessReader["MarkAVG"]));
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (AccessReader != null)
                            {
                                AccessReader.Close();
                            }
                        }
                    }
                }

                //TeacherGroupAvg
                {
                    OleDbCommand command = new OleDbCommand("SELECT Teacher, GroupName, ROUND(AVG(Mark),2) AS MarkAVG FROM [Result] GROUP BY GroupName, Teacher", AccessConnection);
                    {
                        try
                        {
                            AccessReader = command.ExecuteReader();

                            while (AccessReader.Read())
                            {
                                AvgListBoxTeacherGroup.Items.Add(Convert.ToString(AccessReader["Teacher"]) + " - " + Convert.ToString(AccessReader["GroupName"]) + ": " + Convert.ToString(AccessReader["MarkAVG"]));
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (AccessReader != null)
                            {
                                AccessReader.Close();
                            }
                        }
                    }
                }

                //QuestionAvg
                {
                    OleDbCommand command = new OleDbCommand("SELECT Teacher, Id_ques, ROUND(AVG(Mark),2) AS MarkAVG FROM [Result] GROUP BY Teacher, Id_ques", AccessConnection);                

                    {
                        try
                        {
                            AccessReader = command.ExecuteReader();

                            while (AccessReader.Read())
                            {
                                AvgListBoxTeacherQuestion.Items.Add(Convert.ToString(AccessReader["Teacher"]) + " - Вопрос #" + Convert.ToString(AccessReader["Id_ques"]) + ": " + Convert.ToString(AccessReader["MarkAVG"]));
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (AccessReader != null)
                                AccessReader.Close();
                        }
                    }
                }                          
            }

            AccessConnection.Close();
        }

        //Form close
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AccessConnection != null && AccessConnection.State != ConnectionState.Closed)
            {
                AccessConnection.Close();
            }

            Application.Exit();

        }

        //Fomr closing
        private void MainTeach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AccessConnection != null && AccessConnection.State != ConnectionState.Closed)
            {
                AccessConnection.Close();
            }

            Application.Exit();
        }

        //Open window "О программе"
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AboutProgram = new AboutProgram();

            AboutProgram.ShowDialog();
        }

        //Prev form
        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AccessConnection != null && AccessConnection.State != ConnectionState.Closed)
            {
                AccessConnection.Close();
            }

            Form MainMenu = new MainMenu();

            MainMenu.Show();

            this.Hide();
            
        }

        //Select QuestionID from DB
        private void QuestionComboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessConnection.Open();

            OleDbDataReader AccessReader = null;

            OleDbCommand command = new OleDbCommand("SELECT Question FROM [Questions] WHERE Id_ques=@Id_ques", AccessConnection);

            command.Parameters.AddWithValue("Id_ques", QuestionComboBoxID.Text);

            {
                try
                {
                    AccessReader = command.ExecuteReader();

                    while (AccessReader.Read())
                    {
                        QuestionTextBoxEdit.Text = (Convert.ToString(AccessReader["Question"]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (AccessReader != null)
                    {
                        AccessReader.Close();
                    }
                }
            }

            AccessConnection.Close();
        }

        //Update Question in DB
        private void QuestionEditButton_Click(object sender, EventArgs e)
        {
            AccessConnection.Open();

            OleDbDataReader AccessReader = null;

            OleDbCommand command = new OleDbCommand("UPDATE Questions SET Question=@Question WHERE Id_ques=@Id_ques", AccessConnection);

            command.Parameters.AddWithValue("Question", QuestionTextBoxEdit.Text);

            command.Parameters.AddWithValue("Id_ques", QuestionComboBoxID.Text);

            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (AccessReader != null)
                    {
                        AccessReader.Close();
                    }
                }
            }

            QuestionComboBoxID.Items.Clear();

            QuestionTextBoxEdit.Clear();

            OleDbCommand NewCommand = new OleDbCommand("SELECT Id_ques FROM Questions", AccessConnection);

            try
            {
                AccessReader = NewCommand.ExecuteReader();

                while (AccessReader.Read())
                {
                    QuestionComboBoxID.Items.Add(Convert.ToString(AccessReader["Id_ques"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (AccessReader != null)
                {
                    AccessReader.Close();
                }
            }

            AccessConnection.Close();
        }

        //Update Teacher in DB
        private void EditTeacherButton_Click(object sender, EventArgs e)
        {
            AccessConnection.Open();

            OleDbDataReader AccessReader = null;

            OleDbCommand command = new OleDbCommand("UPDATE Teachers SET Teacher=@Teacher WHERE Teacher=@OldTeacher", AccessConnection);

            command.Parameters.AddWithValue("Teacher", EditTeacherTextBox.Text);

            command.Parameters.AddWithValue("OldTeacher", EditTeacherComboBox.Text);

            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (AccessReader != null)
                    {
                        AccessReader.Close();
                    }
                }
            }

            EditTeacherComboBox.Items.Clear();

            DeleteTeacherComboBox.Items.Clear();

            OleDbCommand NewCommand = new OleDbCommand("SELECT Teacher FROM Teachers GROUP BY Teacher", AccessConnection);

            try
            {
                AccessReader = NewCommand.ExecuteReader();

                while (AccessReader.Read())
                {

                    EditTeacherComboBox.Items.Add(Convert.ToString(AccessReader["Teacher"]));

                    DeleteTeacherComboBox.Items.Add(Convert.ToString(AccessReader["Teacher"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (AccessReader != null)
                {
                    AccessReader.Close();
                }
            }

            AccessConnection.Close();
        }

        //Insert Teacher in DB
        private void AddTeacherButton_Click(object sender, EventArgs e)
        {
            AccessConnection.Open();

            OleDbDataReader AccessReader = null;

            OleDbCommand command = new OleDbCommand("INSERT INTO Teachers(Teacher) VALUES(@Teacher)", AccessConnection);

            command.Parameters.AddWithValue("Teacher", AddTeacherTextBox.Text);

            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (AccessReader != null)
                    {
                        AccessReader.Close();
                    }
                }
            }

            EditTeacherComboBox.Items.Clear();

            DeleteTeacherComboBox.Items.Clear();

            OleDbCommand NewCommand = new OleDbCommand("SELECT Teacher FROM Teachers GROUP BY Teacher", AccessConnection);

            try
            {
                AccessReader = NewCommand.ExecuteReader();

                while (AccessReader.Read())
                {

                    EditTeacherComboBox.Items.Add(Convert.ToString(AccessReader["Teacher"]));

                    DeleteTeacherComboBox.Items.Add(Convert.ToString(AccessReader["Teacher"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (AccessReader != null)
                {
                    AccessReader.Close();
                }
            }

            AccessConnection.Close();
        }

        //Delete Teacher in DB
        private void DeleteTeacherButton_Click(object sender, EventArgs e)
        {
            AccessConnection.Open();

            OleDbDataReader AccessReader = null;

            OleDbCommand command = new OleDbCommand("DELETE FROM Teachers WHERE Teacher=@Teacher", AccessConnection);

            command.Parameters.AddWithValue("Teacher", DeleteTeacherComboBox.Text);

            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (AccessReader != null)
                    {
                        AccessReader.Close();
                    }
                }
            }

            EditTeacherComboBox.Items.Clear();

            DeleteTeacherComboBox.Items.Clear();

            OleDbCommand NewCommand = new OleDbCommand("SELECT Teacher FROM Teachers GROUP BY Teacher", AccessConnection);

            try
            {
                AccessReader = NewCommand.ExecuteReader();

                while (AccessReader.Read())
                {

                    EditTeacherComboBox.Items.Add(Convert.ToString(AccessReader["Teacher"]));

                    DeleteTeacherComboBox.Items.Add(Convert.ToString(AccessReader["Teacher"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (AccessReader != null)
                {
                    AccessReader.Close();
                }
            }

            AccessConnection.Close();
        }

        //Insert Group in DB
        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            AccessConnection.Open();

            OleDbDataReader AccessReader = null;

            OleDbCommand command = new OleDbCommand("INSERT INTO Groups(GroupName) VALUES(@Group)", AccessConnection);

            command.Parameters.AddWithValue("Group", AddGroupTextBox.Text);

            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (AccessReader != null)
                    {
                        AccessReader.Close();
                    }
                }
            }

            EditGroupComboBox.Items.Clear();

            DeleteGroupComboBox.Items.Clear();

            OleDbCommand NewCommand = new OleDbCommand("SELECT GroupName FROM Groups GROUP BY GroupName", AccessConnection);
            {
                try
                {
                    AccessReader = NewCommand.ExecuteReader();

                    while (AccessReader.Read())
                    {
                        EditGroupComboBox.Items.Add(Convert.ToString(AccessReader["GroupName"]));

                        DeleteGroupComboBox.Items.Add(Convert.ToString(AccessReader["GroupName"]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (AccessReader != null)
                    {
                        AccessReader.Close();
                    }
                }
            }

            AccessConnection.Close();
        }

        //Update Group in DB
        private void EditGroupButton_Click(object sender, EventArgs e)
        {
            AccessConnection.Open();

            OleDbDataReader AccessReader = null;

            OleDbCommand command = new OleDbCommand("UPDATE Groups SET GroupName=@Group WHERE GroupName=@OldGroup", AccessConnection);

            command.Parameters.AddWithValue("Group", EditGroupTextBox.Text);

            command.Parameters.AddWithValue("OldGroup", EditGroupComboBox.Text);

            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (AccessReader != null)
                    {
                        AccessReader.Close();
                    }
                }
            }
            
            EditGroupComboBox.Items.Clear();

            DeleteGroupComboBox.Items.Clear();

            OleDbCommand NewCommand = new OleDbCommand("SELECT GroupName FROM Groups GROUP BY GroupName", AccessConnection);
            {
                try
                {
                    AccessReader = NewCommand.ExecuteReader();

                    while (AccessReader.Read())
                    {
                        EditGroupComboBox.Items.Add(Convert.ToString(AccessReader["GroupName"]));

                        DeleteGroupComboBox.Items.Add(Convert.ToString(AccessReader["GroupName"]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (AccessReader != null)
                    {
                        AccessReader.Close();
                    }
                }
            }

            AccessConnection.Close();
        }

        //Delete Group in DB
        private void DeleteGroupButton_Click(object sender, EventArgs e)
        {
            AccessConnection.Open();

            OleDbDataReader AccessReader = null;

            OleDbCommand command = new OleDbCommand("DELETE FROM Groups WHERE GroupName=@Group", AccessConnection);

            command.Parameters.AddWithValue("Group", DeleteGroupComboBox.Text);

            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (AccessReader != null)
                    {
                        AccessReader.Close();
                    }
                }
            }

            EditGroupComboBox.Items.Clear();

            DeleteGroupComboBox.Items.Clear();

            OleDbCommand NewCommand = new OleDbCommand("SELECT GroupName FROM Groups GROUP BY GroupName", AccessConnection);
            {
                try
                {
                    AccessReader = NewCommand.ExecuteReader();

                    while (AccessReader.Read())
                    {
                        EditGroupComboBox.Items.Add(Convert.ToString(AccessReader["GroupName"]));

                        DeleteGroupComboBox.Items.Add(Convert.ToString(AccessReader["GroupName"]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (AccessReader != null)
                    {
                        AccessReader.Close();
                    }
                }
            }

            AccessConnection.Close();
        }
        
        //Clear GeneralDGV
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AccessConnection.Open();

            OleDbDataReader AccessReader = null;

            OleDbCommand command = new OleDbCommand("DELETE FROM Result", AccessConnection);

            {
                try
                {
                    DialogResult result;

                    result = MessageBox.Show("Вы уверены? Результ не обратим!", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Yes)
                    {
                        command.ExecuteNonQuery();

                        DBConnectionStatus.Text = "Обновление";

                        AccessConnection.Close();

                        обновитьToolStripMenuItem_Click(null, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (AccessReader != null)
                    {
                        AccessReader.Close();
                    }
                }
            }

            AccessConnection.Close();
        }

        //Update form
        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccessConnection.Open();            

            DBConnectionStatus.Text = "Обновление";

            OleDbDataReader AccessReader = null;

            while (GeneralDGV.Rows.Count > 1)
            {
                for (int i = 0; i < GeneralDGV.Rows.Count - 1; i++)
                {
                    GeneralDGV.Rows.Remove(GeneralDGV.Rows[i]);
                }
            }

            DeleteTeacherComboBox.Items.Clear();

            EditTeacherComboBox.Items.Clear();

            DeleteGroupComboBox.Items.Clear();

            EditGroupComboBox.Items.Clear();

            QuestionComboBoxID.Items.Clear();

            QuestionTextBoxEdit.Clear();

            AvgListBoxTeacherQuestion.Items.Clear();

            AvgListBoxTeacher.Items.Clear();

            AvgListBoxTeacherGroup.Items.Clear();

            AvgTextBox.Clear();

            //GeneralDGV filling
            {
                this.resultTableAdapter1.Fill(this.databaseTIDataSet1.Result);

                this.resultTableAdapter.Fill(this.databaseTIDataSet.Result);
            }

            //TeacherTab filling
            {
                OleDbCommand command = new OleDbCommand("SELECT Teacher FROM Teachers GROUP BY Teacher", AccessConnection);

                try
                {
                    AccessReader = command.ExecuteReader();

                    while (AccessReader.Read())
                    {

                        EditTeacherComboBox.Items.Add(Convert.ToString(AccessReader["Teacher"]));
                        
                        DeleteTeacherComboBox.Items.Add(Convert.ToString(AccessReader["Teacher"]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (AccessReader != null)
                    {
                        AccessReader.Close();
                    }
                }
            }

            //QuestionTab Filling
            {
                OleDbCommand command = new OleDbCommand("SELECT Id_ques FROM Questions", AccessConnection);

                try
                {
                    AccessReader = command.ExecuteReader();

                    while (AccessReader.Read())
                    {
                        QuestionComboBoxID.Items.Add(Convert.ToString(AccessReader["Id_ques"]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (AccessReader != null)
                    {
                        AccessReader.Close();
                    }
                }
            }

            //GroupTab Filling
            {
                OleDbCommand command = new OleDbCommand("SELECT GroupName FROM Groups GROUP BY GroupName", AccessConnection);
                {
                    try
                    {
                        AccessReader = command.ExecuteReader();

                        while (AccessReader.Read())
                        {
                            EditGroupComboBox.Items.Add(Convert.ToString(AccessReader["GroupName"]));

                            DeleteGroupComboBox.Items.Add(Convert.ToString(AccessReader["GroupName"]));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (AccessReader != null)
                        {
                            AccessReader.Close();
                        }
                    }
                }
            }
            //AVG Filling
            {
                //GeneralAvg
                {
                    OleDbCommand command = new OleDbCommand("SELECT ROUND(AVG(Mark),2) AS MarkAVG FROM Result", AccessConnection);
                    {
                        try
                        {
                            AccessReader = command.ExecuteReader();

                            while (AccessReader.Read())
                            {
                                AvgTextBox.Text = Convert.ToString(AccessReader["MarkAVG"]);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (AccessReader != null)
                            {
                                AccessReader.Close();
                            }
                        }
                    }
                }

                //TeacherAvg
                {
                    OleDbCommand command = new OleDbCommand("SELECT Teacher, ROUND(AVG(Mark),2) AS MarkAVG FROM [Result] GROUP BY Teacher", AccessConnection);
                    {
                        try
                        {
                            AccessReader = command.ExecuteReader();

                            while (AccessReader.Read())
                            {
                                AvgListBoxTeacher.Items.Add(Convert.ToString(AccessReader["Teacher"]) + ": " + Convert.ToString(AccessReader["MarkAVG"]));
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (AccessReader != null)
                            {
                                AccessReader.Close();
                            }
                        }
                    }
                }

                //TeacherGroupAvg
                {
                    OleDbCommand command = new OleDbCommand("SELECT Teacher, GroupName, ROUND(AVG(Mark),2) AS MarkAVG FROM [Result] GROUP BY GroupName, Teacher", AccessConnection);
                    {
                        try
                        {
                            AccessReader = command.ExecuteReader();

                            while (AccessReader.Read())
                            {
                                AvgListBoxTeacherGroup.Items.Add(Convert.ToString(AccessReader["Teacher"]) + " - " + Convert.ToString(AccessReader["GroupName"]) + ": " + Convert.ToString(AccessReader["MarkAVG"]));
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (AccessReader != null)
                            {
                                AccessReader.Close();
                            }
                        }
                    }
                }

                //QuestionAvg
                {
                    OleDbCommand command = new OleDbCommand("SELECT Teacher, Id_ques, ROUND(AVG(Mark),2) AS MarkAVG FROM [Result] GROUP BY Teacher, Id_ques", AccessConnection);

                    {
                        try
                        {
                            AccessReader = command.ExecuteReader();

                            while (AccessReader.Read())
                            {
                                AvgListBoxTeacherQuestion.Items.Add(Convert.ToString(AccessReader["Teacher"]) + " - Вопрос #" + Convert.ToString(AccessReader["Id_ques"]) + ": " + Convert.ToString(AccessReader["MarkAVG"]));
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (AccessReader != null)
                                AccessReader.Close();
                        }
                    }
                }
            }

            AccessConnection.Close();

            DBConnectionStatus.Text = "Подключено";
        }
    }
}

