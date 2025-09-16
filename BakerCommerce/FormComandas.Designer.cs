namespace BakerCommerce
{
    partial class FormComandas
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
            this.grbInformações = new System.Windows.Forms.GroupBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.lblComandas = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtComanda = new System.Windows.Forms.TextBox();
            this.grbLançamento = new System.Windows.Forms.GroupBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.btnLançar = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblLançamento = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbInformações.SuspendLayout();
            this.grbLançamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInformações
            // 
            this.grbInformações.Controls.Add(this.lblCodProduto);
            this.grbInformações.Controls.Add(this.lblComandas);
            this.grbInformações.Controls.Add(this.btnContinuar);
            this.grbInformações.Controls.Add(this.txtCodProduto);
            this.grbInformações.Controls.Add(this.txtComanda);
            this.grbInformações.Location = new System.Drawing.Point(12, 37);
            this.grbInformações.Name = "grbInformações";
            this.grbInformações.Size = new System.Drawing.Size(299, 198);
            this.grbInformações.TabIndex = 0;
            this.grbInformações.TabStop = false;
            this.grbInformações.Text = "Informações";
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProduto.Location = new System.Drawing.Point(6, 107);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(126, 24);
            this.lblCodProduto.TabIndex = 4;
            this.lblCodProduto.Text = "Cod. Produto:";
            // 
            // lblComandas
            // 
            this.lblComandas.AutoSize = true;
            this.lblComandas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandas.Location = new System.Drawing.Point(6, 36);
            this.lblComandas.Name = "lblComandas";
            this.lblComandas.Size = new System.Drawing.Size(97, 24);
            this.lblComandas.TabIndex = 3;
            this.lblComandas.Text = "Comanda:";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(25, 150);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(248, 36);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(138, 109);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(135, 20);
            this.txtCodProduto.TabIndex = 1;
            this.txtCodProduto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtComanda
            // 
            this.txtComanda.Location = new System.Drawing.Point(109, 38);
            this.txtComanda.Name = "txtComanda";
            this.txtComanda.Size = new System.Drawing.Size(164, 20);
            this.txtComanda.TabIndex = 0;
            // 
            // grbLançamento
            // 
            this.grbLançamento.Controls.Add(this.btnCancelar);
            this.grbLançamento.Controls.Add(this.lblQuantidade);
            this.grbLançamento.Controls.Add(this.lblProduto);
            this.grbLançamento.Controls.Add(this.txtProduto);
            this.grbLançamento.Controls.Add(this.btnLançar);
            this.grbLançamento.Controls.Add(this.txtQuantidade);
            this.grbLançamento.Enabled = false;
            this.grbLançamento.Location = new System.Drawing.Point(12, 241);
            this.grbLançamento.Name = "grbLançamento";
            this.grbLançamento.Size = new System.Drawing.Size(299, 231);
            this.grbLançamento.TabIndex = 1;
            this.grbLançamento.TabStop = false;
            this.grbLançamento.Text = "Lançamento";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(6, 98);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(113, 24);
            this.lblQuantidade.TabIndex = 9;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(6, 39);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(81, 24);
            this.lblProduto.TabIndex = 8;
            this.lblProduto.Text = "Produto:";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(93, 43);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(180, 20);
            this.txtProduto.TabIndex = 5;
            // 
            // btnLançar
            // 
            this.btnLançar.Location = new System.Drawing.Point(25, 139);
            this.btnLançar.Name = "btnLançar";
            this.btnLançar.Size = new System.Drawing.Size(248, 36);
            this.btnLançar.TabIndex = 7;
            this.btnLançar.Text = "Lançar";
            this.btnLançar.UseVisualStyleBackColor = true;
            this.btnLançar.Click += new System.EventHandler(this.btnLançar_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(125, 101);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(148, 20);
            this.txtQuantidade.TabIndex = 6;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(317, 73);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(471, 343);
            this.dgvProdutos.TabIndex = 2;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // lblLançamento
            // 
            this.lblLançamento.AutoSize = true;
            this.lblLançamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLançamento.Location = new System.Drawing.Point(408, 23);
            this.lblLançamento.Name = "lblLançamento";
            this.lblLançamento.Size = new System.Drawing.Size(300, 29);
            this.lblLançamento.TabIndex = 3;
            this.lblLançamento.Text = "Lançamento de Comandas";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(71, 181);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(151, 36);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.lblLançamento);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.grbLançamento);
            this.Controls.Add(this.grbInformações);
            this.Name = "FormComandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Comandas";
            this.grbInformações.ResumeLayout(false);
            this.grbInformações.PerformLayout();
            this.grbLançamento.ResumeLayout(false);
            this.grbLançamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInformações;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.Label lblComandas;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.TextBox txtComanda;
        private System.Windows.Forms.GroupBox grbLançamento;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Button btnLançar;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblLançamento;
        private System.Windows.Forms.Button btnCancelar;
    }
}