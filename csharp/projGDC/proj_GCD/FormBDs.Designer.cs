namespace proj_GCD
{
    partial class FormBDs
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
            this.rdbLeopardo = new System.Windows.Forms.RadioButton();
            this.rdbGodaddy = new System.Windows.Forms.RadioButton();
            this.rdbLocal = new System.Windows.Forms.RadioButton();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.btnFormBDs2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbLeopardo
            // 
            this.rdbLeopardo.AutoSize = true;
            this.rdbLeopardo.Location = new System.Drawing.Point(95, 59);
            this.rdbLeopardo.Name = "rdbLeopardo";
            this.rdbLeopardo.Size = new System.Drawing.Size(95, 19);
            this.rdbLeopardo.TabIndex = 0;
            this.rdbLeopardo.TabStop = true;
            this.rdbLeopardo.Text = "BD-Leopardo";
            this.rdbLeopardo.UseVisualStyleBackColor = true;
            this.rdbLeopardo.Click += new System.EventHandler(this.rdbLeopardo_Click);
            // 
            // rdbGodaddy
            // 
            this.rdbGodaddy.AutoSize = true;
            this.rdbGodaddy.Location = new System.Drawing.Point(96, 124);
            this.rdbGodaddy.Name = "rdbGodaddy";
            this.rdbGodaddy.Size = new System.Drawing.Size(93, 19);
            this.rdbGodaddy.TabIndex = 1;
            this.rdbGodaddy.TabStop = true;
            this.rdbGodaddy.Text = "BD-Godaddy";
            this.rdbGodaddy.UseVisualStyleBackColor = true;
            this.rdbGodaddy.Click += new System.EventHandler(this.rdbGodaddy_Click);
            // 
            // rdbLocal
            // 
            this.rdbLocal.AutoSize = true;
            this.rdbLocal.Location = new System.Drawing.Point(96, 181);
            this.rdbLocal.Name = "rdbLocal";
            this.rdbLocal.Size = new System.Drawing.Size(73, 19);
            this.rdbLocal.TabIndex = 2;
            this.rdbLocal.TabStop = true;
            this.rdbLocal.Text = "BD-Local";
            this.rdbLocal.UseVisualStyleBackColor = true;
            this.rdbLocal.Click += new System.EventHandler(this.rdbLocal_Click);
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 15;
            this.lstClientes.Location = new System.Drawing.Point(295, 46);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(228, 319);
            this.lstClientes.TabIndex = 3;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            // 
            // btnFormBDs2
            // 
            this.btnFormBDs2.Location = new System.Drawing.Point(513, 387);
            this.btnFormBDs2.Name = "btnFormBDs2";
            this.btnFormBDs2.Size = new System.Drawing.Size(142, 51);
            this.btnFormBDs2.TabIndex = 4;
            this.btnFormBDs2.Text = "Invocar o FormBDs2";
            this.btnFormBDs2.UseVisualStyleBackColor = true;
            this.btnFormBDs2.Click += new System.EventHandler(this.btnFormBDs2_Click_1);
            // 
            // FormBDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormBDs2);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.rdbLocal);
            this.Controls.Add(this.rdbGodaddy);
            this.Controls.Add(this.rdbLeopardo);
            this.Name = "FormBDs";
            this.Text = "FormBDs";
            this.Load += new System.EventHandler(this.FormBDs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rdbLeopardo;
        private RadioButton rdbGodaddy;
        private RadioButton rdbLocal;
        private ListBox lstClientes;
        private Button btnFormBDs2;
    }
}