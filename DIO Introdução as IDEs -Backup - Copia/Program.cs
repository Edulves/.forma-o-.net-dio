﻿using System.Collections;
using System.Diagnostics;
using DIO_Introdução_as_IDEs.Models;


string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
  Console.Clear();
  Console.WriteLine("Digite a sua opção:");
  Console.WriteLine("1 - Cadastrar cliente");
  Console.WriteLine("2 - Buscar cliente");
  Console.WriteLine("3 - Apagar cliente");
  Console.WriteLine("4 - Encerrar");

  opcao = Console.ReadLine();

  switch(opcao)
  {
    case "1":
      Console.WriteLine("Cadastro de cliente");
      break;
    case "2":
      Console.WriteLine("Busca de cliente");
      break;
    case "3":
      Console.WriteLine("Apagar cliente");
      break;
    case "4":
      Console.WriteLine("Encerrar");
      exibirMenu = false;
      // Environment.Exit(0);
      break;

    default:
      Console.WriteLine("Opção inválida");
      break;
  }
}

Console.WriteLine("Programa encerrado");






























// int soma = 0, numero = 0;


// do
// {
//   Console.WriteLine("Digite um número (0 para parar)");
//   numero = Convert.ToInt32(Console.ReadLine());

//   soma += numero;

// } while (numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");





































// int numero = 5;
// int contador = 1;

// while (contador <= 10) 
// {
//   Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//   contador++;

//   if (contador == 6)
//     break;
// }













































// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//   Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }




































// Calculadora calc = new Calculadora();

// calc.Soma(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(10, 2);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuandrada(9);

// int numeroIncremento = 10;

// Console.WriteLine(numeroIncremento);

// Console.WriteLine("Incrementando o 10");
// // numero = numero + 1;
// numeroIncremento++;

// int numeroDecremento = 20;
// Console.WriteLine("Decrementando o 20");
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);
























// bool choveu = false;
// bool estaTarde = true;

// if (!choveu && !estaTarde)
// {
//   Console.WriteLine("Vou pedalar");
// }
// else 
// {
//   Console.WriteLine("Vou pedalar um outro dia");
// }




























// bool posuiPresencaMinima = true;
// double media = 6.5;

// if (posuiPresencaMinima && media > 7)
// {
//   Console.WriteLine("Aprovado!");
// }
// else
// {
//   Console.WriteLine("Reprovado!");
// }




























// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel) 
// {
//   Console.WriteLine("Entrada liberada");
// }
// else
// {
//   Console.WriteLine("Entrada não liberada");
// }

































// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine().ToLower();


// switch (letra) 
// {
//   case "a":
//   case "e":
//   case "i":
//   case "o":
//   case "u":
//     Console.WriteLine("Vogal");
//     break;

//   default:
//     Console.WriteLine("Não é uma vogal");
//     break;
// }



























// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u"
// )
// {
//   Console.WriteLine("Vogal");
// }
// else
// {
//   Console.WriteLine("Não é uma vogal");
// }



























// if (letra == "a")
// {
//   Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//   Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//   Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//   Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//   Console.WriteLine("Vogal");
// }
// else {
//   Console.WriteLine("Não é uma vogal");
// }






















// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

// if (quantidadeCompra <= 0)
// {
//   Console.WriteLine("Venda inválida");
// }
// else if(possivelVenda)
// {
//   Console.WriteLine("Venda realizada.");
// }
// else
// {
//   Console.WriteLine("Desculpe não temos a quantidade desejada em estoque.");
// }


























// string a = "15-";

// int b = 0;

// int.TryParse(a, out int b);


// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");























// double a = 4 / (2 + 2);

// Console.WriteLine(a);
















// int a = 5;
// double b = a;

// long a = long.MaxValue;
// int b = Convert.ToInt32(a);

// int a = int.MaxValue;
// long b = a;

// Console.WriteLine(b);












// int inteiro = 5;
// string a = inteiro.ToString();


// Console.WriteLine(a);













// Cast - Casting
// int a = Convert.ToInt32("5");
// int a = int.Parse("5c");

// int a = Convert.ToInt32(null);
// int a = int.Parse(null);


// Console.WriteLine(a);


















// int a = 10;
// int b = 20;

// int c = a + b;

// c = c + 5; // 30 +5

// c += 5;

// c = c - 5;
// c *= 5;


// Console.WriteLine(c);














// DateTime dataAtual = DateTime.Now.AddDays(3);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));




// string apresentacao = "Olá, seja bem vindo";


// int quantidade = 1;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);

// quantidade = 10;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;


// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Eduardo";
// pessoa1.Idade = 25;
// pessoa1.Apresentar();

// Pessoa pessoa_FisicaRepresentacao = new Pessoa();