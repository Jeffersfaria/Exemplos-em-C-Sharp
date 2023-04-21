//Em C#, encapsulamento é uma técnica de programação que consiste em esconder a implementação interna de um objeto e expor apenas sua interface pública para outros objetos.
//Isso significa que outras partes do programa só conseguem interagir com o objeto através de suas interfaces públicas, que são definidas por meio de propriedades, métodos e
//eventos.

//Um exemplo comum de encapsulamento em C# é a definição de uma classe Pessoa que possui uma propriedade Nome:


public class Pessoa
{
    private string _nome;

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }
}


//Neste exemplo, a propriedade Nome é a interface pública da classe Pessoa, pois é o único meio de acessar e alterar o valor do campo _nome, que é a implementação interna 
//da classe. Note que a propriedade possui as palavras-chave get e set, que permitem a leitura e escrita do valor do campo, respectivamente.

//Agora, para exemplificar o uso de uma estrutura condicional dentro da propriedade, vamos considerar uma classe ContaBancaria que possui uma propriedade Saldo que só pode
//ser acessada se a pessoa tiver autorização para tal:


public class ContaBancaria
{
    private decimal _saldo;
    private bool _autorizado;

    public decimal Saldo
    {
        get
        {
            if (_autorizado)
            {
                return _saldo;
            }
            else
            {
                throw new UnauthorizedAccessException("Acesso negado.");
            }
        }
        set
        {
            _saldo = value;
        }
    }

    public void AutorizarAcesso()
    {
        _autorizado = true;
    }

    public void RevogarAcesso()
    {
        _autorizado = false;
    }
}


//Neste exemplo, a propriedade Saldo só pode ser lida se a pessoa tiver autorização para tal, o que é verificado por meio da variável _autorizado. 
//Se ela não estiver autorizada, uma exceção é lançada. Note que a propriedade ainda permite a escrita no campo _saldo, pois a restrição é apenas para a leitura do valor.

//Em resumo, o encapsulamento em C# é uma técnica que ajuda a garantir a integridade dos dados de uma classe e a limitar o acesso a eles por outras partes do programa.

//***************************************************

//Em C# um campo declarado com "private set" só pode ser alterado dentro da classe em que ele foi declarado. 
//Isso significa que outras classes que acessam essa classe não poderão alterar o valor desse campo diretamente, o que ajuda a manter o encapsulamento e a integridade
//dos dados. No entanto, é possível fornecer um método público na classe que permita alterar o valor desse campo de forma controlada, o que ainda assim mantém o 
//encapsulamento e fornece um meio de acesso controlado aos dados.


//Aqui está um exemplo:


public class Person 
{
    public string Name { get; private set; }
    
    public Person(string name) 
    {
        Name = name;
    }
    
    public void ChangeName(string newName) 
    {
        // Aqui é permitido alterar o valor de Name, pois estamos dentro da classe Person
        Name = newName;
    }
}

public class Program 
{
    static void Main() 
    {
        Person person = new Person("João");
        Console.WriteLine(person.Name); // Output: "João"

        // Tentar alterar o valor de Name aqui irá resultar em erro de compilação
        // person.Name = "Maria"; 

        person.ChangeName("Maria");
        Console.WriteLine(person.Name); // Output: "Maria"
    }
}


//Nesse exemplo, a classe Person possui um campo Name com modificadores public e private set. Isso significa que o valor de Name só pode ser definido na classe
//Person, como no construtor Person(string name), mas pode ser acessado e lido em qualquer lugar do código.

//No entanto, a alteração do valor de Name só é permitida dentro da classe Person, como no método ChangeName(string newName), que tem acesso ao campo private set.
//Fora da classe, como no método Main(), tentar alterar o valor de Name resultará em um erro de compilação.
