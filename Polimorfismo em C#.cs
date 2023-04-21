//O polimorfismo é um dos princípios da programação orientada a objetos que permite que um objeto de uma classe possa ser tratado como um objeto de outra classe
//relacionada, desde que ambas as classes compartilhem uma hierarquia de classes em comum. Isso permite que um método possa ter comportamentos diferentes dependendo do 
//tipo do objeto que o invoca.

//Vamos supor que temos três classes: Animal, Cachorro e Gato. Cachorro e Gato herdam de Animal.


public class Animal
{
    public string Nome { get; set; }
    public virtual void EmitirSom()
    {
        Console.WriteLine("Este é o som de um animal.");
    }
}

public class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Este é o som de um cachorro.");
    }
}

public class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Este é o som de um gato.");
    }
}


//Nesse exemplo, temos uma classe base Animal com uma propriedade Nome e um método EmitirSom que é virtual. As classes Cachorro e Gato sobrescrevem o método EmitirSom 
//para emitir o som correto.

//Agora podemos criar um método que recebe um objeto do tipo Animal como parâmetro e chama o método EmitirSom:


public static void FazerAnimalEmitirSom(Animal animal)
{
    animal.EmitirSom();
}


//Se chamarmos esse método com um objeto do tipo Cachorro, ele emitirá o som de um cachorro:


Cachorro cachorro = new Cachorro();
FazerAnimalEmitirSom(cachorro);


//E se chamarmos esse método com um objeto do tipo Gato, ele emitirá o som de um gato:


Gato gato = new Gato();
FazerAnimalEmitirSom(gato);


//O método FazerAnimalEmitirSom não precisa saber se está lidando com um cachorro ou um gato, ele simplesmente chama o método EmitirSom do objeto que recebe como parâmetro
//e o comportamento correto é executado, graças ao polimorfismo, utilizando a palavra reservada "virtual" no método da classe base, e "override" na classe derivada.


//É possível usar a palavra-chave "abstract" ao invés de "virtual" em um método. A diferença entre eles é que um método virtual tem uma implementação padrão em sua
//classe base, mas pode ser sobrescrito em uma classe derivada, enquanto um método abstrato não tem implementação e deve ser sobrescrito em uma classe derivada.

//No caso do método virtual, a classe derivada pode optar por substituir o comportamento padrão do método, mas não é obrigada a fazê-lo. Já no caso do método
//abstrato, a classe derivada é obrigada a fornecer uma implementação para ele.

//Outra diferença é que uma classe abstrata não pode ser instanciada diretamente, mas apenas através de uma classe derivada. Já uma classe que contém um método virtual
//pode ser instanciada diretamente, sem a necessidade de uma classe derivada:


public abstract class Animal
{
    public abstract void Falar();
}

public class Cachorro : Animal
{
    public override void Falar()
    {
        Console.WriteLine("O cachorro late!");
    }
}

public class Gato : Animal
{
    public override void Falar()
    {
        Console.WriteLine("O gato mia!");
    }
}


//Agora podemos criar uma lista de animais e adicionar objetos de ambas as classes Cachorro e Gato nessa lista. Em seguida, podemos percorrer a lista e chamar o 
//método Falar() para cada objeto da lista, sem saber se cada objeto é um cachorro ou um gato. O polimorfismo permite que a chamada do método Falar() seja resolvida em 
//tempo de execução para cada objeto específico da lista.

//Veja o código abaixo:


List<Animal> animais = new List<Animal>();
animais.Add(new Cachorro());
animais.Add(new Gato());

foreach (Animal animal in animais)
{
    animal.Falar(); // Vai imprimir "O cachorro late!" e "O gato mia!"
}


//A classe "Animal" está sendo utilizada como uma classe base para outras classes, como "Cachorro" e "Gato". Na linha "animais.Add(new Cachorro())", é criada uma 
//instância da classe "Cachorro" e adicionada à lista "animais", que é uma lista de objetos da classe "Animal" (pois "Cachorro" é uma subclasse de "Animal"). 
//O mesmo ocorre com a instância da classe "Gato" adicionada à lista na linha seguinte.


//E nesse exemplo, o polimorfismo permite que o mesmo método Falar() seja utilizado para objetos de diferentes classes derivadas de Animal.
//Isso torna o código mais flexível e fácil de manter, já que não precisamos escrever um método diferente para cada classe derivada.


//Em C#, uma classe é uma estrutura que define a forma e o comportamento de um objeto. Para utilizar a classe em um programa, é necessário criar uma instância
//da classe, que é basicamente uma cópia da definição da classe com seus próprios dados. A instância é criada usando a palavra-chave "new", seguida do nome da classe e 
//dos parênteses vazios, se não houver argumentos para o construtor.

//Por exemplo, se você tiver a classe "Pessoa" com propriedades como "Nome" e "Idade", para criar uma instância dessa classe, você faria:


Pessoa pessoa1 = new Pessoa(); 


//Isso criaria uma nova instância da classe Pessoa e a atribuiria à variável "pessoa1". Agora você pode acessar as propriedades da instância, por exemplo:


pessoa1.Nome = "João";
pessoa1.Idade = 30;


//Essas são as informações específicas dessa instância da classe, que podem ser diferentes das informações em outras instâncias da mesma classe.


//Para instanciar uma classe diretamente em C#, você pode simplesmente criar uma nova instância da classe utilizando o operador new, como no exemplo abaixo:


// Classe simples
public class Exemplo {
    public int Numero { get; set; }
}

// Instanciando diretamente
Exemplo exemplo1 = new Exemplo();
exemplo1.Numero = 10;


//Para instanciar uma classe através de uma classe derivada, primeiro você precisa criar a classe derivada. 
//Em seguida, você pode utilizar o operador new para criar uma nova instância da classe derivada, que também irá instanciar a classe base. Aqui está um exemplo:


// Classe base
public class Pessoa {
    public string Nome { get; set; }
}

// Classe derivada
public class Funcionario : Pessoa {
    public decimal Salario { get; set; }
}

// Instanciando através de uma classe derivada
Funcionario funcionario1 = new Funcionario();
funcionario1.Nome = "João";
funcionario1.Salario = 1000.00m;


//Observe que a instância da classe Funcionario também inclui as propriedades da classe base Pessoa, que podem ser acessadas através da instância da classe Funcionario.


//A possibilidade de instanciar uma classe derivada a partir de uma classe base ocorre graças ao uso da herança em C#. Quando uma classe é derivada de outra, ela herda 
//os membros da classe base e, portanto, pode ser instanciada diretamente ou através da classe derivada. Além disso, a herança permite que a classe derivada adicione novos
//membros ou modifique os membros herdados da classe base, fornecendo maior flexibilidade na criação de objetos.
