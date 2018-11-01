using Dimensionamento.Entities;
using System.Data.SqlClient;

namespace Dimensionamento.Cálculos
{
	public static class CalculosGerais
    {
		public static int getGrupoPotencialdeRisco(DadosDeProjeto dados)
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

		public static string getCategoriadoVaso(DadosDeProjeto dados)
		{
			var tipodeFluido = getClassedeFluido(dados);
			var grupoPotencialdeRisco = getGrupoPotencialdeRisco(dados);

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

		public static char getClassedeFluido(DadosDeProjeto dados)
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
	}
}
