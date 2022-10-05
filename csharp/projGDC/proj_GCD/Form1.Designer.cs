namespace proj_GCD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvMovimentos = new System.Windows.Forms.DataGridView();
            this.txtDebito = new System.Windows.Forms.TextBox();
            this.dtMovimento = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recolonizarMovimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarMêsCorrenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEntreDatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f3EliminarMovimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEntreDatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarLinhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lsbClientes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnAtualizarMovimentos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMovimentos = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblNumMovimentos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCreditoAcumulado = new System.Windows.Forms.TextBox();
            this.txtDebitoAcumulado = new System.Windows.Forms.TextBox();
            this.Acumulados = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTeste = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnFormBDs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMovimentos
            // 
            this.dgvMovimentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovimentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovimentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvMovimentos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvMovimentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMovimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimentos.Location = new System.Drawing.Point(275, 61);
            this.dgvMovimentos.Name = "dgvMovimentos";
            this.dgvMovimentos.RowTemplate.Height = 25;
            this.dgvMovimentos.Size = new System.Drawing.Size(705, 259);
            this.dgvMovimentos.TabIndex = 0;
            // 
            // txtDebito
            // 
            this.txtDebito.Location = new System.Drawing.Point(483, 38);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.Size = new System.Drawing.Size(113, 23);
            this.txtDebito.TabIndex = 1;
            // 
            // dtMovimento
            // 
            this.dtMovimento.CustomFormat = "yyyy-MM-dd";
            this.dtMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMovimento.Location = new System.Drawing.Point(24, 38);
            this.dtMovimento.Name = "dtMovimento";
            this.dtMovimento.Size = new System.Drawing.Size(113, 23);
            this.dtMovimento.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(829, 17);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 49);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(633, 38);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(113, 23);
            this.txtCredito.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.recolonizarMovimentosToolStripMenuItem,
            this.filtrosToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.f3EliminarMovimentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Clientes";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // recolonizarMovimentosToolStripMenuItem
            // 
            this.recolonizarMovimentosToolStripMenuItem.Name = "recolonizarMovimentosToolStripMenuItem";
            this.recolonizarMovimentosToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.recolonizarMovimentosToolStripMenuItem.Text = "Recolonizar Movimentos";
            this.recolonizarMovimentosToolStripMenuItem.Click += new System.EventHandler(this.recolonizarMovimentosToolStripMenuItem_Click);
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarMêsCorrenteToolStripMenuItem,
            this.listarEntreDatasToolStripMenuItem,
            this.balanceteToolStripMenuItem});
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.filtrosToolStripMenuItem.Text = "Filtros";
            // 
            // listarMêsCorrenteToolStripMenuItem
            // 
            this.listarMêsCorrenteToolStripMenuItem.Name = "listarMêsCorrenteToolStripMenuItem";
            this.listarMêsCorrenteToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.listarMêsCorrenteToolStripMenuItem.Text = "Listar Mês Corrente";
            this.listarMêsCorrenteToolStripMenuItem.Click += new System.EventHandler(this.listarMêsCorrenteToolStripMenuItem_Click);
            // 
            // listarEntreDatasToolStripMenuItem
            // 
            this.listarEntreDatasToolStripMenuItem.Name = "listarEntreDatasToolStripMenuItem";
            this.listarEntreDatasToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.listarEntreDatasToolStripMenuItem.Text = "Listar Entre Datas";
            this.listarEntreDatasToolStripMenuItem.Click += new System.EventHandler(this.listarEntreDatasToolStripMenuItem_Click);
            // 
            // balanceteToolStripMenuItem
            // 
            this.balanceteToolStripMenuItem.Name = "balanceteToolStripMenuItem";
            this.balanceteToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.balanceteToolStripMenuItem.Text = "Balancete";
            this.balanceteToolStripMenuItem.Click += new System.EventHandler(this.balanceteToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.imprimirToolStripMenuItem.Text = "⁬Imprimir";
            // 
            // f3EliminarMovimentoToolStripMenuItem
            // 
            this.f3EliminarMovimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarEntreDatasToolStripMenuItem,
            this.eliminarLinhaToolStripMenuItem});
            this.f3EliminarMovimentoToolStripMenuItem.Name = "f3EliminarMovimentoToolStripMenuItem";
            this.f3EliminarMovimentoToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.f3EliminarMovimentoToolStripMenuItem.Text = "Eliminar Movimento";
            // 
            // eliminarEntreDatasToolStripMenuItem
            // 
            this.eliminarEntreDatasToolStripMenuItem.Name = "eliminarEntreDatasToolStripMenuItem";
            this.eliminarEntreDatasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.eliminarEntreDatasToolStripMenuItem.Text = "Eliminar entre datas";
            this.eliminarEntreDatasToolStripMenuItem.Click += new System.EventHandler(this.eliminarEntreDatasToolStripMenuItem_Click);
            // 
            // eliminarLinhaToolStripMenuItem
            // 
            this.eliminarLinhaToolStripMenuItem.Name = "eliminarLinhaToolStripMenuItem";
            this.eliminarLinhaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.eliminarLinhaToolStripMenuItem.Text = "Eliminar Linha";
            this.eliminarLinhaToolStripMenuItem.Click += new System.EventHandler(this.eliminarLinhaToolStripMenuItem_Click);
            // 
            // lsbClientes
            // 
            this.lsbClientes.FormattingEnabled = true;
            this.lsbClientes.ItemHeight = 15;
            this.lsbClientes.Location = new System.Drawing.Point(36, 61);
            this.lsbClientes.Name = "lsbClientes";
            this.lsbClientes.Size = new System.Drawing.Size(210, 259);
            this.lsbClientes.TabIndex = 10;
            this.lsbClientes.SelectedIndexChanged += new System.EventHandler(this.lsbClientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Valor a debitar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valor a creditar";
            // 
            // txtFiltro
            // 
            this.txtFiltro.AccessibleName = "";
            this.txtFiltro.Location = new System.Drawing.Point(37, 33);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.PlaceholderText = "Nome a pesquisar...";
            this.txtFiltro.Size = new System.Drawing.Size(209, 23);
            this.txtFiltro.TabIndex = 13;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.dtMovimento);
            this.panel1.Controls.Add(this.txtDebito);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCredito);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 78);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descrição: (sem limite de nº de caracteres.)";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(155, 38);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(303, 23);
            this.txtDescricao.TabIndex = 13;
            // 
            // btnAtualizarMovimentos
            // 
            this.btnAtualizarMovimentos.Location = new System.Drawing.Point(469, 339);
            this.btnAtualizarMovimentos.Name = "btnAtualizarMovimentos";
            this.btnAtualizarMovimentos.Size = new System.Drawing.Size(121, 47);
            this.btnAtualizarMovimentos.TabIndex = 15;
            this.btnAtualizarMovimentos.Text = "Modificar Movimento";
            this.btnAtualizarMovimentos.UseVisualStyleBackColor = true;
            this.btnAtualizarMovimentos.Click += new System.EventHandler(this.AtualizarMovimento_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.panelMovimentos);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpFim);
            this.panel2.Controls.Add(this.dtpInicio);
            this.panel2.Location = new System.Drawing.Point(12, 510);
            this.panel2.Margin = new System.Windows.Forms.Padding(15);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(381, 80);
            this.panel2.TabIndex = 16;
            // 
            // panelMovimentos
            // 
            this.panelMovimentos.AutoSize = true;
            this.panelMovimentos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMovimentos.Location = new System.Drawing.Point(24, 62);
            this.panelMovimentos.Name = "panelMovimentos";
            this.panelMovimentos.Size = new System.Drawing.Size(0, 0);
            this.panelMovimentos.TabIndex = 21;
            this.panelMovimentos.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Entre datas:";
            // 
            // dtpFim
            // 
            this.dtpFim.Location = new System.Drawing.Point(196, 33);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(167, 23);
            this.dtpFim.TabIndex = 17;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(24, 33);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(166, 23);
            this.dtpInicio.TabIndex = 16;
            // 
            // lblNumMovimentos
            // 
            this.lblNumMovimentos.AutoSize = true;
            this.lblNumMovimentos.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumMovimentos.Location = new System.Drawing.Point(201, 339);
            this.lblNumMovimentos.Name = "lblNumMovimentos";
            this.lblNumMovimentos.Size = new System.Drawing.Size(38, 46);
            this.lblNumMovimentos.TabIndex = 20;
            this.lblNumMovimentos.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Número de Movimentos";
            // 
            // txtCreditoAcumulado
            // 
            this.txtCreditoAcumulado.Location = new System.Drawing.Point(198, 25);
            this.txtCreditoAcumulado.Name = "txtCreditoAcumulado";
            this.txtCreditoAcumulado.Size = new System.Drawing.Size(100, 23);
            this.txtCreditoAcumulado.TabIndex = 17;
            // 
            // txtDebitoAcumulado
            // 
            this.txtDebitoAcumulado.Location = new System.Drawing.Point(92, 25);
            this.txtDebitoAcumulado.Name = "txtDebitoAcumulado";
            this.txtDebitoAcumulado.Size = new System.Drawing.Size(100, 23);
            this.txtDebitoAcumulado.TabIndex = 18;
            // 
            // Acumulados
            // 
            this.Acumulados.AutoSize = true;
            this.Acumulados.BackColor = System.Drawing.Color.AliceBlue;
            this.Acumulados.Location = new System.Drawing.Point(0, 0);
            this.Acumulados.Name = "Acumulados";
            this.Acumulados.Size = new System.Drawing.Size(74, 15);
            this.Acumulados.TabIndex = 19;
            this.Acumulados.Text = "Acumulados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Débito";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Crédito";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.Acumulados);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtDebitoAcumulado);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtCreditoAcumulado);
            this.panel3.Location = new System.Drawing.Point(607, 326);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 68);
            this.panel3.TabIndex = 25;
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(275, 339);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(140, 23);
            this.btnTeste.TabIndex = 26;
            this.btnTeste.Text = "messageBoxNome";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(277, 370);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(138, 23);
            this.btnCount.TabIndex = 27;
            this.btnCount.Text = "count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnFormBDs
            // 
            this.btnFormBDs.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnFormBDs.Location = new System.Drawing.Point(832, 510);
            this.btnFormBDs.Name = "btnFormBDs";
            this.btnFormBDs.Size = new System.Drawing.Size(148, 47);
            this.btnFormBDs.TabIndex = 28;
            this.btnFormBDs.Text = "FormBDs";
            this.btnFormBDs.UseVisualStyleBackColor = false;
            this.btnFormBDs.Click += new System.EventHandler(this.btnFormBDs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(992, 612);
            this.Controls.Add(this.btnFormBDs);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblNumMovimentos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAtualizarMovimentos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lsbClientes);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvMovimentos);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvMovimentos;
        private TextBox txtDebito;
        private DateTimePicker dtMovimento;
        private Button btnGuardar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtCredito;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ListBox lsbClientes;
        private Label label1;
        private Label label2;
        private TextBox txtFiltro;
        private Panel panel1;
        private Label label3;
        private TextBox txtDescricao;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem recolonizarMovimentosToolStripMenuItem;
        private ToolStripMenuItem filtrosToolStripMenuItem;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private Button btnAtualizarMovimentos;
        private Panel panel2;
        private DateTimePicker dtpFim;
        private DateTimePicker dtpInicio;
        private TextBox txtCreditoAcumulado;
        private TextBox txtDebitoAcumulado;
        private Label Acumulados;
        private Panel panelMovimentos;
        private Label lblNumMovimentos;
        private Label label4;
        private Label label5;
        private ToolStripMenuItem listarMêsCorrenteToolStripMenuItem;
        private ToolStripMenuItem listarEntreDatasToolStripMenuItem;
        private ToolStripMenuItem balanceteToolStripMenuItem;
        private ToolStripMenuItem f3EliminarMovimentoToolStripMenuItem;
        private ToolStripMenuItem eliminarEntreDatasToolStripMenuItem;
        private ToolStripMenuItem eliminarLinhaToolStripMenuItem;
        private Label label6;
        private Label label7;
        private Panel panel3;
        private Button btnTeste;
        private Button btnCount;
        private Button btnFormBDs;
    }
}