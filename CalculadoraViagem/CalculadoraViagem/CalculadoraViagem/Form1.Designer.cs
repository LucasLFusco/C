namespace CalculadoraViagem
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdist = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtconsu = new System.Windows.Forms.TextBox();
            this.chkpedagio = new System.Windows.Forms.CheckBox();
            this.txtpedagio = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe os Dados abaixo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distância percorrida: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor do litro do combustível:  R$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Consumo do veiculo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(12, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total gasto com pedágio: R$";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(322, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Km";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtdist
            // 
            this.txtdist.Location = new System.Drawing.Point(216, 75);
            this.txtdist.Name = "txtdist";
            this.txtdist.Size = new System.Drawing.Size(100, 20);
            this.txtdist.TabIndex = 6;
            this.txtdist.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(337, 121);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 7;
            this.txtvalor.TextChanged += new System.EventHandler(this.txtvalor_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(334, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Km/L";
            // 
            // txtconsu
            // 
            this.txtconsu.Location = new System.Drawing.Point(228, 172);
            this.txtconsu.Name = "txtconsu";
            this.txtconsu.Size = new System.Drawing.Size(100, 20);
            this.txtconsu.TabIndex = 9;
            this.txtconsu.TextChanged += new System.EventHandler(this.txtconsu_TextChanged);
            // 
            // chkpedagio
            // 
            this.chkpedagio.AutoSize = true;
            this.chkpedagio.BackColor = System.Drawing.Color.Transparent;
            this.chkpedagio.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkpedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkpedagio.ForeColor = System.Drawing.Color.Yellow;
            this.chkpedagio.Location = new System.Drawing.Point(12, 212);
            this.chkpedagio.Name = "chkpedagio";
            this.chkpedagio.Size = new System.Drawing.Size(335, 28);
            this.chkpedagio.TabIndex = 10;
            this.chkpedagio.Text = "Acrescentar gastos com pedágio";
            this.chkpedagio.UseVisualStyleBackColor = false;
            this.chkpedagio.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtpedagio
            // 
            this.txtpedagio.Enabled = false;
            this.txtpedagio.Location = new System.Drawing.Point(291, 252);
            this.txtpedagio.Name = "txtpedagio";
            this.txtpedagio.Size = new System.Drawing.Size(100, 20);
            this.txtpedagio.TabIndex = 11;
            this.txtpedagio.TextChanged += new System.EventHandler(this.txtpedagio_TextChanged);
            // 
            // btncalc
            // 
            this.btncalc.BackColor = System.Drawing.Color.Orange;
            this.btncalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.Location = new System.Drawing.Point(113, 282);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(215, 63);
            this.btncalc.TabIndex = 12;
            this.btncalc.Text = "Calcular Viagem";
            this.btncalc.UseVisualStyleBackColor = false;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 357);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtpedagio);
            this.Controls.Add(this.chkpedagio);
            this.Controls.Add(this.txtconsu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtdist);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora de Viagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdist;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtconsu;
        private System.Windows.Forms.CheckBox chkpedagio;
        private System.Windows.Forms.TextBox txtpedagio;
        private System.Windows.Forms.Button btncalc;
    }
}

