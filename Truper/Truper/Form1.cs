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
       public partial class Form1 : Form
       {
        String Str = @"Data Source = DESKTOP-4FQ3K92;" +
              "Initial Catalog = Truper;" +
              "Integrated Security = True;";
        SqlConnection conexionSQL;
        int cont = 0,cont2=0;
        DialogResult op;
        public Form1()
        {
            InitializeComponent();
        }

        private void allDisable()
        {
            lblUser.Visible = false;
            lblPass.Visible = false;
            tbUser.Visible = false;
            tbPass.Visible = false;
            emp.Visible = false;
            btnAdm.Visible = false;
            tbNomB.Visible = false;
            lblBusqueda.Visible = false;
            btnSearch.Visible = false;
            dgvBusqueda.Visible = false;
            lblRFCE.Visible = false;
            lblNombres.Visible = false;
            lblApe.Visible = false;
            lblDir.Visible = false;
            lblTel.Visible = false;
            lblPuesto.Visible = false;
            lblSueldo.Visible = false;
            lblAñoN.Visible = false;
            lblAñoE.Visible = false;
            lblSuc.Visible = false;
            tbRFCE.Visible = false;
            tbNombres.Visible = false;
            tbApe.Visible = false;
            tbDir.Visible = false;
            tbTel.Visible = false;
            tbPuesto.Visible = false;
            tbSueldo.Visible = false;
            tbAñoN.Visible = false;
            tbAñoE.Visible = false;
            cbSuc.Visible = false;
            btnAdd.Visible = false;
            lblSelectB.Visible = false;
            tbSearchDelete.Visible = false;
            btnDel.Visible = false;
            lblMod.Visible = false;
            btnMod.Visible = false;
            btnEnc.Visible = false;
            lblA.Visible = false;
            lblB.Visible = false;
            lblC.Visible = false;
            lblM.Visible = false;
            lblAdm.Visible = false;
            lblBie.Visible = false;
            pbA.Visible = false;
            pbAdm.Visible = false;
            pbB.Visible = false;
            pbC.Visible = false;
            pbM.Visible = false;
            label1.Visible = false;
        }

        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }

        }

        public static void SoloLetras(KeyPressEventArgs pE)
        {
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            allDisable();
            lblUser.Visible = true;
            lblPass.Visible = true;
            tbUser.Visible = true;
            tbPass.Visible = true;
            emp.Visible = true;
            btnAdm.Visible = true;
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "admin" && tbPass.Text == "root")
            {
                MessageBox.Show("Bienvenido administrador", "Saludos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbPass.Clear();
                tbUser.Clear();
                Form vp = new Form2();
                vp.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPass.Clear();
                tbUser.Clear();
                cont++;
                if (cont == 5)
                {
                    cont2++;
                    if (cont2 == 2)
                    {
                        MessageBox.Show("Debido a exceso de intentos, el programa será cerrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Debido a exceso de intentos, el programa reposara 5 segundos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Threading.Thread.Sleep(5000);
                        cont = 0;
                        MessageBox.Show("Intente nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                    
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            allDisable();
            tbNomB.Visible = true;
            lblBusqueda.Visible = true;
            btnSearch.Visible = true;
            dgvBusqueda.Visible = true;
            btnSearch.Enabled = false;
            tbNomB.Text = "";
            DialogResult res;
            Form Message = new MessageBoxje();
            res = Message.ShowDialog();
            op = res;
            switch (res)
            {
                case DialogResult.Cancel:
                    lblBusqueda.Text = "Ingrese el RFC a buscar:";
                    tbNomB.MaxLength = 13;
                    btnSearch.Enabled = true;
                    break;
                case DialogResult.Yes:
                    lblBusqueda.Text = "Ingrese el nombre a buscar:";
                    tbNomB.MaxLength = 32767;
                    btnSearch.Enabled = true;
                    break;
                case DialogResult.No:
                    tbNomB.MaxLength = 50;
                    lblBusqueda.Text = "Ingrese ID de la sucursal perteneciente:";
                    btnSearch.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Debe seleccionar una manera de busqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String campo = "";
                conexionSQL = new SqlConnection(Str);
                switch (op)
                {
                    case DialogResult.Cancel:
                        campo = "RFCE";
                        break;
                    case DialogResult.Yes:
                        campo = "Nombres";
                        break;
                    case DialogResult.No:
                        campo = "ID_Sucursal";
                        break;
                }
                SqlDataAdapter dap = new SqlDataAdapter("(SELECT * FROM F1 WHERE "+campo+" like '%" + tbNomB.Text + "%') UNION (SELECT * FROM F2 WHERE " + campo + " like '%"
                    + tbNomB.Text + "%') UNION (SELECT * FROM F3 WHERE " + campo + " like '%"
                    + tbNomB.Text + "%') UNION (SELECT * FROM F4 WHERE " + campo + " like '%" + tbNomB.Text + "%')" +
                    "UNION (SELECT * FROM F5 WHERE " + campo + " like '%" + tbNomB.Text + "%') UNION (SELECT * FROM F6 WHERE " + campo + " like '%"
                    + tbNomB.Text + "%') UNION (SELECT * FROM F7 WHERE " + campo + " like '%" + tbNomB.Text + "%') UNION" +
                    "(SELECT * FROM F8 WHERE " + campo + " like '%" + tbNomB.Text + "%') UNION (SELECT * FROM F9 WHERE " + campo + " like '%" + tbNomB.Text + "%')", conexionSQL);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                dgvBusqueda.DataSource = dt;
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            allDisable();
            lblRFCE.Visible = true;
            lblNombres.Visible = true;
            lblApe.Visible = true;
            lblDir.Visible = true;
            lblTel.Visible = true;
            lblPuesto.Visible = true;
            lblSueldo.Visible = true;
            lblAñoN.Visible = true;
            lblAñoE.Visible = true;
            lblSuc.Visible = true;
            tbRFCE.Visible = true;
            tbNombres.Visible = true;
            tbApe.Visible = true;
            tbDir.Visible = true;
            tbTel.Visible = true;
            tbPuesto.Visible = true;
            tbSueldo.Visible = true;
            tbAñoN.Visible = true;
            tbAñoE.Visible = true;
            cbSuc.Visible = true;
            btnAdd.Visible = true;
            tbRFCE.ReadOnly = false;
            tbNombres.ReadOnly = false;
            tbApe.ReadOnly = false;
            tbDir.ReadOnly = false;
            tbTel.ReadOnly = false;
            tbPuesto.ReadOnly = false;
            tbSueldo.ReadOnly = false;
            tbAñoN.ReadOnly = false;
            tbAñoE.ReadOnly = false;
            cbSuc.Enabled = true;
            tbRFCE.Enabled = true;
            cbSuc.Text = "";
            tbAñoE.Text = "";
            tbAñoN.Text = "";
            tbSueldo.Text = "";
            tbPuesto.Text = "";
            tbTel.Text = "";
            tbDir.Text = "";
            tbApe.Text = "";
            tbNombres.Text = "";
            tbRFCE.Text = "";
            tbSearchDelete.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand Cm;
            SqlDataReader Dr;
            conexionSQL = new SqlConnection(Str);
            Cm = new SqlCommand("SELECT Nombre FROM Sucursales", conexionSQL);
            conexionSQL.Open();
            Dr = Cm.ExecuteReader();
            while (Dr.Read())
            {
                cbSuc.Items.Add(Dr[0]);
            }
            Dr.Close();
            conexionSQL.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String idSuc;//Declaramos variables auxiliares
                conexionSQL = new SqlConnection(Str);//Instanciamos la conexión con los datos de nuestro servidor
                SqlCommand comandoSQL;//Declaramos variables tipo comando SQL
                SqlDataReader Dr;//Declaramos variables tipo lector de datos SQL
                comandoSQL = new SqlCommand("SELECT ID_Sucursal FROM Sucursales where Nombre='" + cbSuc.Text + "'", conexionSQL);//Buscamos ID_Sucursal que pertenezca al nombre dado en pantalla
                conexionSQL.Open();//Abrimos conexión
                Dr = comandoSQL.ExecuteReader();//Ordeanmos al lector a que debe leer los datos del comando anterior
                Dr.Read();//Ordeanmos al lector a que lea el comando
                idSuc = Dr[0].ToString();//Igualamos nuestra variable con el resultado que lea nuestro lector
                Dr.Close();//Ordenamos al lector a parar
                String frag = buscarTabla("ID_Sucursal", idSuc, "Empleados");//Busqueda del nombre del fragmento
                String comando = "INSERT INTO " + frag + "(RFCE,Nombres,Apellidos,Dirección,Teléfono,Puesto,Sueldo,AñoNac,AñoEntrada,ID_Sucursal) " +
                    "VALUES('" + tbRFCE.Text + "','" + tbNombres.Text + "','" + tbApe.Text + "','" + tbDir.Text + "'," + tbTel.Text + ",'" + tbPuesto.Text + "'," + tbSueldo.Text + "," +
                    tbAñoN.Text + "," + tbAñoE.Text + ",'" + idSuc + "')";//Escribimos el comando para actualizar en el fragmento resultante los nuevos datos
                comandoSQL = new SqlCommand(comando, conexionSQL);//Le damos al comando el nuevo comando
                DialogResult dr= MessageBox.Show("¿Está seguro de insertar a " + tbNombres.Text + " en la tabla de Empleados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);//Verificamos
                if (dr == DialogResult.Yes)//Esta seguro y realizamos la alta 
                {
                    comandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Registro exitoso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                else//No esta seguro y cancelamos la alta 
                {
                    MessageBox.Show("Operación cancelada exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Registro no exitoso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexionSQL.Close();
                tbRFCE.Text = "";
                tbNombres.Text = "";
                tbApe.Text = "";
                tbDir.Text = "";
                tbTel.Text = "";
                tbPuesto.Text = "";
                tbSueldo.Text = "";
                tbAñoN.Text = "";
                tbAñoE.Text = "";
                cbSuc.Text = "";
            }
        }

        private void tbTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void tbSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void tbAñoN_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void tbAñoE_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void tbPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void tbApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void tbNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            allDisable();
            btnEnc.Visible = true;
            lblSelectB.Visible = true;
            tbSearchDelete.Visible = true;
            lblRFCE.Visible = true;
            lblNombres.Visible = true;
            lblApe.Visible = true;
            lblDir.Visible = true;
            lblTel.Visible = true;
            lblPuesto.Visible = true;
            lblSueldo.Visible = true;
            lblAñoN.Visible = true;
            lblAñoE.Visible = true;
            lblSuc.Visible = true;
            tbRFCE.Visible = true;
            tbNombres.Visible = true;
            tbApe.Visible = true;
            tbDir.Visible = true;
            tbTel.Visible = true;
            tbPuesto.Visible = true;
            tbSueldo.Visible = true;
            tbAñoN.Visible = true;
            tbAñoE.Visible = true;
            cbSuc.Visible = true;
            btnDel.Visible = true;
            tbRFCE.ReadOnly = true;
            tbNombres.ReadOnly = true;
            tbApe.ReadOnly = true;
            tbDir.ReadOnly = true;
            tbTel.ReadOnly = true;
            tbPuesto.ReadOnly = true;
            tbSueldo.ReadOnly = true;
            tbAñoN.ReadOnly = true;
            tbAñoE.ReadOnly = true;
            cbSuc.Enabled = false;
            tbRFCE.Enabled = false;
            cbSuc.Text = "";
            tbAñoE.Text = "";
            tbAñoN.Text = "";
            tbSueldo.Text = "";
            tbPuesto.Text = "";
            tbTel.Text = "";
            tbDir.Text = "";
            tbApe.Text = "";
            tbNombres.Text = "";
            tbRFCE.Text = "";
            tbSearchDelete.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                String aux, idSuc;//Declaramos variables auxiliares
                SqlCommand comandoSQL;//Declaramos variables tipo comando SQL
                SqlDataReader Dr;//Declaramos variables tipo lector de datos SQL
                conexionSQL = new SqlConnection(Str);//Instanciamos la conexión con los datos de nuestro servidor
                comandoSQL = new SqlCommand("SELECT ID_Sucursal FROM Sucursales where Nombre='" + cbSuc.Text + "'", conexionSQL);//Buscamos ID_Sucursal que pertenezca al nombre dado en pantalla
                conexionSQL.Open();//Abrimos conexión
                Dr = comandoSQL.ExecuteReader();//Ordeanmos al lector a que debe leer los datos del comando anterior
                Dr.Read();//Ordeanmos al lector a que lea el comando
                idSuc = Dr[0].ToString();//Igualamos nuestra variable con el resultado que lea nuestro lector
                Dr.Close();//Ordenamos al lector a parar
                aux = buscarTabla("ID_Sucursal", idSuc, "Empleados");//Busqueda del nombre del fragmento
                string strSQL = "DELETE FROM " + aux + " WHERE RFCE='" + tbRFCE.Text + "'";//Escribimos el comando para actualizar en el fragmento resultante los nuevos datos
                comandoSQL = new SqlCommand(strSQL, conexionSQL);//Le damos al comando el nuevo comando
                DialogResult dr = MessageBox.Show("¿Está seguro de eliminar a " + tbNombres.Text + " de la tabla de Empleados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);//Verificamos
                if (dr == DialogResult.Yes)//Esta seguro y realizamos la eliminación 
                {
                    comandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Eliminación exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                else//No esta seguro y cancelamos la eliminación 
                {
                    MessageBox.Show("Operación cancelada exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Eliminación no exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conexionSQL.Close();
                cbSuc.Text = "";
                tbAñoE.Text = "";
                tbAñoN.Text = "";
                tbSueldo.Text = "";
                tbPuesto.Text = "";
                tbTel.Text = "";
                tbDir.Text = "";
                tbApe.Text = "";
                tbNombres.Text = "";
                tbRFCE.Text = "";
                tbSearchDelete.Text = "";
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            allDisable();
            btnEnc.Visible = true;
            lblRFCE.Visible = true;
            lblNombres.Visible = true;
            lblApe.Visible = true;
            lblDir.Visible = true;
            lblTel.Visible = true;
            lblPuesto.Visible = true;
            lblSueldo.Visible = true;
            lblAñoN.Visible = true;
            lblAñoE.Visible = true;
            lblSuc.Visible = true;
            tbRFCE.Visible = true;
            tbNombres.Visible = true;
            tbApe.Visible = true;
            tbDir.Visible = true;
            tbTel.Visible = true;
            tbPuesto.Visible = true;
            tbSueldo.Visible = true;
            tbAñoN.Visible = true;
            tbAñoE.Visible = true;
            cbSuc.Visible = true;
            tbSearchDelete.Visible = true;
            lblMod.Visible = true;
            btnMod.Visible = true;
            tbRFCE.Enabled = false;
            tbNombres.ReadOnly = false;
            tbApe.ReadOnly = false;
            tbDir.ReadOnly = false;
            tbTel.ReadOnly = false;
            tbPuesto.ReadOnly = false;
            tbSueldo.ReadOnly = false;
            tbAñoN.ReadOnly = false;
            tbAñoE.ReadOnly = false;
            cbSuc.Enabled = false;
            cbSuc.Text = "";
            tbAñoE.Text = "";
            tbAñoN.Text = "";
            tbSueldo.Text = "";
            tbPuesto.Text = "";
            tbTel.Text = "";
            tbDir.Text = "";
            tbApe.Text = "";
            tbNombres.Text = "";
            tbRFCE.Text = "";
            tbSearchDelete.Text = "";
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                String aux;//Declaramos variables auxiliares
                SqlCommand comandoSQL;//Declaramos variables tipo comando SQL
                conexionSQL = new SqlConnection(Str);//Instanciamos la conexión con los datos de nuestro servidor
                SqlDataReader Dr;//Declaramos variables tipo lector de datos SQL
                String idSuc;//Declaramos variable auxiliar
                comandoSQL = new SqlCommand("SELECT ID_Sucursal FROM Sucursales where Nombre='" + cbSuc.Text + "'", conexionSQL);//Buscamos ID_Sucursal que pertenezca al nombre dado en pantalla
                conexionSQL.Open();//Abrimos conexión
                Dr = comandoSQL.ExecuteReader();//Ordeanmos al lector a que debe leer los datos del comando anterior
                Dr.Read();//Ordeanmos al lector a que lea el comando
                idSuc = Dr[0].ToString();//Igualamos nuestra variable con el resultado que lea nuestro lector
                Dr.Close();//Ordenamos al lector a parar
                aux = buscarTabla("ID_Sucursal", idSuc, "Empleados");//Busqueda del nombre del fragmento
                String strSQL = "UPDATE " + aux + " SET RFCE='" + tbRFCE.Text + "',Nombres='" + tbNombres.Text + "',Apellidos='" + tbApe.Text + "',Dirección='" + tbDir.Text +
                    "',Teléfono=" + tbTel.Text + ",Puesto='" + tbPuesto.Text + "',Sueldo=" + tbSueldo.Text + ",AñoNac=" + tbAñoN.Text + ",AñoEntrada=" + tbAñoE.Text + ",ID_Sucursal='" + idSuc +
                    "'WHERE RFCE='" + tbSearchDelete.Text + "'";//Escribimos el comando para actualizar en el fragmento resultante los nuevos datos
                comandoSQL = new SqlCommand(strSQL, conexionSQL);//Le damos al comando el nuevo comando
                DialogResult dr = MessageBox.Show("¿Está seguro de modificar los datos de " + tbNombres.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);//Verificamos
                if (dr == DialogResult.Yes)//Esta seguro y realizamos la modificación 
                {
                    comandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Modificación exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                else//No esta seguro y cancelamos la modificación 
                {
                    MessageBox.Show("Operación cancelada exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            catch (Exception)
            {
                MessageBox.Show("Modificación no exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conexionSQL.Close();
                cbSuc.Text = "";
                tbAñoE.Text = "";
                tbAñoN.Text = "";
                tbSueldo.Text = "";
                tbPuesto.Text = "";
                tbTel.Text = "";
                tbDir.Text = "";
                tbApe.Text = "";
                tbNombres.Text = "";
                tbRFCE.Text = "";
                tbSearchDelete.Text = "";
            }
        }

        private String buscarTabla(String campo, String valor,String tabla)//Variables que deben llegar al método
        {
            String fragmento="";//Variable auxiliar
            SqlCommand Cm;//Variable tipo comando SQL
            SqlDataReader Dr;//Variable tipo lector de datos SQL
            conexionSQL = new SqlConnection(Str);//Instanciamos la conexión con la dirección del servidor
            Cm = new SqlCommand("SELECT Fragmento FROM Catalogo WHERE Campo='"+campo+"' and Valor='"+valor+"' and Tabla='"+tabla+"'", conexionSQL);//Instanciamos el comando con el comando escrito
            conexionSQL.Open();//Abrimos conexión hacía el servidor
            Dr = Cm.ExecuteReader();//Ordenamos a nuestro lector que debe leer los datos del comando anterior
            Dr.Read();//Orenamos al lector a leer los datos
            fragmento = Dr[0].ToString();//Iguyalamos la variable auxiliar con el resultado de nuestro comando
            Dr.Close();//Ordenamos al lector que pare
            return fragmento;//Enviamos el resultado de nuestro comando hacía donde se haya invocado el método.
        }

        private void btnEnc_Click(object sender, EventArgs e)
        {
            conexionSQL = new SqlConnection(Str);
            SqlCommand comandoSQL;
            SqlDataReader Dr;
            try
            {
                conexionSQL.Open();
                comandoSQL = new SqlCommand("(SELECT RFCE FROM F1 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT RFCE FROM F2 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT RFCE FROM F3 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT RFCE FROM F4 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT RFCE FROM F5 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT RFCE FROM F6 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT RFCE FROM F7 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT RFCE FROM F8 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT RFCE FROM F9 where RFCE='" + tbSearchDelete.Text + "')", conexionSQL);
                Dr = comandoSQL.ExecuteReader();
                Dr.Read();
                tbRFCE.Text = Dr[0].ToString();
                Dr.Close();
                comandoSQL = new SqlCommand("(SELECT Nombres FROM F1 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Nombres FROM F2 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Nombres FROM F3 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Nombres FROM F4 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Nombres FROM F5 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Nombres FROM F6 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Nombres FROM F7 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Nombres FROM F8 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Nombres FROM F9 where RFCE='" + tbSearchDelete.Text + "')", conexionSQL);
                Dr = comandoSQL.ExecuteReader();
                Dr.Read();
                tbNombres.Text = Dr[0].ToString();
                Dr.Close();
                comandoSQL = new SqlCommand("(SELECT Apellidos FROM F1 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Apellidos FROM F2 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Apellidos FROM F3 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Apellidos FROM F4 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Apellidos FROM F5 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Apellidos FROM F6 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Apellidos FROM F7 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Apellidos FROM F8 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Apellidos FROM F9 where RFCE='" + tbSearchDelete.Text + "')", conexionSQL);
                Dr = comandoSQL.ExecuteReader();
                Dr.Read();
                tbApe.Text = Dr[0].ToString();
                Dr.Close();
                comandoSQL = new SqlCommand("(SELECT Dirección FROM F1 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Dirección FROM F2 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Dirección FROM F3 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Dirección FROM F4 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Dirección FROM F5 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Dirección FROM F6 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Dirección FROM F7 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Dirección FROM F8 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Dirección FROM F9 where RFCE='" + tbSearchDelete.Text + "')", conexionSQL);
                Dr = comandoSQL.ExecuteReader();
                Dr.Read();
                tbDir.Text = Dr[0].ToString();
                Dr.Close();
                comandoSQL = new SqlCommand("(SELECT Teléfono FROM F1 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Teléfono FROM F2 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Teléfono FROM F3 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Teléfono FROM F4 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Teléfono FROM F5 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Teléfono FROM F6 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Teléfono FROM F7 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Teléfono FROM F8 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Teléfono FROM F9 where RFCE='" + tbSearchDelete.Text + "')", conexionSQL);
                Dr = comandoSQL.ExecuteReader();
                Dr.Read();
                tbTel.Text = Dr[0].ToString();
                Dr.Close();
                comandoSQL = new SqlCommand("(SELECT Puesto FROM F1 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Puesto FROM F2 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Puesto FROM F3 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Puesto FROM F4 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Puesto FROM F5 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Puesto FROM F6 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Puesto FROM F7 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Puesto FROM F8 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Puesto FROM F9 where RFCE='" + tbSearchDelete.Text + "')", conexionSQL);
                Dr = comandoSQL.ExecuteReader();
                Dr.Read();
                tbPuesto.Text = Dr[0].ToString();
                Dr.Close();
                comandoSQL = new SqlCommand("(SELECT Sueldo FROM F1 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Sueldo FROM F2 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Sueldo FROM F3 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Sueldo FROM F4 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Sueldo FROM F5 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Sueldo FROM F6 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Sueldo FROM F7 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT Sueldo FROM F8 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT Sueldo FROM F9 where RFCE='" + tbSearchDelete.Text + "')", conexionSQL);
                Dr = comandoSQL.ExecuteReader();
                Dr.Read();
                tbSueldo.Text = Dr[0].ToString();
                Dr.Close();
                comandoSQL = new SqlCommand("(SELECT AñoNac FROM F1 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT AñoNac FROM F2 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT AñoNac FROM F3 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT AñoNac FROM F4 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT AñoNac FROM F5 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT AñoNac FROM F6 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT AñoNac FROM F7 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT AñoNac FROM F8 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT AñoNac FROM F9 where RFCE='" + tbSearchDelete.Text + "')", conexionSQL);
                Dr = comandoSQL.ExecuteReader();
                Dr.Read();
                tbAñoN.Text = Dr[0].ToString();
                Dr.Close();
                comandoSQL = new SqlCommand("(SELECT AñoEntrada FROM F1 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT AñoEntrada FROM F2 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT AñoEntrada FROM F3 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT AñoEntrada FROM F4 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT AñoEntrada FROM F5 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT AñoEntrada FROM F6 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT AñoEntrada FROM F7 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT AñoEntrada FROM F8 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT AñoEntrada FROM F9 where RFCE='" + tbSearchDelete.Text + "')", conexionSQL);
                Dr = comandoSQL.ExecuteReader();
                Dr.Read();
                tbAñoE.Text = Dr[0].ToString();
                Dr.Close();
                String aux = "";
                comandoSQL = new SqlCommand("(SELECT ID_Sucursal FROM F1 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT ID_Sucursal FROM F2 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT ID_Sucursal FROM F3 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT ID_Sucursal FROM F4 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT ID_Sucursal FROM F5 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT ID_Sucursal FROM F6 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT ID_Sucursal FROM F7 where RFCE='" + tbSearchDelete.Text + "') UNION (SELECT ID_Sucursal FROM F8 where RFCE='" + tbSearchDelete.Text + "')" +
                "UNION (SELECT ID_Sucursal FROM F9 where RFCE='" + tbSearchDelete.Text + "')", conexionSQL);
                Dr = comandoSQL.ExecuteReader();
                Dr.Read();
                aux = Dr[0].ToString();
                Dr.Close();
                comandoSQL = new SqlCommand("SELECT Nombre FROM Sucursales where ID_Sucursal='" + aux + "'", conexionSQL);
                Dr = comandoSQL.ExecuteReader();
                Dr.Read();
                cbSuc.Text = Dr[0].ToString();
                Dr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ese RFC no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexionSQL.Close();
            }
        }

        private void tbRFCE_Leave(object sender, EventArgs e)
        {
            if (tbRFCE.Text=="")
            {
                MessageBox.Show("El campo RFC no puede quedar vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand comandoSQL;
                conexionSQL = new SqlConnection(Str);
                SqlDataReader Dr;
                conexionSQL.Open();
                int aux=0,nF;
                comandoSQL = new SqlCommand("(SELECT COUNT(*) FROM Catalogo)", conexionSQL);
                Dr = comandoSQL.ExecuteReader();
                Dr.Read();
                nF = int.Parse(Dr[0].ToString());
                Dr.Close();
                for (int i = 0; i < nF; i++)
                {
                    comandoSQL = new SqlCommand("(SELECT COUNT(*) FROM F"+(i+1)+" where RFCE='" + tbRFCE.Text + "')", conexionSQL);
                    Dr = comandoSQL.ExecuteReader();
                    Dr.Read();
                    aux += int.Parse(Dr[0].ToString());
                    Dr.Close();
                }
                if (aux > 0)
                {
                    MessageBox.Show("Este RFC ya esta dado de alta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbRFCE.Text = "";
                }
            }
        }

        private void tbNombres_Leave(object sender, EventArgs e)
        {
            if (tbNombres.Text == "")
            {
                MessageBox.Show("El campo Nombres no puede quedar vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbApe_Leave(object sender, EventArgs e)
        {
            if (tbApe.Text == "")
            {
                MessageBox.Show("El campo Apellidos no puede quedar vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbDir_Leave(object sender, EventArgs e)
        {
            if (tbDir.Text == "")
            {
                MessageBox.Show("El campo Dirección no puede quedar vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbTel_Leave(object sender, EventArgs e)
        {
            if (tbTel.Text == "")
            {
                MessageBox.Show("El campo Teléfono no puede quedar vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbPuesto_Leave(object sender, EventArgs e)
        {
            if (tbPuesto.Text == "")
            {
                MessageBox.Show("El campo Puesto no puede quedar vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbSueldo_Leave(object sender, EventArgs e)
        {
            if (tbSueldo.Text == "")
            {
                MessageBox.Show("El campo Sueldo no puede quedar vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbAñoN_Leave(object sender, EventArgs e)
        {
            if (tbAñoN.Text == "")
            {
                MessageBox.Show("El campo Año de nacimiento no puede quedar vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbAñoE_Leave(object sender, EventArgs e)
        {
            if (tbAñoE.Text == "")
            {
                MessageBox.Show("El campo Año de entrada no puede quedar vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbSuc_Leave(object sender, EventArgs e)
        {
            if (cbSuc.Text == "")
            {
                MessageBox.Show("El campo Sucursal no puede quedar vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbNomB_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (op)
            {
                case DialogResult.Yes:
                    SoloLetras(e);
                    break;
            }
        }
    }
}
