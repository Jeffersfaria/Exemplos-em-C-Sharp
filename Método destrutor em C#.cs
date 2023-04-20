//Em C#, um método destrutor (ou "finalizador") é um método especial que é executado automaticamente quando um objeto é destruído pela coleta de lixo. 
//O objetivo do método destrutor é liberar os recursos que foram alocados pelo objeto durante sua vida útil, como por exemplo, fechar arquivos, desconectar de
//bancos de dados, liberar memória alocada dinamicamente, etc.

//Aqui está um exemplo de como criar um método destrutor em C#:


public class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Objeto Pessoa criado.");
    }

    ~Pessoa()
    {
        Console.WriteLine("Objeto Pessoa destruído.");
    }
}


//Explicando cada parte:

    //public class Pessoa: estamos declarando uma nova classe chamada "Pessoa".

    //public Pessoa(): estamos criando um método construtor público para a classe "Pessoa" que será executado automaticamente quando um objeto dessa classe for criado.
    //Nesse caso, estamos apenas imprimindo uma mensagem no console para indicar que o objeto foi criado.

    //~Pessoa(): estamos criando um método destrutor para a classe "Pessoa" que será executado automaticamente quando o objeto for destruído pela coleta de lixo.
    //Nesse caso, estamos apenas imprimindo uma mensagem no console para indicar que o objeto foi destruído.

//Agora, quando criamos um objeto da classe "Pessoa" e esse objeto é destruído pela coleta de lixo, o método destrutor será automaticamente executado:


Pessoa pessoa1 = new Pessoa();
pessoa1 = null; // marcando o objeto para ser coletado pelo Garbage Collector


//Isso imprimirá "Objeto Pessoa criado." quando o objeto for criado e "Objeto Pessoa destruído." quando o objeto for destruído pela coleta de lixo.

//Em resumo, um método destrutor em C# é um método especial de uma classe que é executado automaticamente quando o objeto é destruído pela coleta de lixo. 
//Ele é responsável por liberar os recursos que foram alocados pelo objeto durante sua vida útil. Para criar um método destrutor, é preciso definir seu nome precedido 
//pelo símbolo "~" e inserir o bloco de código que liberará os recursos alocados pelo objeto. Ao ser destruído, o objeto terá seu método destrutor automaticamente executado.
//É importante lembrar que a execução do método destrutor não é garantida, já que a coleta de lixo é um processo assíncrono e depende da disponibilidade de recursos do sistema.
