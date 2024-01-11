using ExemploFundamentos.Common.Models;



// instancia da classe pessoa
Pessoa p = new Pessoa();
Calculadora c = new Calculadora();

// Atribui o nome e idade para p  essoa
p.Nome = "Eduardo";
p.Idade = 25;

// Faz a pessoa se apresentar
p.Apresentar();

c.Somar(1, 2);
c.Subtrair(1, 1);

// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");
// listaString.Add("RJ");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("MG");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");



// Console.WriteLine("Percorrendo o array com o FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//   Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo o array com o FOREACH");
// int contadorForEach = 0;
// foreach(string item in listaString) 
// {
//   Console.WriteLine($"Posição Nº {contadorForEach} - {item}");
//   contadorForEach++;
// }


































// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;


// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


// Console.WriteLine("Percorrendo o array com FOR");
// for(int contador = 0; contador < arrayInteiros.Length; contador++) 
// {
//   Console.WriteLine($"arrayInteiro[{contador}] = {arrayInteiros[contador]}");
// }
























// Console.WriteLine("Percorrendo o array com FOREACH");

// int contadorForEach = 0;
// foreach(int valor in arrayInteiros)
// {
//   Console.WriteLine($"Posição Nº {contadorForEach} - {valor}");
//   contadorForEach++;
// }





















// Pessoa pessoa = new Pessoa();

// Console.WriteLine("Qual seu nome?");
// string? nome = Console.ReadLine();

// Console.WriteLine("Qual a sua idade?");
// int idade = Convert.ToInt32(Console.ReadLine());

// pessoa.Nome = nome;
// pessoa.Idade = idade;

// pessoa.Apresentar();