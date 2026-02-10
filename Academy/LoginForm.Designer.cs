namespace Academy
{
    partial class LoginForm
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
            this.button = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.comboBoxDataBase = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Brown;
            this.button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button.Location = new System.Drawing.Point(145, 224);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(92, 23);
            this.button.TabIndex = 1;
            this.button.Text = "Вход";
            this.button.UseVisualStyleBackColor = false;
            //this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxLogin.Location = new System.Drawing.Point(89, 134);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(205, 26);
            this.textBoxLogin.TabIndex = 4;
            this.textBoxLogin.Text = "Логин";
            this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxPassword.Location = new System.Drawing.Point(89, 181);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(205, 26);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.Text = "Пароль";
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(100, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль забыть нельзя!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 309);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBoxServer);
            this.panel2.Controls.Add(this.comboBoxDataBase);
            this.panel2.Controls.Add(this.textBoxPassword);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxLogin);
            this.panel2.Controls.Add(this.button);
            this.panel2.Location = new System.Drawing.Point(9, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 289);
            this.panel2.TabIndex = 7;
            // 
            // textBoxServer
            // 
            this.textBoxServer.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxServer.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxServer.Location = new System.Drawing.Point(89, 39);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(205, 26);
            this.textBoxServer.TabIndex = 8;
            this.textBoxServer.Text = "Сервер";
            this.textBoxServer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxServer_KeyPress);
            this.textBoxServer.Leave += new System.EventHandler(this.textBoxServer_Leave);
            // 
            // comboBoxDataBase
            // 
            this.comboBoxDataBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBase.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDataBase.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxDataBase.FormattingEnabled = true;
            this.comboBoxDataBase.Location = new System.Drawing.Point(89, 87);
            this.comboBoxDataBase.Name = "comboBoxDataBase";
            this.comboBoxDataBase.Size = new System.Drawing.Size(205, 26);
            this.comboBoxDataBase.TabIndex = 7;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 308);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.ComboBox comboBoxDataBase;
    }
}