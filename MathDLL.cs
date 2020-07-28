using System;
using System.Globalization;
using System.Linq;

namespace DLL_Math
{
	/// <summary>
	/// Classe para calculos
	/// </summary>
	public class MathDLL
	{
		/// <summary>
		/// Metodo de Subtracao entre dois numeros.
		/// </summary>
		/// <param name="value1">String a ser inserida (string)</param>
		/// <param name="value2">String a ser inserida (string)</param>
		/// <returns>Subtracao de todos os numeros listados(float)</returns>
		public static float subtracaoEntreDoisNumeros(string value1, string value2)
		{
			value1 = value1.Replace(",", ".");
			value2 = value2.Replace(",", ".");

			float valueFinal1 = float.Parse(value1, CultureInfo.InvariantCulture);
			float valueFinal2 = float.Parse(value2, CultureInfo.InvariantCulture);

			return valueFinal1 - valueFinal2;
		}

		/// <summary>
		/// Metodo de Soma entre dois numeros.
		/// </summary>
		/// <param name="value1">String a ser inserida (string)</param>
		/// <param name="value2">String a ser inserida (string)</param>
		/// <returns>Soma de todos os numeros listados(float)</returns>
		public static float somaEntreDoisNumeros(string value1, string value2)
		{
			value1 = value1.Replace(",", ".");
			value2 = value2.Replace(",", ".");

			float valueFinal1 = float.Parse(value1, CultureInfo.InvariantCulture);
			float valueFinal2 = float.Parse(value2, CultureInfo.InvariantCulture);

			return valueFinal1 + valueFinal2;
		}

		/// <summary>
		/// Metodo de multiplicacao entre varios numeros.
		/// </summary>
		/// <param name="value">CSV String a ser inserida (string)</param>
		/// <returns>Multiplicacao de todos os numeros listados (float)</returns>
		public static float multiplicacaoEntradaString(string value)
		{
			string valueReplaced = value.Replace(",", ".");

			string[] stringArray = valueReplaced.Split(';');

			float result = 1;

			for (var x = 0; x < stringArray.Length; x++)
			{
				result = result * float.Parse(stringArray[x], CultureInfo.InvariantCulture);
			}

			return result;
		}

		/// <summary>
		/// Metodo de multiplicacao entre varios numeros.
		/// </summary>
		/// <param name="value">CSV String a ser inserida (string)</param>
		/// <returns>Multiplicacao de todos os numeros listados (float)</returns>
		public static float multiplicacaoEntradaArray(string[] value)
		{
			float result = 1;

			for (var x = 0; x < value.Length; x++)
			{
				result = result * float.Parse(value[x], CultureInfo.InvariantCulture);
			}

			return result;
		}

		/// <summary>
		/// Metodo de multiplicacao entre dois numeros.
		/// </summary>
		/// <param name="value1">Primeiro Numero (string)</param>
		/// /// <param name="value2">Segundo Numero (string)</param>
		/// <returns>Multiplicacao de todos os numeros listados (float)</returns>
		public static float multiplicacaoDoisNumeros(string value1, string value2)
		{
			value1 = value1.Replace(",", ".");
			value2 = value2.Replace(",", ".");

			float valueFinal1 = float.Parse(value1, CultureInfo.InvariantCulture);
			float valueFinal2 = float.Parse(value2, CultureInfo.InvariantCulture);

			return valueFinal1 * valueFinal2;
		}

		/// <summary>
		/// Metodo de divisao entre dois numeros.
		/// </summary>
		/// <param name="dividendo">Valor a ser dividido (string)</param>
		/// <param name="divisor">Valor a dividir (string)</param>
		/// <returns>Valor da divisao entre dividendo e divisor (float)</returns>
		public static float divisao(string dividendo, string divisor)
		{
			float value1 = float.Parse(divisor, CultureInfo.InvariantCulture);
			float value2 = float.Parse(dividendo, CultureInfo.InvariantCulture);

			return value2 / value1;
		}

		/// <summary>
		/// Ordena um conjunto de numeros.
		/// </summary>
		/// <param name="value">CSV String com os numeros a serem ordenados (string)</param>
		/// <returns>CSV com os numeros ordenados (string)</returns>
		public static string ordenaArrayEntradaArray(string[] value)
		{
			for (int x = 0; x < value.Length; x++)
			{
				value[x] = value[x].Replace(".", ",");
			}
			double[] myDoubles = Array.ConvertAll(value, double.Parse);

			double[] arrayFinal = myDoubles.OrderBy(c => c).ToArray();

			string[] result = Array.ConvertAll(arrayFinal, x => x.ToString().Replace(",", "."));

			var final = string.Join(",", result);
			return final;
		}

