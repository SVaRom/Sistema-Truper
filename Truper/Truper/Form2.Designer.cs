namespace Truper
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.cbFrag = new System.Windows.Forms.ComboBox();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el fragmento a utilizar:";
            // 
            // cbFrag
            // 
            this.cbFrag.FormattingEnabled = true;
            this.cbFrag.Location = new System.Drawing.Point(16, 30);
            this.cbFrag.Name = "cbFrag";
            this.cbFrag.Size = new System.Drawing.Size(162, 21);
            this.cbFrag.TabIndex = 1;
            this.cbFrag.TextChanged += new System.EventHandler(this.cbFrag_TextChanged);
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToOrderColumns = true;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(185, 13);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.Size = new System.Drawing.Size(527, 371);
            this.dgvSearch.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 288);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ver tabla original";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dentro del visualizador de datos\r\nusted puede añadir, eliminar, \r\nmodificar u ord" +
    "enar los registros.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.cbFrag);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador Truper";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFrag;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}