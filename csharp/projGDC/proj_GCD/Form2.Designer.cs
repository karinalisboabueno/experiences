namespace proj_GCD
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRefCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsereCliente = new System.Windows.Forms.Button();
            this.btnDeleta = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRecolonizar = new System.Windows.Forms.Button();
            this.txtMarcador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.Size = new System.Drawing.Size(800, 193);
            this.dgvClientes.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 242);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtRefCliente
            // 
            this.txtRefCliente.Location = new System.Drawing.Point(150, 242);
            this.txtRefCliente.Name = "txtRefCliente";
            this.txtRefCliente.Size = new System.Drawing.Size(100, 23);
            this.txtRefCliente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ref. Cliente";
            // 
            // btnInsereCliente
            // 
            this.btnInsereCliente.Image = global::proj_GCD.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            this.btnInsereCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsereCliente.Location = new System.Drawing.Point(403, 233);
            this.btnInsereCliente.Name = "btnInsereCliente";
            this.btnInsereCliente.Size = new System.Drawing.Size(112, 39);
            this.btnInsereCliente.TabIndex = 5;
            this.btnInsereCliente.Text = "Inserir";
            this.btnInsereCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsereCliente.UseVisualStyleBackColor = true;
            this.btnInsereCliente.Click += new System.EventHandler(this.btnInsereCliente_Click);
            // 
            // btnDeleta
            // 
            this.btnDeleta.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDeleta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleta.Image = global::proj_GCD.Properties.Resources.delete_delete_deleteusers_delete_male_user_maleclient_2348;
            this.btnDeleta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleta.Location = new System.Drawing.Point(662, 233);
            this.btnDeleta.Name = "btnDeleta";
            this.btnDeleta.Size = new System.Drawing.Size(112, 39);
            this.btnDeleta.TabIndex = 6;
            this.btnDeleta.Text = "Deletar";
            this.btnDeleta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleta.UseVisualStyleBackColor = false;
            this.btnDeleta.Click += new System.EventHandler(this.btnDeleta_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::proj_GCD.Properties.Resources.businessapplication_edit_male_user_thepencil_theclient_negocio_2321;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(531, 233);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 39);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRecolonizar
            // 
            this.btnRecolonizar.Image = global::proj_GCD.Properties.Resources.committeedb_thedatabase_6332;
            this.btnRecolonizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecolonizar.Location = new System.Drawing.Point(653, 354);
            this.btnRecolonizar.Name = "btnRecolonizar";
            this.btnRecolonizar.Size = new System.Drawing.Size(121, 49);
            this.btnRecolonizar.TabIndex = 10;
            this.btnRecolonizar.Text = "Recolonizar";
            this.btnRecolonizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecolonizar.UseVisualStyleBackColor = true;
            this.btnRecolonizar.Click += new System.EventHandler(this.btnRecolonizar_Click);
            // 
            // txtMarcador
            // 
            this.txtMarcador.Location = new System.Drawing.Point(275, 242);
            this.txtMarcador.Name = "txtMarcador";
            this.txtMarcador.Size = new System.Drawing.Size(100, 23);
            this.txtMarcador.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Marcador";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarcador);
            this.Controls.Add(this.btnRecolonizar);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDeleta);
            this.Controls.Add(this.btnInsereCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRefCliente);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvClientes);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvClientes;
        private TextBox txtNome;
        private TextBox txtRefCliente;
        private Label label1;
        private Label label2;
        private Button btnInsereCliente;
        private Button btnDeleta;
        private Button btnUpdate;
        private Button btnRecolonizar;
        private TextBox txtMarcador;
        private Label label4;
    }
}