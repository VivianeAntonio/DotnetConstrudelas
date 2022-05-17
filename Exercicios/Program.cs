﻿// ------------ AULA 1 HELLO WORLD --------------

/*Console.WriteLine("Hello, World!");*/

// ------------ AULA 2 APRESENTAÇÃO DE TIPOS --------------

/*uint ui = 100;
float fl = 10.2f;
long l = 45754577777777;
ulong ul = 4575454547777;
double d = 14555451.555;
decimal mon = 1000.15m;
string meuNome = "Viviane";
char primeiraLetraDoMeuNome = 'T';

Console.WriteLine(ui);
Console.WriteLine(fl);
Console.WriteLine(l);
Console.WriteLine(ul);
Console.WriteLine(d);
Console.WriteLine(mon);
Console.WriteLine(meuNome);
Console.WriteLine(primeiraLetraDoMeuNome);*/

// CONVERSÕES
/*double a = 10.555;
int b = (int)a;
Console.WriteLine(b);*/

// CONVERTER STRING PARA INT
/*string inteiroPossivel = "1234";
int cont = Convert.ToInt32(inteiroPossivel);
Console.WriteLine(cont);*/

// CONVERTER  TRYPARSE RETORNA BOOLEANO
/*int numero = 0;
string numeroString = "1234";
Console.WriteLine(int.TryParse(numeroString, out numero));
Console.WriteLine(numero);*/

// EXERCICIO PEDIR PARA USUARIO DIGITAR 2 NUMEROS E SOMAR

/*string a = Console.ReadLine();
string b = Console.ReadLine();
int c = Convert.ToInt32(a) + Convert.ToInt32(b);
Console.WriteLine(c);*/


// SOLUÇÃO DA PROFESSORA    
/*string a = Console.ReadLine();
string b = Console.ReadLine();
int aConvertido, bConvertido;

int.TryParse(a, out aConvertido);
int.TryParse(b, out bConvertido);
int c = aConvertido + bConvertido;

Console.WriteLine(c);*/

// OUTRA SOLUÇÃO 
/*Console.Write("\nInforme o Primeiro número: ");
string a = Console.ReadLine();
Console.Write("\nInforme o Segundo número: ");
string b = Console.ReadLine();
Console.WriteLine("\n Soma dos números é {0}", Convert.ToInt32(a) + Convert.ToInt32(b));
Console.Read();*/

// ------------- AULA 3 datas ---------------

/*var date = new DateTime();
Console.WriteLine(date);

var date1 = DateTime.Now;
Console.WriteLine(date1);

var date2 = DateTime.UtcNow;
Console.WriteLine(date2);

var date3 = new DateTime(2020, 07, 02, 22, 59, 59);
var date4 = new DateTime(2020, 07, 02);

Console.WriteLine(date1.DayOfWeek);

Console.WriteLine(date1.Day);
Console.WriteLine(date1.Month);
Console.WriteLine(date1.Year);

var date5 = DateTime.Now;
Console.WriteLine(date5);
date = date5.AddDays(2);
Console.WriteLine(date5);*/

// EXERCÍCIO: pedir pro usuariO dia, mes e ano do aniversario
// e escrever na tela o dia da semana e dia do ano que ela nasceu
/*
Console.WriteLine("Digite o dia do seu aniversário: ");
var dia = Console.ReadLine();
Console.WriteLine("Digite o mês do seu aniversário: ");
var mes = Console.ReadLine();
Console.WriteLine("Digite o ano do seu aniversário: ");
var ano = Console.ReadLine();

var diaInteiro = Convert.ToInt32(dia);
var mesInteiro = Convert.ToInt32(mes);
var anoInteiro = Convert.ToInt32(ano);

var dataDoAniversario = new DateTime(anoInteiro, mesInteiro, diaInteiro);
Console.WriteLine(dataDoAniversario.DayOfWeek);
Console.WriteLine(dataDoAniversario.DayOfYear);
*/

// ----- TRABALHANDO COM STRINGS concatenando -----
/*
StringBuilder sb = new StringBuilder();
sb.Append("Viviane ");
sb.Append(" Antonio ");
string str = sb.ToString();
Console.WriteLine(str);
*/

// ----- COMPARANDO STRINGS -----
/*
var a = "A";
var b = "a";
//Console.WriteLine(a == b);
//Console.WriteLine(a.Equals(b));

Console.WriteLine(String.Compare(a,b, true));

string s = new string('*', 20);
Console.WriteLine(s);

string s1 = "eu sou programadora";
string s2 = "dora";

var pos = s1.IndexOf(s2);
Console.WriteLine(pos);

var pos2 = s1.ToCharArray();    // ********* importante **********
Console.WriteLine(pos2[10]);
*/

// ----- EXERCICIO -------
/*
Console.WriteLine("Digite uma string: ");
string primeira = Console.ReadLine();
Console.WriteLine("Digite outra string: ");
string segunda = Console.ReadLine();
Console.WriteLine(segunda + " " + primeira);
var primeiraChar = primeira.ToCharArray();
Console.WriteLine(primeira[2]);

*/
// SUBSTRING

