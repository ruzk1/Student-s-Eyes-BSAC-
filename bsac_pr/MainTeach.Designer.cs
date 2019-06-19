namespace bsac_pr
{
    partial class MainTeach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTeach));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneralDGV = new System.Windows.Forms.DataGridView();
            this.resultBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseTIDataSet1 = new bsac_pr.DatabaseTIDataSet1();
            this.resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseTIDataSet = new bsac_pr.DatabaseTIDataSet();
            this.resultTableAdapter = new bsac_pr.DatabaseTIDataSetTableAdapters.ResultTableAdapter();
            this.resultTableAdapter1 = new bsac_pr.DatabaseTIDataSet1TableAdapters.ResultTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GeneralTab = new System.Windows.Forms.TabPage();
            this.StatisticTab = new System.Windows.Forms.TabPage();
            this.AvgTeacherQuestionLabel = new System.Windows.Forms.Label();
            this.AvgListBoxTeacherQuestion = new System.Windows.Forms.ListBox();
            this.AvgTextBox = new System.Windows.Forms.TextBox();
            this.AvgLabel = new System.Windows.Forms.Label();
            this.AvgTeacherGroupLabel = new System.Windows.Forms.Label();
            this.AvgListBoxTeacherGroup = new System.Windows.Forms.ListBox();
            this.AvgTeacherLabel = new System.Windows.Forms.Label();
            this.AvgListBoxTeacher = new System.Windows.Forms.ListBox();
            this.TeacherTab = new System.Windows.Forms.TabPage();
            this.EditTeacherLabel2 = new System.Windows.Forms.Label();
            this.EditTeacherTextBox = new System.Windows.Forms.TextBox();
            this.EditTeacherLabel = new System.Windows.Forms.Label();
            this.EditTeacherComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteTeacherLabel = new System.Windows.Forms.Label();
            this.DeleteTeacherComboBox = new System.Windows.Forms.ComboBox();
            this.AddTeacherTextBox = new System.Windows.Forms.TextBox();
            this.DeleteTeacherButton = new System.Windows.Forms.Button();
            this.EditTeacherButton = new System.Windows.Forms.Button();
            this.AddTeacherButton = new System.Windows.Forms.Button();
            this.TeacherAddLabel = new System.Windows.Forms.Label();
            this.GroupTab = new System.Windows.Forms.TabPage();
            this.EditGroupLabel2 = new System.Windows.Forms.Label();
            this.EditGroupTextBox = new System.Windows.Forms.TextBox();
            this.EditGroupLabel1 = new System.Windows.Forms.Label();
            this.EditGroupComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteGroupLabel = new System.Windows.Forms.Label();
            this.DeleteGroupComboBox = new System.Windows.Forms.ComboBox();
            this.AddGroupTextBox = new System.Windows.Forms.TextBox();
            this.DeleteGroupButton = new System.Windows.Forms.Button();
            this.EditGroupButton = new System.Windows.Forms.Button();
            this.AddGroupButton = new System.Windows.Forms.Button();
            this.AddGroupLabel = new System.Windows.Forms.Label();
            this.QuestionTab = new System.Windows.Forms.TabPage();
            this.QuestionEditButton = new System.Windows.Forms.Button();
            this.QuestionComboBoxID = new System.Windows.Forms.ComboBox();
            this.QuestionTextBoxEdit = new System.Windows.Forms.TextBox();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.DBStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DBConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTIDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTIDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.GeneralTab.SuspendLayout();
            this.StatisticTab.SuspendLayout();
            this.TeacherTab.SuspendLayout();
            this.GroupTab.SuspendLayout();
            this.QuestionTab.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.работаСБДToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // работаСБДToolStripMenuItem
            // 
            this.работаСБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.работаСБДToolStripMenuItem.Name = "работаСБДToolStripMenuItem";
            this.работаСБДToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.работаСБДToolStripMenuItem.Text = "Работа с БД";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // GeneralDGV
            // 
            this.GeneralDGV.AutoGenerateColumns = false;
            this.GeneralDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GeneralDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GeneralDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherDataGridViewTextBoxColumn,
            this.groupNameDataGridViewTextBoxColumn,
            this.markDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn});
            this.GeneralDGV.DataSource = this.resultBindingSource1;
            this.GeneralDGV.Location = new System.Drawing.Point(-4, -2);
            this.GeneralDGV.Name = "GeneralDGV";
            this.GeneralDGV.ReadOnly = true;
            this.GeneralDGV.Size = new System.Drawing.Size(859, 340);
            this.GeneralDGV.TabIndex = 4;
            // 
            // resultBindingSource1
            // 
            this.resultBindingSource1.DataMember = "Result";
            this.resultBindingSource1.DataSource = this.databaseTIDataSet1;
            // 
            // databaseTIDataSet1
            // 
            this.databaseTIDataSet1.DataSetName = "DatabaseTIDataSet1";
            this.databaseTIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultBindingSource
            // 
            this.resultBindingSource.DataMember = "Result";
            this.resultBindingSource.DataSource = this.databaseTIDataSet;
            // 
            // databaseTIDataSet
            // 
            this.databaseTIDataSet.DataSetName = "DatabaseTIDataSet";
            this.databaseTIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultTableAdapter
            // 
            this.resultTableAdapter.ClearBeforeFill = true;
            // 
            // resultTableAdapter1
            // 
            this.resultTableAdapter1.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.GeneralTab);
            this.tabControl1.Controls.Add(this.StatisticTab);
            this.tabControl1.Controls.Add(this.TeacherTab);
            this.tabControl1.Controls.Add(this.GroupTab);
            this.tabControl1.Controls.Add(this.QuestionTab);
            this.tabControl1.Location = new System.Drawing.Point(13, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(859, 360);
            this.tabControl1.TabIndex = 5;
            // 
            // GeneralTab
            // 
            this.GeneralTab.Controls.Add(this.GeneralDGV);
            this.GeneralTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GeneralTab.Location = new System.Drawing.Point(4, 22);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralTab.Size = new System.Drawing.Size(851, 334);
            this.GeneralTab.TabIndex = 0;
            this.GeneralTab.Text = "Общий вид";
            this.GeneralTab.UseVisualStyleBackColor = true;
            // 
            // StatisticTab
            // 
            this.StatisticTab.Controls.Add(this.AvgTeacherQuestionLabel);
            this.StatisticTab.Controls.Add(this.AvgListBoxTeacherQuestion);
            this.StatisticTab.Controls.Add(this.AvgTextBox);
            this.StatisticTab.Controls.Add(this.AvgLabel);
            this.StatisticTab.Controls.Add(this.AvgTeacherGroupLabel);
            this.StatisticTab.Controls.Add(this.AvgListBoxTeacherGroup);
            this.StatisticTab.Controls.Add(this.AvgTeacherLabel);
            this.StatisticTab.Controls.Add(this.AvgListBoxTeacher);
            this.StatisticTab.Location = new System.Drawing.Point(4, 22);
            this.StatisticTab.Name = "StatisticTab";
            this.StatisticTab.Size = new System.Drawing.Size(851, 334);
            this.StatisticTab.TabIndex = 4;
            this.StatisticTab.Text = "Статистика";
            this.StatisticTab.UseVisualStyleBackColor = true;
            // 
            // AvgTeacherQuestionLabel
            // 
            this.AvgTeacherQuestionLabel.AutoSize = true;
            this.AvgTeacherQuestionLabel.Location = new System.Drawing.Point(538, 25);
            this.AvgTeacherQuestionLabel.Name = "AvgTeacherQuestionLabel";
            this.AvgTeacherQuestionLabel.Size = new System.Drawing.Size(225, 13);
            this.AvgTeacherQuestionLabel.TabIndex = 7;
            this.AvgTeacherQuestionLabel.Text = "Средний балл преподавателя по вопросам";
            // 
            // AvgListBoxTeacherQuestion
            // 
            this.AvgListBoxTeacherQuestion.FormattingEnabled = true;
            this.AvgListBoxTeacherQuestion.Location = new System.Drawing.Point(541, 44);
            this.AvgListBoxTeacherQuestion.Name = "AvgListBoxTeacherQuestion";
            this.AvgListBoxTeacherQuestion.ScrollAlwaysVisible = true;
            this.AvgListBoxTeacherQuestion.Size = new System.Drawing.Size(300, 290);
            this.AvgListBoxTeacherQuestion.TabIndex = 6;
            // 
            // AvgTextBox
            // 
            this.AvgTextBox.Location = new System.Drawing.Point(155, 3);
            this.AvgTextBox.MaxLength = 4;
            this.AvgTextBox.Name = "AvgTextBox";
            this.AvgTextBox.ReadOnly = true;
            this.AvgTextBox.Size = new System.Drawing.Size(30, 20);
            this.AvgTextBox.TabIndex = 5;
            // 
            // AvgLabel
            // 
            this.AvgLabel.AutoSize = true;
            this.AvgLabel.Location = new System.Drawing.Point(4, 6);
            this.AvgLabel.Name = "AvgLabel";
            this.AvgLabel.Size = new System.Drawing.Size(145, 13);
            this.AvgLabel.TabIndex = 4;
            this.AvgLabel.Text = "Средний балл по академии";
            // 
            // AvgTeacherGroupLabel
            // 
            this.AvgTeacherGroupLabel.AutoSize = true;
            this.AvgTeacherGroupLabel.Location = new System.Drawing.Point(252, 25);
            this.AvgTeacherGroupLabel.Name = "AvgTeacherGroupLabel";
            this.AvgTeacherGroupLabel.Size = new System.Drawing.Size(217, 13);
            this.AvgTeacherGroupLabel.TabIndex = 3;
            this.AvgTeacherGroupLabel.Text = "Средний балл преподавателя по группам";
            // 
            // AvgListBoxTeacherGroup
            // 
            this.AvgListBoxTeacherGroup.FormattingEnabled = true;
            this.AvgListBoxTeacherGroup.Location = new System.Drawing.Point(255, 44);
            this.AvgListBoxTeacherGroup.Name = "AvgListBoxTeacherGroup";
            this.AvgListBoxTeacherGroup.ScrollAlwaysVisible = true;
            this.AvgListBoxTeacherGroup.Size = new System.Drawing.Size(280, 290);
            this.AvgListBoxTeacherGroup.TabIndex = 2;
            // 
            // AvgTeacherLabel
            // 
            this.AvgTeacherLabel.AutoSize = true;
            this.AvgTeacherLabel.Location = new System.Drawing.Point(13, 25);
            this.AvgTeacherLabel.Name = "AvgTeacherLabel";
            this.AvgTeacherLabel.Size = new System.Drawing.Size(163, 13);
            this.AvgTeacherLabel.TabIndex = 1;
            this.AvgTeacherLabel.Text = "Средний балл преподавателей";
            // 
            // AvgListBoxTeacher
            // 
            this.AvgListBoxTeacher.FormattingEnabled = true;
            this.AvgListBoxTeacher.Location = new System.Drawing.Point(9, 44);
            this.AvgListBoxTeacher.Name = "AvgListBoxTeacher";
            this.AvgListBoxTeacher.ScrollAlwaysVisible = true;
            this.AvgListBoxTeacher.Size = new System.Drawing.Size(240, 290);
            this.AvgListBoxTeacher.TabIndex = 0;
            // 
            // TeacherTab
            // 
            this.TeacherTab.Controls.Add(this.EditTeacherLabel2);
            this.TeacherTab.Controls.Add(this.EditTeacherTextBox);
            this.TeacherTab.Controls.Add(this.EditTeacherLabel);
            this.TeacherTab.Controls.Add(this.EditTeacherComboBox);
            this.TeacherTab.Controls.Add(this.DeleteTeacherLabel);
            this.TeacherTab.Controls.Add(this.DeleteTeacherComboBox);
            this.TeacherTab.Controls.Add(this.AddTeacherTextBox);
            this.TeacherTab.Controls.Add(this.DeleteTeacherButton);
            this.TeacherTab.Controls.Add(this.EditTeacherButton);
            this.TeacherTab.Controls.Add(this.AddTeacherButton);
            this.TeacherTab.Controls.Add(this.TeacherAddLabel);
            this.TeacherTab.Location = new System.Drawing.Point(4, 22);
            this.TeacherTab.Name = "TeacherTab";
            this.TeacherTab.Padding = new System.Windows.Forms.Padding(3);
            this.TeacherTab.Size = new System.Drawing.Size(851, 334);
            this.TeacherTab.TabIndex = 1;
            this.TeacherTab.Text = "Преподаватели";
            this.TeacherTab.UseVisualStyleBackColor = true;
            // 
            // EditTeacherLabel2
            // 
            this.EditTeacherLabel2.AutoSize = true;
            this.EditTeacherLabel2.Location = new System.Drawing.Point(592, 64);
            this.EditTeacherLabel2.Name = "EditTeacherLabel2";
            this.EditTeacherLabel2.Size = new System.Drawing.Size(75, 13);
            this.EditTeacherLabel2.TabIndex = 10;
            this.EditTeacherLabel2.Text = "Заменить на:";
            // 
            // EditTeacherTextBox
            // 
            this.EditTeacherTextBox.Location = new System.Drawing.Point(590, 80);
            this.EditTeacherTextBox.Name = "EditTeacherTextBox";
            this.EditTeacherTextBox.Size = new System.Drawing.Size(200, 20);
            this.EditTeacherTextBox.TabIndex = 9;
            // 
            // EditTeacherLabel
            // 
            this.EditTeacherLabel.AutoSize = true;
            this.EditTeacherLabel.Location = new System.Drawing.Point(592, 24);
            this.EditTeacherLabel.Name = "EditTeacherLabel";
            this.EditTeacherLabel.Size = new System.Drawing.Size(140, 13);
            this.EditTeacherLabel.TabIndex = 8;
            this.EditTeacherLabel.Text = "Выберите преподавателя:";
            // 
            // EditTeacherComboBox
            // 
            this.EditTeacherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditTeacherComboBox.FormattingEnabled = true;
            this.EditTeacherComboBox.Location = new System.Drawing.Point(590, 40);
            this.EditTeacherComboBox.Name = "EditTeacherComboBox";
            this.EditTeacherComboBox.Size = new System.Drawing.Size(200, 21);
            this.EditTeacherComboBox.TabIndex = 7;
            // 
            // DeleteTeacherLabel
            // 
            this.DeleteTeacherLabel.AutoSize = true;
            this.DeleteTeacherLabel.Location = new System.Drawing.Point(42, 224);
            this.DeleteTeacherLabel.Name = "DeleteTeacherLabel";
            this.DeleteTeacherLabel.Size = new System.Drawing.Size(140, 13);
            this.DeleteTeacherLabel.TabIndex = 6;
            this.DeleteTeacherLabel.Text = "Выберите преподавателя:";
            // 
            // DeleteTeacherComboBox
            // 
            this.DeleteTeacherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeleteTeacherComboBox.FormattingEnabled = true;
            this.DeleteTeacherComboBox.Location = new System.Drawing.Point(40, 240);
            this.DeleteTeacherComboBox.Name = "DeleteTeacherComboBox";
            this.DeleteTeacherComboBox.Size = new System.Drawing.Size(200, 21);
            this.DeleteTeacherComboBox.TabIndex = 5;
            // 
            // AddTeacherTextBox
            // 
            this.AddTeacherTextBox.Location = new System.Drawing.Point(40, 40);
            this.AddTeacherTextBox.Name = "AddTeacherTextBox";
            this.AddTeacherTextBox.Size = new System.Drawing.Size(200, 20);
            this.AddTeacherTextBox.TabIndex = 4;
            // 
            // DeleteTeacherButton
            // 
            this.DeleteTeacherButton.Location = new System.Drawing.Point(45, 267);
            this.DeleteTeacherButton.Name = "DeleteTeacherButton";
            this.DeleteTeacherButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteTeacherButton.TabIndex = 3;
            this.DeleteTeacherButton.Text = "Удалить";
            this.DeleteTeacherButton.UseVisualStyleBackColor = true;
            this.DeleteTeacherButton.Click += new System.EventHandler(this.DeleteTeacherButton_Click);
            // 
            // EditTeacherButton
            // 
            this.EditTeacherButton.Location = new System.Drawing.Point(595, 106);
            this.EditTeacherButton.Name = "EditTeacherButton";
            this.EditTeacherButton.Size = new System.Drawing.Size(75, 23);
            this.EditTeacherButton.TabIndex = 2;
            this.EditTeacherButton.Text = "Изменить";
            this.EditTeacherButton.UseVisualStyleBackColor = true;
            this.EditTeacherButton.Click += new System.EventHandler(this.EditTeacherButton_Click);
            // 
            // AddTeacherButton
            // 
            this.AddTeacherButton.Location = new System.Drawing.Point(45, 66);
            this.AddTeacherButton.Name = "AddTeacherButton";
            this.AddTeacherButton.Size = new System.Drawing.Size(75, 23);
            this.AddTeacherButton.TabIndex = 1;
            this.AddTeacherButton.Text = "Добавить";
            this.AddTeacherButton.UseVisualStyleBackColor = true;
            this.AddTeacherButton.Click += new System.EventHandler(this.AddTeacherButton_Click);
            // 
            // TeacherAddLabel
            // 
            this.TeacherAddLabel.AutoSize = true;
            this.TeacherAddLabel.Location = new System.Drawing.Point(42, 24);
            this.TeacherAddLabel.Name = "TeacherAddLabel";
            this.TeacherAddLabel.Size = new System.Drawing.Size(82, 13);
            this.TeacherAddLabel.TabIndex = 0;
            this.TeacherAddLabel.Text = "Введите ФИО:";
            // 
            // GroupTab
            // 
            this.GroupTab.Controls.Add(this.EditGroupLabel2);
            this.GroupTab.Controls.Add(this.EditGroupTextBox);
            this.GroupTab.Controls.Add(this.EditGroupLabel1);
            this.GroupTab.Controls.Add(this.EditGroupComboBox);
            this.GroupTab.Controls.Add(this.DeleteGroupLabel);
            this.GroupTab.Controls.Add(this.DeleteGroupComboBox);
            this.GroupTab.Controls.Add(this.AddGroupTextBox);
            this.GroupTab.Controls.Add(this.DeleteGroupButton);
            this.GroupTab.Controls.Add(this.EditGroupButton);
            this.GroupTab.Controls.Add(this.AddGroupButton);
            this.GroupTab.Controls.Add(this.AddGroupLabel);
            this.GroupTab.Location = new System.Drawing.Point(4, 22);
            this.GroupTab.Name = "GroupTab";
            this.GroupTab.Size = new System.Drawing.Size(851, 334);
            this.GroupTab.TabIndex = 2;
            this.GroupTab.Text = "Группы";
            this.GroupTab.UseVisualStyleBackColor = true;
            // 
            // EditGroupLabel2
            // 
            this.EditGroupLabel2.AutoSize = true;
            this.EditGroupLabel2.Location = new System.Drawing.Point(592, 64);
            this.EditGroupLabel2.Name = "EditGroupLabel2";
            this.EditGroupLabel2.Size = new System.Drawing.Size(75, 13);
            this.EditGroupLabel2.TabIndex = 21;
            this.EditGroupLabel2.Text = "Заменить на:";
            // 
            // EditGroupTextBox
            // 
            this.EditGroupTextBox.Location = new System.Drawing.Point(590, 80);
            this.EditGroupTextBox.Name = "EditGroupTextBox";
            this.EditGroupTextBox.Size = new System.Drawing.Size(93, 20);
            this.EditGroupTextBox.TabIndex = 20;
            // 
            // EditGroupLabel1
            // 
            this.EditGroupLabel1.AutoSize = true;
            this.EditGroupLabel1.Location = new System.Drawing.Point(592, 24);
            this.EditGroupLabel1.Name = "EditGroupLabel1";
            this.EditGroupLabel1.Size = new System.Drawing.Size(96, 13);
            this.EditGroupLabel1.TabIndex = 19;
            this.EditGroupLabel1.Text = "Выберите группу:";
            // 
            // EditGroupComboBox
            // 
            this.EditGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditGroupComboBox.FormattingEnabled = true;
            this.EditGroupComboBox.Location = new System.Drawing.Point(590, 40);
            this.EditGroupComboBox.Name = "EditGroupComboBox";
            this.EditGroupComboBox.Size = new System.Drawing.Size(93, 21);
            this.EditGroupComboBox.TabIndex = 18;
            // 
            // DeleteGroupLabel
            // 
            this.DeleteGroupLabel.AutoSize = true;
            this.DeleteGroupLabel.Location = new System.Drawing.Point(42, 224);
            this.DeleteGroupLabel.Name = "DeleteGroupLabel";
            this.DeleteGroupLabel.Size = new System.Drawing.Size(96, 13);
            this.DeleteGroupLabel.TabIndex = 17;
            this.DeleteGroupLabel.Text = "Выберите группу:";
            // 
            // DeleteGroupComboBox
            // 
            this.DeleteGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeleteGroupComboBox.FormattingEnabled = true;
            this.DeleteGroupComboBox.Location = new System.Drawing.Point(40, 240);
            this.DeleteGroupComboBox.Name = "DeleteGroupComboBox";
            this.DeleteGroupComboBox.Size = new System.Drawing.Size(93, 21);
            this.DeleteGroupComboBox.TabIndex = 16;
            // 
            // AddGroupTextBox
            // 
            this.AddGroupTextBox.Location = new System.Drawing.Point(40, 40);
            this.AddGroupTextBox.Name = "AddGroupTextBox";
            this.AddGroupTextBox.Size = new System.Drawing.Size(93, 20);
            this.AddGroupTextBox.TabIndex = 15;
            // 
            // DeleteGroupButton
            // 
            this.DeleteGroupButton.Location = new System.Drawing.Point(45, 267);
            this.DeleteGroupButton.Name = "DeleteGroupButton";
            this.DeleteGroupButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteGroupButton.TabIndex = 14;
            this.DeleteGroupButton.Text = "Удалить";
            this.DeleteGroupButton.UseVisualStyleBackColor = true;
            this.DeleteGroupButton.Click += new System.EventHandler(this.DeleteGroupButton_Click);
            // 
            // EditGroupButton
            // 
            this.EditGroupButton.Location = new System.Drawing.Point(595, 106);
            this.EditGroupButton.Name = "EditGroupButton";
            this.EditGroupButton.Size = new System.Drawing.Size(75, 23);
            this.EditGroupButton.TabIndex = 13;
            this.EditGroupButton.Text = "Изменить";
            this.EditGroupButton.UseVisualStyleBackColor = true;
            this.EditGroupButton.Click += new System.EventHandler(this.EditGroupButton_Click);
            // 
            // AddGroupButton
            // 
            this.AddGroupButton.Location = new System.Drawing.Point(45, 66);
            this.AddGroupButton.Name = "AddGroupButton";
            this.AddGroupButton.Size = new System.Drawing.Size(75, 23);
            this.AddGroupButton.TabIndex = 12;
            this.AddGroupButton.Text = "Добавить";
            this.AddGroupButton.UseVisualStyleBackColor = true;
            this.AddGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
            // 
            // AddGroupLabel
            // 
            this.AddGroupLabel.AutoSize = true;
            this.AddGroupLabel.Location = new System.Drawing.Point(42, 24);
            this.AddGroupLabel.Name = "AddGroupLabel";
            this.AddGroupLabel.Size = new System.Drawing.Size(88, 13);
            this.AddGroupLabel.TabIndex = 11;
            this.AddGroupLabel.Text = "Введите группу:";
            // 
            // QuestionTab
            // 
            this.QuestionTab.Controls.Add(this.QuestionEditButton);
            this.QuestionTab.Controls.Add(this.QuestionComboBoxID);
            this.QuestionTab.Controls.Add(this.QuestionTextBoxEdit);
            this.QuestionTab.Controls.Add(this.QuestionLabel);
            this.QuestionTab.Location = new System.Drawing.Point(4, 22);
            this.QuestionTab.Name = "QuestionTab";
            this.QuestionTab.Size = new System.Drawing.Size(851, 334);
            this.QuestionTab.TabIndex = 3;
            this.QuestionTab.Text = "Вопросы";
            this.QuestionTab.UseVisualStyleBackColor = true;
            // 
            // QuestionEditButton
            // 
            this.QuestionEditButton.Location = new System.Drawing.Point(378, 63);
            this.QuestionEditButton.Name = "QuestionEditButton";
            this.QuestionEditButton.Size = new System.Drawing.Size(248, 23);
            this.QuestionEditButton.TabIndex = 3;
            this.QuestionEditButton.Text = "Изменить";
            this.QuestionEditButton.UseVisualStyleBackColor = true;
            this.QuestionEditButton.Click += new System.EventHandler(this.QuestionEditButton_Click);
            // 
            // QuestionComboBoxID
            // 
            this.QuestionComboBoxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuestionComboBoxID.FormattingEnabled = true;
            this.QuestionComboBoxID.Location = new System.Drawing.Point(122, 37);
            this.QuestionComboBoxID.Name = "QuestionComboBoxID";
            this.QuestionComboBoxID.Size = new System.Drawing.Size(50, 21);
            this.QuestionComboBoxID.TabIndex = 2;
            this.QuestionComboBoxID.SelectedIndexChanged += new System.EventHandler(this.QuestionComboBoxID_SelectedIndexChanged);
            // 
            // QuestionTextBoxEdit
            // 
            this.QuestionTextBoxEdit.Location = new System.Drawing.Point(178, 37);
            this.QuestionTextBoxEdit.Name = "QuestionTextBoxEdit";
            this.QuestionTextBoxEdit.Size = new System.Drawing.Size(660, 20);
            this.QuestionTextBoxEdit.TabIndex = 1;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(20, 40);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(96, 13);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "Выберите вопрос";
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DBStatusLabel,
            this.DBConnectionStatus});
            this.StatusBar.Location = new System.Drawing.Point(0, 390);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(884, 22);
            this.StatusBar.TabIndex = 6;
            this.StatusBar.Text = "Состояние";
            // 
            // DBStatusLabel
            // 
            this.DBStatusLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DBStatusLabel.Name = "DBStatusLabel";
            this.DBStatusLabel.Size = new System.Drawing.Size(69, 17);
            this.DBStatusLabel.Text = "Состояние:";
            // 
            // DBConnectionStatus
            // 
            this.DBConnectionStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DBConnectionStatus.Name = "DBConnectionStatus";
            this.DBConnectionStatus.Size = new System.Drawing.Size(95, 17);
            this.DBConnectionStatus.Text = "Не подключено";
            // 
            // teacherDataGridViewTextBoxColumn
            // 
            this.teacherDataGridViewTextBoxColumn.DataPropertyName = "Teacher";
            this.teacherDataGridViewTextBoxColumn.HeaderText = "Преподаватель";
            this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
            this.teacherDataGridViewTextBoxColumn.ReadOnly = true;
            this.teacherDataGridViewTextBoxColumn.Width = 250;
            // 
            // groupNameDataGridViewTextBoxColumn
            // 
            this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName";
            this.groupNameDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            this.groupNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupNameDataGridViewTextBoxColumn.Width = 50;
            // 
            // markDataGridViewTextBoxColumn
            // 
            this.markDataGridViewTextBoxColumn.DataPropertyName = "Mark";
            this.markDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.markDataGridViewTextBoxColumn.Name = "markDataGridViewTextBoxColumn";
            this.markDataGridViewTextBoxColumn.ReadOnly = true;
            this.markDataGridViewTextBoxColumn.Width = 50;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "Question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "Вопрос";
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            this.questionDataGridViewTextBoxColumn.ReadOnly = true;
            this.questionDataGridViewTextBoxColumn.Width = 448;
            // 
            // MainTeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(884, 412);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainTeach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Преподаватель";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainTeach_FormClosing);
            this.Load += new System.EventHandler(this.MainTeach_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTIDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTIDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.GeneralTab.ResumeLayout(false);
            this.StatisticTab.ResumeLayout(false);
            this.StatisticTab.PerformLayout();
            this.TeacherTab.ResumeLayout(false);
            this.TeacherTab.PerformLayout();
            this.GroupTab.ResumeLayout(false);
            this.GroupTab.PerformLayout();
            this.QuestionTab.ResumeLayout(false);
            this.QuestionTab.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.DataGridView GeneralDGV;
        private DatabaseTIDataSet databaseTIDataSet;
        private System.Windows.Forms.BindingSource resultBindingSource;
        private DatabaseTIDataSetTableAdapters.ResultTableAdapter resultTableAdapter;
        private DatabaseTIDataSet1 databaseTIDataSet1;
        private System.Windows.Forms.BindingSource resultBindingSource1;
        private DatabaseTIDataSet1TableAdapters.ResultTableAdapter resultTableAdapter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GeneralTab;
        private System.Windows.Forms.TabPage TeacherTab;
        private System.Windows.Forms.TabPage StatisticTab;
        private System.Windows.Forms.TabPage GroupTab;
        private System.Windows.Forms.TabPage QuestionTab;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel DBStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel DBConnectionStatus;
        private System.Windows.Forms.Label AvgTeacherGroupLabel;
        private System.Windows.Forms.ListBox AvgListBoxTeacherGroup;
        private System.Windows.Forms.Label AvgTeacherLabel;
        private System.Windows.Forms.ListBox AvgListBoxTeacher;
        private System.Windows.Forms.TextBox AvgTextBox;
        private System.Windows.Forms.Label AvgLabel;
        private System.Windows.Forms.Label AvgTeacherQuestionLabel;
        private System.Windows.Forms.ListBox AvgListBoxTeacherQuestion;
        private System.Windows.Forms.Button QuestionEditButton;
        private System.Windows.Forms.ComboBox QuestionComboBoxID;
        private System.Windows.Forms.TextBox QuestionTextBoxEdit;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label EditTeacherLabel;
        private System.Windows.Forms.ComboBox EditTeacherComboBox;
        private System.Windows.Forms.Label DeleteTeacherLabel;
        private System.Windows.Forms.ComboBox DeleteTeacherComboBox;
        private System.Windows.Forms.TextBox AddTeacherTextBox;
        private System.Windows.Forms.Button DeleteTeacherButton;
        private System.Windows.Forms.Button EditTeacherButton;
        private System.Windows.Forms.Button AddTeacherButton;
        private System.Windows.Forms.Label TeacherAddLabel;
        private System.Windows.Forms.TextBox EditTeacherTextBox;
        private System.Windows.Forms.Label EditTeacherLabel2;
        private System.Windows.Forms.Label EditGroupLabel2;
        private System.Windows.Forms.TextBox EditGroupTextBox;
        private System.Windows.Forms.Label EditGroupLabel1;
        private System.Windows.Forms.ComboBox EditGroupComboBox;
        private System.Windows.Forms.Label DeleteGroupLabel;
        private System.Windows.Forms.ComboBox DeleteGroupComboBox;
        private System.Windows.Forms.TextBox AddGroupTextBox;
        private System.Windows.Forms.Button DeleteGroupButton;
        private System.Windows.Forms.Button EditGroupButton;
        private System.Windows.Forms.Button AddGroupButton;
        private System.Windows.Forms.Label AddGroupLabel;
        private System.Windows.Forms.ToolStripMenuItem работаСБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
    }
}