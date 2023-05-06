//Em C#, os termos "propriedade" e "campo" referem-se a duas formas diferentes de armazenar e acessar dados em uma classe.

//Um campo é uma variável declarada dentro da classe que armazena um valor. Os campos são geralmente declarados como privados (private) para garantir o encapsulamento dos
//dados, o que significa que eles não podem ser acessados diretamente fora da classe. Em vez disso, os campos são geralmente acessados através de métodos ou propriedades da
//classe. Por exemplo:


class Exemplo {
   private int idade;

   public void SetIdade(int novaIdade) {
      idade = novaIdade;
   }

   public int GetIdade() {
      return idade;
   }
}


//Neste exemplo, "idade" é um campo privado da classe Exemplo. Os métodos SetIdade() e GetIdade() são públicos e podem ser usados para alterar e obter o valor do 
//campo "idade" fora da classe.

//Por outro lado, uma propriedade é uma forma de acessar e controlar o valor de um campo. Propriedades fornecem uma maneira de encapsular um campo privado, fornecendo acesso 
//para leitura e gravação de seus valores através de métodos especiais chamados "getters" e "setters". Por exemplo:


class Exemplo {
   private int idade;

   public int Idade {
      get { return idade; }
      set { idade = value; }
   }
}


//Neste exemplo, "idade" é um campo privado da classe Exemplo, e a propriedade "Idade" é usada para acessá-lo. O método getter (get) é usado para obter o valor do 
//campo, enquanto o método setter (set) é usado para definir um novo valor para o campo. A propriedade pode ser usada assim:


Exemplo obj = new Exemplo();
obj.Idade = 30; // chama o setter para definir o valor do campo
Console.WriteLine(obj.Idade); // chama o getter para obter o valor do campo


//Em resumo, campos são simplesmente variáveis que armazenam dados dentro da classe, enquanto propriedades são uma forma mais avançada de encapsulamento de dados que 
//permitem controlar o acesso aos campos de uma classe.
