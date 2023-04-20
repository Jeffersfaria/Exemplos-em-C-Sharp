//Uma classe em C# é um tipo de dados personalizado que pode ser usado para criar objetos que possuem propriedades e métodos específicos.
//Aqui está um exemplo de como criar uma classe em C#:


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


//Explicando cada parte:

   //public class Pessoa: estamos declarando uma nova classe chamada "Pessoa". 
   //O modificador de acesso public significa que essa classe pode ser acessada de qualquer lugar no código.

   //public string Nome { get; set; } e public int Idade { get; set; }: estamos declarando duas propriedades públicas da classe "Pessoa", uma para o nome e outra para a idade.
   //Essas propriedades podem ser acessadas e modificadas de fora da classe.

   //public Pessoa(string nome, int idade): estamos criando um método construtor para a classe "Pessoa". 
   //O construtor é chamado sempre que um novo objeto "Pessoa" é criado e inicializa suas propriedades com os valores passados como parâmetros.

   //public void Falar(string mensagem) e public void Envelhecer(): estamos criando dois métodos públicos da classe "Pessoa".
   //O método Falar recebe uma mensagem como parâmetro e imprime na tela quem está falando e a mensagem em si. O método Envelhecer simplesmente adiciona 1 à idade da pessoa.

//Agora podemos criar um objeto da classe "Pessoa" usando o seguinte código:


Pessoa pessoa1 = new Pessoa("João", 25);
pessoa1.Falar("Olá, mundo!");
pessoa1.Envelhecer();


//Isso criará um novo objeto "Pessoa" chamado "pessoa1" com nome "João" e idade 25. Em seguida, chamamos os métodos Falar e Envelhecer do objeto.
//O método Falar imprimirá "João diz: Olá, mundo!" na tela e o método Envelhecer aumentará a idade de "pessoa1" para 26.

//Essa é uma explicação básica e didática sobre como criar uma classe em C#. 
