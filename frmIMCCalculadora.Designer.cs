namespace IMCCalculadora
{
    partial class frmIMCCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIMCCalculadora));
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rdbSexoM = new System.Windows.Forms.RadioButton();
            this.rdbSexoF = new System.Windows.Forms.RadioButton();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.rdbObesidadeGrauIII = new System.Windows.Forms.RadioButton();
            this.rdbObesidadeGrauII = new System.Windows.Forms.RadioButton();
            this.rdbObesidadeGrauI = new System.Windows.Forms.RadioButton();
            this.rdbSobrepeso = new System.Windows.Forms.RadioButton();
            this.rdbPesoNormal = new System.Windows.Forms.RadioButton();
            this.rdbAbaixoDoPeso = new System.Windows.Forms.RadioButton();
            this.pcbResultado = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gpbSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gpbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(12, 20);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(84, 20);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso (kg): ";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(12, 72);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(82, 20);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura (m):";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(12, 124);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(58, 20);
            this.lblIdade.TabIndex = 2;
            this.lblIdade.Text = "Idade: ";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(12, 43);
            this.txtPeso.MaxLength = 6;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 26);
            this.txtPeso.TabIndex = 0;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(12, 95);
            this.txtAltura.MaxLength = 4;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 26);
            this.txtAltura.TabIndex = 1;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(12, 147);
            this.txtIdade.MaxLength = 3;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 26);
            this.txtIdade.TabIndex = 2;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(221, 210);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 26);
            this.txtResultado.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(358, 62);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 40);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(358, 116);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 40);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(358, 505);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 40);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.pictureBox3);
            this.gpbSexo.Controls.Add(this.pictureBox2);
            this.gpbSexo.Controls.Add(this.rdbSexoM);
            this.gpbSexo.Controls.Add(this.rdbSexoF);
            this.gpbSexo.Location = new System.Drawing.Point(170, 43);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(140, 130);
            this.gpbSexo.TabIndex = 3;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(103, 77);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(103, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // rdbSexoM
            // 
            this.rdbSexoM.AutoSize = true;
            this.rdbSexoM.Location = new System.Drawing.Point(8, 81);
            this.rdbSexoM.Name = "rdbSexoM";
            this.rdbSexoM.Size = new System.Drawing.Size(98, 24);
            this.rdbSexoM.TabIndex = 4;
            this.rdbSexoM.TabStop = true;
            this.rdbSexoM.Text = "Masculino";
            this.rdbSexoM.UseVisualStyleBackColor = true;
            // 
            // rdbSexoF
            // 
            this.rdbSexoF.AutoSize = true;
            this.rdbSexoF.Location = new System.Drawing.Point(8, 36);
            this.rdbSexoF.Name = "rdbSexoF";
            this.rdbSexoF.Size = new System.Drawing.Size(92, 24);
            this.rdbSexoF.TabIndex = 3;
            this.rdbSexoF.TabStop = true;
            this.rdbSexoF.Text = "Feminino";
            this.rdbSexoF.UseVisualStyleBackColor = true;
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.rdbObesidadeGrauIII);
            this.gpbResultado.Controls.Add(this.rdbObesidadeGrauII);
            this.gpbResultado.Controls.Add(this.rdbObesidadeGrauI);
            this.gpbResultado.Controls.Add(this.rdbSobrepeso);
            this.gpbResultado.Controls.Add(this.rdbPesoNormal);
            this.gpbResultado.Controls.Add(this.rdbAbaixoDoPeso);
            this.gpbResultado.Controls.Add(this.pcbResultado);
            this.gpbResultado.Enabled = false;
            this.gpbResultado.Location = new System.Drawing.Point(91, 251);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(291, 239);
            this.gpbResultado.TabIndex = 12;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado";
            // 
            // rdbObesidadeGrauIII
            // 
            this.rdbObesidadeGrauIII.AutoSize = true;
            this.rdbObesidadeGrauIII.Location = new System.Drawing.Point(58, 193);
            this.rdbObesidadeGrauIII.Name = "rdbObesidadeGrauIII";
            this.rdbObesidadeGrauIII.Size = new System.Drawing.Size(163, 24);
            this.rdbObesidadeGrauIII.TabIndex = 5;
            this.rdbObesidadeGrauIII.TabStop = true;
            this.rdbObesidadeGrauIII.Text = "Obesidade Grau III";
            this.rdbObesidadeGrauIII.UseVisualStyleBackColor = true;
            // 
            // rdbObesidadeGrauII
            // 
            this.rdbObesidadeGrauII.AutoSize = true;
            this.rdbObesidadeGrauII.Location = new System.Drawing.Point(58, 163);
            this.rdbObesidadeGrauII.Name = "rdbObesidadeGrauII";
            this.rdbObesidadeGrauII.Size = new System.Drawing.Size(158, 24);
            this.rdbObesidadeGrauII.TabIndex = 4;
            this.rdbObesidadeGrauII.TabStop = true;
            this.rdbObesidadeGrauII.Text = "Obesidade Grau II";
            this.rdbObesidadeGrauII.UseVisualStyleBackColor = true;
            // 
            // rdbObesidadeGrauI
            // 
            this.rdbObesidadeGrauI.AutoSize = true;
            this.rdbObesidadeGrauI.Location = new System.Drawing.Point(58, 133);
            this.rdbObesidadeGrauI.Name = "rdbObesidadeGrauI";
            this.rdbObesidadeGrauI.Size = new System.Drawing.Size(153, 24);
            this.rdbObesidadeGrauI.TabIndex = 3;
            this.rdbObesidadeGrauI.TabStop = true;
            this.rdbObesidadeGrauI.Text = "Obesidade Grau I";
            this.rdbObesidadeGrauI.UseVisualStyleBackColor = true;
            // 
            // rdbSobrepeso
            // 
            this.rdbSobrepeso.AutoSize = true;
            this.rdbSobrepeso.Location = new System.Drawing.Point(58, 103);
            this.rdbSobrepeso.Name = "rdbSobrepeso";
            this.rdbSobrepeso.Size = new System.Drawing.Size(105, 24);
            this.rdbSobrepeso.TabIndex = 2;
            this.rdbSobrepeso.TabStop = true;
            this.rdbSobrepeso.Text = "Sobrepeso";
            this.rdbSobrepeso.UseVisualStyleBackColor = true;
            // 
            // rdbPesoNormal
            // 
            this.rdbPesoNormal.AutoSize = true;
            this.rdbPesoNormal.Location = new System.Drawing.Point(58, 73);
            this.rdbPesoNormal.Name = "rdbPesoNormal";
            this.rdbPesoNormal.Size = new System.Drawing.Size(117, 24);
            this.rdbPesoNormal.TabIndex = 1;
            this.rdbPesoNormal.TabStop = true;
            this.rdbPesoNormal.Text = "Peso Normal";
            this.rdbPesoNormal.UseVisualStyleBackColor = true;
            // 
            // rdbAbaixoDoPeso
            // 
            this.rdbAbaixoDoPeso.AutoSize = true;
            this.rdbAbaixoDoPeso.Location = new System.Drawing.Point(58, 43);
            this.rdbAbaixoDoPeso.Name = "rdbAbaixoDoPeso";
            this.rdbAbaixoDoPeso.Size = new System.Drawing.Size(137, 24);
            this.rdbAbaixoDoPeso.TabIndex = 0;
            this.rdbAbaixoDoPeso.TabStop = true;
            this.rdbAbaixoDoPeso.Text = "Abaixo do Peso";
            this.rdbAbaixoDoPeso.UseVisualStyleBackColor = true;
            // 
            // pcbResultado
            // 
            this.pcbResultado.Image = ((System.Drawing.Image)(resources.GetObject("pcbResultado.Image")));
            this.pcbResultado.Location = new System.Drawing.Point(13, 42);
            this.pcbResultado.Name = "pcbResultado";
            this.pcbResultado.Size = new System.Drawing.Size(61, 174);
            this.pcbResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbResultado.TabIndex = 6;
            this.pcbResultado.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(127, 213);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(88, 20);
            this.lblResultado.TabIndex = 13;
            this.lblResultado.Text = "Seu IMC é:";
            // 
            // frmIMCCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 557);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmIMCCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora IMC";
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gpbResultado.ResumeLayout(false);
            this.gpbResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rdbSexoM;
        private System.Windows.Forms.RadioButton rdbSexoF;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.RadioButton rdbObesidadeGrauIII;
        private System.Windows.Forms.RadioButton rdbObesidadeGrauII;
        private System.Windows.Forms.RadioButton rdbObesidadeGrauI;
        private System.Windows.Forms.RadioButton rdbSobrepeso;
        private System.Windows.Forms.RadioButton rdbPesoNormal;
        private System.Windows.Forms.RadioButton rdbAbaixoDoPeso;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox pcbResultado;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}