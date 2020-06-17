namespace Encriptador
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encriptarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desencriptarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtLlano = new System.Windows.Forms.TextBox();
            this.TxtCifrado = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem,
            this.opcionToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // opcionToolStripMenuItem
            // 
            this.opcionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encriptarToolStripMenuItem,
            this.desencriptarToolStripMenuItem});
            this.opcionToolStripMenuItem.Name = "opcionToolStripMenuItem";
            this.opcionToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.opcionToolStripMenuItem.Text = "Opcion";
            // 
            // encriptarToolStripMenuItem
            // 
            this.encriptarToolStripMenuItem.Name = "encriptarToolStripMenuItem";
            this.encriptarToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.encriptarToolStripMenuItem.Text = "Encriptar";
            this.encriptarToolStripMenuItem.Click += new System.EventHandler(this.encriptarToolStripMenuItem_Click);
            // 
            // desencriptarToolStripMenuItem
            // 
            this.desencriptarToolStripMenuItem.Name = "desencriptarToolStripMenuItem";
            this.desencriptarToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.desencriptarToolStripMenuItem.Text = "Desencriptar";
            this.desencriptarToolStripMenuItem.Click += new System.EventHandler(this.desencriptarToolStripMenuItem_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(18, 40);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(49, 13);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Encriptar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Texto llano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Texto cifrado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Encriptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtLlano
            // 
            this.TxtLlano.Location = new System.Drawing.Point(84, 72);
            this.TxtLlano.Name = "TxtLlano";
            this.TxtLlano.Size = new System.Drawing.Size(237, 20);
            this.TxtLlano.TabIndex = 3;
            // 
            // TxtCifrado
            // 
            this.TxtCifrado.Location = new System.Drawing.Point(402, 72);
            this.TxtCifrado.Name = "TxtCifrado";
            this.TxtCifrado.ReadOnly = true;
            this.TxtCifrado.Size = new System.Drawing.Size(237, 20);
            this.TxtCifrado.TabIndex = 3;
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(84, 124);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(237, 20);
            this.TxtClave.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Clave";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 194);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtCifrado);
            this.Controls.Add(this.TxtLlano);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Encriptador y decodificador de mensajes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtLlano;
        private System.Windows.Forms.TextBox TxtCifrado;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem opcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encriptarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desencriptarToolStripMenuItem;
    }
}