		/// <summary>
		/// Ordena um conjunto de numeros.
		/// </summary>
		/// <param name="value">CSV String com os numeros a serem ordenados (string)</param>
		/// <returns>CSV com os numeros ordenados (string)</returns>
		public static string ordenaArrayEntradaString(string value)
		{
			value = value.Replace(".", ",");

			string[] splitNumber = value.Split(';');

			double[] myDoubles = Array.ConvertAll(splitNumber, double.Parse);

			double[] arrayFinal = myDoubles.OrderBy(c => c).ToArray();

			string[] result = Array.ConvertAll(arrayFinal, x => x.ToString().Replace(",", "."));

			var final = string.Join(",", result);
			return final;
		}

		/// <summary>
		/// Ordena um conjunto de numeros e os inverte depois.
		/// </summary>
		/// <param name="value">CSV String com os numeros a serem ordenados e invertidos (string)</param>
		/// <returns>CSV com os numeros ordenados e invertidos (string)</returns>
		public static string ordenaInverteArrayEntradaString(string value)
		{
			value = value.Replace(".", ",");

			string[] splitNumber = value.Split(';');

			double[] myDoubles = Array.ConvertAll(splitNumber, double.Parse);

			double[] arrayFinal = myDoubles.OrderByDescending(c => c).ToArray();

			string[] result = Array.ConvertAll(arrayFinal, x => x.ToString().Replace(",", "."));

			var final = string.Join(",", result);

			return final;
		}

		/// <summary>
		/// Ordena um conjunto de numeros e os inverte depois.
		/// </summary>
		/// <param name="value">CSV String com os numeros a serem ordenados e invertidos (string)</param>
		/// <returns>CSV com os numeros ordenados e invertidos (string)</returns>
		public static string ordenaInverteArrayEntradaArray(string[] value)
		{
			for (int x = 0; x < value.Length; x++)
			{
				value[x] = value[x].Replace(".", ",");
			}

			double[] myDoubles = Array.ConvertAll(value, double.Parse);

			double[] arrayFinal = myDoubles.OrderByDescending(c => c).ToArray();

			string[] result = Array.ConvertAll(arrayFinal, x => x.ToString().Replace(",", "."));

			var final = string.Join(",", result);

			return final;
		}

		/// <summary>
		/// Soma um conjunto de numeros.
		/// </summary>
		/// <param name="value">CSV String com os numeros a serem ordenados (string)</param>
		/// <returns>Resultado da soma de todos os valores (string)</returns>
		public static double somaArrayEntradaString(string value)
		{
			value = value.Replace(".", ",");

			string[] splitNumber = value.Split(';');

			double[] myDoubles = Array.ConvertAll(splitNumber, double.Parse);

			double[] arrayFinal = myDoubles.ToArray();

			double final = 0;

			final = arrayFinal.Sum();

			return final;
		}

		/// <summary>
		/// Soma um conjunto de numeros.
		/// </summary>
		/// <param name="value">CSV String com os numeros a serem ordenados (string)</param>
		/// <returns>Resultado da soma de todos os valores (string)</returns>
		public static double somaArrayEntradaArray(string[] value)
		{
			for (int x = 0; x < value.Length; x++)
			{
				value[x] = value[x].Replace(".", ",");
			}
			double[] myDoubles = Array.ConvertAll(value, double.Parse);

			double[] arrayFinal = myDoubles.ToArray();

			double final = 0;

			final = arrayFinal.Sum();

			return final;
		}

		/// <summary>
		/// Media de um conjunto de numeros.
		/// </summary>
		/// <param name="value">CSV String com os numeros a serem ordenados (string)</param>
		/// <returns>Resultado da media de todos os valores (string)</returns>
		public static double mediaArrayEntradaString(string value)
		{
			value = value.Replace(".", ",");

			string[] splitNumber = value.Split(';');

			double[] myDoubles = Array.ConvertAll(splitNumber, double.Parse);

			double[] arrayFinal = myDoubles.ToArray();

			double final = 0;

			final = (arrayFinal.Sum() / arrayFinal.Length);

			return final;
		}

