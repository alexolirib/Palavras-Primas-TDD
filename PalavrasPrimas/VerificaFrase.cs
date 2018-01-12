using System;

namespace PalavrasPrimas
{
    public class VerificaFrase
    {
		public String PalavraPrimo(string palavra)
		{
			if (palavra != null)
			{
				palavra = palavra.Replace(" ", "");
			}

			if (palavra != null && palavra.Length>0)
			{
				// O método TransformaEmNumero irá pegar a palavra e converter para número e somar cada caractere, 
				// irá retornar o total da soma, se retornar -1 significa que tem algum caractere que não é permitido
				int PalavraValor = TransformaEmNumero(palavra);
				
				if (PalavraValor != -1)
				{
					String NumeroPrimo = VerificaNumeroPrimo(PalavraValor);
					return "O Valor que representa a palavra é " + PalavraValor + " e " + NumeroPrimo; 
				}
				else
				{
					return "Expressão possui algum caractere que não é permitido";
				}
			}
			else
			{
				return "nenhuma palavra";
			}
		}

		private int TransformaEmNumero(string palavra)
		{
			char[] CharPalavra = palavra.ToCharArray();
			int contador = 0;

			for (int i = 0; i < CharPalavra.Length; i++)
			{	//Verifica se é um caractere válido pela a tabela ASCII
				if (((Convert.ToInt32(CharPalavra[i]) >= 65) && (Convert.ToInt32(CharPalavra[i]) <= 90)) || ((Convert.ToInt32(CharPalavra[i]) >= 97) && (Convert.ToInt32(CharPalavra[i]) <= 122)))
				{
					//Verifica se é maiúscula
					if ((Convert.ToInt32(CharPalavra[i]) >= 65) && (Convert.ToInt32(CharPalavra[i]) <= 90))
					{
						contador += (Convert.ToInt32(CharPalavra[i]) - 38);
					}
					else //Minúscula
					{
						contador += (Convert.ToInt32(CharPalavra[i]) - 96);
					} 
				}
				else
				{
					return -1;
				}
			}
			return contador;
		}

		private String VerificaNumeroPrimo(int PalavraValor)
		{
			int contadorDivisivel = 0;
			for (int i = 1; i <= PalavraValor; i++)
			{
				if (PalavraValor % i == 0)
				{
					contadorDivisivel++;
				}
			}

			if (contadorDivisivel == 2)
			{
				return "é primo";
			}
			else
			{
				return "não é primo";
			}
		}
	}
}
