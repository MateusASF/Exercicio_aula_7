using Exercício_aula_7;

Console.WriteLine("Exercício Herança e Polimorfismo - aula 07");
Console.WriteLine("\n========================================");

Console.WriteLine(@"O contrato a ser escrito é para Pessoa Física ou Pessoa Jurídica?
Escreva 'PF' para Pessoa Física ou 'PJ' Pessoa Jurídica");

string input = Console.ReadLine().ToUpper();
while (input != "PF" && input != "PJ" || string.IsNullOrWhiteSpace(input))
{
    Console.Clear();
    Console.WriteLine(@"O contrato a ser escrito é para Pessoa Física ou Pessoa Jurídica?
Escreva 'PF' para Pessoa Física ou 'PJ' Pessoa Jurídica");
    Console.WriteLine("\nParâmetros de entrada inválidos, siga as orientações e tente novamente");
    input = Console.ReadLine().ToUpper();
}


if (input == "PF")
{
    Console.Clear();
    Console.WriteLine("Contrato para pessoa fisica\n");
    var contrato = new ContratoPessoaFisica();

    Console.WriteLine("\nQual o nome do contratante?");
    contrato.Contratante = Console.ReadLine(); 

    Console.WriteLine("\nQual a data de nascimento do contratante?");
    contrato.Nascimento = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("\nQual o CPF do contratante?");
    contrato.Cpf = Console.ReadLine();

    Console.WriteLine("\nQual o valor do contrato?");
    contrato.Valor = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("\nQual o prazo do contrato?");
    contrato.Prazo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nQual o valor da prestação do contrato?");
    decimal prestacao = Convert.ToDecimal(Console.ReadLine());
    contrato.CalcularPrestacao(prestacao);
    contrato.Parcela = contrato.CalcularPrestacao(prestacao);
    contrato.ExibirInfo();
}
else
{
    var contrato = new ContratoPessoaJuridica();
    Console.Clear();
    Console.WriteLine("Contrato para pessoa juridica\n");

    Console.WriteLine("\nQual o nome da empresa contratante?");
    contrato.Contratante = Console.ReadLine();

    Console.WriteLine("\nQual a inscrição estadual da empresa contratante?");
    contrato.inscricaoEstadual = Console.ReadLine();

    Console.WriteLine("\nQual o CNPJ da empresa contratante?");
    contrato.Cnpj = Console.ReadLine();

    Console.WriteLine("\nQual o valor do contrato?");
    contrato.Valor = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("\nQual o prazo do contrato?");
    contrato.Prazo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nQual o valor da prestação do contrato?");
    decimal prestacao = Convert.ToDecimal(Console.ReadLine());
    contrato.Parcela = contrato.CalcularPrestacao(prestacao);
    contrato.ExibirInfo();
}

