namespace DataSet
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
            this.comboBoxStudentsGroups = new System.Windows.Forms.ComboBox();
            this.comboBoxStudentsDirections = new System.Windows.Forms.ComboBox();
            this.labelGroups = new System.Windows.Forms.Label();
            this.labelDirections = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPageDisciplines = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.comboBoxDisciplinesForDirection = new System.Windows.Forms.ComboBox();
            this.dataGridViewDisciplines = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageDisciplines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplines)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxStudentsGroups
            // 
            this.comboBoxStudentsGroups.Location = new System.Drawing.Point(126, 3);
            this.comboBoxStudentsGroups.Name = "comboBoxStudentsGroups";
            this.comboBoxStudentsGroups.Size = new System.Drawing.Size(221, 21);
            this.comboBoxStudentsGroups.TabIndex = 5;
            // 
            // comboBoxStudentsDirections
            // 
            this.comboBoxStudentsDirections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudentsDirections.FormattingEnabled = true;
            this.comboBoxStudentsDirections.Location = new System.Drawing.Point(517, 3);
            this.comboBoxStudentsDirections.Name = "comboBoxStudentsDirections";
            this.comboBoxStudentsDirections.Size = new System.Drawing.Size(224, 21);
            this.comboBoxStudentsDirections.TabIndex = 1;
            this.comboBoxStudentsDirections.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentsDirection_SelectedIndexChanged);
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Location = new System.Drawing.Point(3, 6);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(123, 13);
            this.labelGroups.TabIndex = 3;
            this.labelGroups.Text = "Фильтрация по группе";
            // 
            // labelDirections
            // 
            this.labelDirections.AutoSize = true;
            this.labelDirections.Location = new System.Drawing.Point(370, 6);
            this.labelDirections.Name = "labelDirections";
            this.labelDirections.Size = new System.Drawing.Size(141, 13);
            this.labelDirections.TabIndex = 4;
            this.labelDirections.Text = "По направлению обучения";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPageDisciplines);
            this.tabControl.Location = new System.Drawing.Point(15, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(773, 380);
            this.tabControl.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxStudentsGroups);
            this.tabPage1.Controls.Add(this.comboBoxStudentsDirections);
            this.tabPage1.Controls.Add(this.labelDirections);
            this.tabPage1.Controls.Add(this.labelGroups);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(765, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(765, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(765, 354);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPageDisciplines
            // 
            this.tabPageDisciplines.Controls.Add(this.dataGridViewDisciplines);
            this.tabPageDisciplines.Controls.Add(this.comboBoxDisciplinesForDirection);
            this.tabPageDisciplines.Location = new System.Drawing.Point(4, 22);
            this.tabPageDisciplines.Name = "tabPageDisciplines";
            this.tabPageDisciplines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDisciplines.Size = new System.Drawing.Size(765, 354);
            this.tabPageDisciplines.TabIndex = 3;
            this.tabPageDisciplines.Text = "Disciplines";
            this.tabPageDisciplines.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // comboBoxDisciplinesForDirection
            // 
            this.comboBoxDisciplinesForDirection.FormattingEnabled = true;
            this.comboBoxDisciplinesForDirection.Location = new System.Drawing.Point(292, 6);
            this.comboBoxDisciplinesForDirection.Name = "comboBoxDisciplinesForDirection";
            this.comboBoxDisciplinesForDirection.Size = new System.Drawing.Size(354, 21);
            this.comboBoxDisciplinesForDirection.TabIndex = 0;
            this.comboBoxDisciplinesForDirection.SelectedIndexChanged += new System.EventHandler(this.comboBoxDisciplinesForDirection_SelectedIndexChanged);
            // 
            // dataGridViewDisciplines
            // 
            this.dataGridViewDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisciplines.Location = new System.Drawing.Point(0, 33);
            this.dataGridViewDisciplines.Name = "dataGridViewDisciplines";
            this.dataGridViewDisciplines.Size = new System.Drawing.Size(765, 321);
            this.dataGridViewDisciplines.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageDisciplines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStudentsGroups;
        private System.Windows.Forms.ComboBox comboBoxStudentsDirections;
        private System.Windows.Forms.Label labelGroups;
        private System.Windows.Forms.Label labelDirections;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPageDisciplines;
        private System.Windows.Forms.DataGridView dataGridViewDisciplines;
        private System.Windows.Forms.ComboBox comboBoxDisciplinesForDirection;
    }
}

