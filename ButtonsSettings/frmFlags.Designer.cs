namespace ButtonsSettings
{
    partial class frmFlags
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.mnuCancel = new System.Windows.Forms.MenuItem();
            this.mnuOK = new System.Windows.Forms.MenuItem();
            this.optStartMenu = new System.Windows.Forms.RadioButton();
            this.optShowHome = new System.Windows.Forms.RadioButton();
            this.optScrollRight = new System.Windows.Forms.RadioButton();
            this.optScrollUp = new System.Windows.Forms.RadioButton();
            this.optScrollDown = new System.Windows.Forms.RadioButton();
            this.optScrollLeft = new System.Windows.Forms.RadioButton();
            this.optDisableKey = new System.Windows.Forms.RadioButton();
            this.optOKclose = new System.Windows.Forms.RadioButton();
            this.optShowSIP = new System.Windows.Forms.RadioButton();
            this.optShowContext = new System.Windows.Forms.RadioButton();
            this.optRotate = new System.Windows.Forms.RadioButton();
            this.optApplication = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.mnuCancel);
            this.mainMenu1.MenuItems.Add(this.mnuOK);
            // 
            // mnuCancel
            // 
            this.mnuCancel.Text = "Cancel";
            this.mnuCancel.Click += new System.EventHandler(this.mnuCancel_Click);
            // 
            // mnuOK
            // 
            this.mnuOK.Text = "OK";
            this.mnuOK.Click += new System.EventHandler(this.mnuOK_Click);
            // 
            // optStartMenu
            // 
            this.optStartMenu.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.optStartMenu.Location = new System.Drawing.Point(9, 13);
            this.optStartMenu.Name = "optStartMenu";
            this.optStartMenu.Size = new System.Drawing.Size(108, 22);
            this.optStartMenu.TabIndex = 0;
            this.optStartMenu.Text = "showStart Menu";
            this.optStartMenu.CheckedChanged += new System.EventHandler(this.optStartMenu_CheckedChanged);
            // 
            // optShowHome
            // 
            this.optShowHome.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.optShowHome.Location = new System.Drawing.Point(9, 95);
            this.optShowHome.Name = "optShowHome";
            this.optShowHome.Size = new System.Drawing.Size(108, 22);
            this.optShowHome.TabIndex = 0;
            this.optShowHome.Text = "show Home";
            this.optShowHome.CheckedChanged += new System.EventHandler(this.optShowHome_CheckedChanged);
            // 
            // optScrollRight
            // 
            this.optScrollRight.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.optScrollRight.Location = new System.Drawing.Point(9, 136);
            this.optScrollRight.Name = "optScrollRight";
            this.optScrollRight.Size = new System.Drawing.Size(108, 22);
            this.optScrollRight.TabIndex = 0;
            this.optScrollRight.Text = "scroll Right";
            this.optScrollRight.CheckedChanged += new System.EventHandler(this.optScrollRight_CheckedChanged);
            // 
            // optScrollUp
            // 
            this.optScrollUp.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.optScrollUp.Location = new System.Drawing.Point(9, 177);
            this.optScrollUp.Name = "optScrollUp";
            this.optScrollUp.Size = new System.Drawing.Size(108, 22);
            this.optScrollUp.TabIndex = 0;
            this.optScrollUp.Text = "scroll Up";
            this.optScrollUp.CheckedChanged += new System.EventHandler(this.optScrollUp_CheckedChanged);
            // 
            // optScrollDown
            // 
            this.optScrollDown.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.optScrollDown.Location = new System.Drawing.Point(129, 13);
            this.optScrollDown.Name = "optScrollDown";
            this.optScrollDown.Size = new System.Drawing.Size(102, 22);
            this.optScrollDown.TabIndex = 0;
            this.optScrollDown.Text = "scroll Down";
            this.optScrollDown.CheckedChanged += new System.EventHandler(this.optScrollDown_CheckedChanged);
            // 
            // optScrollLeft
            // 
            this.optScrollLeft.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.optScrollLeft.Location = new System.Drawing.Point(129, 54);
            this.optScrollLeft.Name = "optScrollLeft";
            this.optScrollLeft.Size = new System.Drawing.Size(102, 22);
            this.optScrollLeft.TabIndex = 0;
            this.optScrollLeft.Text = "scroll Left";
            this.optScrollLeft.CheckedChanged += new System.EventHandler(this.optScrollLeft_CheckedChanged);
            // 
            // optDisableKey
            // 
            this.optDisableKey.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.optDisableKey.Location = new System.Drawing.Point(129, 95);
            this.optDisableKey.Name = "optDisableKey";
            this.optDisableKey.Size = new System.Drawing.Size(102, 22);
            this.optDisableKey.TabIndex = 0;
            this.optDisableKey.Text = "DISABLE";
            this.optDisableKey.CheckedChanged += new System.EventHandler(this.optDisableKey_CheckedChanged);
            // 
            // optOKclose
            // 
            this.optOKclose.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.optOKclose.Location = new System.Drawing.Point(129, 136);
            this.optOKclose.Name = "optOKclose";
            this.optOKclose.Size = new System.Drawing.Size(102, 22);
            this.optOKclose.TabIndex = 0;
            this.optOKclose.Text = "OK Close";
            this.optOKclose.CheckedChanged += new System.EventHandler(this.optOKclose_CheckedChanged);
            // 
            // optShowSIP
            // 
            this.optShowSIP.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.optShowSIP.Location = new System.Drawing.Point(9, 54);
            this.optShowSIP.Name = "optShowSIP";
            this.optShowSIP.Size = new System.Drawing.Size(108, 22);
            this.optShowSIP.TabIndex = 0;
            this.optShowSIP.Text = "show SIP";
            this.optShowSIP.CheckedChanged += new System.EventHandler(this.optShowSIP_CheckedChanged);
            // 
            // optShowContext
            // 
            this.optShowContext.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.optShowContext.Location = new System.Drawing.Point(129, 177);
            this.optShowContext.Name = "optShowContext";
            this.optShowContext.Size = new System.Drawing.Size(102, 22);
            this.optShowContext.TabIndex = 0;
            this.optShowContext.Text = "show Context";
            this.optShowContext.CheckedChanged += new System.EventHandler(this.optShowContext_CheckedChanged);
            // 
            // optRotate
            // 
            this.optRotate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.optRotate.Location = new System.Drawing.Point(129, 210);
            this.optRotate.Name = "optRotate";
            this.optRotate.Size = new System.Drawing.Size(102, 22);
            this.optRotate.TabIndex = 0;
            this.optRotate.Text = "rotate Screen";
            this.optRotate.CheckedChanged += new System.EventHandler(this.optRotate_CheckedChanged);
            // 
            // optApplication
            // 
            this.optApplication.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.optApplication.Location = new System.Drawing.Point(9, 210);
            this.optApplication.Name = "optApplication";
            this.optApplication.Size = new System.Drawing.Size(102, 22);
            this.optApplication.TabIndex = 0;
            this.optApplication.Text = "Application";
            this.optApplication.CheckedChanged += new System.EventHandler(this.optApplication_CheckedChanged);
            // 
            // frmFlags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.ControlBox = false;
            this.Controls.Add(this.optApplication);
            this.Controls.Add(this.optRotate);
            this.Controls.Add(this.optShowContext);
            this.Controls.Add(this.optOKclose);
            this.Controls.Add(this.optDisableKey);
            this.Controls.Add(this.optScrollLeft);
            this.Controls.Add(this.optScrollDown);
            this.Controls.Add(this.optScrollUp);
            this.Controls.Add(this.optScrollRight);
            this.Controls.Add(this.optShowHome);
            this.Controls.Add(this.optShowSIP);
            this.Controls.Add(this.optStartMenu);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "frmFlags";
            this.Text = "frmFlags";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton optStartMenu;
        private System.Windows.Forms.RadioButton optShowHome;
        private System.Windows.Forms.RadioButton optScrollRight;
        private System.Windows.Forms.RadioButton optScrollUp;
        private System.Windows.Forms.RadioButton optScrollDown;
        private System.Windows.Forms.RadioButton optScrollLeft;
        private System.Windows.Forms.RadioButton optDisableKey;
        private System.Windows.Forms.RadioButton optOKclose;
        private System.Windows.Forms.RadioButton optShowSIP;
        private System.Windows.Forms.RadioButton optShowContext;
        private System.Windows.Forms.RadioButton optRotate;
        private System.Windows.Forms.MenuItem mnuCancel;
        private System.Windows.Forms.MenuItem mnuOK;
        private System.Windows.Forms.RadioButton optApplication;
    }
}