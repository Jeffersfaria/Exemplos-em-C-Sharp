//Em C#, um objeto é uma instância de uma classe. Uma classe define um tipo de dados personalizado com propriedades, métodos e outros membros, e quando criamos um objeto
//dessa classe, estamos criando uma variável que contém todas as propriedades e métodos da classe.

//Aqui está um exemplo de como criar um objeto em C#:


// declaração da classe
public class Pessoa
{
    // propriedades
    public string Nome { get; set; }
    public int Idade { get; set; }

    // método construtor
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // métodos
    public void Falar(string mensagem)
    {
        Console.WriteLine($"{Nome} diz: {mensagem}");
    }

    public void Envelhecer()
    {
        Idade++;
    }
}

// criando um objeto da classe Pessoa
Pessoa pessoa1 = new Pessoa("João", 25);


//Explicando cada parte:

    //public class Pessoa: estamos declarando uma nova classe chamada "Pessoa".

    //public string Nome { get; set; } e public int Idade { get; set; }: estamos declarando duas propriedades públicas da classe "Pessoa", uma para o nome e outra para a idade.

    //public Pessoa(string nome, int idade): estamos criando um método construtor para a classe "Pessoa". O construtor é chamado sempre que um novo objeto "Pessoa" é criado
    //e inicializa suas propriedades com os valores passados como parâmetros.

    //public void Falar(string mensagem) e public void Envelhecer(): estamos criando dois métodos públicos da classe "Pessoa".

    //Pessoa pessoa1 = new Pessoa("João", 25);: estamos criando um novo objeto "Pessoa" chamado "pessoa1" com nome "João" e idade 25. Usando a palavra-chave new, estamos
    //alocando um novo espaço de memória para esse objeto e chamando o método construtor da classe para inicializar suas propriedades.

//Agora que temos o objeto "pessoa1", podemos acessar suas propriedades e métodos usando a seguinte sintaxe:


// acessando as propriedades do objeto
Console.WriteLine(pessoa1.Nome);
Console.WriteLine(pessoa1.Idade);

// chamando os métodos do objeto
pessoa1.Falar("Olá, mundo!");
pessoa1.Envelhecer();


//Isso imprimirá "João" e "25" na tela, e em seguida chamará o método Falar para imprimir "João diz: Olá, mundo!" e o método Envelhecer para aumentar a idade
//de "pessoa1" para 26.

//Em resumo, um objeto em C# é uma variável que contém todas as propriedades e métodos de uma classe. Para criar um objeto, usamos a palavra-chave new seguida pelo nome 
//da classe e seus argumentos de inicialização, e para acessar as propriedades e métodos do objeto, usamos a sintaxe de ponto (.) seguida pelo nome da propriedade ou método.
