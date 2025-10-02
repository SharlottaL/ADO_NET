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
            this.SuspendLayout();
            // 
            // comboBoxStudentsGroups
            // 
            //this.comboBoxStudentsGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            //this.comboBoxStudentsGroups.FormattingEnabled = true;
            //this.comboBoxStudentsGroups.Location = new System.Drawing.Point(153, 12);
            //this.comboBoxStudentsGroups.Name = "comboBoxStudentsGroups";
            //this.comboBoxStudentsGroups.Size = new System.Drawing.Size(217, 21);
            //this.comboBoxStudentsGroups.TabIndex = 0;
      //      this.comboBoxStudentsGroups.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxStudentsDirections
            // 
            this.comboBoxStudentsDirections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudentsDirections.FormattingEnabled = true;
            this.comboBoxStudentsDirections.Location = new System.Drawing.Point(527, 12);
            this.comboBoxStudentsDirections.Name = "comboBoxStudentsDirections";
            this.comboBoxStudentsDirections.Size = new System.Drawing.Size(224, 21);
            this.comboBoxStudentsDirections.TabIndex = 1;
            this.comboBoxStudentsDirections.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentsDirections_SelectedIndexChanged);
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Location = new System.Drawing.Point(12, 12);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(123, 13);
            this.labelGroups.TabIndex = 3;
            this.labelGroups.Text = "Фильтрация по группе";
            // 
            // labelDirections
            // 
            this.labelDirections.AutoSize = true;
            this.labelDirections.Location = new System.Drawing.Point(380, 12);
            this.labelDirections.Name = "labelDirections";
            this.labelDirections.Size = new System.Drawing.Size(141, 13);
            this.labelDirections.TabIndex = 4;
            this.labelDirections.Text = "По направлению обучения";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDirections);
            this.Controls.Add(this.labelGroups);
            this.Controls.Add(this.comboBoxStudentsDirections);
            this.Controls.Add(this.comboBoxStudentsGroups);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStudentsGroups;
        private System.Windows.Forms.ComboBox comboBoxStudentsDirections;
        private System.Windows.Forms.Label labelGroups;
        private System.Windows.Forms.Label labelDirections;
    }
}

