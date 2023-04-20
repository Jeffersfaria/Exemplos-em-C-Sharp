//Em C#, um método é um bloco de código que executa uma determinada tarefa e pode receber parâmetros de entrada e retornar um valor de saída. 
//Os métodos são definidos dentro de uma classe e podem ser chamados a partir de um objeto daquela classe ou diretamente da própria classe.

//Aqui está um exemplo de como criar um método em C#:


public class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }
}


//Explicando cada parte:

    //public class Calculadora: estamos declarando uma nova classe chamada "Calculadora".

    //public int Somar(int a, int b): estamos criando um método público chamado "Somar" que recebe dois parâmetros de entrada, "a" e "b", ambos do tipo inteiro. 
    //O método retorna um valor inteiro que é a soma dos dois parâmetros.

    //return a + b;: estamos retornando o resultado da soma dos dois parâmetros recebidos.

//Agora que temos o método "Somar" dentro da classe "Calculadora", podemos chamá-lo a partir de um objeto da classe ou diretamente da própria classe usando a seguinte sintaxe:


// criando um objeto da classe Calculadora
Calculadora minhaCalculadora = new Calculadora();

// chamando o método Somar a partir do objeto
int resultado = minhaCalculadora.Somar(5, 3);

// chamando o método Somar diretamente da classe
int resultado2 = Calculadora.Somar(5, 3);


//Isso armazenará o resultado da soma de 5 e 3 na variável "resultado", usando o objeto "minhaCalculadora" para chamar o método "Somar", e na variável "resultado2", usando
//a própria classe "Calculadora" para chamar o método "Somar".

//Em resumo, um método em C# é um bloco de código que executa uma tarefa específica e pode receber parâmetros de entrada e retornar um valor de saída. 
//Para criar um método, é preciso definir seu nome, seus parâmetros de entrada e seu valor de retorno, e inserir o bloco de código que realizará a tarefa desejada.
//Para chamar um método, é preciso usar a sintaxe de ponto (.) seguida pelo nome do objeto ou da classe e o nome do método, passando os argumentos necessários para a
//sua execução.
