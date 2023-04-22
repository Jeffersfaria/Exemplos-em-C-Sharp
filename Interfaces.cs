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
