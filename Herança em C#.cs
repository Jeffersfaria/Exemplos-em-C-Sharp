//Em C#, a herança é um recurso que permite criar uma nova classe baseada em uma classe existente. A nova classe herda os membros e comportamentos da classe base e pode 
//adicionar ou modificar seus próprios membros e comportamentos. Isso pode ajudar a evitar a duplicação de código e a promover a reutilização de código.

//Para criar uma herança em C#, você pode usar a palavra-chave "class" seguida pelo nome da nova classe e a palavra-chave " : " seguida pelo nome da classe base que deseja
//herdar. Aqui está um exemplo:


public class Animal
{
    public void Respirar()
    {
        Console.WriteLine("O animal está respirando.");
    }
}

public class Cachorro : Animal
{
    public void Latir()
    {
        Console.WriteLine("O cachorro está latindo.");
    }
}


//Neste exemplo, temos uma classe "Animal" com um método "Respirar". Também temos uma classe "Cachorro" que herda de "Animal" e adiciona seu próprio método "Latir".
//Agora, podemos criar uma instância de "Cachorro" e chamar seus métodos:


Cachorro cachorro = new Cachorro();
cachorro.Respirar(); // Output: O animal está respirando.
cachorro.Latir(); // Output: O cachorro está latindo.


//Observe que, quando criamos uma instância de "Cachorro", ela também tem acesso ao método "Respirar" da classe "Animal", porque "Cachorro" herda de "Animal".

//A herança em C# é uma ferramenta poderosa, mas deve ser usada com cuidado. É importante ter em mente que a herança é uma relação do tipo "é um". 
//Ou seja, quando você usa herança, está afirmando que a nova classe é uma versão especializada da classe base. Se essa relação não for clara ou se houver muitas subclasses
//com muitas diferenças entre si, a herança pode levar a uma hierarquia de classes complicada e difícil de entender e manter. Portanto, é importante avaliar cuidadosamente 
//se a herança é apropriada para sua situação e se há outras abordagens, como a composição, que podem ser mais adequadas.
