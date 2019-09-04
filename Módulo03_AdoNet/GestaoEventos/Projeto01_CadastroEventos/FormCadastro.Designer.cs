namespace Projeto01_CadastroEventos
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.incluirEventoButton = new System.Windows.Forms.Button();
			this.dataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.responsavelTextBox = new System.Windows.Forms.TextBox();
			this.precoTextBox = new System.Windows.Forms.TextBox();
			this.descricaoTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.incluirConvidadoButton = new System.Windows.Forms.Button();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.telefoneTextBox = new System.Windows.Forms.TextBox();
			this.nomeTextBox = new System.Windows.Forms.TextBox();
			this.cpfTextBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.eventoComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.buscarConvidadosButton = new System.Windows.Forms.Button();
			this.convidadosDataGridView = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.convidadosDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.incluirEventoButton);
			this.groupBox1.Controls.Add(this.dataMaskedTextBox);
			this.groupBox1.Controls.Add(this.responsavelTextBox);
			this.groupBox1.Controls.Add(this.precoTextBox);
			this.groupBox1.Controls.Add(this.descricaoTextBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(383, 396);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados do Evento";
			// 
			// incluirEventoButton
			// 
			this.incluirEventoButton.Location = new System.Drawing.Point(18, 166);
			this.incluirEventoButton.Name = "incluirEventoButton";
			this.incluirEventoButton.Size = new System.Drawing.Size(88, 32);
			this.incluirEventoButton.TabIndex = 5;
			this.incluirEventoButton.Text = "Incluir Evento";
			this.incluirEventoButton.UseVisualStyleBackColor = true;
			this.incluirEventoButton.Click += new System.EventHandler(this.incluirEventoButton_Click);
			// 
			// dataMaskedTextBox
			// 
			this.dataMaskedTextBox.Location = new System.Drawing.Point(108, 90);
			this.dataMaskedTextBox.Mask = "00/00/0000";
			this.dataMaskedTextBox.Name = "dataMaskedTextBox";
			this.dataMaskedTextBox.Size = new System.Drawing.Size(78, 20);
			this.dataMaskedTextBox.TabIndex = 3;
			// 
			// responsavelTextBox
			// 
			this.responsavelTextBox.Location = new System.Drawing.Point(108, 60);
			this.responsavelTextBox.Name = "responsavelTextBox";
			this.responsavelTextBox.Size = new System.Drawing.Size(257, 20);
			this.responsavelTextBox.TabIndex = 2;
			// 
			// precoTextBox
			// 
			this.precoTextBox.Location = new System.Drawing.Point(108, 120);
			this.precoTextBox.Name = "precoTextBox";
			this.precoTextBox.Size = new System.Drawing.Size(78, 20);
			this.precoTextBox.TabIndex = 4;
			// 
			// descricaoTextBox
			// 
			this.descricaoTextBox.Location = new System.Drawing.Point(108, 30);
			this.descricaoTextBox.Name = "descricaoTextBox";
			this.descricaoTextBox.Size = new System.Drawing.Size(257, 20);
			this.descricaoTextBox.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Preço:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Data:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Responsável:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Descrição:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.convidadosDataGridView);
			this.groupBox2.Controls.Add(this.buscarConvidadosButton);
			this.groupBox2.Controls.Add(this.incluirConvidadoButton);
			this.groupBox2.Controls.Add(this.emailTextBox);
			this.groupBox2.Controls.Add(this.telefoneTextBox);
			this.groupBox2.Controls.Add(this.nomeTextBox);
			this.groupBox2.Controls.Add(this.cpfTextBox);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.eventoComboBox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(417, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(383, 396);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dados do Convidado";
			// 
			// incluirConvidadoButton
			// 
			this.incluirConvidadoButton.Location = new System.Drawing.Point(24, 194);
			this.incluirConvidadoButton.Name = "incluirConvidadoButton";
			this.incluirConvidadoButton.Size = new System.Drawing.Size(105, 32);
			this.incluirConvidadoButton.TabIndex = 10;
			this.incluirConvidadoButton.Text = "Incluir Convidado";
			this.incluirConvidadoButton.UseVisualStyleBackColor = true;
			this.incluirConvidadoButton.Click += new System.EventHandler(this.incluirConvidadoButton_Click);
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(86, 150);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(282, 20);
			this.emailTextBox.TabIndex = 9;
			// 
			// telefoneTextBox
			// 
			this.telefoneTextBox.Location = new System.Drawing.Point(86, 119);
			this.telefoneTextBox.Name = "telefoneTextBox";
			this.telefoneTextBox.Size = new System.Drawing.Size(183, 20);
			this.telefoneTextBox.TabIndex = 8;
			// 
			// nomeTextBox
			// 
			this.nomeTextBox.Location = new System.Drawing.Point(86, 89);
			this.nomeTextBox.Name = "nomeTextBox";
			this.nomeTextBox.Size = new System.Drawing.Size(282, 20);
			this.nomeTextBox.TabIndex = 7;
			// 
			// cpfTextBox
			// 
			this.cpfTextBox.Location = new System.Drawing.Point(86, 59);
			this.cpfTextBox.Name = "cpfTextBox";
			this.cpfTextBox.Size = new System.Drawing.Size(183, 20);
			this.cpfTextBox.TabIndex = 6;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(21, 153);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "Email:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(20, 123);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 13);
			this.label8.TabIndex = 15;
			this.label8.Text = "Telefone:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(20, 93);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Nome:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(20, 63);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(26, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Cpf:";
			// 
			// eventoComboBox
			// 
			this.eventoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.eventoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.eventoComboBox.FormattingEnabled = true;
			this.eventoComboBox.Location = new System.Drawing.Point(86, 29);
			this.eventoComboBox.Name = "eventoComboBox";
			this.eventoComboBox.Size = new System.Drawing.Size(183, 21);
			this.eventoComboBox.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 33);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Evento:";
			// 
			// buscarConvidadosButton
			// 
			this.buscarConvidadosButton.Location = new System.Drawing.Point(293, 27);
			this.buscarConvidadosButton.Name = "buscarConvidadosButton";
			this.buscarConvidadosButton.Size = new System.Drawing.Size(75, 23);
			this.buscarConvidadosButton.TabIndex = 17;
			this.buscarConvidadosButton.Text = "Buscar";
			this.buscarConvidadosButton.UseVisualStyleBackColor = true;
			this.buscarConvidadosButton.Click += new System.EventHandler(this.buscarConvidadosButton_Click);
			// 
			// convidadosDataGridView
			// 
			this.convidadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.convidadosDataGridView.Location = new System.Drawing.Point(7, 236);
			this.convidadosDataGridView.Name = "convidadosDataGridView";
			this.convidadosDataGridView.Size = new System.Drawing.Size(370, 148);
			this.convidadosDataGridView.TabIndex = 18;
			// 
			// FormCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(813, 432);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormCadastro";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.convidadosDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button incluirEventoButton;
		private System.Windows.Forms.MaskedTextBox dataMaskedTextBox;
		private System.Windows.Forms.TextBox responsavelTextBox;
		private System.Windows.Forms.TextBox precoTextBox;
		private System.Windows.Forms.TextBox descricaoTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox eventoComboBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.TextBox telefoneTextBox;
		private System.Windows.Forms.TextBox nomeTextBox;
		private System.Windows.Forms.TextBox cpfTextBox;
		private System.Windows.Forms.Button incluirConvidadoButton;
		private System.Windows.Forms.DataGridView convidadosDataGridView;
		private System.Windows.Forms.Button buscarConvidadosButton;
	}
}

