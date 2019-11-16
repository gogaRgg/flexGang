namespace SqlServerTestApp
{
    partial class DBConnectionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dbNameBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.userpassBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.serverBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Database name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "User password";
            // 
            // dbNameBox
            // 
            this.dbNameBox.Location = new System.Drawing.Point(145, 74);
            this.dbNameBox.Name = "dbNameBox";
            this.dbNameBox.Size = new System.Drawing.Size(186, 20);
            this.dbNameBox.TabIndex = 2;
            this.dbNameBox.Text = "Кулиминов";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(145, 104);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(186, 20);
            this.usernameBox.TabIndex = 3;
            this.usernameBox.Text = "aminkul";
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // userpassBox
            // 
            this.userpassBox.Location = new System.Drawing.Point(145, 136);
            this.userpassBox.Name = "userpassBox";
            this.userpassBox.PasswordChar = '*';
            this.userpassBox.Size = new System.Drawing.Size(186, 20);
            this.userpassBox.TabIndex = 4;
            this.userpassBox.Text = "igorigorigor";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(163, 186);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(132, 35);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connect!";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // serverBox
            // 
            this.serverBox.Location = new System.Drawing.Point(145, 45);
            this.serverBox.Name = "serverBox";
            this.serverBox.Size = new System.Drawing.Size(186, 20);
            this.serverBox.TabIndex = 1;
            this.serverBox.Text = ".\\sqlexpress";
            this.serverBox.TextChanged += new System.EventHandler(this.serverBox_TextChanged);
            // 
            // DBConnectionForm
            // 
            this.AcceptButton = this.connectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 260);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.userpassBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.serverBox);
            this.Controls.Add(this.dbNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DBConnectionForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DBConnectionForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DBConnectionForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dbNameBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox userpassBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox serverBox;
    }
}