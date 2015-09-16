namespace AplicacionFiguras
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbcirc = new System.Windows.Forms.RadioButton();
            this.rbrec = new System.Windows.Forms.RadioButton();
            this.gbCir = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCRadio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbAreaC = new System.Windows.Forms.Label();
            this.txtCX = new System.Windows.Forms.TextBox();
            this.txtCY = new System.Windows.Forms.TextBox();
            this.lbAreaR = new System.Windows.Forms.Label();
            this.txtrP2Y = new System.Windows.Forms.TextBox();
            this.txtrP2X = new System.Windows.Forms.TextBox();
            this.txtrP1Y = new System.Windows.Forms.TextBox();
            this.txtrP1X = new System.Windows.Forms.TextBox();
            this.gbrec = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCoordenada = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbCir.SuspendLayout();
            this.gbrec.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbcirc);
            this.groupBox1.Controls.Add(this.rbrec);
            this.groupBox1.Location = new System.Drawing.Point(30, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Que figura deseas dibujar?";
            // 
            // rbcirc
            // 
            this.rbcirc.AutoSize = true;
            this.rbcirc.Location = new System.Drawing.Point(30, 91);
            this.rbcirc.Name = "rbcirc";
            this.rbcirc.Size = new System.Drawing.Size(57, 17);
            this.rbcirc.TabIndex = 1;
            this.rbcirc.TabStop = true;
            this.rbcirc.Text = "Circulo";
            this.rbcirc.UseVisualStyleBackColor = true;
            this.rbcirc.CheckedChanged += new System.EventHandler(this.rbcirc_CheckedChanged);
            // 
            // rbrec
            // 
            this.rbrec.AutoSize = true;
            this.rbrec.Location = new System.Drawing.Point(30, 50);
            this.rbrec.Name = "rbrec";
            this.rbrec.Size = new System.Drawing.Size(80, 17);
            this.rbrec.TabIndex = 0;
            this.rbrec.TabStop = true;
            this.rbrec.Text = "Rectangulo";
            this.rbrec.UseVisualStyleBackColor = true;
            this.rbrec.CheckedChanged += new System.EventHandler(this.rbrec_CheckedChanged);
            // 
            // gbCir
            // 
            this.gbCir.Controls.Add(this.label10);
            this.gbCir.Controls.Add(this.label4);
            this.gbCir.Controls.Add(this.txtCRadio);
            this.gbCir.Controls.Add(this.label5);
            this.gbCir.Controls.Add(this.label6);
            this.gbCir.Controls.Add(this.lbAreaC);
            this.gbCir.Controls.Add(this.txtCX);
            this.gbCir.Controls.Add(this.txtCY);
            this.gbCir.Enabled = false;
            this.gbCir.Location = new System.Drawing.Point(331, 247);
            this.gbCir.Name = "gbCir";
            this.gbCir.Size = new System.Drawing.Size(199, 211);
            this.gbCir.TabIndex = 1;
            this.gbCir.TabStop = false;
            this.gbCir.Text = "Circulo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y";
            // 
            // txtCRadio
            // 
            this.txtCRadio.Location = new System.Drawing.Point(73, 102);
            this.txtCRadio.Name = "txtCRadio";
            this.txtCRadio.Size = new System.Drawing.Size(39, 20);
            this.txtCRadio.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Punto 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Radio";
            // 
            // lbAreaC
            // 
            this.lbAreaC.AutoSize = true;
            this.lbAreaC.Location = new System.Drawing.Point(83, 169);
            this.lbAreaC.Name = "lbAreaC";
            this.lbAreaC.Size = new System.Drawing.Size(29, 13);
            this.lbAreaC.TabIndex = 7;
            this.lbAreaC.Text = "Area";
            // 
            // txtCX
            // 
            this.txtCX.Location = new System.Drawing.Point(29, 47);
            this.txtCX.Name = "txtCX";
            this.txtCX.Size = new System.Drawing.Size(39, 20);
            this.txtCX.TabIndex = 4;
            // 
            // txtCY
            // 
            this.txtCY.Location = new System.Drawing.Point(117, 47);
            this.txtCY.Name = "txtCY";
            this.txtCY.Size = new System.Drawing.Size(39, 20);
            this.txtCY.TabIndex = 5;
            // 
            // lbAreaR
            // 
            this.lbAreaR.AutoSize = true;
            this.lbAreaR.Location = new System.Drawing.Point(80, 158);
            this.lbAreaR.Name = "lbAreaR";
            this.lbAreaR.Size = new System.Drawing.Size(29, 13);
            this.lbAreaR.TabIndex = 4;
            this.lbAreaR.Text = "Area";
            // 
            // txtrP2Y
            // 
            this.txtrP2Y.Location = new System.Drawing.Point(106, 102);
            this.txtrP2Y.Name = "txtrP2Y";
            this.txtrP2Y.Size = new System.Drawing.Size(39, 20);
            this.txtrP2Y.TabIndex = 3;
            this.txtrP2Y.TextChanged += new System.EventHandler(this.txtCP2Y_TextChanged);
            // 
            // txtrP2X
            // 
            this.txtrP2X.Location = new System.Drawing.Point(28, 102);
            this.txtrP2X.Name = "txtrP2X";
            this.txtrP2X.Size = new System.Drawing.Size(39, 20);
            this.txtrP2X.TabIndex = 2;
            // 
            // txtrP1Y
            // 
            this.txtrP1Y.Location = new System.Drawing.Point(106, 47);
            this.txtrP1Y.Name = "txtrP1Y";
            this.txtrP1Y.Size = new System.Drawing.Size(39, 20);
            this.txtrP1Y.TabIndex = 1;
            // 
            // txtrP1X
            // 
            this.txtrP1X.Location = new System.Drawing.Point(28, 47);
            this.txtrP1X.Name = "txtrP1X";
            this.txtrP1X.Size = new System.Drawing.Size(39, 20);
            this.txtrP1X.TabIndex = 0;
            // 
            // gbrec
            // 
            this.gbrec.Controls.Add(this.label9);
            this.gbrec.Controls.Add(this.label8);
            this.gbrec.Controls.Add(this.label7);
            this.gbrec.Controls.Add(this.label3);
            this.gbrec.Controls.Add(this.label2);
            this.gbrec.Controls.Add(this.label1);
            this.gbrec.Controls.Add(this.lbAreaR);
            this.gbrec.Controls.Add(this.txtrP2Y);
            this.gbrec.Controls.Add(this.txtrP1X);
            this.gbrec.Controls.Add(this.txtrP2X);
            this.gbrec.Controls.Add(this.txtrP1Y);
            this.gbrec.Enabled = false;
            this.gbrec.Location = new System.Drawing.Point(60, 247);
            this.gbrec.Name = "gbrec";
            this.gbrec.Size = new System.Drawing.Size(215, 211);
            this.gbrec.TabIndex = 2;
            this.gbrec.TabStop = false;
            this.gbrec.Text = "Rectangulo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Punto 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Punto 1";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(574, 280);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 33);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Enabled = false;
            this.btnDibujar.Location = new System.Drawing.Point(574, 333);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(90, 32);
            this.btnDibujar.TabIndex = 4;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(274, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 198);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lbCoordenada
            // 
            this.lbCoordenada.AutoSize = true;
            this.lbCoordenada.Location = new System.Drawing.Point(281, 227);
            this.lbCoordenada.Name = "lbCoordenada";
            this.lbCoordenada.Size = new System.Drawing.Size(40, 13);
            this.lbCoordenada.TabIndex = 6;
            this.lbCoordenada.Text = "(0) , (1)";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(574, 387);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(90, 31);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 479);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.gbrec);
            this.Controls.Add(this.lbCoordenada);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbCir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCir.ResumeLayout(false);
            this.gbCir.PerformLayout();
            this.gbrec.ResumeLayout(false);
            this.gbrec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbcirc;
        private System.Windows.Forms.RadioButton rbrec;
        private System.Windows.Forms.GroupBox gbCir;
        private System.Windows.Forms.GroupBox gbrec;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbAreaR;
        private System.Windows.Forms.TextBox txtrP2Y;
        private System.Windows.Forms.TextBox txtrP2X;
        private System.Windows.Forms.TextBox txtrP1Y;
        private System.Windows.Forms.TextBox txtrP1X;
        private System.Windows.Forms.Label lbAreaC;
        private System.Windows.Forms.TextBox txtCRadio;
        private System.Windows.Forms.TextBox txtCY;
        private System.Windows.Forms.TextBox txtCX;
        private System.Windows.Forms.Label lbCoordenada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBorrar;
    }
}

