//Em C#, uma interface é um tipo de referência que define um conjunto de membros que uma classe pode implementar. 
//Ela é usada para definir um contrato entre duas partes, especificando o que uma classe deve implementar para ser compatível com uma determinada interface.

//Por exemplo, vamos supor que você precise criar um sistema que possa exibir informações de diferentes tipos de mídia, como fotos, vídeos e áudio. 
//Você pode definir uma interface chamada "IMedia" que inclui os membros necessários para exibir informações sobre qualquer tipo de mídia. A interface pode ser definida 
//da seguinte forma:


public interface IMedia
{
    string Title { get; set; }
    string Description { get; set; }
    DateTime DateCreated { get; set; }
    void Play();
}


//Nesse exemplo, a interface IMedia define quatro membros: Title, Description, DateCreated e Play. Os três primeiros são propriedades que retornam e definem o 
//título, descrição e data de criação da mídia. O último membro é um método que exibe a mídia.

//Uma vez que você definiu a interface, pode implementá-la em diferentes classes, como "Photo", "Video" e "Audio". Por exemplo, a classe Photo pode ser implementada
//da seguinte forma:


public class Photo : IMedia
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DateCreated { get; set; }
    
    public void Play()
    {
        // Exibe a foto
    }
}


//A classe Photo implementa todos os membros definidos na interface IMedia, tornando-se compatível com ela. 
//Isso significa que você pode usar a classe Photo para exibir informações sobre uma foto, da mesma forma que usaria qualquer outra classe que implementa a interface IMedia.

//Em resumo, as interfaces em C# são usadas para definir um contrato que as classes podem implementar para serem compatíveis com outras partes do sistema. 
//Isso ajuda a garantir que diferentes partes do sistema possam interagir entre si de forma consistente e confiável.


//A utilização de interfaces permite a implementação de comportamentos distintos para nossas classes de forma mais flexível. 
//Com uma interface definimos um contrato, uma regra que qualquer classe que a implemente seguirá no momento de estabelecer nossos métodos.


//O C# não implementa o conceito de herança múltipla, pois classes muito distintas com métodos de mesmo nome poderiam causar problemas para o compilador definir 
//qual usar na nova instância;
//O funcionamento das interfaces na orientação a objetos, que são contratos que definem comportamentos a serem implementados pelas classes que assinam este contrato;
//Como utilizar o padrão de nomenclatura adotada para nomeação de interfaces, aplicando a convenção que utiliza o prefixo "I".


//Uma boa metáfora para entender o conceito de interface em C# é o de um controlador remoto de TV.

//Imagine que sua TV é uma classe em C#. Ela tem vários métodos que você pode usar para mudar o canal, ajustar o volume, mudar as configurações de imagem, entre outros.

//Agora imagine que você tem um controle remoto universal, que é uma interface. Essa interface também tem botões para mudar o canal, ajustar o volume e mudar as configurações
//de imagem, mas não faz nada por conta própria. Em vez disso, ela simplesmente envia um sinal para a TV, que é quem executa as ações correspondentes.

//Da mesma forma, uma interface em C# é um tipo de contrato que define quais métodos e propriedades uma classe deve implementar. Ela não tem implementação própria, mas 
//simplesmente define a assinatura dos métodos que devem ser implementados pela classe que a implementa.

//Por exemplo, suponha que tenhamos a interface IAnimal, que define um método FazerBarulho(). Em seguida, temos as classes Cachorro e Gato, que implementam a interface IAnimal
//e, portanto, devem ter o método FazerBarulho().

//A implementação do método FazerBarulho() em cada classe será diferente, assim como a TV executa ações diferentes quando você aperta os botões do controle remoto.
//Mas, ao implementar a interface IAnimal, as classes Cachorro e Gato garantem que terão esse método em comum, o que torna mais fácil para outras partes do código 
//trabalhar com eles de maneira consistente.
    

//E Quando uma classe implementa uma interface, ela é obrigada a fornecer uma implementação para todos os membros da interface. Caso contrário, essa classe deve ser 
//marcada como abstrata. Isso significa que as classes que implementam a interface precisam fornecer uma implementação para todos os métodos e propriedades declarados na
//interface.
