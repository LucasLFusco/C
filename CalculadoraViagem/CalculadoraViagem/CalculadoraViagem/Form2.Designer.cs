namespace CalculadoraViagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.qtdLitros = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.vtotalcomb = new System.Windows.Forms.Label();
            this.vtotal = new System.Windows.Forms.Label();
            this.vkm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de litros de combustível usados: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor gasto com a viagem: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(408, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor total gasto apenas com combustível: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label4.Location = new System.Drawing.Point(12, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor por KM rodado: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // qtdLitros
            // 
            this.qtdLitros.AutoSize = true;
            this.qtdLitros.BackColor = System.Drawing.Color.Transparent;
            this.qtdLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdLitros.ForeColor = System.Drawing.Color.Red;
            this.qtdLitros.Location = new System.Drawing.Point(19, 62);
            this.qtdLitros.Name = "qtdLitros";
            this.qtdLitros.Size = new System.Drawing.Size(57, 20);
            this.qtdLitros.TabIndex = 5;
            this.qtdLitros.Text = "label6";
            this.qtdLitros.Click += new System.EventHandler(this.txtresult_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(224, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 55);
            this.button2.TabIndex = 9;
            this.button2.Text = "Salvar relatório";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // vtotalcomb
            // 
            this.vtotalcomb.AutoSize = true;
            this.vtotalcomb.BackColor = System.Drawing.Color.Transparent;
            this.vtotalcomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vtotalcomb.ForeColor = System.Drawing.Color.Red;
            this.vtotalcomb.Location = new System.Drawing.Point(18, 133);
            this.vtotalcomb.Name = "vtotalcomb";
            this.vtotalcomb.Size = new System.Drawing.Size(57, 20);
            this.vtotalcomb.TabIndex = 10;
            this.vtotalcomb.Text = "label7";
            // 
            // vtotal
            // 
            this.vtotal.AutoSize = true;
            this.vtotal.BackColor = System.Drawing.Color.Transparent;
            this.vtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vtotal.ForeColor = System.Drawing.Color.Red;
            this.vtotal.Location = new System.Drawing.Point(19, 211);
            this.vtotal.Name = "vtotal";
            this.vtotal.Size = new System.Drawing.Size(57, 20);
            this.vtotal.TabIndex = 11;
            this.vtotal.Text = "label8";
            // 
            // vkm
            // 
            this.vkm.AutoSize = true;
            this.vkm.BackColor = System.Drawing.Color.Transparent;
            this.vkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vkm.ForeColor = System.Drawing.Color.Red;
            this.vkm.Location = new System.Drawing.Point(19, 278);
            this.vkm.Name = "vkm";
            this.vkm.Size = new System.Drawing.Size(57, 20);
            this.vkm.TabIndex = 12;
            this.vkm.Text = "label9";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 413);
            this.Controls.Add(this.vkm);
            this.Controls.Add(this.vtotal);
            this.Controls.Add(this.vtotalcomb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qtdLitros);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        
    }
}