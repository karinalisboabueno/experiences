namespace proj_GCD
{
    partial class FormBDs2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnClienteSelecionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(261, 213);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(258, 154);
            this.listBox1.TabIndex = 1;
            // 
            // btnClienteSelecionado
            // 
            this.btnClienteSelecionado.Location = new System.Drawing.Point(261, 74);
            this.btnClienteSelecionado.Name = "btnClienteSelecionado";
            this.btnClienteSelecionado.Size = new System.Drawing.Size(258, 71);
            this.btnClienteSelecionado.TabIndex = 2;
            this.btnClienteSelecionado.Text = "Clicar aqui: aparecerá nesta listbox, o cliente selecionado na listbox do form an" +
    "terior.";
            this.btnClienteSelecionado.UseVisualStyleBackColor = true;
            this.btnClienteSelecionado.Click += new System.EventHandler(this.btnClienteSelecionado_Click);
            // 
            // FormBDs2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClienteSelecionado);
            this.Controls.Add(this.listBox1);
            this.Name = "FormBDs2";
            this.Text = "FormBDs2";
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox listBox1;
        private Button btnClienteSelecionado;
    }
}