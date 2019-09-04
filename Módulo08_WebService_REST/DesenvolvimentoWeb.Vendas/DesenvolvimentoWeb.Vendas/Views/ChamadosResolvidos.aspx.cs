using DesenvolvimentoWeb.Vendas.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesenvolvimentoWeb.Vendas.Views
{
	public partial class ChamadosResolvidos : System.Web.UI.Page
	{
		HttpClient client;
		Chamado chamado;

		public ChamadosResolvidos()
		{
			if (client == null)
			{
				client = new HttpClient();
				client.BaseAddress = new Uri("http://localhost:50883/");
				client.DefaultRequestHeaders.Accept.Add(
					new MediaTypeWithQualityHeaderValue("application/json"));
			}
		}

		protected async void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				try
				{
					HttpResponseMessage response =
						client.GetAsync("chamadosResolvidos").Result;

					if (response.IsSuccessStatusCode)
					{
						var resultado = await response.Content.ReadAsStringAsync();

						var lista = JsonConvert
							.DeserializeObject<Chamado[]>(resultado)
							.ToList();

						resolvidosRepeater.DataSource = lista;
					}

				}
				catch (Exception ex)
				{
					throw;
				}
			}
		}


	}
}