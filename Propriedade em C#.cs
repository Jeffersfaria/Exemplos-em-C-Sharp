//Em C#, uma propriedade é uma forma de expor dados encapsulados em uma classe. 
//Propriedades permitem que você controle o acesso aos dados de uma classe e imponha regras de validação para garantir que os dados estejam em um estado consistente.

//Aqui está um exemplo de como criar uma propriedade em C#:


public class Pessoa
{
    private string nome;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
}


//Neste exemplo, criamos uma classe "Pessoa" com uma propriedade "Nome". A propriedade "Nome" é um membro da classe que encapsula o campo privado "nome". 
//Ela tem um método "get" para obter o valor do campo e um método "set" para atribuir um valor ao campo.

//Você pode usar a propriedade da seguinte maneira:


Pessoa p = new Pessoa();
p.Nome = "João";
Console.WriteLine(p.Nome); // imprime "João"


//Aqui, criamos uma nova instância da classe Pessoa, atribuímos o valor "João" à propriedade Nome e imprimimos o valor da propriedade no console.

//As propriedades em C# também podem ter regras adicionais, como validação de entrada ou cálculos de saída. Aqui está um exemplo de uma propriedade com uma regra de validação:


public class Pessoa
{
    private int idade;

    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 0 || value > 120)
            {
                throw new ArgumentException("Idade inválida");
            }
            idade = value;
        }
    }
}


//Neste exemplo, criamos uma propriedade "Idade" que valida o valor de entrada para garantir que esteja dentro de um intervalo válido (de 0 a 120 anos). 
//Se o valor não estiver dentro desse intervalo, uma exceção será lançada.

//Em resumo, propriedades em C# são uma maneira de encapsular campos privados de uma classe e expor dados de uma maneira controlada e consistente. 
//Elas permitem que você defina regras de validação e cálculos adicionais para seus dados e podem ser acessadas e usadas como qualquer outro membro da classe.
