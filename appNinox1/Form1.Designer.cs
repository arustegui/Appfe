namespace appNinox1
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
            this.btn3 = new System.Windows.Forms.Button();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblRsocial = new System.Windows.Forms.Label();
            this.lblCp = new System.Windows.Forms.Label();
            this.upLoad = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtRsocial = new System.Windows.Forms.TextBox();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.lblpk12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtCsr = new System.Windows.Forms.TextBox();
            this.txtAliasp12 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtErpAlias = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCopiarcp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAliasp12 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerarCpCsr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(168, 386);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(121, 23);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "Generar Aliasp12";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(53, 109);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(32, 15);
            this.lblCuit.TabIndex = 6;
            this.lblCuit.Text = "CUIT";
            this.lblCuit.Click += new System.EventHandler(this.cuit_Click);
            // 
            // lblRsocial
            // 
            this.lblRsocial.AutoSize = true;
            this.lblRsocial.Location = new System.Drawing.Point(12, 73);
            this.lblRsocial.Name = "lblRsocial";
            this.lblRsocial.Size = new System.Drawing.Size(73, 15);
            this.lblRsocial.TabIndex = 7;
            this.lblRsocial.Text = "Razon Social";
            this.lblRsocial.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Location = new System.Drawing.Point(56, 215);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(22, 15);
            this.lblCp.TabIndex = 8;
            this.lblCp.Text = "CP";
            // 
            // upLoad
            // 
            this.upLoad.AutoSize = true;
            this.upLoad.Location = new System.Drawing.Point(48, 247);
            this.upLoad.Name = "upLoad";
            this.upLoad.Size = new System.Drawing.Size(28, 15);
            this.upLoad.TabIndex = 9;
            this.upLoad.Text = "CSR";
            this.upLoad.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(92, 101);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(208, 23);
            this.txtCuit.TabIndex = 10;
            this.txtCuit.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtRsocial
            // 
            this.txtRsocial.Location = new System.Drawing.Point(92, 70);
            this.txtRsocial.Name = "txtRsocial";
            this.txtRsocial.Size = new System.Drawing.Size(208, 23);
            this.txtRsocial.TabIndex = 11;
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(92, 207);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(352, 23);
            this.txtCp.TabIndex = 12;
            this.txtCp.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblpk12
            // 
            this.lblpk12.AutoSize = true;
            this.lblpk12.Location = new System.Drawing.Point(31, 349);
            this.lblpk12.Name = "lblpk12";
            this.lblpk12.Size = new System.Drawing.Size(52, 15);
            this.lblpk12.TabIndex = 14;
            this.lblpk12.Text = "alias.p12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Vencimiento";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(101, 436);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(126, 23);
            this.textBox5.TabIndex = 16;
            // 
            // txtCsr
            // 
            this.txtCsr.Location = new System.Drawing.Point(92, 239);
            this.txtCsr.Name = "txtCsr";
            this.txtCsr.Size = new System.Drawing.Size(352, 23);
            this.txtCsr.TabIndex = 18;
            this.txtCsr.TextChanged += new System.EventHandler(this.txtCsr_TextChanged);
            // 
            // txtAliasp12
            // 
            this.txtAliasp12.Location = new System.Drawing.Point(90, 346);
            this.txtAliasp12.Name = "txtAliasp12";
            this.txtAliasp12.Size = new System.Drawing.Size(448, 23);
            this.txtAliasp12.TabIndex = 20;
            this.txtAliasp12.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "ERP Alias:";
            // 
            // txtErpAlias
            // 
            this.txtErpAlias.Location = new System.Drawing.Point(92, 130);
            this.txtErpAlias.Name = "txtErpAlias";
            this.txtErpAlias.Size = new System.Drawing.Size(208, 23);
            this.txtErpAlias.TabIndex = 22;
            this.txtErpAlias.Text = "Ingresar nombre de cliente";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Crear Carpeta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCopiarcp
            // 
            this.btnCopiarcp.Location = new System.Drawing.Point(460, 204);
            this.btnCopiarcp.Name = "btnCopiarcp";
            this.btnCopiarcp.Size = new System.Drawing.Size(75, 26);
            this.btnCopiarcp.TabIndex = 24;
            this.btnCopiarcp.Text = "Copiar";
            this.btnCopiarcp.UseVisualStyleBackColor = true;
            this.btnCopiarcp.Click += new System.EventHandler(this.btnCopiarcp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 25;
            this.button1.Text = "Copiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAliasp12
            // 
            this.btnAliasp12.Location = new System.Drawing.Point(344, 386);
            this.btnAliasp12.Name = "btnAliasp12";
            this.btnAliasp12.Size = new System.Drawing.Size(75, 23);
            this.btnAliasp12.TabIndex = 26;
            this.btnAliasp12.Text = "Ir a carpeta";
            this.btnAliasp12.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(232, 278);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 45);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(52, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "GENERACION DE CLAVE PRIVADA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(101, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 32);
            this.label4.TabIndex = 29;
            this.label4.Text = "NINOX FE";
            // 
            // btnGenerarCpCsr
            // 
            this.btnGenerarCpCsr.Location = new System.Drawing.Point(81, 278);
            this.btnGenerarCpCsr.Name = "btnGenerarCpCsr";
            this.btnGenerarCpCsr.Size = new System.Drawing.Size(145, 45);
            this.btnGenerarCpCsr.TabIndex = 30;
            this.btnGenerarCpCsr.Text = "GENERAR CP y CSR";
            this.btnGenerarCpCsr.UseVisualStyleBackColor = true;
            this.btnGenerarCpCsr.Click += new System.EventHandler(this.btnGenerarCpCsr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 574);
            this.Controls.Add(this.btnGenerarCpCsr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAliasp12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCopiarcp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtErpAlias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAliasp12);
            this.Controls.Add(this.txtCsr);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblpk12);
            this.Controls.Add(this.txtCp);
            this.Controls.Add(this.txtRsocial);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.upLoad);
            this.Controls.Add(this.lblCp);
            this.Controls.Add(this.lblRsocial);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.btn3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn3;
        private Label lblCuit;
        private Label lblRsocial;
        private Label lblCp;
        private Label upLoad;
        private TextBox txtCuit;
        private TextBox txtRsocial;
        private TextBox txtCp;
        private Label lblpk12;
        private Label label2;
        private TextBox textBox5;
        private TextBox txtCsr;
        private TextBox txtAliasp12;
        private Label label1;
        private TextBox txtErpAlias;
        private Button button2;
        private Button btnCopiarcp;
        private Button button1;
        private Button btnAliasp12;
        private Button btnLimpiar;
        private Label label3;
        private Label label4;
        private Button btnGenerarCpCsr;
    }
}