		/// <summary>
		/// Media de um conjunto de numeros.
		/// </summary>
		/// <param name="value">CSV String com os numeros a serem ordenados (string)</param>
		/// <returns>Resultado da media de todos os valores (string)</returns>
		public static double mediaArrayEntradaArray(string[] value)
		{
			for (int x = 0; x < value.Length; x++) {
				value[x] = value[x].Replace(".",",");
			}
			double[] myDoubles = Array.ConvertAll(value, double.Parse);

			double[] arrayFinal = myDoubles.ToArray();

			double final = 0;

			final = (arrayFinal.Sum() / arrayFinal.Length);

			return final;
		}

		/// <summary>
		/// Porcentagem de um numero em relacao a outro.
		/// </summary>
		/// <param name="porcentagem">Porcentagem do valor (string)</param>
		/// <param name="valor">Valor total a ser calculado a porcentagem (string)</param>
		/// <returns>Valor calculado da porcentagem (porcentagem/100)*valor (string)</returns>
		public static float porcentagemDeUmValor(string porcentagem, string valor)
		{
			valor = valor.Replace(",", ".");

			porcentagem = porcentagem.Replace(",", ".");

			float valueFinal1 = float.Parse(porcentagem, CultureInfo.InvariantCulture);

			float valueFinal2 = float.Parse(valor, CultureInfo.InvariantCulture);

			return (valueFinal1 / 100) * valueFinal2;
		}

		/// <summary>
		/// Metodo de fatorial de um numero.
		/// </summary>
		/// <param name="dividendo">Valor a ser dividido (string)</param>
		/// <param name="divisor">Valor a dividir (string)</param>
		/// <returns>Resto da divisao entre dois numeros (float)</returns>
		public static float restoDivisao(string dividendo, string divisor)
		{
			dividendo = dividendo.Replace(",", ".");
			divisor = divisor.Replace(",", ".");

			float valueFinal1 = float.Parse(dividendo, CultureInfo.InvariantCulture);
			float valueFinal2 = float.Parse(divisor, CultureInfo.InvariantCulture);
			return (valueFinal1 % valueFinal2);
		}

		/// <summary>
		/// Metodo de raiz quadrada de um numero.
		/// </summary>
		/// <param name="value">Valor a ser calculado (string)</param>
		/// <returns>Raiz quadrada do numero(double)</returns>
		public static double raizQuadrada(string value)
		{
			value = value.Replace(",", ".");

			double value1 = Convert.ToDouble(value, CultureInfo.InvariantCulture);
			return Math.Sqrt(value1);
		}

		/// <summary>
		/// Metodo de fatorial de um numero.
		/// </summary>
		/// <param name="value">Numero (string)</param>
		/// <returns>Fatorial do numero (float)</returns>
		public static float fatorial(string value)
		{
			value = value.Replace(",", ".");

			float valueFinal1 = float.Parse(value, CultureInfo.InvariantCulture);

			float fat = valueFinal1;

			for (int i = 1; i < fat; i++)
			{
				valueFinal1 = valueFinal1 * i;
			}

			return valueFinal1;
		}

		/// <summary>
		/// Metodo de fibonacci.
		/// </summary>
		/// <param name="value">Numero de iteracoes fibonacci (string)</param>
		/// <returns>Resultado do calculo das iteracoes(int)</returns>
		public static int fibonacci(string value)
		{
			value = value.Replace(",", ".");

			int valueFinal1 = Int32.Parse(value);

			int resultado = 0;

			int n1 = 0;
			int n2 = 1;
			int n3;

			for (int i = 2; i < valueFinal1; ++i)
			{
				n3 = n1 + n2;
				resultado = n3;
				n1 = n2;
				n2 = n3;
			}

			return resultado;
		}

		/// <summary>
		/// Metodo de verificacao de numero para ver se e par ou impar.
		/// </summary>
		/// <param name="value">Numero (string)</param>
		/// <returns>True ou False (bool)</returns>
		public static bool numeroPar(string value)
		{
			value = value.Replace(",", ".");

			bool resultado;
			float valueFinal1 = float.Parse(value, CultureInfo.InvariantCulture);
			if (valueFinal1 % 2 == 0)
			{
				resultado = true;
			}
			else
			{
				resultado = false;
			}
			return resultado;
		}

