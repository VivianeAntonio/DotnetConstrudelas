// ------------ AULA 1 HELLO WORLD --------------

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

// ------ AULA 5 IF ELSE ------------
/*
Console.WriteLine("Digite um numero");
var umNumero = Console.ReadLine();
Console.WriteLine("Digite outro numero");
var outroNumero = Console.ReadLine();



if (int.TryParse(umNumero, out int umNumeroInt) == false)
{
    Console.WriteLine("Digite um numero valido");
}
else
if (int.TryParse(outroNumero, out int outroNumeroInt) == false)
{
    Console.WriteLine("Digite outro numero valido");
}
else
    Console.WriteLine(umNumeroInt > outroNumeroInt && outroNumeroInt % 2 == 0);*/

// OUTRA FORMA DE ESCREVER 
/*Console.WriteLine("Digite um numero");
var umNumero = Console.ReadLine();



if (int.TryParse(umNumero, out int umNumeroInt) == false)
{
    Console.WriteLine("Digite um numero valido");
}
else // se o numero for valido
{
    Console.WriteLine("Digite outro numero");
    var outroNumero = Console.ReadLine();



    if (int.TryParse(outroNumero, out int outroNumeroInt) == false)
    {
        Console.WriteLine("Digite outro numero valido");
    }
    else // se o Segundo for valido
    {
        Console.WriteLine(umNumeroInt > outroNumeroInt && outroNumeroInt % 2 == 0);
    }
}*/

// SWITCH CASE
/*
Console.WriteLine("Digite um mes");
var mes = Console.ReadLine();
var mesMinusculo = mes.ToLower();


switch (mesMinusculo)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Este mês tem 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("Este mês tem 28 ou 29 dias");
        break;
    default:
        Console.WriteLine("Este mês tem 30 dias");
        break;
}
Console.WriteLine("o que executa depois do break");*/

//MESMA SOLUCAO ESCRITO DE OUTRO JEITO
/*
var mes = Console.ReadLine();
var mesMinusculo = mes.ToLower();
switch (mesMinusculo)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Este mês tem 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("Este mês tem 28 ou 29 dias");
        break;
    case "abril":
    case "junho":
    case "setembro":
    case "novembro":
        Console.WriteLine("Este mês tem 30 dias");
        break;
    default:
        Console.WriteLine("Digite um mes valido");
        break;
}
Console.WriteLine("o que executa depois do break");*/

// EXERCICIO PEÇA PARA O USUARIO DIGITAR UM NUMERO
// IMPRIMA SE ELE E PAR SEM USAR O OPERADOR % E USANDO SWITH

// EXEMPLO CONVERTENDO PARA INTEIRO
/*
Console.Write("Digite um número: ");
string n = Console.ReadLine();

int.TryParse(n.Substring((n.Length - 1), 1), out int digFinal);

switch (digFinal)
{
    case 2:
    case 4:
    case 6:
    case 8:
    case 0:
        Console.WriteLine("Este número é par");
        break;
    default:
        Console.WriteLine("Este número é ímpar");
        break;

}*/

//EXEMPLO UTILIZANDO STRINGS
/*Console.Write("Digite um número: ");
string n = Console.ReadLine();



string ultimoDigito = n.Substring((n.Length - 1), 1);



switch (ultimoDigito)
{
    case "2":
    case "4":
    case "6":
    case "8":
    case "0":
        Console.WriteLine("Este número é par");
        break;
    default:
        Console.WriteLine("Este número é ímpar");
        break;
}*/

// LAÇO FOR
/*
Console.WriteLine("Digite um numero");
var numeroStr = Console.ReadLine();

var numero = Convert.ToInt32(numeroStr);

for (int i = 0; i < numero; i++)
{
    Console.WriteLine($"olha aqui eu no loop - {i}");
}*/

/*Console.Write("Digite um número: ");
int.TryParse(Console.ReadLine(), out int n1);
Console.Write("Digite outro número: ");
int.TryParse(Console.ReadLine(), out int n2);

 

int soma = 0;
for (int i = 0; i < n2; i++) {
    soma += n1;
}
Console.WriteLine($"A multiplicação entre {n1} e {n2} é {soma}");*/

// LISTA
/*List<int> minhaListaDeInteiros = new List<int>();
minhaListaDeInteiros.Add(10);
minhaListaDeInteiros.Add(20);
minhaListaDeInteiros.Add(30);
minhaListaDeInteiros.Add(40);
minhaListaDeInteiros.Add(55);
minhaListaDeInteiros.Add(550);
minhaListaDeInteiros.Add(10);

foreach (var meuInteiro in minhaListaDeInteiros)
{
    Console.WriteLine(meuInteiro);
}*/

// EXERCICIO LEIA UMA PALAVRA, ESCREVA ELA NA VERTICAL USANDO FOREACH
/*
Console.Write("Digite uma palavra: ");
string word = Console.ReadLine();

foreach (char letra in word)
{
    Console.WriteLine(letra);
}*/

// WHILE

/*var minhaPalavra = Console.ReadLine();
var minhaPalavraArray = minhaPalavra.ToCharArray();
int i = 0;
while (i < minhaPalavraArray.Length)
{
    Console.WriteLine(i + " - " + minhaPalavraArray[i]);
    i++;
}*/

// DO WHILE 

/*var minhaPalavra = Console.ReadLine();

var minhaPalavraArray = minhaPalavra.ToCharArray();

int i = 0;
do
{
    Console.WriteLine(i + " - " + minhaPalavraArray[i]);
    i++;
} while (i < minhaPalavraArray.Length);*/

// ---- EXERCICIO----
/*int soma = 0;
string numeroStr;
int numero = 0;
do
{
    Console.WriteLine("Digite um numero para somar ou 0 para sair");
    numeroStr = Console.ReadLine();
    numero = Convert.ToInt32(numeroStr);
    soma += numero;
}
while (numero != 0);
Console.WriteLine(soma);*/

// ------- EQUAÇÃO DO SEGUNDO GRAU COM BIBLIOTECA MATH --------

/*int a, b, c;
double delta;
double raizDelta;
double primeiraRaiz;
double segundaRaiz;

Console.WriteLine("Digite o valor de A ");
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine("Digite o valor de B ");
int.TryParse(Console.ReadLine(), out b);
Console.WriteLine("Digite o valor de C ");
int.TryParse(Console.ReadLine(), out c);

delta = Math.Pow(b, 2) - (4 * a * c);
raizDelta = Math.Sqrt(delta);

primeiraRaiz = (-b + raizDelta) / (2 * a);
segundaRaiz = (-b - raizDelta) / (2 * a);

Console.WriteLine($"Primeira raiz {primeiraRaiz}, segunda raiz {segundaRaiz}");
*/


// ------------- exercício exibir palavra invertida -------------
/*
Console.WriteLine("Digite uma palavra");
var palavra = Console.ReadLine();
var palavraCharArray = palavra.ToCharArray();
string palavraInvertida = "";
for (int i = palavra.Length - 1; i >= 0; i--)
{
    palavraInvertida += palavraCharArray[i];
}
Console.WriteLine(palavraInvertida);*/









