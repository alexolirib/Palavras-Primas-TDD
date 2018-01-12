using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalavrasPrimas;

namespace PalavrasPrimaTeste
{
	[TestClass]
	public class TestePalavras
	{
		[TestMethod]
		public void Escrever_a_NaoPrimo()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("a");

			Assert.AreEqual("O Valor que representa a palavra é 1 e não é primo", resultado);
		}

		[TestMethod]
		public void Escrever_b_Primo()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("b");

			Assert.AreEqual("O Valor que representa a palavra é 2 e é primo", resultado);
		}

		[TestMethod]
		public void Escrever_m_Primo()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("m");

			Assert.AreEqual("O Valor que representa a palavra é 13 e é primo", resultado);
		}

		[TestMethod]
		public void Escrever_z_NaoPrimo()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("z");

			Assert.AreEqual("O Valor que representa a palavra é 26 e não é primo", resultado);
		}

		[TestMethod]
		public void Escrever_A_NaoPrimo()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("A");

			Assert.AreEqual("O Valor que representa a palavra é 27 e não é primo", resultado);
		}

		[TestMethod]
		public void Escrever_K_Primo()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("K");

			Assert.AreEqual("O Valor que representa a palavra é 37 e é primo", resultado);
		}

		[TestMethod]
		public void Escrever_Z_NaoPrimo()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("Z");

			Assert.AreEqual("O Valor que representa a palavra é 52 e não é primo", resultado);
		}

		[TestMethod]
		public void Escrever__NenhumaPalavra()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("");

			Assert.AreEqual("nenhuma palavra", resultado);
		}

		[TestMethod]
		public void Escrever_____NenhumaPalavra()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("   ");

			Assert.AreEqual("nenhuma palavra", resultado);
		}

		[TestMethod]
		public void UsuarioInserirNull()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo(null);

			Assert.AreEqual("nenhuma palavra", resultado);
		}

		[TestMethod]
		public void Escrever_be_Primo()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("be");

			Assert.AreEqual("O Valor que representa a palavra é 7 e é primo", resultado);
		}

		[TestMethod]
		public void Escrever_aAtez_E_AAteZ_NaoPrimo()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ");

			Assert.AreEqual("O Valor que representa a palavra é 1378 e não é primo", resultado);
		}

		[TestMethod]
		public void Escrever_AleX_NaoPrimo()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("AleX");

			Assert.AreEqual("O Valor que representa a palavra é 94 e não é primo", resultado);
		}

		[TestMethod]
		public void Escrever_IVIA_NaoPrimo()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("IVIA");

			Assert.AreEqual("O Valor que representa a palavra é 145 e não é primo", resultado);
		}

		[TestMethod]
		public void Escrever_ivia_Primo()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("ivia");

			Assert.AreEqual("O Valor que representa a palavra é 41 e é primo", resultado);
		}

		[TestMethod]
		public void Escrever_Hackathon_NAoPrimo()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("Hackathon");

			Assert.AreEqual("O Valor que representa a palavra é 107 e é primo", resultado);
		}

		[TestMethod]
		public void Escrever_A__a_NaoPrimo()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("A  a");

			Assert.AreEqual("O Valor que representa a palavra é 28 e não é primo", resultado);
		}

		[TestMethod]
		public void Escrever_A__la_Da_eg_Primo()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("A  la Da  eg");

			Assert.AreEqual("O Valor que representa a palavra é 83 e é primo", resultado);
		}

		[TestMethod]
		public void Escrever_______E_Primo()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("      E");

			Assert.AreEqual("O Valor que representa a palavra é 31 e é primo", resultado);
		}

		[TestMethod]
		public void Escrever_______maria_NaoPrimo()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("      maria");

			Assert.AreEqual("O Valor que representa a palavra é 42 e não é primo", resultado);
		}

		[TestMethod]
		public void Escrever_Comer_aRRoz_e_caRnE_NaoPrimo()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("Comer aRRoz e caRnE");

			Assert.AreEqual("O Valor que representa a palavra é 308 e não é primo", resultado);
		}

		[TestMethod]
		public void Escrever_2018_CaractereNaoPermitido()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("2018");

			Assert.AreEqual("Expressão possui algum caractere que não é permitido", resultado);
		}

		[TestMethod]
		public void Escrever_AlaDa_ég_CaractereNaoPermitido()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("AlaDa ég");

			Assert.AreEqual("Expressão possui algum caractere que não é permitido", resultado);
		}


		[TestMethod]
		public void Escrever_açaí_CaractereNaoPermitido()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("açaí");

			Assert.AreEqual("Expressão possui algum caractere que não é permitido", resultado);
		}


		[TestMethod]
		public void Escrever_aço_CaractereNaoPermitido()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("aço");

			Assert.AreEqual("Expressão possui algum caractere que não é permitido", resultado);
		}


		[TestMethod]
		public void Escrever_tenho_23_anos_CaractereNaoPermitido()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("tenho 23 anos");

			Assert.AreEqual("Expressão possui algum caractere que não é permitido", resultado);
		}


		[TestMethod]
		public void Escrever_isso_é_amor_CaractereNaoPermitido()
		{
			var teste = new VerificaFrase();

			var resultado = teste.PalavraPrimo("isso é amor");

			Assert.AreEqual("Expressão possui algum caractere que não é permitido", resultado);
		}
	}

}