		/// <summary>
		/// Metodo de verificacao de numero para ver se e primo.
		/// </summary>
		/// <param name="value">Numero (string)</param>
		/// <returns>True ou False (bool)</returns>
		public static bool numeroPrimo(string value)
		{
			value = value.Replace(",", ".");

			bool resultado = false;
			float m = 0;
			int flag = 0;
			float valueFinal1 = float.Parse(value, CultureInfo.InvariantCulture);

			m = valueFinal1 / 2;
			for (int i = 2; i <= m; i++)
			{
				if (valueFinal1 % i == 0)
				{
					resultado = false;
					flag = 1;
					break;
				}
			}
			if (flag == 0)
			{
				resultado = true;
			}
			return resultado;
		}

		/// <summary>
		/// Metodo de arredondamento de numero para o inteiro mais proximo.
		/// </summary>
		/// <param name="value">Numero (string)</param>
		/// <returns>Numero arredondado (decimal)</returns>
		public static decimal arredondaNum(string value)
		{
			value = value.Replace(",", ".");

			decimal valueFinal1 = Decimal.Parse(value, CultureInfo.InvariantCulture);

			return (Math.Round(valueFinal1));
		}

		/// <summary>
		/// Metodo de calculo de logaritmo de um num.
		/// </summary>
		/// <param name="value">Numero (string)</param>
		/// <returns>Valor do log (double)</returns>
		public static double log(string value)
		{
			value = value.Replace(",", ".");
			double value1 = Convert.ToDouble(value);
			return Math.Log(value1);
		}

		/// <summary>
		/// Metodo de calculo de logaritmo com base.
		/// </summary>
		/// <param name="value">Numero (string)</param>
		/// /// <param name="baseValue">Numero da base (string)</param>
		/// <returns>Valor do log (double)</returns>
		public static double logBase(string value, string baseValue)
		{
			value = value.Replace(",", ".");
			double value1 = Convert.ToDouble(value, CultureInfo.InvariantCulture);
			double value2 = Convert.ToDouble(baseValue, CultureInfo.InvariantCulture);
			return Math.Log(value1, value2);
		}

		/// <summary>
		/// Metodo de comparacao entre dois numeros.
		/// </summary>
		/// <param name="value1">Primeiro Numero (string)</param>
		/// /// <param name="value2">Segundo Numero (string)</param>
		/// <returns>Maior numero (float)</returns>
		public static float maiorNumFloat(string value1, string value2)
		{
			value1 = value1.Replace(",", ".");
			value2 = value2.Replace(",", ".");

			float valueFinal1 = float.Parse(value1, CultureInfo.InvariantCulture);
			float valueFinal2 = float.Parse(value2, CultureInfo.InvariantCulture);

			return (Math.Max(valueFinal1, valueFinal2));
		}

		/// <summary>
		/// Metodo de comparacao entre dois numeros.
		/// </summary>
		/// <param name="value1">Primeiro Numero (string)</param>
		/// /// <param name="value2">Segundo Numero (string)</param>
		/// <returns>Menor numero (float)</returns>
		public static float menorNumFloat(string value1, string value2)
		{
			value1 = value1.Replace(",", ".");
			value2 = value2.Replace(",", ".");

			float valueFinal1 = float.Parse(value1, CultureInfo.InvariantCulture);
			float valueFinal2 = float.Parse(value2, CultureInfo.InvariantCulture);

			return (Math.Min(valueFinal1, valueFinal2));
		}

		/// <summary>
		/// Metodo de comparacao entre dois numeros inteiros para ver o maior deles.
		/// </summary>
		/// <param name="value">Numero (string)</param>
		/// <returns>Maior numero (int32)</returns>
		public static double maiorNumEntradaString(string value)
		{
			value = value.Replace(".", ",");

			var splitNumber = value.Split(';');
			double[] myInts = Array.ConvertAll(splitNumber, double.Parse);
			return myInts.Max();
		}

		/// <summary>
		/// Metodo de comparacao entre dois numeros inteiros para ver o maior deles.
		/// </summary>
		/// <param name="value">Numero (string)</param>
		/// <returns>Maior numero (int32)</returns>
		public static double maiorNumEntradaArray(string[] value)
		{
			for (int x = 0; x < value.Length; x++)
			{
				value[x] = value[x].Replace(".", ",");
			}

			double[] myInts = Array.ConvertAll(value, double.Parse);
			return myInts.Max();
		}



		/// <summary>
		/// Metodo de comparacao entre numeros inteiros em padrao CSV para ver o menor deles.
		/// </summary>
		/// <param name="value">Numero (string)</param>
		/// <returns>Menor numero (int32)</returns>
		public static double menorNumEntradaString(string value)
		{
			value = value.Replace(".", ",");

			var splitNumber = value.Split(';');
			double[] myInts = Array.ConvertAll(splitNumber, double.Parse);
			return myInts.Min();
		}

