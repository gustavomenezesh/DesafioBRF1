# DesafioBRF1


## -Implementação das Funções

 Foram utilizadas duas funções para resolução do desafio, foram elas:

### .fat(n)

 Retorna o fatorial de um número passado como entrada, através da seguinte implementação:

![imagem](https://uploaddeimagens.com.br/images/002/754/726/original/fatorial.png?1594160080)

### .f(n)

 Essa função é responsável pela soma de todos os dígitos do fatorial de um número, segue sua implementação:
 
 ![imagem](https://uploaddeimagens.com.br/images/002/754/730/original/sumAlgarisms.png?1594160593)
 
 A lógica utilizada foi transformar o valor da entrada em uma string, para que assim o programa possa tratar cada digito individualmente(já que virou um array de caracteres) e assim utilizar um laço de repetição para acumular os valores de cada dígito
 Nessa função também foi realizado a validação do intervalo pedido no enunciado do desafio ([0,2000]).
 
 ### .main()
 
 Essa é a função principal do programa e basicamente só mostra o resultado da soma dos dígitos do fatorial de um número, como mostra a sua implementação:
 
 ![imagem](https://uploaddeimagens.com.br/images/002/754/734/original/main.png?1594161003)
 
 ## -Implementação dos Testes
 
  Para a implementação dos testes foi utilizado o modelo que já vem no Visaul Studio para criação de testes para C#, onde já os vincula ao projeto que irá ser testado
	
	Para este desafios foram realizados 3 testes, sendo eles:
	
 ### .validFatorial()
	
 Esse teste verifica se a função responsável pelo cálculo do fatorial está funcionando corretamente, através do método Assert.AreEqual() função essa que analisa se o valor esperado e o valor obtido com a função tem o mesmo valor, como mostra na implementação a seguir:
	
 ![imagem](https://uploaddeimagens.com.br/images/002/754/744/original/test1.png?1594161542)
 
 ### .validSum()
 
 Esse teste verifica se a função que realiza a soma dos algarismos de um número está retornando o resultado esperado também através do método Assert.AreEqual(), segue sua implementação:
 
 ![imagem](https://uploaddeimagens.com.br/images/002/754/751/original/test2.png?1594161795)
 
 ### .validInterval()
 
 Esse teste também funciona como os dois citados acima, a diferença é que nesse caso é verificado se o intervalo está sendo invalidado quando é passado um valor fora dele ([0,2000]), sua implementação é feita passando um valor fora do intervalo como entrada e analisando se a saída é -1(fora do intervalo), como mostra a implementação a seguir:
 
 ![imagem](https://uploaddeimagens.com.br/images/002/754/762/original/test3.png?1594162166)
 
## -Ferramentas utilizadas

Visual Studio
