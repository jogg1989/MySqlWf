using System;
using System.Windows.Forms;
using MySqlWf.Data;

namespace MySqlWf
{
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Eventos
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
        #endregion Eventos
    }
}
