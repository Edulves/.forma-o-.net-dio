using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;



string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

var listaAnonima = listaVenda.Select(x => new { x.Produto, x.Preco });

foreach (var venda in listaAnonima)
{
  System.Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
}





































// var tipoAnonimo = new { Nome = "Eduardo", Sobrenome = "Alves", Altura = 1.80 };

// System.Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// System.Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// System.Console.WriteLine("Altura: " + tipoAnonimo.Altura);








































// bool? desejaReceberEmail = true;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value) 
// {
//   System.Console.WriteLine("O usuário optou por receber e-mail.");
// }
// else{
//   System.Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail.");
// }

































// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//   System.Console.WriteLine($"Id: {venda.Id}, produto: {venda.Produto}," +
//                            $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" +
//                            $" {(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
// }
















































// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritorio", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);





































// int numero = 19;
// bool ehpar = false;

// IF Ternário
// ehpar = numero % 2 == 0;

// System.Console.WriteLine($"O número {numero} é " + (ehpar ? "par" : "ímpar"));

// if (numero % 2 == 0)
// {
//   System.Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//   System.Console.WriteLine($"O número {numero} é ímpar");
// }















































// Pessoa p1 = new Pessoa("Eduardo", "Alves");

// (string nome, string sobrenome) = p1;

// System.Console.WriteLine($"{nome} {sobrenome}");















































// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/ArquivoLeitura.txt");

// if (sucesso)
// {
//   // System.Console.WriteLine("Quantidade linhas do arquivos: " + quatidadeLinhas);
//   foreach (string linha in linhasArquivo)
//   {
//     System.Console.WriteLine(linha);
//   }
// }
// else
// {
//   System.Console.WriteLine("Não foi possível ler o arquivo");
// }




































// (int, string, string, decimal) tupla = (1, "Eduardo", "Alves", 1.84M);

// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Eduardo", "Alves", 1.84M);
// var outroExemploTuplaCreate = Tuple.Create(1, "Eduardo", "Alves", 1.84M);


// System.Console.WriteLine($"Id: {tupla.Item1}");
// System.Console.WriteLine($"Nome: {tupla.Item2}");
// System.Console.WriteLine($"Sobrenome: {tupla.Item3}");
// System.Console.WriteLine($"Altura: {tupla.Item4}");
















































// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Mina Gerais");

// System.Console.WriteLine(estados["MG"]);

// foreach (KeyValuePair<string, string> item in estados)
// {
//   System.Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
// }

// System.Console.WriteLine("----------");

// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor alterado";

// foreach (KeyValuePair<string, string> item in estados)
// {
//   System.Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
// }

// string chave = "BA2";
// System.Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//   System.Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//   System.Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }









































// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//   System.Console.WriteLine(item);
// }

// System.Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);
// foreach (int item in pilha)
// {
//   System.Console.WriteLine(item);
// }

















































// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//   System.Console.WriteLine(item);
// }

// System.Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//   System.Console.WriteLine(item);
// }















































// new ExemploExcessao().Metodo1();

















































// try
// {
//   string[] linhas = File.ReadAllLines("Arquivos/ArquivoLeitura.txt");

//   foreach(string linha in linhas)
//   {
//     System.Console.WriteLine(linha);
//   }
// } 
// catch (FileNotFoundException ex)
// {
//   System.Console.WriteLine($"Ocorreu uma na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// } 
// catch (DirectoryNotFoundException ex)
// {
//   System.Console.WriteLine($"Ocorreu uma na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//   System.Console.WriteLine($"Ocorreu uma exceção generica. {ex.Message}");
// } 
// finally 
// {
//   System.Console.WriteLine("Chegou até aqui");
// }






































// DateTime data = DateTime.Now;
// string dataString = "2022-04-170 18:00";

// bool sucesso = DateTime.TryParseExact(dataString,
//                       "yyyy-MM-dd HH:mm", 
//                       CultureInfo.InvariantCulture, 
//                       DateTimeStyles.None, out DateTime data);

// if (sucesso) 
// {
//   System.Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//   System.Console.WriteLine($"{dataString} não é uma data valida");
// }

// System.Console.WriteLine(data);
// System.Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
// System.Console.WriteLine(data.ToShortTimeString());






































// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine($"{valorMonetario.ToString("N2")}");

// double porcentagem = .3421;

// System.Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// System.Console.WriteLine(numero.ToString("##-##-##"));






























// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// System.Console.WriteLine(resultado);










































// Pessoa p1 = new Pessoa(nome: "Eduardo", sobrenome: "Alves");
// Pessoa p2 = new Pessoa(nome: "João", sobrenome: "Palmeira");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();












































// Pessoa p1 = new Pessoa();
// p1.Nome = "Eduardo";
// p1.Sobrenome = "Alves";
// p1.Idade = 25;
// p1.Apresentar();