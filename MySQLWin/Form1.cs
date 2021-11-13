using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            DBConnector dbcon = new DBConnector();
            bool connected = dbcon.Connect(tbHost.Text, tbDB.Text, tbUser.Text, tbPw.Text);
            if (connected)
            {
                MessageBox.Show(this, dbcon.SuccessMsg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, dbcon.ErrorMsg, "Falla de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
