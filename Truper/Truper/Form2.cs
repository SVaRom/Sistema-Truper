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

namespace Truper
{
    public partial class Form2 : Form
    {
        String Str = @"Data Source = DESKTOP-4FQ3K92;" +
              "Initial Catalog = Truper;" +
              "Integrated Security = True;";
        SqlConnection conexionSQL;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlCommand Cm;
            SqlDataReader Dr;
            conexionSQL = new SqlConnection(Str);
            Cm = new SqlCommand("SELECT Fragmento FROM Catalogo", conexionSQL);
            conexionSQL.Open();
            Dr = Cm.ExecuteReader();
            while (Dr.Read())
            {
                cbFrag.Items.Add(Dr[0]);
            }
            Dr.Close();
            conexionSQL.Close();
        }

        private void cbFrag_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conexionSQL = new SqlConnection(Str);
                SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM "+cbFrag.Text, conexionSQL);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                dgvSearch.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Hubo un error, intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexionSQL.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexionSQL = new SqlConnection(Str);
                SqlDataAdapter dap = new SqlDataAdapter("(SELECT * FROM F1) UNION (SELECT * FROM F2) UNION" +
                    "(SELECT * FROM F3) UNION (SELECT * FROM F4) UNION (SELECT * FROM F5) UNION (SELECT * FROM F6) UNION" +
                    "(SELECT * FROM F7) UNION (SELECT * FROM F8) UNION (SELECT * FROM F9)", conexionSQL);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                dgvSearch.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Hubo un error, intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexionSQL.Close();
            }
        }
    }
}
