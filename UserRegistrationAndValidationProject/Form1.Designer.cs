namespace UserRegistrationAndValidationProject
{
    partial class Form1
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
            this.Control_Bar = new System.Windows.Forms.Panel();
            this.MinimisePictureBox = new System.Windows.Forms.PictureBox();
            this.ExitPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginSignupPanel = new System.Windows.Forms.Panel();
            this.ImportButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.UsageButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.InfoErrorLabel = new System.Windows.Forms.Label();
            this.UsernameLoginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordLoginTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SignupPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RedoPasswordSignUpTextBox = new System.Windows.Forms.TextBox();
            this.PasswordSignUpTextBox = new System.Windows.Forms.TextBox();
            this.UsernameSignUpTextBox = new System.Windows.Forms.TextBox();
            this.ImportFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ImportBackGroundWorker = new System.ComponentModel.BackgroundWorker();
            this.Control_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimisePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            this.LoginSignupPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.SignupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Control_Bar
            // 
            this.Control_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Control_Bar.Controls.Add(this.MinimisePictureBox);
            this.Control_Bar.Controls.Add(this.ExitPictureBox);
            this.Control_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Control_Bar.Location = new System.Drawing.Point(0, 0);
            this.Control_Bar.Name = "Control_Bar";
            this.Control_Bar.Size = new System.Drawing.Size(700, 32);
            this.Control_Bar.TabIndex = 1;
            this.Control_Bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_Bar_MouseMove);
            // 
            // MinimisePictureBox
            // 
            this.MinimisePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimisePictureBox.Image = global::UserRegistrationAndValidationProject.Properties.Resources._;
            this.MinimisePictureBox.Location = new System.Drawing.Point(636, 0);
            this.MinimisePictureBox.Name = "MinimisePictureBox";
            this.MinimisePictureBox.Size = new System.Drawing.Size(32, 32);
            this.MinimisePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MinimisePictureBox.TabIndex = 3;
            this.MinimisePictureBox.TabStop = false;
            this.MinimisePictureBox.Click += new System.EventHandler(this.MinimisePictureBox_Click);
            this.MinimisePictureBox.MouseLeave += new System.EventHandler(this.MinimisePictureBox_MouseLeave);
            this.MinimisePictureBox.MouseHover += new System.EventHandler(this.MinimisePictureBox_MouseHover);
            // 
            // ExitPictureBox
            // 
            this.ExitPictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitPictureBox.Image = global::UserRegistrationAndValidationProject.Properties.Resources.x;
            this.ExitPictureBox.Location = new System.Drawing.Point(668, 0);
            this.ExitPictureBox.Name = "ExitPictureBox";
            this.ExitPictureBox.Size = new System.Drawing.Size(32, 32);
            this.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ExitPictureBox.TabIndex = 3;
            this.ExitPictureBox.TabStop = false;
            this.ExitPictureBox.Click += new System.EventHandler(this.ExitBox_Click);
            this.ExitPictureBox.MouseLeave += new System.EventHandler(this.ExitBox_MouseLeave);
            this.ExitPictureBox.MouseHover += new System.EventHandler(this.ExitBox_MouseHover);
            // 
            // LoginSignupPanel
            // 
            this.LoginSignupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LoginSignupPanel.Controls.Add(this.ImportButton);
            this.LoginSignupPanel.Controls.Add(this.DoneButton);
            this.LoginSignupPanel.Controls.Add(this.UsageButton);
            this.LoginSignupPanel.Controls.Add(this.SignUpButton);
            this.LoginSignupPanel.Controls.Add(this.LoginButton);
            this.LoginSignupPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoginSignupPanel.Location = new System.Drawing.Point(0, 32);
            this.LoginSignupPanel.Name = "LoginSignupPanel";
            this.LoginSignupPanel.Size = new System.Drawing.Size(200, 368);
            this.LoginSignupPanel.TabIndex = 2;
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(12, 326);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(80, 30);
            this.ImportButton.TabIndex = 2;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(114, 326);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(80, 30);
            this.DoneButton.TabIndex = 1;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // UsageButton
            // 
            this.UsageButton.Location = new System.Drawing.Point(60, 210);
            this.UsageButton.Name = "UsageButton";
            this.UsageButton.Size = new System.Drawing.Size(80, 30);
            this.UsageButton.TabIndex = 1;
            this.UsageButton.Text = "Usage";
            this.UsageButton.UseVisualStyleBackColor = true;
            this.UsageButton.Click += new System.EventHandler(this.UsageButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(60, 140);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(80, 30);
            this.SignUpButton.TabIndex = 1;
            this.SignUpButton.Text = "SignUp";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(60, 70);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(80, 30);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.InfoPanel.Controls.Add(this.InfoErrorLabel);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoPanel.Location = new System.Drawing.Point(200, 330);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(500, 70);
            this.InfoPanel.TabIndex = 3;
            // 
            // InfoErrorLabel
            // 
            this.InfoErrorLabel.AutoSize = true;
            this.InfoErrorLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.InfoErrorLabel.Location = new System.Drawing.Point(10, 15);
            this.InfoErrorLabel.Name = "InfoErrorLabel";
            this.InfoErrorLabel.Size = new System.Drawing.Size(37, 20);
            this.InfoErrorLabel.TabIndex = 0;
            this.InfoErrorLabel.Text = "Info";
            this.InfoErrorLabel.Visible = false;
            // 
            // UsernameLoginTextBox
            // 
            this.UsernameLoginTextBox.Location = new System.Drawing.Point(371, 106);
            this.UsernameLoginTextBox.Name = "UsernameLoginTextBox";
            this.UsernameLoginTextBox.Size = new System.Drawing.Size(179, 26);
            this.UsernameLoginTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(278, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username:";
            // 
            // PasswordLoginTextBox
            // 
            this.PasswordLoginTextBox.Location = new System.Drawing.Point(371, 179);
            this.PasswordLoginTextBox.Name = "PasswordLoginTextBox";
            this.PasswordLoginTextBox.Size = new System.Drawing.Size(179, 26);
            this.PasswordLoginTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(278, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // SignupPanel
            // 
            this.SignupPanel.Controls.Add(this.label5);
            this.SignupPanel.Controls.Add(this.label3);
            this.SignupPanel.Controls.Add(this.label4);
            this.SignupPanel.Controls.Add(this.RedoPasswordSignUpTextBox);
            this.SignupPanel.Controls.Add(this.PasswordSignUpTextBox);
            this.SignupPanel.Controls.Add(this.UsernameSignUpTextBox);
            this.SignupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignupPanel.Location = new System.Drawing.Point(200, 32);
            this.SignupPanel.Name = "SignupPanel";
            this.SignupPanel.Size = new System.Drawing.Size(500, 298);
            this.SignupPanel.TabIndex = 7;
            this.SignupPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(35, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Redo Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(78, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(78, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Username:";
            // 
            // RedoPasswordSignUpTextBox
            // 
            this.RedoPasswordSignUpTextBox.Location = new System.Drawing.Point(171, 212);
            this.RedoPasswordSignUpTextBox.Name = "RedoPasswordSignUpTextBox";
            this.RedoPasswordSignUpTextBox.Size = new System.Drawing.Size(179, 26);
            this.RedoPasswordSignUpTextBox.TabIndex = 7;
            // 
            // PasswordSignUpTextBox
            // 
            this.PasswordSignUpTextBox.Location = new System.Drawing.Point(171, 150);
            this.PasswordSignUpTextBox.Name = "PasswordSignUpTextBox";
            this.PasswordSignUpTextBox.Size = new System.Drawing.Size(179, 26);
            this.PasswordSignUpTextBox.TabIndex = 7;
            // 
            // UsernameSignUpTextBox
            // 
            this.UsernameSignUpTextBox.Location = new System.Drawing.Point(171, 77);
            this.UsernameSignUpTextBox.Name = "UsernameSignUpTextBox";
            this.UsernameSignUpTextBox.Size = new System.Drawing.Size(179, 26);
            this.UsernameSignUpTextBox.TabIndex = 8;
            // 
            // ImportFileDialog
            // 
            this.ImportFileDialog.FileName = "openFileDialog1";
            // 
            // ImportBackGroundWorker
            // 
            this.ImportBackGroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ImportBackGroundWorker_DoWork);
            this.ImportBackGroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ImportBackGroundWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.SignupPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordLoginTextBox);
            this.Controls.Add(this.UsernameLoginTextBox);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.LoginSignupPanel);
            this.Controls.Add(this.Control_Bar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Control_Bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimisePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            this.LoginSignupPanel.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.SignupPanel.ResumeLayout(false);
            this.SignupPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Control_Bar;
        private System.Windows.Forms.PictureBox MinimisePictureBox;
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.Panel LoginSignupPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button UsageButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label InfoErrorLabel;
        private System.Windows.Forms.TextBox UsernameLoginTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordLoginTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel SignupPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RedoPasswordSignUpTextBox;
        private System.Windows.Forms.TextBox PasswordSignUpTextBox;
        private System.Windows.Forms.TextBox UsernameSignUpTextBox;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.OpenFileDialog ImportFileDialog;
        private System.ComponentModel.BackgroundWorker ImportBackGroundWorker;
    }
}

