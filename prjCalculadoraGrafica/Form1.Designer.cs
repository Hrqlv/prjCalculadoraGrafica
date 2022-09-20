namespace prjCalculadoraGrafica
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCalculos = new System.Windows.Forms.GroupBox();
            this.rbVolume = new System.Windows.Forms.RadioButton();
            this.rbPerimetro = new System.Windows.Forms.RadioButton();
            this.rbArea = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.pnDesenho = new System.Windows.Forms.Panel();
            this.gbCalculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCalculos
            // 
            this.gbCalculos.Controls.Add(this.rbVolume);
            this.gbCalculos.Controls.Add(this.rbPerimetro);
            this.gbCalculos.Controls.Add(this.rbArea);
            this.gbCalculos.Location = new System.Drawing.Point(63, 23);
            this.gbCalculos.Name = "gbCalculos";
            this.gbCalculos.Size = new System.Drawing.Size(211, 129);
            this.gbCalculos.TabIndex = 0;
            this.gbCalculos.TabStop = false;
            this.gbCalculos.Text = "groupBox1";
            // 
            // rbVolume
            // 
            this.rbVolume.AutoSize = true;
            this.rbVolume.BackColor = System.Drawing.Color.Black;
            this.rbVolume.Location = new System.Drawing.Point(6, 94);
            this.rbVolume.Name = "rbVolume";
            this.rbVolume.Size = new System.Drawing.Size(130, 17);
            this.rbVolume.TabIndex = 3;
            this.rbVolume.TabStop = true;
            this.rbVolume.Text = "VOLUME CIRCULO";
            this.rbVolume.UseVisualStyleBackColor = false;
            // 
            // rbPerimetro
            // 
            this.rbPerimetro.AutoSize = true;
            this.rbPerimetro.Location = new System.Drawing.Point(6, 55);
            this.rbPerimetro.Name = "rbPerimetro";
            this.rbPerimetro.Size = new System.Drawing.Size(150, 17);
            this.rbPerimetro.TabIndex = 2;
            this.rbPerimetro.TabStop = true;
            this.rbPerimetro.Text = "PERIMETRO CIRCULO";
            this.rbPerimetro.UseVisualStyleBackColor = true;
            // 
            // rbArea
            // 
            this.rbArea.AutoSize = true;
            this.rbArea.Checked = true;
            this.rbArea.Location = new System.Drawing.Point(6, 20);
            this.rbArea.Name = "rbArea";
            this.rbArea.Size = new System.Drawing.Size(114, 17);
            this.rbArea.TabIndex = 1;
            this.rbArea.TabStop = true;
            this.rbArea.Text = "AREA CIRCULO";
            this.rbArea.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DIGITE O RAIO:";
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(95, 185);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(138, 21);
            this.txtRaio.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(101, 212);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.BackColor = System.Drawing.Color.White;
            this.lbResultado.ForeColor = System.Drawing.Color.Black;
            this.lbResultado.Location = new System.Drawing.Point(118, 247);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(101, 18);
            this.lbResultado.TabIndex = 4;
            this.lbResultado.Text = "RESPOSTA=0";
            // 
            // pnDesenho
            // 
            this.pnDesenho.BackColor = System.Drawing.Color.White;
            this.pnDesenho.ForeColor = System.Drawing.Color.Red;
            this.pnDesenho.Location = new System.Drawing.Point(461, 86);
            this.pnDesenho.Name = "pnDesenho";
            this.pnDesenho.Size = new System.Drawing.Size(274, 179);
            this.pnDesenho.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(796, 327);
            this.Controls.Add(this.pnDesenho);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCalculos);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA GRAFICA";
            this.gbCalculos.ResumeLayout(false);
            this.gbCalculos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCalculos;
        private System.Windows.Forms.RadioButton rbVolume;
        private System.Windows.Forms.RadioButton rbPerimetro;
        private System.Windows.Forms.RadioButton rbArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Panel pnDesenho;
    }
}

