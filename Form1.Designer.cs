namespace BidingSources
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbExibir = new ListBox();
            bindingSource1 = new BindingSource(components);
            txtNome = new TextBox();
            txtSobreNome = new TextBox();
            txtEmail = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnSalvar = new Button();
            panel1 = new Panel();
            txtTelefone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbExibir
            // 
            lbExibir.DataSource = bindingSource1;
            lbExibir.DisplayMember = "Nome";
            lbExibir.FormattingEnabled = true;
            lbExibir.Location = new Point(12, 39);
            lbExibir.Name = "lbExibir";
            lbExibir.Size = new Size(161, 259);
            lbExibir.TabIndex = 0;
            lbExibir.ValueMember = "Id";
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.Pessoa);
            // 
            // txtNome
            // 
            txtNome.DataBindings.Add(new Binding("Text", bindingSource1, "Nome", true, DataSourceUpdateMode.OnPropertyChanged));
            txtNome.Location = new Point(267, 56);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(225, 23);
            txtNome.TabIndex = 1;
            // 
            // txtSobreNome
            // 
            txtSobreNome.DataBindings.Add(new Binding("Text", bindingSource1, "Sobrenome", true, DataSourceUpdateMode.OnPropertyChanged));
            txtSobreNome.Location = new Point(267, 110);
            txtSobreNome.Name = "txtSobreNome";
            txtSobreNome.PlaceholderText = "Sobrenome";
            txtSobreNome.Size = new Size(225, 23);
            txtSobreNome.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.DataBindings.Add(new Binding("Text", bindingSource1, "Email", true, DataSourceUpdateMode.OnPropertyChanged));
            txtEmail.Location = new Point(267, 167);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail";
            txtEmail.Size = new Size(225, 23);
            txtEmail.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DataBindings.Add(new Binding("Value", bindingSource1, "DataNascimento", true));
            dateTimePicker1.Location = new Point(563, 56);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(399, 357);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(230, 46);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTelefone);
            panel1.Controls.Add(lbExibir);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(txtSobreNome);
            panel1.Controls.Add(txtEmail);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 6;
            // 
            // txtTelefone
            // 
            txtTelefone.DataBindings.Add(new Binding("Text", bindingSource1, "Telefone", true, DataSourceUpdateMode.OnPropertyChanged));
            txtTelefone.Location = new Point(267, 218);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(225, 23);
            txtTelefone.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbExibir;
        private TextBox txtNome;
        private TextBox txtSobreNome;
        private TextBox txtEmail;
        private DateTimePicker dateTimePicker1;
        private Button btnSalvar;
        private Panel panel1;
        private TextBox txtTelefone;
        private BindingSource bindingSource1;
    }
}
