namespace ButtonsSettings
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.mnuButton = new System.Windows.Forms.MenuItem();
            this.mnuSave = new System.Windows.Forms.MenuItem();
            this.mnuAdd = new System.Windows.Forms.MenuItem();
            this.menuDelete = new System.Windows.Forms.MenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtApplication = new System.Windows.Forms.TextBox();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.mnuSelectFile = new System.Windows.Forms.MenuItem();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtResetCmd = new System.Windows.Forms.TextBox();
            this.txtAppArgs = new System.Windows.Forms.TextBox();
            this.txtResetArgs = new System.Windows.Forms.TextBox();
            this.inputPanel1 = new Microsoft.WindowsCE.Forms.InputPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangeFlags = new System.Windows.Forms.Button();
            this.txtFlags = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(6, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 20);
            label1.Text = "Application Button:";
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(7, 35);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 20);
            label2.Text = "Application:";
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(7, 135);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(40, 20);
            label3.Text = "Icon:";
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(7, 162);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(82, 20);
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(7, 85);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(74, 20);
            label5.Text = "ResetCmd:";
            // 
            // label6
            // 
            label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            label6.Location = new System.Drawing.Point(7, 186);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(214, 15);
            label6.Text = "click and hold to select files";
            label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(59, 59);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(74, 20);
            label7.Text = "Arguments:";
            // 
            // label8
            // 
            label8.Location = new System.Drawing.Point(59, 108);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(74, 20);
            label8.Text = "Arguments:";
            // 
            // label9
            // 
            label9.Location = new System.Drawing.Point(6, 205);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(40, 20);
            label9.Text = "Flags:";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.mnuFile);
            this.mainMenu1.MenuItems.Add(this.mnuButton);
            // 
            // mnuFile
            // 
            this.mnuFile.MenuItems.Add(this.mnuExit);
            this.mnuFile.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuButton
            // 
            this.mnuButton.MenuItems.Add(this.mnuSave);
            this.mnuButton.MenuItems.Add(this.mnuAdd);
            this.mnuButton.MenuItems.Add(this.menuDelete);
            this.mnuButton.Text = "Button";
            // 
            // mnuSave
            // 
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuAdd
            // 
            this.mnuAdd.Text = "Add";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Text = "Delete";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(130, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 22);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtApplication
            // 
            this.txtApplication.ContextMenu = this.contextMenu1;
            this.txtApplication.Location = new System.Drawing.Point(87, 35);
            this.txtApplication.Name = "txtApplication";
            this.txtApplication.Size = new System.Drawing.Size(134, 21);
            this.txtApplication.TabIndex = 2;
            this.txtApplication.GotFocus += new System.EventHandler(this.txtApplication_GotFocus);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.mnuSelectFile);
            // 
            // mnuSelectFile
            // 
            this.mnuSelectFile.Text = "Select File";
            this.mnuSelectFile.Click += new System.EventHandler(this.mnuSelectFile_Click);
            // 
            // txtIcon
            // 
            this.txtIcon.ContextMenu = this.contextMenu1;
            this.txtIcon.Location = new System.Drawing.Point(53, 135);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(168, 21);
            this.txtIcon.TabIndex = 2;
            this.txtIcon.GotFocus += new System.EventHandler(this.txtApplication_GotFocus);
            // 
            // txtName
            // 
            this.txtName.ContextMenu = this.contextMenu1;
            this.txtName.Location = new System.Drawing.Point(99, 162);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(122, 21);
            this.txtName.TabIndex = 2;
            this.txtName.GotFocus += new System.EventHandler(this.txtApplication_GotFocus);
            // 
            // txtResetCmd
            // 
            this.txtResetCmd.ContextMenu = this.contextMenu1;
            this.txtResetCmd.Location = new System.Drawing.Point(87, 85);
            this.txtResetCmd.Name = "txtResetCmd";
            this.txtResetCmd.Size = new System.Drawing.Size(134, 21);
            this.txtResetCmd.TabIndex = 2;
            this.txtResetCmd.GotFocus += new System.EventHandler(this.txtApplication_GotFocus);
            // 
            // txtAppArgs
            // 
            this.txtAppArgs.Location = new System.Drawing.Point(139, 59);
            this.txtAppArgs.Name = "txtAppArgs";
            this.txtAppArgs.Size = new System.Drawing.Size(82, 21);
            this.txtAppArgs.TabIndex = 2;
            // 
            // txtResetArgs
            // 
            this.txtResetArgs.Location = new System.Drawing.Point(139, 108);
            this.txtResetArgs.Name = "txtResetArgs";
            this.txtResetArgs.Size = new System.Drawing.Size(82, 21);
            this.txtResetArgs.TabIndex = 2;
            // 
            // inputPanel1
            // 
            this.inputPanel1.EnabledChanged += new System.EventHandler(this.inputPanel1_EnabledChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnChangeFlags);
            this.panel1.Controls.Add(this.txtFlags);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(label9);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.txtApplication);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtAppArgs);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(this.txtResetArgs);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(this.txtIcon);
            this.panel1.Controls.Add(label8);
            this.panel1.Controls.Add(this.txtResetCmd);
            this.panel1.Controls.Add(label7);
            this.panel1.Controls.Add(label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 268);
            // 
            // btnChangeFlags
            // 
            this.btnChangeFlags.Location = new System.Drawing.Point(156, 204);
            this.btnChangeFlags.Name = "btnChangeFlags";
            this.btnChangeFlags.Size = new System.Drawing.Size(64, 21);
            this.btnChangeFlags.TabIndex = 11;
            this.btnChangeFlags.Text = "change";
            this.btnChangeFlags.Click += new System.EventHandler(this.btnChangeFlags_Click);
            // 
            // txtFlags
            // 
            this.txtFlags.Location = new System.Drawing.Point(52, 204);
            this.txtFlags.Name = "txtFlags";
            this.txtFlags.Size = new System.Drawing.Size(92, 21);
            this.txtFlags.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(67, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "save changes";
            this.btnSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.panel1);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "ButtonSettings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtApplication;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtResetCmd;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuExit;
        private System.Windows.Forms.MenuItem mnuButton;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem mnuSelectFile;
        private System.Windows.Forms.MenuItem mnuSave;
        private System.Windows.Forms.MenuItem mnuAdd;
        private System.Windows.Forms.MenuItem menuDelete;
        private System.Windows.Forms.TextBox txtAppArgs;
        private System.Windows.Forms.TextBox txtResetArgs;
        private Microsoft.WindowsCE.Forms.InputPanel inputPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFlags;
        private System.Windows.Forms.Button btnChangeFlags;
        private System.Windows.Forms.Button btnSave;
    }
}

