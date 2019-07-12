namespace Interface
{
    partial class PaginaInicial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaInicial));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdCasos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.txtErro = new System.Windows.Forms.TextBox();
            this.txtValorX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResultadoX = new System.Windows.Forms.TextBox();
            this.btnResultadoX = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Limpar = new System.Windows.Forms.Button();
            this.LimparPrevisao = new System.Windows.Forms.Button();
            this.Gerar = new System.Windows.Forms.Button();
            this.numGrauPolinomio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrauPolinomio)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ano,
            this.QtdCasos});
            this.dataGridView1.Location = new System.Drawing.Point(29, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(320, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DataGridView1_EditingControlShowing);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataGridView1_KeyPress);
            // 
            // Ano
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ano.DefaultCellStyle = dataGridViewCellStyle2;
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            // 
            // QtdCasos
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtdCasos.DefaultCellStyle = dataGridViewCellStyle3;
            this.QtdCasos.HeaderText = "Quantidade de Casos";
            this.QtdCasos.Name = "QtdCasos";
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Calcular.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Calcular.Location = new System.Drawing.Point(97, 433);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(83, 42);
            this.Calcular.TabIndex = 2;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(24, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grau Polinômio:";
            // 
            // txtResposta
            // 
            this.txtResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResposta.Location = new System.Drawing.Point(369, 104);
            this.txtResposta.Multiline = true;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.ReadOnly = true;
            this.txtResposta.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResposta.Size = new System.Drawing.Size(406, 25);
            this.txtResposta.TabIndex = 4;
            // 
            // txtErro
            // 
            this.txtErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErro.Location = new System.Drawing.Point(369, 180);
            this.txtErro.Name = "txtErro";
            this.txtErro.ReadOnly = true;
            this.txtErro.Size = new System.Drawing.Size(182, 22);
            this.txtErro.TabIndex = 5;
            // 
            // txtValorX
            // 
            this.txtValorX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorX.Location = new System.Drawing.Point(369, 340);
            this.txtValorX.Name = "txtValorX";
            this.txtValorX.Size = new System.Drawing.Size(167, 22);
            this.txtValorX.TabIndex = 6;
            this.txtValorX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorX_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Polinômio resultante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Erro (+ / -):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ano:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(565, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Resultado:";
            // 
            // txtResultadoX
            // 
            this.txtResultadoX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoX.Location = new System.Drawing.Point(570, 340);
            this.txtResultadoX.Name = "txtResultadoX";
            this.txtResultadoX.ReadOnly = true;
            this.txtResultadoX.Size = new System.Drawing.Size(205, 22);
            this.txtResultadoX.TabIndex = 7;
            // 
            // btnResultadoX
            // 
            this.btnResultadoX.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnResultadoX.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultadoX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResultadoX.Location = new System.Drawing.Point(453, 385);
            this.btnResultadoX.Name = "btnResultadoX";
            this.btnResultadoX.Size = new System.Drawing.Size(83, 42);
            this.btnResultadoX.TabIndex = 8;
            this.btnResultadoX.Text = "Calcular";
            this.btnResultadoX.UseVisualStyleBackColor = false;
            this.btnResultadoX.Click += new System.EventHandler(this.BtnResultadoX_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(24, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dados:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(369, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Previsão:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(125, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(563, 26);
            this.label8.TabIndex = 15;
            this.label8.Text = "Previsão dos Casos de Dengue por meio de Análise Temporal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(379, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "Resultados:";
            // 
            // Limpar
            // 
            this.Limpar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Limpar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Limpar.Location = new System.Drawing.Point(186, 433);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(83, 42);
            this.Limpar.TabIndex = 3;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = false;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // LimparPrevisao
            // 
            this.LimparPrevisao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LimparPrevisao.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimparPrevisao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LimparPrevisao.Location = new System.Drawing.Point(570, 385);
            this.LimparPrevisao.Name = "LimparPrevisao";
            this.LimparPrevisao.Size = new System.Drawing.Size(83, 42);
            this.LimparPrevisao.TabIndex = 17;
            this.LimparPrevisao.Text = "Limpar";
            this.LimparPrevisao.UseVisualStyleBackColor = false;
            this.LimparPrevisao.Click += new System.EventHandler(this.LimparPrevisao_Click);
            // 
            // Gerar
            // 
            this.Gerar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gerar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Gerar.Location = new System.Drawing.Point(485, 219);
            this.Gerar.Name = "Gerar";
            this.Gerar.Size = new System.Drawing.Size(158, 42);
            this.Gerar.TabIndex = 18;
            this.Gerar.Text = "Gerar Gráfico";
            this.Gerar.UseVisualStyleBackColor = false;
            this.Gerar.Click += new System.EventHandler(this.Gerar_Click);
            // 
            // numGrauPolinomio
            // 
            this.numGrauPolinomio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGrauPolinomio.Location = new System.Drawing.Point(186, 398);
            this.numGrauPolinomio.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numGrauPolinomio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGrauPolinomio.Name = "numGrauPolinomio";
            this.numGrauPolinomio.Size = new System.Drawing.Size(64, 22);
            this.numGrauPolinomio.TabIndex = 19;
            this.numGrauPolinomio.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // PaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.numGrauPolinomio);
            this.Controls.Add(this.Gerar);
            this.Controls.Add(this.LimparPrevisao);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnResultadoX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResultadoX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorX);
            this.Controls.Add(this.txtErro);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PaginaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo dos Mínimos Quadrados";
            this.Load += new System.EventHandler(this.PaginaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrauPolinomio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.TextBox txtErro;
        private System.Windows.Forms.TextBox txtValorX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResultadoX;
        private System.Windows.Forms.Button btnResultadoX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdCasos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button LimparPrevisao;
        private System.Windows.Forms.Button Gerar;
        private System.Windows.Forms.NumericUpDown numGrauPolinomio;
    }
}

