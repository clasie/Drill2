using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreWinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var loginUI = new LoginUI();
            loginUI.ShowDialog();
            if (!loginUI.IsLogged) {
                Application.Exit();
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                SqlDataReader reader;
                string connString = "Server=PC1224;Database=Drill2;Trusted_Connection=True;";
                conn = new SqlConnection(connString);
                conn.Open();
                MessageBox.Show("Ok connection");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"KO connection: {ex.ToString()}");
            }
            finally {
                if (conn != null) {
                    conn.Close();
                }             
            }

        }
    }
}
