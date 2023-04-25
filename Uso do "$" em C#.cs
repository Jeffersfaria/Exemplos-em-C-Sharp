//O símbolo "$" em C# é conhecido como "string interpolation" ou interpolação de string. Ele permite que você incorpore expressões dentro de literais de string, facilitando 
//a concatenação de strings e variáveis.

//Em vez de concatenar várias strings e variáveis usando o operador "+" ou o método String.Format(), você pode simplesmente colocar o "$" antes de uma string delimitada por
//aspas duplas e incorporar as expressões desejadas dentro da string entre chaves "{}".

//Por exemplo, em vez de escrever:


int idade = 25;
string mensagem = "Eu tenho " + idade.ToString() + " anos de idade.";


//Você pode escrever:


int idade = 25;
string mensagem = $"Eu tenho {idade} anos de idade.";


//Dessa forma, o valor da variável "idade" será interpolado na string e a variável "mensagem" terá o valor "Eu tenho 25 anos de idade.".

//A interpolação de strings com "$" é mais simples, legível e menos propensa a erros do que outras formas de concatenação de strings, especialmente quando se lida com
//várias variáveis e/ou valores de diferentes tipos. Além disso, a interpolação de strings também permite a formatação de strings diretamente dentro das chaves "{}".
