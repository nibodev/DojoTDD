using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoTDD.Domain
{
	public class Sale
	{
		public decimal Value { get; set; }
		public Sale(decimal value)
		{
			Value = value;
		}
		
		public decimal GetComission()
		{
			decimal comission = 0;
			if (Value > 10000)
			{
				comission = Value * 0.1M;
			}
			else
			{
				comission = Value * 0.05M;
			}
			return comission;
		}
	}
}
