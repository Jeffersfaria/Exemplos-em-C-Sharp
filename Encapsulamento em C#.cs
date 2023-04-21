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
