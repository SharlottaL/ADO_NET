namespace Academy
{
    partial class MainForm
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.comboBoxStudentsDirections = new System.Windows.Forms.ComboBox();
            this.labelDirections = new System.Windows.Forms.Label();
            this.labelGroups = new System.Windows.Forms.Label();
            this.comboBoxStudentsGroups = new System.Windows.Forms.ComboBox();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.buttonAddGroups = new System.Windows.Forms.Button();
            this.comboBoxGroupsDirections = new System.Windows.Forms.ComboBox();
            this.labelGroupsDirections = new System.Windows.Forms.Label();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.tabPageDirections = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridViewDirections = new System.Windows.Forms.DataGridView();
            this.tabPageDisciplines = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDirections = new System.Windows.Forms.ComboBox();
            this.dataGridViewDisciplines = new System.Windows.Forms.DataGridView();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.tabPageGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            this.tabPageDirections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirections)).BeginInit();
            this.tabPageDisciplines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplines)).BeginInit();
            this.tabPageTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageStudents);
            this.tabControl.Controls.Add(this.tabPageGroups);
            this.tabControl.Controls.Add(this.tabPageDirections);
            this.tabControl.Controls.Add(this.tabPageDisciplines);
            this.tabControl.Controls.Add(this.tabPageTeachers);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 428);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.buttonAddStudent);
            this.tabPageStudents.Controls.Add(this.comboBoxStudentsDirections);
            this.tabPageStudents.Controls.Add(this.labelDirections);
            this.tabPageStudents.Controls.Add(this.labelGroups);
            this.tabPageStudents.Controls.Add(this.comboBoxStudentsGroups);
            this.tabPageStudents.Controls.Add(this.dataGridViewStudents);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(792, 402);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Students";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(709, 3);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(75, 23);
            this.buttonAddStudent.TabIndex = 6;
            this.buttonAddStudent.Text = "Add";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // comboBoxStudentsDirections
            // 
            this.comboBoxStudentsDirections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudentsDirections.FormattingEnabled = true;
            this.comboBoxStudentsDirections.Location = new System.Drawing.Point(459, 5);
            this.comboBoxStudentsDirections.Name = "comboBoxStudentsDirections";
            this.comboBoxStudentsDirections.Size = new System.Drawing.Size(218, 21);
            this.comboBoxStudentsDirections.TabIndex = 4;
            this.comboBoxStudentsDirections.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentsDirection_SelectedIndexChanged);
            // 
            // labelDirections
            // 
            this.labelDirections.AutoSize = true;
            this.labelDirections.Location = new System.Drawing.Point(312, 8);
            this.labelDirections.Name = "labelDirections";
            this.labelDirections.Size = new System.Drawing.Size(141, 13);
            this.labelDirections.TabIndex = 3;
            this.labelDirections.Text = "По направлению обучения";
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Location = new System.Drawing.Point(26, 7);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(123, 13);
            this.labelGroups.TabIndex = 2;
            this.labelGroups.Text = "Фильтрация по группе";
            // 
            // comboBoxStudentsGroups
            // 
            this.comboBoxStudentsGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudentsGroups.FormattingEnabled = true;
            this.comboBoxStudentsGroups.Location = new System.Drawing.Point(155, 5);
            this.comboBoxStudentsGroups.Name = "comboBoxStudentsGroups";
            this.comboBoxStudentsGroups.Size = new System.Drawing.Size(132, 21);
            this.comboBoxStudentsGroups.TabIndex = 5;
            this.comboBoxStudentsGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentsGroup_SelectedIndexChanged);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(3, 29);
            this.dataGridViewStudents.MultiSelect = false;
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(786, 370);
            this.dataGridViewStudents.TabIndex = 0;
            this.dataGridViewStudents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewStudents_MouseDoubleClick);
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Controls.Add(this.buttonAddGroups);
            this.tabPageGroups.Controls.Add(this.comboBoxGroupsDirections);
            this.tabPageGroups.Controls.Add(this.labelGroupsDirections);
            this.tabPageGroups.Controls.Add(this.dataGridViewGroups);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(792, 402);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Groups";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // buttonAddGroups
            // 
            this.buttonAddGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddGroups.Location = new System.Drawing.Point(655, 373);
            this.buttonAddGroups.Name = "buttonAddGroups";
            this.buttonAddGroups.Size = new System.Drawing.Size(120, 23);
            this.buttonAddGroups.TabIndex = 3;
            this.buttonAddGroups.Text = "Добавить/изменить";
            this.buttonAddGroups.UseVisualStyleBackColor = true;
            this.buttonAddGroups.Click += new System.EventHandler(this.buttonAddGroups_Click);
            // 
            // comboBoxGroupsDirections
            // 
            this.comboBoxGroupsDirections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroupsDirections.FormattingEnabled = true;
            this.comboBoxGroupsDirections.Location = new System.Drawing.Point(136, 9);
            this.comboBoxGroupsDirections.Name = "comboBoxGroupsDirections";
            this.comboBoxGroupsDirections.Size = new System.Drawing.Size(273, 21);
            this.comboBoxGroupsDirections.TabIndex = 2;
            this.comboBoxGroupsDirections.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroupsDirections_SelectedIndexChanged);
            // 
            // labelGroupsDirections
            // 
            this.labelGroupsDirections.AutoSize = true;
            this.labelGroupsDirections.Location = new System.Drawing.Point(10, 12);
            this.labelGroupsDirections.Name = "labelGroupsDirections";
            this.labelGroupsDirections.Size = new System.Drawing.Size(121, 13);
            this.labelGroupsDirections.TabIndex = 1;
            this.labelGroupsDirections.Text = "Напрвление обучения:";
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Location = new System.Drawing.Point(3, 36);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.Size = new System.Drawing.Size(786, 363);
            this.dataGridViewGroups.TabIndex = 0;
            // 
            // tabPageDirections
            // 
            this.tabPageDirections.Controls.Add(this.checkBox1);
            this.tabPageDirections.Controls.Add(this.dataGridViewDirections);
            this.tabPageDirections.Location = new System.Drawing.Point(4, 22);
            this.tabPageDirections.Name = "tabPageDirections";
            this.tabPageDirections.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDirections.Size = new System.Drawing.Size(792, 402);
            this.tabPageDirections.TabIndex = 2;
            this.tabPageDirections.Text = "Directions";
            this.tabPageDirections.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(601, 379);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(183, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Показать пустые направления";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridViewDirections
            // 
            this.dataGridViewDirections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDirections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDirections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDirections.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDirections.Name = "dataGridViewDirections";
            this.dataGridViewDirections.Size = new System.Drawing.Size(786, 396);
            this.dataGridViewDirections.TabIndex = 0;
            // 
            // tabPageDisciplines
            // 
            this.tabPageDisciplines.Controls.Add(this.label1);
            this.tabPageDisciplines.Controls.Add(this.comboBoxDirections);
            this.tabPageDisciplines.Controls.Add(this.dataGridViewDisciplines);
            this.tabPageDisciplines.Location = new System.Drawing.Point(4, 22);
            this.tabPageDisciplines.Name = "tabPageDisciplines";
            this.tabPageDisciplines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDisciplines.Size = new System.Drawing.Size(792, 402);
            this.tabPageDisciplines.TabIndex = 3;
            this.tabPageDisciplines.Text = "Disciplines";
            this.tabPageDisciplines.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Напрвление обучения:";
            // 
            // comboBoxDirections
            // 
            this.comboBoxDirections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDirections.FormattingEnabled = true;
            this.comboBoxDirections.Location = new System.Drawing.Point(447, 13);
            this.comboBoxDirections.Name = "comboBoxDirections";
            this.comboBoxDirections.Size = new System.Drawing.Size(273, 21);
            this.comboBoxDirections.TabIndex = 3;
            this.comboBoxDirections.SelectedIndexChanged += new System.EventHandler(this.comboBoxDirections_SelectedIndexChanged);
            // 
            // dataGridViewDisciplines
            // 
            this.dataGridViewDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDisciplines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisciplines.Location = new System.Drawing.Point(0, 40);
            this.dataGridViewDisciplines.Name = "dataGridViewDisciplines";
            this.dataGridViewDisciplines.Size = new System.Drawing.Size(789, 359);
            this.dataGridViewDisciplines.TabIndex = 0;
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.Controls.Add(this.buttonAdd);
            this.tabPageTeachers.Controls.Add(this.dataGridViewTeachers);
            this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeachers.Size = new System.Drawing.Size(792, 402);
            this.tabPageTeachers.TabIndex = 4;
            this.tabPageTeachers.Text = "Teachers";
            this.tabPageTeachers.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(709, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewTeachers
            // 
            this.dataGridViewTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeachers.Location = new System.Drawing.Point(0, 43);
            this.dataGridViewTeachers.Name = "dataGridViewTeachers";
            this.dataGridViewTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTeachers.Size = new System.Drawing.Size(789, 356);
            this.dataGridViewTeachers.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Name = "MainForm";
            this.Text = "Academy PD_411";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.tabPageGroups.ResumeLayout(false);
            this.tabPageGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            this.tabPageDirections.ResumeLayout(false);
            this.tabPageDirections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirections)).EndInit();
            this.tabPageDisciplines.ResumeLayout(false);
            this.tabPageDisciplines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplines)).EndInit();
            this.tabPageTeachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.TabPage tabPageDirections;
        private System.Windows.Forms.TabPage tabPageDisciplines;
        private System.Windows.Forms.TabPage tabPageTeachers;
        private System.Windows.Forms.DataGridView dataGridViewDirections;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.ComboBox comboBoxGroupsDirections;
        private System.Windows.Forms.Label labelGroupsDirections;
        private System.Windows.Forms.ComboBox comboBoxStudentsDirections;
        private System.Windows.Forms.Label labelDirections;
        private System.Windows.Forms.Label labelGroups;
        private System.Windows.Forms.ComboBox comboBoxStudentsGroups;
        private System.Windows.Forms.DataGridView dataGridViewDisciplines;
        private System.Windows.Forms.DataGridView dataGridViewTeachers;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonAddGroups;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDirections;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
    }
}

