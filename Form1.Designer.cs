namespace Jogo_da_Forca
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
            this.btnStart = new System.Windows.Forms.Button();
            this.pnForca = new System.Windows.Forms.Panel();
            this.btnValidar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTrestantes = new System.Windows.Forms.Label();
            this.gbTentativas = new System.Windows.Forms.GroupBox();
            this.lbTotalTentativas = new System.Windows.Forms.Label();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.lbLetra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.gbDica = new System.Windows.Forms.GroupBox();
            this.lbDica = new System.Windows.Forms.Label();
            this.pnForca.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbTentativas.SuspendLayout();
            this.gbDica.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(17, 445);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(771, 42);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseMnemonic = false;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnForca
            // 
            this.pnForca.Controls.Add(this.gbDica);
            this.pnForca.Controls.Add(this.txtPalavra);
            this.pnForca.Controls.Add(this.label1);
            this.pnForca.Controls.Add(this.btnValidar);
            this.pnForca.Controls.Add(this.groupBox1);
            this.pnForca.Controls.Add(this.gbTentativas);
            this.pnForca.Controls.Add(this.txtLetra);
            this.pnForca.Controls.Add(this.lbLetra);
            this.pnForca.Location = new System.Drawing.Point(17, 16);
            this.pnForca.Name = "pnForca";
            this.pnForca.Size = new System.Drawing.Size(771, 426);
            this.pnForca.TabIndex = 2;
            this.pnForca.Visible = false;
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(171, 375);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 48);
            this.btnValidar.TabIndex = 4;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTrestantes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(527, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tentativas Restantes";
            // 
            // lbTrestantes
            // 
            this.lbTrestantes.AutoSize = true;
            this.lbTrestantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrestantes.Location = new System.Drawing.Point(85, 51);
            this.lbTrestantes.Name = "lbTrestantes";
            this.lbTrestantes.Size = new System.Drawing.Size(37, 39);
            this.lbTrestantes.TabIndex = 0;
            this.lbTrestantes.Text = "5";
            // 
            // gbTentativas
            // 
            this.gbTentativas.Controls.Add(this.lbTotalTentativas);
            this.gbTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTentativas.Location = new System.Drawing.Point(527, 10);
            this.gbTentativas.Name = "gbTentativas";
            this.gbTentativas.Size = new System.Drawing.Size(241, 132);
            this.gbTentativas.TabIndex = 2;
            this.gbTentativas.TabStop = false;
            this.gbTentativas.Text = "Total de tentativas";
            // 
            // lbTotalTentativas
            // 
            this.lbTotalTentativas.AutoSize = true;
            this.lbTotalTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalTentativas.Location = new System.Drawing.Point(85, 51);
            this.lbTotalTentativas.Name = "lbTotalTentativas";
            this.lbTotalTentativas.Size = new System.Drawing.Size(37, 39);
            this.lbTotalTentativas.TabIndex = 0;
            this.lbTotalTentativas.Text = "5";
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(3, 403);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(162, 20);
            this.txtLetra.TabIndex = 1;
            // 
            // lbLetra
            // 
            this.lbLetra.AutoSize = true;
            this.lbLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLetra.Location = new System.Drawing.Point(3, 375);
            this.lbLetra.Name = "lbLetra";
            this.lbLetra.Size = new System.Drawing.Size(162, 25);
            this.lbLetra.TabIndex = 0;
            this.lbLetra.Text = "Digite uma letra";
            this.lbLetra.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Identifique a Palavra";
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(11, 45);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(276, 20);
            this.txtPalavra.TabIndex = 6;
            this.txtPalavra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbDica
            // 
            this.gbDica.Controls.Add(this.lbDica);
            this.gbDica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDica.Location = new System.Drawing.Point(263, 291);
            this.gbDica.Name = "gbDica";
            this.gbDica.Size = new System.Drawing.Size(505, 132);
            this.gbDica.TabIndex = 7;
            this.gbDica.TabStop = false;
            this.gbDica.Text = "Dica";
            // 
            // lbDica
            // 
            this.lbDica.AutoSize = true;
            this.lbDica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDica.Location = new System.Drawing.Point(6, 26);
            this.lbDica.Name = "lbDica";
            this.lbDica.Size = new System.Drawing.Size(45, 20);
            this.lbDica.TabIndex = 0;
            this.lbDica.Text = "Dica";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 489);
            this.Controls.Add(this.pnForca);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Jogo da Forca";
            this.pnForca.ResumeLayout(false);
            this.pnForca.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTentativas.ResumeLayout(false);
            this.gbTentativas.PerformLayout();
            this.gbDica.ResumeLayout(false);
            this.gbDica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnForca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTrestantes;
        private System.Windows.Forms.GroupBox gbTentativas;
        private System.Windows.Forms.Label lbTotalTentativas;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Label lbLetra;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDica;
        private System.Windows.Forms.Label lbDica;
        private System.Windows.Forms.TextBox txtPalavra;
    }
}

