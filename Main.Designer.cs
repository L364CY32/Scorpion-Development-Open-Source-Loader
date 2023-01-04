namespace KeyAuth
{
    public partial class Main : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.siticoneCirclePictureBox2 = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SpooferButton = new Guna.UI2.WinForms.Guna2Button();
            this.CleanerButton = new Guna.UI2.WinForms.Guna2Button();
            this.CheatButton = new Guna.UI2.WinForms.Guna2Button();
            this.DiscordButton = new Guna.UI2.WinForms.Guna2Button();
            this.HomeButton = new Guna.UI2.WinForms.Guna2Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.HomeForm = new Guna.UI2.WinForms.Guna2Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.siticoneControlBox9 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox10 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.HomeForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // siticoneCirclePictureBox2
            // 
            this.siticoneCirclePictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("siticoneCirclePictureBox2.ErrorImage")));
            this.siticoneCirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("siticoneCirclePictureBox2.Image")));
            this.siticoneCirclePictureBox2.ImageRotate = 0F;
            this.siticoneCirclePictureBox2.Location = new System.Drawing.Point(21, 13);
            this.siticoneCirclePictureBox2.Name = "siticoneCirclePictureBox2";
            this.siticoneCirclePictureBox2.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox2.Size = new System.Drawing.Size(43, 40);
            this.siticoneCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticoneCirclePictureBox2.TabIndex = 65;
            this.siticoneCirclePictureBox2.TabStop = false;
            this.siticoneCirclePictureBox2.Click += new System.EventHandler(this.siticoneCirclePictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.SpooferButton);
            this.panel1.Controls.Add(this.CleanerButton);
            this.panel1.Controls.Add(this.CheatButton);
            this.panel1.Controls.Add(this.DiscordButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Controls.Add(this.siticoneCirclePictureBox2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 482);
            this.panel1.TabIndex = 66;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // SpooferButton
            // 
            this.SpooferButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SpooferButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SpooferButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SpooferButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SpooferButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.SpooferButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SpooferButton.ForeColor = System.Drawing.Color.White;
            this.SpooferButton.Location = new System.Drawing.Point(7, 285);
            this.SpooferButton.Name = "SpooferButton";
            this.SpooferButton.Size = new System.Drawing.Size(78, 41);
            this.SpooferButton.TabIndex = 70;
            this.SpooferButton.Text = "Spoofers";
            this.SpooferButton.Click += new System.EventHandler(this.SpooferButton_Click);
            // 
            // CleanerButton
            // 
            this.CleanerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CleanerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CleanerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CleanerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CleanerButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.CleanerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CleanerButton.ForeColor = System.Drawing.Color.White;
            this.CleanerButton.Location = new System.Drawing.Point(7, 220);
            this.CleanerButton.Name = "CleanerButton";
            this.CleanerButton.Size = new System.Drawing.Size(78, 41);
            this.CleanerButton.TabIndex = 69;
            this.CleanerButton.Text = "Cleaners";
            this.CleanerButton.Click += new System.EventHandler(this.CleanerButton_Click);
            // 
            // CheatButton
            // 
            this.CheatButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CheatButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CheatButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CheatButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CheatButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.CheatButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheatButton.ForeColor = System.Drawing.Color.White;
            this.CheatButton.Location = new System.Drawing.Point(7, 154);
            this.CheatButton.Name = "CheatButton";
            this.CheatButton.Size = new System.Drawing.Size(78, 41);
            this.CheatButton.TabIndex = 68;
            this.CheatButton.Text = "Cheats";
            this.CheatButton.Click += new System.EventHandler(this.CheatsButton_Click);
            // 
            // DiscordButton
            // 
            this.DiscordButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DiscordButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DiscordButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DiscordButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DiscordButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.DiscordButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DiscordButton.ForeColor = System.Drawing.Color.White;
            this.DiscordButton.Location = new System.Drawing.Point(7, 350);
            this.DiscordButton.Name = "DiscordButton";
            this.DiscordButton.Size = new System.Drawing.Size(78, 41);
            this.DiscordButton.TabIndex = 67;
            this.DiscordButton.Text = "Discord";
            this.DiscordButton.Click += new System.EventHandler(this.DiscordButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HomeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HomeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HomeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(7, 91);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(78, 41);
            this.HomeButton.TabIndex = 66;
            this.HomeButton.Text = "Home";
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // HomeForm
            // 
            this.HomeForm.BackColor = System.Drawing.Color.Black;
            this.HomeForm.Controls.Add(this.label13);
            this.HomeForm.Controls.Add(this.label9);
            this.HomeForm.Controls.Add(this.siticoneControlBox9);
            this.HomeForm.Controls.Add(this.siticoneControlBox10);
            this.HomeForm.Controls.Add(this.label2);
            this.HomeForm.Controls.Add(this.label7);
            this.HomeForm.Controls.Add(this.label8);
            this.HomeForm.Controls.Add(this.label59);
            this.HomeForm.Location = new System.Drawing.Point(99, -1);
            this.HomeForm.Name = "HomeForm";
            this.HomeForm.Size = new System.Drawing.Size(617, 482);
            this.HomeForm.TabIndex = 94;
            this.HomeForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomeForm_MouseDown);
            this.HomeForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomeForm_MouseMove);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(19, 438);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(358, 32);
            this.label13.TabIndex = 78;
            this.label13.Text = "Make sure you keep track of your login information \r\nas we wont be able to help g" +
    "et it back";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(168, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 32);
            this.label9.TabIndex = 77;
            this.label9.Text = "Free and Safe Cheats";
            // 
            // siticoneControlBox9
            // 
            this.siticoneControlBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox9.BorderRadius = 10;
            this.siticoneControlBox9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.siticoneControlBox9.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox9.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox9.HoveredState.Parent = this.siticoneControlBox9;
            this.siticoneControlBox9.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox9.Location = new System.Drawing.Point(564, 3);
            this.siticoneControlBox9.Name = "siticoneControlBox9";
            this.siticoneControlBox9.ShadowDecoration.Parent = this.siticoneControlBox9;
            this.siticoneControlBox9.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox9.TabIndex = 75;
            // 
            // siticoneControlBox10
            // 
            this.siticoneControlBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox10.BorderRadius = 10;
            this.siticoneControlBox10.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.siticoneControlBox10.HoveredState.Parent = this.siticoneControlBox10;
            this.siticoneControlBox10.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox10.Location = new System.Drawing.Point(513, 3);
            this.siticoneControlBox10.Name = "siticoneControlBox10";
            this.siticoneControlBox10.ShadowDecoration.Parent = this.siticoneControlBox10;
            this.siticoneControlBox10.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox10.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(376, 415);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(179, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 32);
            this.label7.TabIndex = 72;
            this.label7.Text = "Active Staff Team";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(156, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 32);
            this.label8.TabIndex = 71;
            this.label8.Text = "Cheap and Safe Cheats";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.Color.Transparent;
            this.label59.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.White;
            this.label59.Location = new System.Drawing.Point(12, 19);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(495, 34);
            this.label59.TabIndex = 70;
            this.label59.Text = "Scorpion Development Open Source Loader";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 481);
            this.Controls.Add(this.HomeForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scorpion Development Open Source Loader";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.HomeForm.ResumeLayout(false);
            this.HomeForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button HomeButton;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox2;
        private Guna.UI2.WinForms.Guna2Button DiscordButton;
        private Guna.UI2.WinForms.Guna2Button CheatButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private Guna.UI2.WinForms.Guna2Button CleanerButton;
        private Guna.UI2.WinForms.Guna2Button SpooferButton;
        private Guna.UI2.WinForms.Guna2Panel HomeForm;
        private System.Windows.Forms.Label label9;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox9;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label13;
    }
}
