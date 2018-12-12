using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dimensionamento.Entities
{
    public static class Table452
    {
		public static double getMinimumThickness(double DN)
		{
			if (DN <= 6)
			{
				return 1.51;
			}
			if (DN <= 8)
			{
				return 1.96;
			}
			if (DN <= 10)
			{
				return 2.02;
			}
			if (DN <= 15)
			{
				return 2.42;
			}
			if (DN <= 20)
			{
				return 2.51;
			}
			if (DN <= 25)
			{
				return 2.96;
			}
			if (DN <= 32)
			{
				return 3.12;
			}
			if (DN <= 40)
			{
				return 3.22;
			}
			if (DN <= 50)
			{
				return 3.42;
			}
			if (DN <= 65)
			{
				return 4.52;
			}
			if (DN <= 80)
			{
				return 4.80;
			}
			if (DN <= 90)
			{
				return 5.02;
			}
			if (DN <= 100)
			{
				return 5.27;
			}
			if (DN <= 125)
			{
				return 5.73;
			}
			if (DN <= 150)
			{
				return 6.22;
			}
			if (DN <= 200)
			{
				return 7.16;
			}
			if (DN < 300)
			{
				return 8.11;
			}
			if (DN < 300)
			{
				return 8.34;
			}
			return 8.34;
		}
    }
}
