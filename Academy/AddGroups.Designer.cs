namespace Academy
{
    partial class AddGroups
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
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.comboBoxAddDirections = new System.Windows.Forms.ComboBox();
            this.checkedListBoxLearningDays = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkedListBoxTime = new System.Windows.Forms.CheckedListBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Location = new System.Drawing.Point(155, 9);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(121, 20);
            this.textBoxGroupName.TabIndex = 0;
            this.textBoxGroupName.TextChanged += new System.EventHandler(this.textBoxGroupName_TextChanged);
            // 
            // comboBoxAddDirections
            // 
            this.comboBoxAddDirections.FormattingEnabled = true;
            this.comboBoxAddDirections.Location = new System.Drawing.Point(155, 38);
            this.comboBoxAddDirections.Name = "comboBoxAddDirections";
            this.comboBoxAddDirections.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAddDirections.TabIndex = 1;
            // 
            // checkedListBoxLearningDays
            // 
            this.checkedListBoxLearningDays.CheckOnClick = true;
            this.checkedListBoxLearningDays.FormattingEnabled = true;
            this.checkedListBoxLearningDays.Location = new System.Drawing.Point(155, 90);
            this.checkedListBoxLearningDays.MultiColumn = true;
            this.checkedListBoxLearningDays.Name = "checkedListBoxLearningDays";
            this.checkedListBoxLearningDays.Size = new System.Drawing.Size(120, 109);
            this.checkedListBoxLearningDays.TabIndex = 3;
            this.checkedListBoxLearningDays.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxGroups_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите название группы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите направление";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Выберите учебные дни";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выберите время ";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(129, 323);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBoxTime
            // 
            this.checkedListBoxTime.CheckOnClick = true;
            this.checkedListBoxTime.FormattingEnabled = true;
            this.checkedListBoxTime.Location = new System.Drawing.Point(156, 223);
            this.checkedListBoxTime.MultiColumn = true;
            this.checkedListBoxTime.Name = "checkedListBoxTime";
            this.checkedListBoxTime.Size = new System.Drawing.Size(120, 79);
            this.checkedListBoxTime.TabIndex = 9;
            this.checkedListBoxTime.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxTime_ItemCheck);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(210, 323);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // AddGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 358);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.checkedListBoxTime);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxLearningDays);
            this.Controls.Add(this.comboBoxAddDirections);
            this.Controls.Add(this.textBoxGroupName);
            this.Name = "AddGroups";
            this.Text = "AddGroups";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.ComboBox comboBoxAddDirections;
        private System.Windows.Forms.CheckedListBox checkedListBoxLearningDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckedListBox checkedListBoxTime;
        private System.Windows.Forms.Button buttonExit;
    }
}