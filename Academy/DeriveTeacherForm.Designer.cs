namespace Academy
{
    partial class DeriveTeacherForm
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
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.dateTimePickerWorkSince = new System.Windows.Forms.DateTimePicker();
            this.labelWorkSince = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.Location = new System.Drawing.Point(12, 392);
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(127, 342);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(161, 20);
            this.textBoxRate.TabIndex = 41;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(69, 342);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(43, 13);
            this.labelRate.TabIndex = 40;
            this.labelRate.Text = "Ставка";
            // 
            // dateTimePickerWorkSince
            // 
            this.dateTimePickerWorkSince.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerWorkSince.Location = new System.Drawing.Point(127, 303);
            this.dateTimePickerWorkSince.Name = "dateTimePickerWorkSince";
            this.dateTimePickerWorkSince.Size = new System.Drawing.Size(161, 20);
            this.dateTimePickerWorkSince.TabIndex = 39;
            // 
            // labelWorkSince
            // 
            this.labelWorkSince.AutoSize = true;
            this.labelWorkSince.Location = new System.Drawing.Point(0, 302);
            this.labelWorkSince.Name = "labelWorkSince";
            this.labelWorkSince.Size = new System.Drawing.Size(111, 13);
            this.labelWorkSince.TabIndex = 38;
            this.labelWorkSince.Text = "Дата начала работы";
            // 
            // DeriveTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(644, 425);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.dateTimePickerWorkSince);
            this.Controls.Add(this.labelWorkSince);
            this.Name = "DeriveTeacherForm";
            this.Text = "DeriveTeacherForm";
            this.Controls.SetChildIndex(this.labelLastName, 0);
            this.Controls.SetChildIndex(this.labelFirstName, 0);
            this.Controls.SetChildIndex(this.labelMiddlName, 0);
            this.Controls.SetChildIndex(this.labelBirthDate, 0);
            this.Controls.SetChildIndex(this.labelEmail, 0);
            this.Controls.SetChildIndex(this.labelPhone, 0);
            this.Controls.SetChildIndex(this.textBoxLastName, 0);
            this.Controls.SetChildIndex(this.textBoxFirstName, 0);
            this.Controls.SetChildIndex(this.textBoxMiddleName, 0);
            this.Controls.SetChildIndex(this.dateTimePickerBirthDate, 0);
            this.Controls.SetChildIndex(this.textBoxEmail, 0);
            this.Controls.SetChildIndex(this.textBoxPhone, 0);
            this.Controls.SetChildIndex(this.pictureBoxPhoto, 0);
            this.Controls.SetChildIndex(this.buttonOboz, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonOK, 0);
            this.Controls.SetChildIndex(this.labelID, 0);
            this.Controls.SetChildIndex(this.labelWorkSince, 0);
            this.Controls.SetChildIndex(this.dateTimePickerWorkSince, 0);
            this.Controls.SetChildIndex(this.labelRate, 0);
            this.Controls.SetChildIndex(this.textBoxRate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.DateTimePicker dateTimePickerWorkSince;
        private System.Windows.Forms.Label labelWorkSince;
    }
}