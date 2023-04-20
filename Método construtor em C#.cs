//Em C#, um método construtor é um método especial de uma classe que é executado automaticamente quando um objeto é criado a partir dessa classe. 
//O objetivo do método construtor é inicializar os campos e propriedades do objeto com valores padrão ou com valores fornecidos pelo usuário.

//Aqui está um exemplo de como criar um método construtor em C#:


public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}


//Explicando cada parte:

    //public class Pessoa: estamos declarando uma nova classe chamada "Pessoa".

    //public string Nome { get; set; } e public int Idade { get; set; }: estamos declarando duas propriedades da classe, "Nome" e "Idade", que podem ser acessadas e
    //modificadas a partir de objetos dessa classe.

    //public Pessoa(string nome, int idade): estamos criando um método construtor público para a classe "Pessoa" que recebe dois parâmetros de entrada, "nome" do tipo 
    //string e "idade" do tipo inteiro.

    //Nome = nome; e Idade = idade;: estamos atribuindo os valores dos parâmetros de entrada às propriedades correspondentes da classe.

//Agora, quando criamos um objeto da classe "Pessoa", o método construtor será automaticamente executado e os valores passados para o construtor serão usados para inicializar
//as propriedades da classe:


Pessoa pessoa1 = new Pessoa("João", 30);
Console.WriteLine($"Nome: {pessoa1.Nome}, Idade: {pessoa1.Idade}");


//Isso imprimirá "Nome: João, Idade: 30" no console, já que o método construtor inicializou as propriedades "Nome" e "Idade" do objeto "pessoa1" com esses valores.

//Em resumo, um método construtor em C# é um método especial de uma classe que é executado automaticamente quando um objeto é criado a partir dessa classe. 
//Ele é responsável por inicializar os campos e propriedades do objeto com valores padrão ou com valores fornecidos pelo usuário. Para criar um método construtor, é preciso
//definir seu nome e seus parâmetros de entrada, e inserir o bloco de código que inicializará as propriedades do objeto. Ao criar um objeto a partir da classe, o método
//construtor será automaticamente executado e as propriedades do objeto serão inicializadas de acordo com os valores fornecidos.
