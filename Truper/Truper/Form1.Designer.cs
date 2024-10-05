namespace Truper
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripSeparator();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnAdm = new System.Windows.Forms.Button();
            this.tbNomB = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.lblRFCE = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblAñoN = new System.Windows.Forms.Label();
            this.lblAñoE = new System.Windows.Forms.Label();
            this.lblSuc = new System.Windows.Forms.Label();
            this.tbRFCE = new System.Windows.Forms.TextBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.tbApe = new System.Windows.Forms.TextBox();
            this.tbDir = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbPuesto = new System.Windows.Forms.TextBox();
            this.tbSueldo = new System.Windows.Forms.TextBox();
            this.tbAñoN = new System.Windows.Forms.TextBox();
            this.tbAñoE = new System.Windows.Forms.TextBox();
            this.cbSuc = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSelectB = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblMod = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.tbSearchDelete = new System.Windows.Forms.TextBox();
            this.btnEnc = new System.Windows.Forms.Button();
            this.emp = new System.Windows.Forms.PictureBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblAdm = new System.Windows.Forms.Label();
            this.pbA = new System.Windows.Forms.PictureBox();
            this.pbB = new System.Windows.Forms.PictureBox();
            this.pbC = new System.Windows.Forms.PictureBox();
            this.pbM = new System.Windows.Forms.PictureBox();
            this.pbAdm = new System.Windows.Forms.PictureBox();
            this.lblBie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdm)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(720, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = global::Truper.Properties.Resources.icons8_admin_settings_male_50;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(107, 24);
            this.toolStripButton1.Text = "Administrador";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Truper.Properties.Resources.icons8_add_property_50;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 24);
            this.toolStripButton2.Text = "Alta";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::Truper.Properties.Resources.icons8_delete_file_50;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(53, 24);
            this.toolStripButton3.Text = "Baja";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::Truper.Properties.Resources.icons8_search_property_50;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(78, 24);
            this.toolStripButton4.Text = "Consulta";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::Truper.Properties.Resources.icons8_available_updates_50;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(101, 24);
            this.toolStripButton5.Text = "Modificación";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(6, 27);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(264, 246);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Usuario:";
            this.lblUser.Visible = false;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(246, 306);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(64, 13);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Contraseña:";
            this.lblPass.Visible = false;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(331, 239);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 20);
            this.tbUser.TabIndex = 3;
            this.tbUser.Visible = false;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(331, 299);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 4;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.Visible = false;
            // 
            // btnAdm
            // 
            this.btnAdm.Location = new System.Drawing.Point(319, 365);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(75, 23);
            this.btnAdm.TabIndex = 6;
            this.btnAdm.Text = "Ingresar";
            this.btnAdm.UseVisualStyleBackColor = true;
            this.btnAdm.Visible = false;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // tbNomB
            // 
            this.tbNomB.Location = new System.Drawing.Point(235, 27);
            this.tbNomB.Name = "tbNomB";
            this.tbNomB.Size = new System.Drawing.Size(369, 20);
            this.tbNomB.TabIndex = 7;
            this.tbNomB.Visible = false;
            this.tbNomB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomB_KeyPress);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(15, 31);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(119, 13);
            this.lblBusqueda.TabIndex = 8;
            this.lblBusqueda.Text = "Sin modo de busqueda:";
            this.lblBusqueda.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(610, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AllowUserToAddRows = false;
            this.dgvBusqueda.AllowUserToDeleteRows = false;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Location = new System.Drawing.Point(12, 54);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.Size = new System.Drawing.Size(696, 379);
            this.dgvBusqueda.TabIndex = 10;
            this.dgvBusqueda.Visible = false;
            // 
            // lblRFCE
            // 
            this.lblRFCE.AutoSize = true;
            this.lblRFCE.Location = new System.Drawing.Point(132, 102);
            this.lblRFCE.Name = "lblRFCE";
            this.lblRFCE.Size = new System.Drawing.Size(31, 13);
            this.lblRFCE.TabIndex = 11;
            this.lblRFCE.Text = "RFC:";
            this.lblRFCE.Visible = false;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(111, 157);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(52, 13);
            this.lblNombres.TabIndex = 12;
            this.lblNombres.Text = "Nombres:";
            this.lblNombres.Visible = false;
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Location = new System.Drawing.Point(114, 202);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(52, 13);
            this.lblApe.TabIndex = 13;
            this.lblApe.Text = "Apellidos:";
            this.lblApe.Visible = false;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(111, 246);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(55, 13);
            this.lblDir.TabIndex = 14;
            this.lblDir.Text = "Dirección:";
            this.lblDir.Visible = false;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(114, 293);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 15;
            this.lblTel.Text = "Teléfono:";
            this.lblTel.Visible = false;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(448, 102);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(43, 13);
            this.lblPuesto.TabIndex = 16;
            this.lblPuesto.Text = "Puesto:";
            this.lblPuesto.Visible = false;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(448, 157);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(43, 13);
            this.lblSueldo.TabIndex = 17;
            this.lblSueldo.Text = "Sueldo:";
            this.lblSueldo.Visible = false;
            // 
            // lblAñoN
            // 
            this.lblAñoN.AutoSize = true;
            this.lblAñoN.Location = new System.Drawing.Point(393, 202);
            this.lblAñoN.Name = "lblAñoN";
            this.lblAñoN.Size = new System.Drawing.Size(98, 13);
            this.lblAñoN.TabIndex = 18;
            this.lblAñoN.Text = "Año de nacimiento:";
            this.lblAñoN.Visible = false;
            // 
            // lblAñoE
            // 
            this.lblAñoE.AutoSize = true;
            this.lblAñoE.Location = new System.Drawing.Point(408, 246);
            this.lblAñoE.Name = "lblAñoE";
            this.lblAñoE.Size = new System.Drawing.Size(83, 13);
            this.lblAñoE.TabIndex = 19;
            this.lblAñoE.Text = "Año de entrada:";
            this.lblAñoE.Visible = false;
            // 
            // lblSuc
            // 
            this.lblSuc.AutoSize = true;
            this.lblSuc.Location = new System.Drawing.Point(375, 293);
            this.lblSuc.Name = "lblSuc";
            this.lblSuc.Size = new System.Drawing.Size(116, 13);
            this.lblSuc.TabIndex = 20;
            this.lblSuc.Text = "Seleccione la sucursal:";
            this.lblSuc.Visible = false;
            // 
            // tbRFCE
            // 
            this.tbRFCE.Location = new System.Drawing.Point(175, 99);
            this.tbRFCE.MaxLength = 13;
            this.tbRFCE.Name = "tbRFCE";
            this.tbRFCE.Size = new System.Drawing.Size(111, 20);
            this.tbRFCE.TabIndex = 21;
            this.tbRFCE.Visible = false;
            this.tbRFCE.Leave += new System.EventHandler(this.tbRFCE_Leave);
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(175, 154);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(111, 20);
            this.tbNombres.TabIndex = 22;
            this.tbNombres.Visible = false;
            this.tbNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombres_KeyPress);
            this.tbNombres.Leave += new System.EventHandler(this.tbNombres_Leave);
            // 
            // tbApe
            // 
            this.tbApe.Location = new System.Drawing.Point(175, 199);
            this.tbApe.Name = "tbApe";
            this.tbApe.Size = new System.Drawing.Size(111, 20);
            this.tbApe.TabIndex = 23;
            this.tbApe.Visible = false;
            this.tbApe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApe_KeyPress);
            this.tbApe.Leave += new System.EventHandler(this.tbApe_Leave);
            // 
            // tbDir
            // 
            this.tbDir.Location = new System.Drawing.Point(175, 243);
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(111, 20);
            this.tbDir.TabIndex = 24;
            this.tbDir.Visible = false;
            this.tbDir.Leave += new System.EventHandler(this.tbDir_Leave);
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(172, 290);
            this.tbTel.MaxLength = 9;
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(111, 20);
            this.tbTel.TabIndex = 25;
            this.tbTel.Visible = false;
            this.tbTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTel_KeyPress);
            this.tbTel.Leave += new System.EventHandler(this.tbTel_Leave);
            // 
            // tbPuesto
            // 
            this.tbPuesto.Location = new System.Drawing.Point(507, 99);
            this.tbPuesto.Name = "tbPuesto";
            this.tbPuesto.Size = new System.Drawing.Size(111, 20);
            this.tbPuesto.TabIndex = 26;
            this.tbPuesto.Visible = false;
            this.tbPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPuesto_KeyPress);
            this.tbPuesto.Leave += new System.EventHandler(this.tbPuesto_Leave);
            // 
            // tbSueldo
            // 
            this.tbSueldo.Location = new System.Drawing.Point(507, 154);
            this.tbSueldo.Name = "tbSueldo";
            this.tbSueldo.Size = new System.Drawing.Size(111, 20);
            this.tbSueldo.TabIndex = 27;
            this.tbSueldo.Visible = false;
            this.tbSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSueldo_KeyPress);
            this.tbSueldo.Leave += new System.EventHandler(this.tbSueldo_Leave);
            // 
            // tbAñoN
            // 
            this.tbAñoN.Location = new System.Drawing.Point(507, 199);
            this.tbAñoN.MaxLength = 4;
            this.tbAñoN.Name = "tbAñoN";
            this.tbAñoN.Size = new System.Drawing.Size(111, 20);
            this.tbAñoN.TabIndex = 28;
            this.tbAñoN.Visible = false;
            this.tbAñoN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAñoN_KeyPress);
            this.tbAñoN.Leave += new System.EventHandler(this.tbAñoN_Leave);
            // 
            // tbAñoE
            // 
            this.tbAñoE.Location = new System.Drawing.Point(507, 239);
            this.tbAñoE.MaxLength = 4;
            this.tbAñoE.Name = "tbAñoE";
            this.tbAñoE.Size = new System.Drawing.Size(111, 20);
            this.tbAñoE.TabIndex = 29;
            this.tbAñoE.Visible = false;
            this.tbAñoE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAñoE_KeyPress);
            this.tbAñoE.Leave += new System.EventHandler(this.tbAñoE_Leave);
            // 
            // cbSuc
            // 
            this.cbSuc.FormattingEnabled = true;
            this.cbSuc.Location = new System.Drawing.Point(497, 289);
            this.cbSuc.Name = "cbSuc";
            this.cbSuc.Size = new System.Drawing.Size(121, 21);
            this.cbSuc.TabIndex = 30;
            this.cbSuc.Visible = false;
            this.cbSuc.Leave += new System.EventHandler(this.cbSuc_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(319, 365);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSelectB
            // 
            this.lblSelectB.AutoSize = true;
            this.lblSelectB.Location = new System.Drawing.Point(31, 31);
            this.lblSelectB.Name = "lblSelectB";
            this.lblSelectB.Size = new System.Drawing.Size(193, 13);
            this.lblSelectB.TabIndex = 33;
            this.lblSelectB.Text = "Ingrese el RFC del empleado a eliminar:";
            this.lblSelectB.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(319, 365);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 35;
            this.btnDel.Text = "Eliminar";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Location = new System.Drawing.Point(32, 31);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(200, 13);
            this.lblMod.TabIndex = 36;
            this.lblMod.Text = "Ingrese el RFC del empleado a modificar:";
            this.lblMod.Visible = false;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(319, 365);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 37;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Visible = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // tbSearchDelete
            // 
            this.tbSearchDelete.Location = new System.Drawing.Point(225, 27);
            this.tbSearchDelete.MaxLength = 13;
            this.tbSearchDelete.Name = "tbSearchDelete";
            this.tbSearchDelete.Size = new System.Drawing.Size(369, 20);
            this.tbSearchDelete.TabIndex = 38;
            this.tbSearchDelete.Visible = false;
            // 
            // btnEnc
            // 
            this.btnEnc.Location = new System.Drawing.Point(610, 28);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(75, 23);
            this.btnEnc.TabIndex = 39;
            this.btnEnc.Text = "Encontrar";
            this.btnEnc.UseVisualStyleBackColor = true;
            this.btnEnc.Visible = false;
            this.btnEnc.Click += new System.EventHandler(this.btnEnc_Click);
            // 
            // emp
            // 
            this.emp.Image = global::Truper.Properties.Resources.Employd;
            this.emp.InitialImage = global::Truper.Properties.Resources.Employd;
            this.emp.Location = new System.Drawing.Point(291, 50);
            this.emp.Name = "emp";
            this.emp.Size = new System.Drawing.Size(140, 140);
            this.emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emp.TabIndex = 5;
            this.emp.TabStop = false;
            this.emp.Visible = false;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(71, 93);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(321, 36);
            this.lblA.TabIndex = 42;
            this.lblA.Text = "Alta:\r\nEn esta sección podrás añadir a un nuevo empleado.";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(70, 153);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(340, 38);
            this.lblB.TabIndex = 43;
            this.lblB.Text = "Baja:\r\nEn esta sección podrás eliminar a algún empleado.";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.Location = new System.Drawing.Point(71, 298);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(405, 38);
            this.lblM.TabIndex = 44;
            this.lblM.Text = "Modificación:\r\nEn esta sección podrás modificar los datos de tus empleados.";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(70, 225);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(370, 38);
            this.lblC.TabIndex = 45;
            this.lblC.Text = "Consulta:\r\nEn esta sección podrás consultar a cualquier empleado.";
            // 
            // lblAdm
            // 
            this.lblAdm.AutoSize = true;
            this.lblAdm.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdm.Location = new System.Drawing.Point(71, 365);
            this.lblAdm.Name = "lblAdm";
            this.lblAdm.Size = new System.Drawing.Size(587, 38);
            this.lblAdm.TabIndex = 46;
            this.lblAdm.Text = "Administrador:\r\nEn esta sección es necesario autentificarte para poder ver las op" +
    "ciones de administrador.";
            // 
            // pbA
            // 
            this.pbA.Image = global::Truper.Properties.Resources.icons8_add_property_50;
            this.pbA.Location = new System.Drawing.Point(15, 82);
            this.pbA.Name = "pbA";
            this.pbA.Size = new System.Drawing.Size(50, 50);
            this.pbA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbA.TabIndex = 47;
            this.pbA.TabStop = false;
            // 
            // pbB
            // 
            this.pbB.Image = global::Truper.Properties.Resources.icons8_delete_file_50;
            this.pbB.Location = new System.Drawing.Point(14, 149);
            this.pbB.Name = "pbB";
            this.pbB.Size = new System.Drawing.Size(50, 50);
            this.pbB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbB.TabIndex = 48;
            this.pbB.TabStop = false;
            // 
            // pbC
            // 
            this.pbC.Image = global::Truper.Properties.Resources.icons8_search_property_50;
            this.pbC.Location = new System.Drawing.Point(14, 218);
            this.pbC.Name = "pbC";
            this.pbC.Size = new System.Drawing.Size(50, 50);
            this.pbC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbC.TabIndex = 49;
            this.pbC.TabStop = false;
            // 
            // pbM
            // 
            this.pbM.Image = global::Truper.Properties.Resources.icons8_available_updates_50;
            this.pbM.Location = new System.Drawing.Point(15, 289);
            this.pbM.Name = "pbM";
            this.pbM.Size = new System.Drawing.Size(50, 50);
            this.pbM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbM.TabIndex = 50;
            this.pbM.TabStop = false;
            // 
            // pbAdm
            // 
            this.pbAdm.Image = global::Truper.Properties.Resources.icons8_admin_settings_male_50;
            this.pbAdm.Location = new System.Drawing.Point(15, 353);
            this.pbAdm.Name = "pbAdm";
            this.pbAdm.Size = new System.Drawing.Size(50, 50);
            this.pbAdm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAdm.TabIndex = 51;
            this.pbAdm.TabStop = false;
            // 
            // lblBie
            // 
            this.lblBie.AutoSize = true;
            this.lblBie.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblBie.Location = new System.Drawing.Point(149, 54);
            this.lblBie.Name = "lblBie";
            this.lblBie.Size = new System.Drawing.Size(445, 23);
            this.lblBie.TabIndex = 52;
            this.lblBie.Text = "Esta aplicacion te ayudará a realizar las siguientes tareas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "Bienvenido al sistema Truper";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 445);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.tbNomB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnAdm);
            this.Controls.Add(this.emp);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbSuc);
            this.Controls.Add(this.tbAñoE);
            this.Controls.Add(this.tbAñoN);
            this.Controls.Add(this.tbSueldo);
            this.Controls.Add(this.tbPuesto);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbDir);
            this.Controls.Add(this.tbApe);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.tbRFCE);
            this.Controls.Add(this.lblSuc);
            this.Controls.Add(this.lblAñoE);
            this.Controls.Add(this.lblAñoN);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.lblApe);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblRFCE);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.lblSelectB);
            this.Controls.Add(this.tbSearchDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEnc);
            this.Controls.Add(this.dgvBusqueda);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBie);
            this.Controls.Add(this.pbAdm);
            this.Controls.Add(this.pbM);
            this.Controls.Add(this.pbC);
            this.Controls.Add(this.pbA);
            this.Controls.Add(this.lblAdm);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.pbB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(736, 484);
            this.MinimumSize = new System.Drawing.Size(736, 484);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Truper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripButton6;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox tbUser;
        public System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.PictureBox emp;
        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.TextBox tbNomB;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.Label lblRFCE;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblAñoN;
        private System.Windows.Forms.Label lblAñoE;
        private System.Windows.Forms.Label lblSuc;
        private System.Windows.Forms.TextBox tbRFCE;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.TextBox tbApe;
        private System.Windows.Forms.TextBox tbDir;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbPuesto;
        private System.Windows.Forms.TextBox tbSueldo;
        private System.Windows.Forms.TextBox tbAñoN;
        private System.Windows.Forms.TextBox tbAñoE;
        private System.Windows.Forms.ComboBox cbSuc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSelectB;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.TextBox tbSearchDelete;
        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblAdm;
        private System.Windows.Forms.PictureBox pbA;
        private System.Windows.Forms.PictureBox pbB;
        private System.Windows.Forms.PictureBox pbC;
        private System.Windows.Forms.PictureBox pbM;
        private System.Windows.Forms.PictureBox pbAdm;
        private System.Windows.Forms.Label lblBie;
        private System.Windows.Forms.Label label1;
    }
}

