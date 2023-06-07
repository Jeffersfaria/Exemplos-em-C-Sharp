//Em C#, o "throw" é uma palavra-chave que é usada para lançar uma exceção explicitamente em um determinado ponto do código. Quando uma exceção é lançada, ela interrompe o fluxo normal do programa e pode 
//ser capturada e tratada por blocos "try-catch" para fornecer um tratamento adequado do erro.

//A sintaxe básica do "throw" em C# é a seguinte:


throw excecao;

//Onde "excecao" é o objeto de exceção a ser lançado. Pode ser uma instância de uma classe de exceção predefinida, como "ArgumentException" ou "InvalidOperationException", ou uma exceção personalizada 
//que herda da classe "Exception".

//Aqui está um exemplo simples de como usar o "throw" em C#:


public int Divide(int dividendo, int divisor)
{
    if (divisor == 0)
    {
        throw new DivideByZeroException("Divisor não pode ser zero.");
    }

    return dividendo / divisor;
}


//No exemplo acima, o método "Divide" verifica se o divisor é igual a zero. Se for o caso, é lançada uma exceção "DivideByZeroException" com uma mensagem de erro informando que o divisor não pode ser zero.

//Ao chamar o método "Divide", você pode usar um bloco "try-catch" para capturar e tratar a exceção lançada:

try
{
    int resultado = Divide(10, 0);
    Console.WriteLine("Resultado: " + resultado);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Erro ao dividir: " + ex.Message);
}


//No exemplo acima, o código dentro do bloco "try" chama o método "Divide" com um divisor igual a zero. Como resultado, uma exceção "DivideByZeroException" é lançada. O bloco "catch" captura a exceção e executa o código de tratamento, exibindo a mensagem de erro na saída. Isso evita que a exceção pare a execução do programa e permite que você tome medidas apropriadas para lidar com o erro.
