using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ButtonsSettings
{
    public partial class frmAddKey : Form
    {
        List<string> _keys;
        public frmAddKey(List<string> shKeys)
        {
            InitializeComponent();
            _keys = shKeys;
            readKeys();
        }
        void readKeys()
        {
            comboBox1.Items.Clear();
            foreach (string s in _keys)
            {
                comboBox1.Items.Add(s);
            }
        }

        private void mnuOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            ShellKeyItem sk = new ShellKeyItem(comboBox1.SelectedItem.ToString());
            sk.ShellKeyValue = comboBox1.SelectedItem.ToString();
            sk.save2Reg();            
            this.Close();
        }

        private void mnuCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}