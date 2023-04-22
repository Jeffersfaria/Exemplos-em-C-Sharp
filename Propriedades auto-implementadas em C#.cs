//As propriedades auto-implementadas em C# são uma forma abreviada de criar uma propriedade com um campo de armazenamento implícito. 
//Essas propriedades permitem que você declare a propriedade e seu tipo, mas o compilador C# cria o campo de armazenamento para você, sem a necessidade de escrever código 
//adicional.

//Em vez de escrever uma propriedade com um campo de armazenamento explícito, como:


private string _name;

public string Name
{
    get { return _name; }
    set { _name = value; }
}


//Você pode simplesmente usar uma propriedade auto-implementada:


public string Name { get; set; }


//A propriedade acima é equivalente à primeira, com a diferença de que não precisamos declarar o campo _name explicitamente. O compilador C# cria o campo automaticamente 
//para nós, tornando o código mais conciso.

//As propriedades auto-implementadas podem ser usadas com tipos de valor (como int, float, double) e tipos de referência (como classes). É possível apenas definir a propriedade
//como "get" para criar uma propriedade somente de leitura ou definir a propriedade como "set" para criar uma propriedade somente de escrita.

//Também é possível definir um modificador de acesso para a propriedade, permitindo que você torne uma propriedade pública, privada ou protegida.

//As propriedades auto-implementadas em C# são uma forma conveniente de criar propriedades em classes, sem a necessidade de escrever código adicional para o campo de 
//armazenamento. É importante notar, no entanto, que as propriedades auto-implementadas não são uma solução para todas as situações e que a escolha entre elas e as propriedades
//com campos explícitos dependerá do caso em questão.
