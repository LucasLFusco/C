namespace Somar_a_N
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
            this.TXTa = new System.Windows.Forms.TextBox();
            this.TXTn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTresult = new System.Windows.Forms.RichTextBox();
            this.BTNcalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número A :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(29, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número N :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TXTa
            // 
            this.TXTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTa.Location = new System.Drawing.Point(205, 39);
            this.TXTa.Name = "TXTa";
            this.TXTa.Size = new System.Drawing.Size(67, 29);
            this.TXTa.TabIndex = 2;
            this.TXTa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TXTn
            // 
            this.TXTn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTn.Location = new System.Drawing.Point(205, 76);
            this.TXTn.Name = "TXTn";
            this.TXTn.Size = new System.Drawing.Size(67, 29);
            this.TXTn.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado :";
            // 
            // TXTresult
            // 
            this.TXTresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTresult.Location = new System.Drawing.Point(33, 248);
            this.TXTresult.Name = "TXTresult";
            this.TXTresult.Size = new System.Drawing.Size(210, 101);
            this.TXTresult.TabIndex = 5;
            this.TXTresult.Text = "";
            // 
            // BTNcalc
            // 
            this.BTNcalc.BackColor = System.Drawing.Color.IndianRed;
            this.BTNcalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNcalc.Location = new System.Drawing.Point(12, 137);
            this.BTNcalc.Name = "BTNcalc";
            this.BTNcalc.Size = new System.Drawing.Size(94, 41);
            this.BTNcalc.TabIndex = 6;
            this.BTNcalc.Text = "Calcular";
            this.BTNcalc.UseVisualStyleBackColor = false;
            this.BTNcalc.Click += new System.EventHandler(this.BTNcalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.BTNcalc);
            this.Controls.Add(this.TXTresult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTn);
            this.Controls.Add(this.TXTa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Soma de a e N";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTa;
        private System.Windows.Forms.TextBox TXTn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TXTresult;
        private System.Windows.Forms.Button BTNcalc;
    }
}

