using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ButtonsSettings
{
    public partial class frmFlags : Form
    {
        public frmFlags(int flags)
        {
            InitializeComponent();
            iFlags = flags;
            updateOptions();
        }

        public int iFlags = 0x00;

        void updateOptions(){
            switch (iFlags)
            {
                case (int)ShellKeyItem.eFlags.disableKey:
                    optDisableKey.Checked = true;
                    break;
                case (int)ShellKeyItem.eFlags.okClose:
                    optOKclose.Checked = true;
                    break;
                case (int)ShellKeyItem.eFlags.rotateScreen:
                    optRotate.Checked = true;
                    break;
                case (int)ShellKeyItem.eFlags.scrollDown:
                    optScrollDown.Checked = true;
                    break;
                case (int)ShellKeyItem.eFlags.scrollLeft:
                    optScrollLeft.Checked = true;
                    break;
                case (int)ShellKeyItem.eFlags.scrollRight:
                    optScrollRight.Checked = true;
                    break;
                case (int)ShellKeyItem.eFlags.scrollUp:
                    optScrollUp.Checked = true;
                    break;
                case (int)ShellKeyItem.eFlags.showContextMenu:
                    optShowContext.Checked = true;
                    break;
                case (int)ShellKeyItem.eFlags.showHome:
                    optShowHome.Checked = true;
                    break;
                case (int)ShellKeyItem.eFlags.showSIP:
                    optShowSIP.Checked = true;
                    break;
                case (int)ShellKeyItem.eFlags.showStartMenu:
                    optStartMenu.Checked = true;
                    break;
                case (int)ShellKeyItem.eFlags.useApp:
                    optApplication.Checked = true;
                    break;

            }
        }
        private void mnuOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void mnuCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void optStartMenu_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                iFlags = (int)ShellKeyItem.eFlags.showStartMenu;
        }

        private void optShowSIP_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                iFlags = (int)ShellKeyItem.eFlags.showSIP;
        }

        private void optShowHome_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                iFlags = (int)ShellKeyItem.eFlags.showHome;
        }

        private void optScrollRight_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                iFlags = (int)ShellKeyItem.eFlags.scrollRight;
        }

        private void optScrollUp_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                iFlags = (int)ShellKeyItem.eFlags.scrollUp;
        }

        private void optScrollDown_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                iFlags = (int)ShellKeyItem.eFlags.scrollDown;
        }

        private void optScrollLeft_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if(rb.Checked)
                iFlags = (int)ShellKeyItem.eFlags.scrollLeft;
        }

        private void optDisableKey_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if(rb.Checked)
                iFlags = (int)ShellKeyItem.eFlags.disableKey;
        }

        private void optOKclose_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                iFlags = (int)ShellKeyItem.eFlags.okClose;
        }

        private void optShowContext_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                iFlags = (int)ShellKeyItem.eFlags.showContextMenu;
        }

        private void optRotate_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                iFlags = (int)ShellKeyItem.eFlags.rotateScreen;
        }

        private void optApplication_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                iFlags = (int)ShellKeyItem.eFlags.useApp;
        }
    }
}