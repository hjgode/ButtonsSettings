using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ButtonsSettings
{
    public partial class frmMain : Form
    {
        ShellKeys2 shKeys2;
        List<ShellKeyItem> _shellKeyItems;

        public frmMain()
        {
            InitializeComponent();
            shKeys2 = new ShellKeys2();
            //sk2.delShellKey("40C2");
            readKeys();
        }

        void readKeys()
        {            
            comboBox1.Items.Clear();
            _shellKeyItems = shKeys2.getShellKeyItems();// getAllShellKeys();
            foreach (ShellKeyItem ski in _shellKeyItems)
            {
                if(ski.bFromReg)
                    comboBox1.Items.Add(ski);
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (shKeys2 != null)
                shKeys2.Dispose();
            Application.Exit();
        }

        TextBox tbCurrent=null;
        private void mnuSelectFile_Click(object sender, EventArgs e)
        {
            TextBox tb = tbCurrent;
            if (tbCurrent == null)
                return;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Program Links|*.lnk|program Files|*.exe|All|*.*";
            ofd.FilterIndex = 1;
            ofd.InitialDirectory = @"\Windows\Start Menu\Programs";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tb.Text = "\"" + ofd.FileName + "\"";
            }
            ofd.Dispose();
        }

        private void txtApplication_GotFocus(object sender, EventArgs e)
        {
            tbCurrent = (TextBox)sender;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                return;
            ShellKeyItem _ski = (ShellKeyItem)comboBox1.SelectedItem;
            txtApplication.Text = _ski.@default;
            txtIcon.Text = _ski.Icon;
            txtResetCmd.Text = _ski.ResetCmd;
            txtName.Text = _ski.Name;
            txtFlags.Text = "0x"+_ski.Flags.ToString("X");
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                return;

            ShellKeyItem _sk = (ShellKeyItem)comboBox1.SelectedItem;
            if (_sk.save2Reg())
                MessageBox.Show("Save OK");
            else
                MessageBox.Show("Save FAILED");
            
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            frmAddKey af = new frmAddKey(shKeys2.newKeysList);
            if (af.ShowDialog() == DialogResult.OK)
                readKeys();
            af.Dispose();
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                return;

            if (MessageBox.Show("Do you really want delete '" + comboBox1.SelectedItem.ToString() +"'", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                //Compact Framework keeps references to used registry keys although these have been closed explicitly in code
                //the following lines forces Compact Framework to dispose all used registry references
                //only after that we are able to delete the reg key
                shKeys2.Dispose();
                shKeys2 = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                if (ShellKeys2.delShellKey(comboBox1.SelectedItem.ToString()))
                    MessageBox.Show("RegistryKey '" + comboBox1.SelectedItem.ToString()+"' has been deleted");//readKeys();
                else
                    MessageBox.Show("Sorry. Delete failed");
                //reload the shellkeys2 object
                shKeys2 = new ShellKeys2();
                readKeys();
            }
        }

        private void inputPanel1_EnabledChanged(object sender, EventArgs e)
        {
            if (inputPanel1.Enabled)
            {
                panel1.Bounds = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height - inputPanel1.Bounds.Height);
            }
            else
                panel1.Bounds = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnChangeFlags_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                return;
            ShellKeyItem _sk = (ShellKeyItem)comboBox1.SelectedItem;
            frmFlags frm = new frmFlags(_sk.Flags);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _sk.Flags = frm.iFlags;
                txtFlags.Text = "0x" + _sk.Flags.ToString("X");
            }
            frm.Dispose();
        }

        private void frmMain_Closing(object sender, CancelEventArgs e)
        {
            if(MessageBox.Show("Are you sure?", 
                "Leave ButtonSettings", 
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)==DialogResult.Cancel)
            e.Cancel=true;

        }


    }
}