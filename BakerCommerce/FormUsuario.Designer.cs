namespace BakerCommerce
{
    partial class FormUsuarios
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
            this.lblGerenciamento = new System.Windows.Forms.Label();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtSenhaCadastro = new System.Windows.Forms.TextBox();
            this.txtEmailCadastro = new System.Windows.Forms.TextBox();
            this.txtNomeCadastro = new System.Windows.Forms.TextBox();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtSenhaEditar = new System.Windows.Forms.TextBox();
            this.textEmailEditar = new System.Windows.Forms.TextBox();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblSenhaEditar = new System.Windows.Forms.Label();
            this.lblEmailEditar = new System.Windows.Forms.Label();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGerenciamento
            // 
            this.lblGerenciamento.AutoSize = true;
            this.lblGerenciamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerenciamento.Location = new System.Drawing.Point(269, 9);
            this.lblGerenciamento.Name = "lblGerenciamento";
            this.lblGerenciamento.Size = new System.Drawing.Size(279, 25);
            this.lblGerenciamento.TabIndex = 0;
            this.lblGerenciamento.Text = "Gerenciamento de Usuários";
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(36, 37);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(727, 187);
            this.dgvUsuario.TabIndex = 1;
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.lblSenha);
            this.grbCadastrar.Controls.Add(this.lblEmail);
            this.grbCadastrar.Controls.Add(this.lblNome);
            this.grbCadastrar.Controls.Add(this.txtSenhaCadastro);
            this.grbCadastrar.Controls.Add(this.txtEmailCadastro);
            this.grbCadastrar.Controls.Add(this.txtNomeCadastro);
            this.grbCadastrar.Location = new System.Drawing.Point(36, 230);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(284, 157);
            this.grbCadastrar.TabIndex = 2;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(6, 128);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(272, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(93, 101);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(93, 61);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(46, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(85, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome Completo:";
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.Location = new System.Drawing.Point(141, 94);
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaCadastro.TabIndex = 2;
            // 
            // txtEmailCadastro
            // 
            this.txtEmailCadastro.Location = new System.Drawing.Point(141, 54);
            this.txtEmailCadastro.Name = "txtEmailCadastro";
            this.txtEmailCadastro.Size = new System.Drawing.Size(100, 20);
            this.txtEmailCadastro.TabIndex = 1;
            // 
            // txtNomeCadastro
            // 
            this.txtNomeCadastro.Location = new System.Drawing.Point(141, 19);
            this.txtNomeCadastro.Name = "txtNomeCadastro";
            this.txtNomeCadastro.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCadastro.TabIndex = 0;
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txtSenhaEditar);
            this.grbEditar.Controls.Add(this.textEmailEditar);
            this.grbEditar.Controls.Add(this.txtNomeCompleto);
            this.grbEditar.Controls.Add(this.lblSenhaEditar);
            this.grbEditar.Controls.Add(this.lblEmailEditar);
            this.grbEditar.Controls.Add(this.lblNomeEditar);
            this.grbEditar.Location = new System.Drawing.Point(457, 230);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(306, 157);
            this.grbEditar.TabIndex = 3;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(6, 128);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(294, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtSenhaEditar
            // 
            this.txtSenhaEditar.Location = new System.Drawing.Point(97, 98);
            this.txtSenhaEditar.Name = "txtSenhaEditar";
            this.txtSenhaEditar.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaEditar.TabIndex = 8;
            // 
            // textEmailEditar
            // 
            this.textEmailEditar.Location = new System.Drawing.Point(97, 61);
            this.textEmailEditar.Name = "textEmailEditar";
            this.textEmailEditar.Size = new System.Drawing.Size(100, 20);
            this.textEmailEditar.TabIndex = 7;
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(97, 23);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCompleto.TabIndex = 6;
            // 
            // lblSenhaEditar
            // 
            this.lblSenhaEditar.AutoSize = true;
            this.lblSenhaEditar.Location = new System.Drawing.Point(50, 101);
            this.lblSenhaEditar.Name = "lblSenhaEditar";
            this.lblSenhaEditar.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaEditar.TabIndex = 6;
            this.lblSenhaEditar.Text = "Senha:";
            // 
            // lblEmailEditar
            // 
            this.lblEmailEditar.AutoSize = true;
            this.lblEmailEditar.Location = new System.Drawing.Point(56, 65);
            this.lblEmailEditar.Name = "lblEmailEditar";
            this.lblEmailEditar.Size = new System.Drawing.Size(35, 13);
            this.lblEmailEditar.TabIndex = 6;
            this.lblEmailEditar.Text = "Email:";
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Location = new System.Drawing.Point(6, 26);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(85, 13);
            this.lblNomeEditar.TabIndex = 6;
            this.lblNomeEditar.Text = "Nome Completo:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Location = new System.Drawing.Point(36, 393);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(727, 46);
            this.grbApagar.TabIndex = 4;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(499, 17);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(222, 23);
            this.btnApagar.TabIndex = 0;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.lblGerenciamento);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGerenciamento;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtSenhaCadastro;
        private System.Windows.Forms.TextBox txtEmailCadastro;
        private System.Windows.Forms.TextBox txtNomeCadastro;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenhaEditar;
        private System.Windows.Forms.TextBox textEmailEditar;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lblSenhaEditar;
        private System.Windows.Forms.Label lblEmailEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
    }
}