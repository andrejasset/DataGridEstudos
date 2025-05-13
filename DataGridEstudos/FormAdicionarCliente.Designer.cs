namespace DataGridEstudos
{
    partial class FormAdicionarCliente
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
            Label1 = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            Label2 = new Label();
            txtEmail = new TextBox();
            Label3 = new Label();
            txtDataCadastro = new Label();
            dtpDataCadastro = new DateTimePicker();
            btnSalvar = new Button();
            btnCancelar = new Button();
            bntPrincipal = new Button();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = SystemColors.Menu;
            Label1.Location = new Point(32, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(43, 15);
            Label1.TabIndex = 0;
            Label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Menu;
            txtNome.Location = new Point(76, 7);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(281, 23);
            txtNome.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = SystemColors.Menu;
            txtTelefone.Location = new Point(93, 35);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(264, 23);
            txtTelefone.TabIndex = 3;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = SystemColors.Menu;
            Label2.Location = new Point(32, 38);
            Label2.Name = "Label2";
            Label2.Size = new Size(55, 15);
            Label2.TabIndex = 2;
            Label2.Text = "Telefone:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ButtonHighlight;
            txtEmail.Location = new Point(76, 65);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(281, 23);
            txtEmail.TabIndex = 5;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = SystemColors.Menu;
            Label3.Location = new Point(32, 67);
            Label3.Name = "Label3";
            Label3.Size = new Size(44, 15);
            Label3.TabIndex = 4;
            Label3.Text = "E-Mail:";
            // 
            // txtDataCadastro
            // 
            txtDataCadastro.AutoSize = true;
            txtDataCadastro.BackColor = SystemColors.Menu;
            txtDataCadastro.Location = new Point(32, 105);
            txtDataCadastro.Name = "txtDataCadastro";
            txtDataCadastro.Size = new Size(84, 15);
            txtDataCadastro.TabIndex = 6;
            txtDataCadastro.Text = "Data Cadastro:";
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Location = new Point(122, 99);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.Size = new Size(253, 23);
            dtpDataCadastro.TabIndex = 8;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(340, 178);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(448, 126);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(340, 310);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(448, 125);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // bntPrincipal
            // 
            bntPrincipal.Location = new Point(21, 178);
            bntPrincipal.Name = "bntPrincipal";
            bntPrincipal.Size = new Size(313, 260);
            bntPrincipal.TabIndex = 11;
            bntPrincipal.Text = "Principal";
            bntPrincipal.UseVisualStyleBackColor = true;
            // 
            // FormAdicionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bntPrincipal);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(dtpDataCadastro);
            Controls.Add(txtDataCadastro);
            Controls.Add(txtEmail);
            Controls.Add(Label3);
            Controls.Add(txtTelefone);
            Controls.Add(Label2);
            Controls.Add(txtNome);
            Controls.Add(Label1);
            Name = "FormAdicionarCliente";
            Text = "FormAdicionarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label1;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private Label Label2;
        private TextBox txtEmail;
        private Label Label3;
        private Label txtDataCadastro;
        private DateTimePicker dtpDataCadastro;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button bntPrincipal;
    }
}