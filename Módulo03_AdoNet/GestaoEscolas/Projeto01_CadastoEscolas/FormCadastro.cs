using Projeto01_CadastoEscolas.RepositoryDao;
using Projeto02_AcessoDados.DAL;
using Projeto02_AcessoDados.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto01_CadastoEscolas
{
	public partial class FormCadastro : Form
	{
		public FormCadastro()
		{
			InitializeComponent();
			ListarEscolas();
		}

		private void incluirEscolasButton_Click(object sender, EventArgs e)
		{
			try
			{
				Escola escola = new Escola();
				escola.Descricao = descricaoTextBox.Text;
				escola.Endereco = enderecoTextBox.Text;
				escola.Telefone = telefoneTextBox.Text;

				EscolaDao dao = Repository.GetEscolaDao();
				dao.Incluir(escola);

				MessageBox.Show("Escola incluida com sucesso!");

				//limpar campos
				descricaoTextBox.Clear();
				enderecoTextBox.Clear();
				telefoneTextBox.Clear();

				//direcionar cursor para um campo
				descricaoTextBox.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

			}

		}

		private void ListarEscolas()
		{
			try
			{
				EscolaDao dao = Repository.GetEscolaDao();
				escolaComboBox.DataSource = dao.Listar();
				escolaComboBox.DisplayMember = "Descricao";     //Text
				escolaComboBox.ValueMember = "Id";              //Value

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void incluirCursoButton_Click(object sender, EventArgs e)
		{
			try
			{
				Curso curso = new Curso();
				CursoDao dao = Repository.GetCursoDao();

				curso.Descricao = descricaoCursoTextBox.Text;
				curso.CargaHoraria = Convert.ToInt32(cargaHorariaTextBox.Text);
				curso.Preco = Convert.ToDouble(precoTextBox.Text);
				
				
				//obtendo o Id do evento a partir do ComboBox
				int id = (int)escolaComboBox.SelectedValue;
				curso.escolaInfo = Repository.GetEscolaDao().Buscar(id);

				//incluindo o convidado no banco de dados
				dao.Incluir(curso);
				if (dao.statusInclusaoCurso == 1)
				{
					MessageBox.Show("Curso alterado com sucesso");
				}
				else
				{
					MessageBox.Show("Curso incluído com sucesso");
				}

				//Limpar campos e retornar ao primeiro
				descricaoCursoTextBox.Clear();
				cargaHorariaTextBox.Clear();
				precoTextBox.Clear();

				descricaoCursoTextBox.Focus();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

			}
		}
	}
}