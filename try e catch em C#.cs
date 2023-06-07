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