		/// <summary>
		/// Metodo de comparacao entre numeros inteiros em padrao CSV para ver o menor deles.
		/// </summary>
		/// <param name="value">Numero (string)</param>
		/// <returns>Menor numero (int32)</returns>
		public static double menorNumEntradaArray(string[] value)
		{
			for (int x = 0; x < value.Length; x++)
			{
				value[x] = value[x].Replace(".", ",");
			}
			double[] myInts = Array.ConvertAll(value, double.Parse);
			return myInts.Min();
		}

		/// <summary>
		/// Metodo de calculo de Angulo do Cosseno.
		/// </summary>
		/// <param name="value">Numero (string)</param>
		/// <returns>Valor do calculo do angulo do Cosseno (double)</returns>
		public static double anguloCosseno(string value)
		{
			value = value.Replace(",", ".");

			double valueFinal = Double.Parse(value, CultureInfo.InvariantCulture);

			return (Math.Acos(valueFinal));
		}

		/// <summary>
		/// Metodo de calculo de Angulo do Seno.
		/// </summary>
		/// <param name="value">Numero (string)</param>
		/// <returns>Valor do calculo do angulo do Seno (double)</returns>
		public static double anguloSeno(string value)
		{
			value = value.Replace(",", ".");

			double valueFinal = Double.Parse(value, CultureInfo.InvariantCulture);

			return (Math.Asin(valueFinal));
		}

		/// <summary>
		/// Metodo de calculo de Angulo do Tangente.
		/// </summary>
		/// <param name="value">Numero (string)</param>
		/// <returns>Valor do calculo do angulo da Tangente (double)</returns>
		public static double anguloTangente(string value)
		{
			value = value.Replace(",", ".");

			double valueFinal = Double.Parse(value, CultureInfo.InvariantCulture);

			return (Math.Atan(valueFinal));
		}

		/// <summary>
		/// Metodo de calculo de Cosseno.
		/// </summary>
		/// <param name="value">Numero (string)</param>
		/// <returns>Valor do calculo do Cosseno (double)</returns>
		public static double cosseno(string value)
		{
			value = value.Replace(",", ".");

			double valueFinal = Double.Parse(value, CultureInfo.InvariantCulture);

			return (Math.Cos(valueFinal));
		}

		/// <summary>
		/// Metodo de calculo de Seno.
		/// </summary>
		/// <param name="value">Numero (string)</param>
		/// <returns>Valor do calculo do Seno (double)</returns>
		public static double seno(string value)
		{
			value = value.Replace(",", ".");

			double valueFinal = Double.Parse(value, CultureInfo.InvariantCulture);

			return (Math.Sin(valueFinal));
		}

		/// <summary>
		/// Metodo de calculo de Tangente.
		/// </summary>
		/// <param name="value">Numero (string)</param>
		/// <returns>Valor do calculo da Tangente (double)</returns>
		public static double tangente(string value)
		{
			value = value.Replace(",", ".");

			double valueFinal = Double.Parse(value, CultureInfo.InvariantCulture);

			return (Math.Tan(valueFinal));
		}

		/// <summary>
		/// Metodo de calculo de potencia base e expoente.
		/// </summary>
		/// <param name="baseV">Base (string)</param>
		/// /// <param name="expoente">Expoente (string)</param>
		/// <returns>Valor do calculo da potencia (double)</returns>
		public static double potencia(string baseV, string expoente)
		{
			baseV = baseV.Replace(",", ".");
			expoente = expoente.Replace(",", ".");

			double valueFinal1 = Double.Parse(baseV, CultureInfo.InvariantCulture);
			double valueFinal2 = Double.Parse(expoente, CultureInfo.InvariantCulture);

			return (Math.Pow(valueFinal1, valueFinal2));
		}

		/// <summary>
		/// Metodo de calculo de raiz.
		/// </summary>
		/// <param name="indice">Base (string)</param>
		/// /// <param name="radicando">Expoente (string)</param>
		/// <returns>Valor do calculo da raiz (double)</returns>
		public static double raiz(string indice, string radicando)
		{
			indice = indice.Replace(",", ".");
			radicando = radicando.Replace(",", ".");

			double value1 = Double.Parse(indice, CultureInfo.InvariantCulture);
			double value2 = Double.Parse(radicando, CultureInfo.InvariantCulture);
			//linha teste
			return (Math.Pow(value2, 1 / value1));
		}

	}
}
