using Dimensionamento.Entities;
using System.Data.SqlClient;

namespace Dimensionamento.Cálculos
{
	public static class CalculosGerais
    {
		public static int GetGrupoPotencialdeRisco(DadosDeProjeto dados)
		{
			var pv = dados.Pressao_de_Operacao_Maxima * dados.Volume_Interno;

			if (pv >= 100)
			{
				return 1;
			}
			if (pv < 100 && pv >= 30)
			{
				return 2;
			}
			if (pv < 30 && pv >= 2.5)
			{
				return 3;
			}
			if (pv < 2.5 && pv >= 1)
			{
				return 4;
			}
			if (pv < 1)
			{
				return 5;
			}
			return 0;
		}

		public static string GetCategoriadoVaso(DadosDeProjeto dados)
		{
			var tipodeFluido = GetClassedeFluido(dados);
			var grupoPotencialdeRisco = GetGrupoPotencialdeRisco(dados);

			var conn = new SqlConnection("Data Source = SQL5035.site4now.net; Initial Catalog = DB_A4111A_tccdimuff; User Id = DB_A4111A_tccdimuff_admin; Password = asdf1234; ");

			conn.Open();

			var query = $@"
						SELECT * FROM[DB_A4111A_tccdimuff].[dbo].[NR_13_Categoria_de_Vaso]
							WHERE CLASSEDEFLUIDO = '{tipodeFluido}' AND GRUPODEPOTENCIALDERISCO = '{grupoPotencialdeRisco}'";

			var command = new SqlCommand(query, conn);

			using (SqlDataReader reader = command.ExecuteReader())
			{
				reader.Read();
				var result = reader["Categoria"].ToString().Trim();
				return result;
			}
		}

		public static char GetClassedeFluido(DadosDeProjeto dados)
		{
			var fluido = dados.Fluido;

			if (fluido == "Fluidos inflamáveis")
			{
				return 'A';
			}
			if (fluido == "Combustível com temperatura superior ou igual a 200°C")
			{
				return 'A';
			}
			if (fluido == "Fluidos tóxicos com limite de tolerância igual ou inferior a 20 ppm")
			{
				return 'A';
			}
			if (fluido == "Hidrogênio")
			{
				return 'A';
			}
			if (fluido == "Acetileno")
			{
				return 'A';
			}
			if (fluido == "Fluidos combustíveis com temperatura inferior a 200°C")
			{
				return 'B';
			}
			if (fluido == "Fluidos tóxicos com limite de tolerância superior a 20 ppm")
			{
				return 'B';
			}
			if (fluido == "Vapor de água, gases asfixiantes simples ou ar comprimido")
			{
				return 'C';
			}

			return 'D';
		}

		public static double GetTensaoMaximaAdmissivel(string parte, double temperaturaDeProjeto, string material)
		{
			string specNo = null;
			string typeOrGrade = null;
			var range = GetRange(temperaturaDeProjeto);
			var specNoEnd = material.IndexOf("Gr.");
			if (specNoEnd != -1)
			{
				specNo = material.Substring(0, specNoEnd);
				var grStart = material.LastIndexOf("Gr.") + 3;
				typeOrGrade = "AND TYPEORGRADE = '" + material.Substring(grStart) + "'";
			}
			else
			{
				specNo = material;
			}

			var conn = new SqlConnection("Data Source = SQL5035.site4now.net; Initial Catalog = DB_A4111A_tccdimuff; User Id = DB_A4111A_tccdimuff_admin; Password = asdf1234; ");

			conn.Open();

			string db1 = "";
			string db2 = "";

			if (parte == "Cascos e Tampos")
			{
				db1 = "Parte_D_5-A_2010_PG5452";
				db2 = "Parte_D_5-A_2010_PG5450";
			}
			if (parte == "Bocal")
			{
				db1 = "Parte_D_5-A_2010_PG5448";
				db2 = "Parte_D_5-A_2010_PG5446";
			}

			var query = $@"
							SELECT * FROM [DB_A4111A_TCCDIMUFF].[DBO].[{db1}] 
								WHERE [LINENO] IN
									(SELECT[LINENO] FROM [DB_A4111A_TCCDIMUFF].[DBO].[{db2}] 
										WHERE SPECNO = '{specNo}' {typeOrGrade})";

			var command = new SqlCommand(query, conn);

			using (SqlDataReader reader = command.ExecuteReader())
			{
				reader.Read();
				var result = reader[range].ToString();
				return double.Parse(result);
			}
		}

		public static string GetRange(double temperatura)
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

			for (int i = 100; i < 500; i += 25)
			{
				if (temperatura > i && temperatura <= i + 25)
				{
					return (i + 25).ToString();
				}
			}
			return "";
		}
	}
}
