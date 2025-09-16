namespace BakerCommerce
{
    partial class FormCaixa
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
            this.lblTituloComanda = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.chkPagamentoRecebido = new System.Windows.Forms.CheckBox();
            this.btnEncerrarComanda = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.pbCaixa = new System.Windows.Forms.PictureBox();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.txtComanda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloComanda
            // 
            this.lblTituloComanda.AutoSize = true;
            this.lblTituloComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloComanda.Location = new System.Drawing.Point(15, 19);
            this.lblTituloComanda.Name = "lblTituloComanda";
            this.lblTituloComanda.Size = new System.Drawing.Size(249, 29);
            this.lblTituloComanda.TabIndex = 0;
            this.lblTituloComanda.Text = "Número da Comanda:";
            // 
            // btnListar
            // 
            this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListar.Location = new System.Drawing.Point(649, 12);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(211, 43);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvItens
            // 
            this.dgvItens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(20, 64);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.Size = new System.Drawing.Size(840, 240);
            this.dgvItens.TabIndex = 2;
            // 
            // lblCaixa
            // 
            this.lblCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixa.Location = new System.Drawing.Point(130, 396);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(73, 29);
            this.lblCaixa.TabIndex = 3;
            this.lblCaixa.Text = "Caixa";
            // 
            // chkPagamentoRecebido
            // 
            this.chkPagamentoRecebido.AutoSize = true;
            this.chkPagamentoRecebido.Location = new System.Drawing.Point(670, 396);
            this.chkPagamentoRecebido.Name = "chkPagamentoRecebido";
            this.chkPagamentoRecebido.Size = new System.Drawing.Size(129, 17);
            this.chkPagamentoRecebido.TabIndex = 6;
            this.chkPagamentoRecebido.Text = "Pagamento Recebido";
            this.chkPagamentoRecebido.UseVisualStyleBackColor = true;
            this.chkPagamentoRecebido.CheckedChanged += new System.EventHandler(this.chkPagamentoRecebido_CheckedChanged);
            // 
            // btnEncerrarComanda
            // 
            this.btnEncerrarComanda.Enabled = false;
            this.btnEncerrarComanda.Location = new System.Drawing.Point(619, 420);
            this.btnEncerrarComanda.Name = "btnEncerrarComanda";
            this.btnEncerrarComanda.Size = new System.Drawing.Size(241, 60);
            this.btnEncerrarComanda.TabIndex = 7;
            this.btnEncerrarComanda.Text = "Encerrar Comanda";
            this.btnEncerrarComanda.UseVisualStyleBackColor = true;
            this.btnEncerrarComanda.Click += new System.EventHandler(this.btnEncerrarComanda_Click);
            // 
            // lblValor
            // 
            this.lblValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(644, 330);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(49, 29);
            this.lblValor.TabIndex = 8;
            this.lblValor.Text = "R$:";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbCaixa
            // 
            this.pbCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbCaixa.Image = global::BakerCommerce.Properties.Resources.caixa_eletronico;
            this.pbCaixa.Location = new System.Drawing.Point(233, 364);
            this.pbCaixa.Name = "pbCaixa";
            this.pbCaixa.Size = new System.Drawing.Size(90, 90);
            this.pbCaixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCaixa.TabIndex = 4;
            this.pbCaixa.TabStop = false;
            // 
            // lblTotalValor
            // 
            this.lblTotalValor.AutoSize = true;
            this.lblTotalValor.Location = new System.Drawing.Point(716, 338);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(10, 13);
            this.lblTotalValor.TabIndex = 5;
            this.lblTotalValor.Text = "-";
            // 
            // txtComanda
            // 
            this.txtComanda.Location = new System.Drawing.Point(266, 26);
            this.txtComanda.Name = "txtComanda";
            this.txtComanda.Size = new System.Drawing.Size(298, 20);
            this.txtComanda.TabIndex = 9;
            // 
            // FormCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.txtComanda);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnEncerrarComanda);
            this.Controls.Add(this.chkPagamentoRecebido);
            this.Controls.Add(this.lblTotalValor);
            this.Controls.Add(this.pbCaixa);
            this.Controls.Add(this.lblCaixa);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblTituloComanda);
            this.Name = "FormCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloComanda;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.PictureBox pbCaixa;
        private System.Windows.Forms.CheckBox chkPagamentoRecebido;
        private System.Windows.Forms.Button btnEncerrarComanda;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.TextBox txtComanda;
    }
}