/*
var primeira = Console.ReadLine();
var strRet = primeira.Substring(0, 2); //vai retornar da posição 0 até a posição 2
Console.WriteLine(strRet);

*/
/*
var primeira = Console.ReadLine();
var strRet = primeira.Replace("teste", "legal");
var strRet2 = primeira.Replace('t', 'l');
Console.WriteLine(strRet);
Console.WriteLine(strRet2);
*/


// ------ GLOBALIZAÇÃO--- idioma

/*
using System.Globalization;
CultureInfo pt = new CultureInfo("en-us");
Console.WriteLine(pt.DisplayName);
Console.WriteLine(pt.DateTimeFormat.FirstDayOfWeek.ToString());
Console.WriteLine(pt.DateTimeFormat.DateSeparator);
Console.WriteLine(pt.NumberFormat.CurrencyDecimalSeparator);
var number = 10000;
Console.WriteLine(number.ToString("c", pt));
var dateTime = DateTime.Now;
Console.WriteLine(dateTime.ToString(pt));
*/

// -----------EXERCICIO -------
/*using System.Globalization;
CultureInfo pt = new CultureInfo("pt-BR");

Console.WriteLine("Qual a cidade onde você mora? ");
string cidade = Console.ReadLine();
Console.WriteLine("Qual o valor da gasolina? ");
string valorGasolina = Console.ReadLine();

var gasolinaConvertido = Convert.ToDecimal(valorGasolina);
var hoje = DateTime.Now;
Console.WriteLine("Em " + cidade + " no dia " + hoje.ToString(pt) +
    " a gasolina está custando " + gasolinaConvertido);*/

// --------------- AULA 4 - ERROS ---------------

// consertar esses erros:
/*var date = new DateTime("2020", 07, 02, 22, 59, 59);
string minhaString = new DateTime();
Console.WriteLine("")*/


/*var date = new DateTime(2020, 07, 02, 22, 59, 59);
DateTime minhaString = new DateTime();
Console.WriteLine("");
return;
Console.WriteLine("oi");
Console.WriteLine(minhaString);*/

// TRY CATCH
/*var a = "OlaThays";
try
{
    Convert.ToInt32(a);
    Console.WriteLine("lalalla");
}
catch (Exception e)
{
    Console.WriteLine("Deu Erro");
    Console.WriteLine(e.ToString());
}*/

/*Console.WriteLine("Digite o dia do seu aniversário no formato DD/MM/AAAA");
string dataDeNascimentoStr = Console.ReadLine();
string diaStr = dataDeNascimentoStr.Substring(0, 2);
string mesStr = dataDeNascimentoStr.Substring(3, 2);
string anoStr = dataDeNascimentoStr.Substring(6, 4);
try
{
    short dia = Convert.ToInt16(diaStr);
    short mes = Convert.ToInt16(mesStr);
    short ano = Convert.ToInt16(anoStr);
    var dataDeNascimentoDate = new DateTime(ano, mes, dia);
    Console.WriteLine(dataDeNascimentoDate.DayOfWeek);
}
catch (Exception ex)
{
    Console.WriteLine("Digite a data corretamente");
    Console.WriteLine(ex.ToString());
}
*/

// ------ operadores aritmeticos ------
/*
int i = 3;
Console.WriteLine(i);
Console.WriteLine(i++);
Console.WriteLine(i);

int k = 3;
Console.WriteLine(k);
Console.WriteLine(k--);
Console.WriteLine(k);

int j = 4;
Console.WriteLine(j);
Console.WriteLine(--j);
Console.WriteLine(j);*/

// exercicio calcular o resto da divisao por 2

/*Console.WriteLine("Digite um número: ");
var numero = Console.ReadLine();
int divisao = Convert.ToInt32(numero);
int resto = divisao % 2;
Console.WriteLine(resto);*/

/*int a = 10;
//a += 20;
a = a + 20;
Console.WriteLine(a);

int b = 10;
//b *= 20;
b = b * 20;
Console.WriteLine(b);*/


/*int a = 10;
int b = 20;
Console.WriteLine(a > b || b > 10); //true*/


/*int a = 10;
int b = 20;
Console.WriteLine(a > b || b > 10); //true
Console.WriteLine(a < b && b > 10); //true
Console.WriteLine(a < b && b < 10); //false*/

// ----- exercicio ----

/*Console.WriteLine("Digite o primeiro número: ");
var primeiroNum = Console.ReadLine();
Console.WriteLine("Digite o segundo número: ");
var segundoNum = Console.ReadLine();

int primeiroInt = Convert.ToInt32(primeiroNum);
int segundoInt = Convert.ToInt32(segundoNum);

Console.WriteLine(primeiroInt >= segundoInt || primeiroInt < segundoInt);*/

/* ----- outra solucao-----   

Console.Write("Digite um número: ");
int.TryParse(Console.ReadLine(), outintn1);
Console.Write("Digite outro número: ");
int.TryParse(Console.ReadLine(), outintn2);
 
Console.WriteLine($"{​​​​​​​​​n1}​​​​​​​​​ >= {​​​​​​​​​n2}​​​​​​​​​: {​​​​​​​​​n1>=n2}​​​​​​​​​");
*/

/*Console.WriteLine("Digite um número:");
string numero = Console.ReadLine();
var numeroint = Convert.ToInt32(numero);

int divisao = numeroint % 2;
Console.WriteLine(divisao == 0);*/

// ------ AULA 5 ------------







