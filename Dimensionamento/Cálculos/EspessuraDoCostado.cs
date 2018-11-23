using Dimensionamento.Entities;
using System;
using System.Data.SqlClient;

namespace Dimensionamento.Cálculos
{
	public class EspessuraDoCostado
	{
		public static double ResultadoSemSobrespessuraDeCorrosao(DadosDeProjeto dados)
		{
			var P = dados.Pressao_Interna_de_Projeto;
			var D = dados.Diametro_Interno;
			var S = getTensaoMaximaAdmissivel(dados);
			var E = dados.Eficiencia_de_Junta_do_Costado;


			var resultadoSemSobrespessuraDeCorrosao = (D / 2) * ((Math.Exp(P / (S * E))) - 1);

			//O capítulo 4, seção 4.1, subseção 4.1.2 diz que a espessura mínima sem sobrespessura de corrosão é de 1,6 mm.
			if (resultadoSemSobrespessuraDeCorrosao < 1.6)
			{
				resultadoSemSobrespessuraDeCorrosao = 1.6;
			}

			return resultadoSemSobrespessuraDeCorrosao;
		}

		public static double ResultadoComSobrespessuraDeCorrosao(DadosDeProjeto dados)
		{
			var C = dados.Sobrespessura_de_Corrosao;
			var resultadoComSobrespessuraDeCorrosao = ResultadoSemSobrespessuraDeCorrosao(dados) + C;

			return resultadoComSobrespessuraDeCorrosao;
		}

		public static double getTensaoMaximaAdmissivel(DadosDeProjeto dados)
		{
			string specNo = null;
			string typeOrGrade = null;
			var range = getRange(dados.Temperatura_de_Projeto);
			var specNoEnd = dados.Materiais.Cascos_e_Tampos.IndexOf("Gr.");
			if (specNoEnd != -1)
			{
				specNo = dados.Materiais.Cascos_e_Tampos.Substring(0, specNoEnd);
				var grStart = dados.Materiais.Cascos_e_Tampos.LastIndexOf("Gr.") + 3;
				typeOrGrade = "AND TYPEORGRADE = " + dados.Materiais.Cascos_e_Tampos.Substring(grStart);
			}
			else
			{
				specNo = dados.Materiais.Cascos_e_Tampos;
			}		

			var conn = new SqlConnection("Data Source = SQL5035.site4now.net; Initial Catalog = DB_A4111A_tccdimuff; User Id = DB_A4111A_tccdimuff_admin; Password = asdf1234; ");

			conn.Open();

			var query = $@"
							SELECT * FROM [DB_A4111A_TCCDIMUFF].[DBO].[Parte_D_5-A_2010_PG5452] 
								WHERE [LINENO] IN
									(SELECT[LINENO] FROM [DB_A4111A_TCCDIMUFF].[DBO].[Parte_D_5-A_2010_PG5450] 
										WHERE SPECNO = '{specNo}' {typeOrGrade})";

			var command = new SqlCommand(query, conn);

			using (SqlDataReader reader = command.ExecuteReader())
			{
				reader.Read();
				var result = reader[range].ToString();
				return double.Parse(result);
			}
		}

		private static string getRange(double temperatura)
		{
			if (temperatura > -30 && temperatura <= 40)
			{
				return "-30To40";
			}
			if (temperatura > 40 && temperatura <= 65)
			{
				return "65";
			}
			if (temperatura > 65 && temperatura <= 100)
			{
				return "100";
			}

			for (int i = 100; i < 500; i+=25)
			{
				if (temperatura > i && temperatura <= i+25)
				{
					return (i+25).ToString();
				}
			}
			return "";
		}
	}
}
