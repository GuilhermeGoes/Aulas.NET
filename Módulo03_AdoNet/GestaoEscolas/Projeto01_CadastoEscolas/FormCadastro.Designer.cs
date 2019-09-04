namespace Projeto01_CadastoEscolas
{
	partial class FormCadastro
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
			this.dadosEscolaGroupBox = new System.Windows.Forms.GroupBox();
			this.incluirEscolasButton = new System.Windows.Forms.Button();
			this.telefoneTextBox = new System.Windows.Forms.TextBox();
			this.enderecoTextBox = new System.Windows.Forms.TextBox();
			this.descricaoTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dadosCursoGroupBox = new System.Windows.Forms.GroupBox();
			this.incluirCursoButton = new System.Windows.Forms.Button();
			this.precoTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cargaHorariaTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.descricaoCursoTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.escolaComboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dadosEscolaGroupBox.SuspendLayout();
			this.dadosCursoGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// dadosEscolaGroupBox
			// 
			this.dadosEscolaGroupBox.Controls.Add(this.incluirEscolasButton);
			this.dadosEscolaGroupBox.Controls.Add(this.telefoneTextBox);
			this.dadosEscolaGroupBox.Controls.Add(this.enderecoTextBox);
			this.dadosEscolaGroupBox.Controls.Add(this.descricaoTextBox);
			this.dadosEscolaGroupBox.Controls.Add(this.label3);
			this.dadosEscolaGroupBox.Controls.Add(this.label2);
			this.dadosEscolaGroupBox.Controls.Add(this.label1);
			this.dadosEscolaGroupBox.Location = new System.Drawing.Point(13, 13);
			this.dadosEscolaGroupBox.Name = "dadosEscolaGroupBox";
			this.dadosEscolaGroupBox.Size = new System.Drawing.Size(375, 363);
			this.dadosEscolaGroupBox.TabIndex = 0;
			this.dadosEscolaGroupBox.TabStop = false;
			this.dadosEscolaGroupBox.Text = "Dados Escola";
			// 
			// incluirEscolasButton
			// 
			this.incluirEscolasButton.Location = new System.Drawing.Point(21, 144);
			this.incluirEscolasButton.Name = "incluirEscolasButton";
			this.incluirEscolasButton.Size = new System.Drawing.Size(87, 32);
			this.incluirEscolasButton.TabIndex = 6;
			this.incluirEscolasButton.Text = "Incluir Escola";
			this.incluirEscolasButton.UseVisualStyleBackColor = true;
			this.incluirEscolasButton.Click += new System.EventHandler(this.incluirEscolasButton_Click);
			// 
			// telefoneTextBox
			// 
			this.telefoneTextBox.Location = new System.Drawing.Point(91, 104);
			this.telefoneTextBox.Name = "telefoneTextBox";
			this.telefoneTextBox.Size = new System.Drawing.Size(135, 20);
			this.telefoneTextBox.TabIndex = 5;
			// 
			// enderecoTextBox
			// 
			this.enderecoTextBox.Location = new System.Drawing.Point(91, 70);
			this.enderecoTextBox.Name = "enderecoTextBox";
			this.enderecoTextBox.Size = new System.Drawing.Size(261, 20);
			this.enderecoTextBox.TabIndex = 4;
			// 
			// descricaoTextBox
			// 
			this.descricaoTextBox.Location = new System.Drawing.Point(91, 36);
			this.descricaoTextBox.Name = "descricaoTextBox";
			this.descricaoTextBox.Size = new System.Drawing.Size(261, 20);
			this.descricaoTextBox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Telefone:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Endereço:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Descrição:";
			// 
			// dadosCursoGroupBox
			// 
			this.dadosCursoGroupBox.Controls.Add(this.incluirCursoButton);
			this.dadosCursoGroupBox.Controls.Add(this.precoTextBox);
			this.dadosCursoGroupBox.Controls.Add(this.label7);
			this.dadosCursoGroupBox.Controls.Add(this.cargaHorariaTextBox);
			this.dadosCursoGroupBox.Controls.Add(this.label6);
			this.dadosCursoGroupBox.Controls.Add(this.descricaoCursoTextBox);
			this.dadosCursoGroupBox.Controls.Add(this.label5);
			this.dadosCursoGroupBox.Controls.Add(this.escolaComboBox);
			this.dadosCursoGroupBox.Controls.Add(this.label4);
			this.dadosCursoGroupBox.Location = new System.Drawing.Point(394, 13);
			this.dadosCursoGroupBox.Name = "dadosCursoGroupBox";
			this.dadosCursoGroupBox.Size = new System.Drawing.Size(375, 363);
			this.dadosCursoGroupBox.TabIndex = 1;
			this.dadosCursoGroupBox.TabStop = false;
			this.dadosCursoGroupBox.Text = "Dados Curso";
			// 
			// incluirCursoButton
			// 
			this.incluirCursoButton.Location = new System.Drawing.Point(24, 180);
			this.incluirCursoButton.Name = "incluirCursoButton";
			this.incluirCursoButton.Size = new System.Drawing.Size(87, 32);
			this.incluirCursoButton.TabIndex = 8;
			this.incluirCursoButton.Text = "Incluir Curso";
			this.incluirCursoButton.UseVisualStyleBackColor = true;
			this.incluirCursoButton.Click += new System.EventHandler(this.incluirCursoButton_Click);
			// 
			// precoTextBox
			// 
			this.precoTextBox.Location = new System.Drawing.Point(105, 138);
			this.precoTextBox.Name = "precoTextBox";
			this.precoTextBox.Size = new System.Drawing.Size(105, 20);
			this.precoTextBox.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(21, 141);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Preço: ";
			// 
			// cargaHorariaTextBox
			// 
			this.cargaHorariaTextBox.Location = new System.Drawing.Point(105, 104);
			this.cargaHorariaTextBox.Name = "cargaHorariaTextBox";
			this.cargaHorariaTextBox.Size = new System.Drawing.Size(105, 20);
			this.cargaHorariaTextBox.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(21, 107);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Carga Horária: ";
			// 
			// descricaoCursoTextBox
			// 
			this.descricaoCursoTextBox.Location = new System.Drawing.Point(105, 70);
			this.descricaoCursoTextBox.Name = "descricaoCursoTextBox";
			this.descricaoCursoTextBox.Size = new System.Drawing.Size(247, 20);
			this.descricaoCursoTextBox.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Descrição:";
			// 
			// escolaComboBox
			// 
			this.escolaComboBox.FormattingEnabled = true;
			this.escolaComboBox.Location = new System.Drawing.Point(105, 35);
			this.escolaComboBox.Name = "escolaComboBox";
			this.escolaComboBox.Size = new System.Drawing.Size(247, 21);
			this.escolaComboBox.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Escola:";
			// 
			// FormCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(783, 388);
			this.Controls.Add(this.dadosCursoGroupBox);
			this.Controls.Add(this.dadosEscolaGroupBox);
			this.Name = "FormCadastro";
			this.Text = "Cadastro de Escolas";
			this.dadosEscolaGroupBox.ResumeLayout(false);
			this.dadosEscolaGroupBox.PerformLayout();
			this.dadosCursoGroupBox.ResumeLayout(false);
			this.dadosCursoGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox dadosEscolaGroupBox;
		private System.Windows.Forms.Button incluirEscolasButton;
		private System.Windows.Forms.TextBox telefoneTextBox;
		private System.Windows.Forms.TextBox enderecoTextBox;
		private System.Windows.Forms.TextBox descricaoTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox dadosCursoGroupBox;
		private System.Windows.Forms.ComboBox escolaComboBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox descricaoCursoTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox precoTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox cargaHorariaTextBox;
		private System.Windows.Forms.Button incluirCursoButton;
	}
}

