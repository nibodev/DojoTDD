using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DojoTDD.Tests
{
	[TestFixture]
	public class SalesTests
	{

		[Test]
		public void TesteComissaoComVendaMenorDe10000()
		{
			// arrange
			decimal saleValue = 1000;
			Domain.Sale sale = new Domain.Sale(saleValue);
			decimal expectedComission = 50;

			// act
			decimal comission = sale.GetComission();

			// assert
			Assert.AreEqual(expectedComission, comission);
		}

		[Test]
		public void TesteComissaoComVendaMaiorDe10000()
		{
			// arrange
			decimal saleValue = 100000;
			Domain.Sale sale = new Domain.Sale(saleValue);
			decimal expectedComission = 10000;

			// act
			decimal comission = sale.GetComission();

			// assert
			Assert.AreEqual(expectedComission, comission);
		}

		[Test]
		public void TesteComissaoComVendaIguala10000()
		{
			// arrange
			decimal saleValue = 10000;
			Domain.Sale sale = new Domain.Sale(saleValue);
			decimal expectedComission = 500;

			// act
			decimal comission = sale.GetComission();

			// assert
			Assert.AreEqual(expectedComission, comission);
		}

	}
}
