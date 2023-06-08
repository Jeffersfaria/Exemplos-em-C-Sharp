//Em C#, o "try" e "catch" são blocos de código utilizados para lidar com exceções, que são erros ou condições inesperadas que podem ocorrer durante a execução de um programa. O bloco "try" é usado para 
//envolver o código que pode gerar exceções, enquanto o bloco "catch" é usado para capturar e tratar essas exceções.

//Quando o código dentro do bloco "try" lança uma exceção, o fluxo de execução é interrompido e o controle passa para o bloco "catch" correspondente, que contém o código responsável por tratar a exceção. 
//O bloco "catch" pode conter lógica para lidar com a exceção, como exibir uma mensagem de erro, registrar informações sobre a exceção ou executar alguma ação corretiva.

//A utilização do "try" e "catch" é importante para lidar com erros de forma controlada e evitar que o programa seja encerrado abruptamente. Ele permite que o código trate exceções específicas ou 
//genéricas, fornecendo uma maneira de lidar com falhas e manter o programa em um estado controlado.

//A estrutura geral do "try" e "catch" em C# é a seguinte:


try
{
    // Código que pode gerar exceções
}
catch (ExcecaoTipoA)
{
    // Tratamento para exceções do tipo A
}
catch (ExcecaoTipoB)
{
    // Tratamento para exceções do tipo B
}
catch (Exception)
{
    // Tratamento para exceções genéricas
}
finally
{
    // Bloco opcional que é executado sempre, independentemente de ocorrer uma exceção ou não
}

//Dentro do bloco "catch", é possível especificar diferentes tipos de exceções que podem ser tratadas separadamente, permitindo um tratamento mais específico para cada caso. 
//O bloco "finally" é opcional e é usado para definir código que deve ser executado sempre, independentemente de ocorrer uma exceção ou não.

//Em resumo, o "try" e "catch" em C# são usados para capturar e tratar exceções, permitindo que o código lide com erros de forma controlada e execute ações apropriadas em caso de falhas.
//Isso ajuda a melhorar a robustez e a confiabilidade do programa.

***********************************************************************************************************************************************************************************************


//Exemplos de como utilizar as propriedades "Message", "StackTrace" e "InnerException" em C#:

//Exemplo utilizando a propriedade "Message":


try
{
    int[] numbers = new int[3];
    Console.WriteLine(numbers[4]);
}
catch (Exception ex)
{
    Console.WriteLine("Ocorreu um erro: " + ex.Message);
}


//Nesse exemplo, um erro de índice é gerado ao tentar acessar o quarto elemento de um array de tamanho 3. A propriedade "Message" é utilizada para exibir uma mensagem de erro que descreve o problema.

//Exemplo utilizando a propriedade "StackTrace":


try
{
    throw new Exception("Ocorreu um erro.");
}
catch (Exception ex)
{
    Console.WriteLine("Ocorreu uma exceção: " + ex.StackTrace);
}


//Nesse exemplo, uma exceção é lançada manualmente com uma mensagem de erro. A propriedade "StackTrace" é utilizada para obter uma representação textual da pilha de chamadas de métodos que levou à ocorrência
//da exceção.

//Exemplo utilizando a propriedade "InnerException":


try
{
    try
    {
        throw new ArgumentException("Argumento inválido.");
    }
    catch (Exception innerEx)
    {
        throw new InvalidOperationException("Operação inválida.", innerEx);
    }
}
catch (Exception ex)
{
    Console.WriteLine("Ocorreu uma exceção: " + ex.Message);
    if (ex.InnerException != null)
    {
        Console.WriteLine("Exceção interna: " + ex.InnerException.Message);
    }
}


//Nesse exemplo, um bloco "try" aninhado é utilizado para capturar uma exceção inicial ("ArgumentException") e lançar uma nova exceção ("InvalidOperationException") com a exceção original como a exceção 
//interna. A propriedade "InnerException" é utilizada para acessar a exceção interna e exibir sua mensagem de erro.

//Esses exemplos demonstram como utilizar as propriedades "Message", "StackTrace" e "InnerException" para obter informações úteis sobre as exceções ocorridas durante a execução do código.


***********************************************************************************************************************************************************************************************


//Aqui está um exemplo de bloco catch em C# onde uma variável de exceção é definida:


try
{
    int result = Divide(10, 0);
    Console.WriteLine("Resultado: " + result);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Erro: Tentativa de divisão por zero.");
    Console.WriteLine("Mensagem de exceção: " + ex.Message);
    Console.WriteLine("Detalhes da exceção: " + ex.StackTrace);
}


//Nesse exemplo, a função Divide é chamada com os parâmetros 10 e 0, o que causará uma exceção DivideByZeroException devido à tentativa de divisão por zero. No bloco catch, uma variável ex do tipo 
//DivideByZeroException é definida para capturar a exceção lançada.

//Dentro do bloco catch, você pode utilizar a variável ex para acessar informações da exceção. No exemplo, são exibidas a mensagem de exceção utilizando ex.Message e os detalhes da exceção (pilha de chamadas)
//utilizando ex.StackTrace. Essas informações podem ser úteis para depuração e tratamento adequado das exceções.

//Lembrando que é importante tratar as exceções de forma apropriada no código, garantindo a robustez e a manipulação adequada dos erros que possam ocorrer durante a execução.





//"ex" é um objeto da classe DivideByZeroException que é criado quando ocorre a exceção. No bloco catch, você pode declarar uma variável para capturar a exceção e, em seguida, utilizar o operador de 
//ponto (.) para acessar as propriedades e métodos desse objeto.

//No exemplo que foi dado anteriormente, ex é uma variável que representa a exceção DivideByZeroException. Essa classe possui propriedades, como Message e StackTrace, que fornecem informações sobre a exceção
//ocorrida. O uso do operador de ponto permite acessar essas propriedades para obter os detalhes relevantes da exceção.

//Por exemplo, ao utilizar ex.Message, você está acessando a propriedade Message do objeto ex, que contém uma mensagem descritiva da exceção. Da mesma forma, ao utilizar ex.StackTrace, você está acessando a 
//propriedade StackTrace do objeto ex, que contém a pilha de chamadas do momento em que a exceção foi lançada.

//Ao usar o operador de ponto (.), você está acessando membros (propriedades, métodos, etc.) de um objeto em C#. Isso permite interagir com o objeto e obter informações relevantes para tratamento 
//de exceções, registro de erros, entre outras tarefas.

//"ex" é uma variável que representa um objeto da classe DivideByZeroException.

//Em C#, as exceções são representadas por objetos de classes derivadas da classe base Exception. Quando uma exceção é lançada, um objeto é criado para representar essa exceção. Esse objeto pode ser
//atribuído a uma variável para posterior manipulação no bloco catch.

//Então, ex é uma variável do tipo DivideByZeroException que contém o objeto criado quando a exceção é lançada. Portanto, pode-se dizer que ex é uma variável que referencia um objeto de exceção.






