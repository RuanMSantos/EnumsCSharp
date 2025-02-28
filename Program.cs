// São um tipo de dados disponibilizado no c# que permite representar um conjunto de valores.

// Um exemplo de uso dos Enums é quando vc quer representar valores agrupados em uma categoria como dias
// da semana por exemplo.

// Outro exemplo muito comum são os estados de algum tipo de entidade que podemos ter em um sistema
// como por exemplo um sistema de compras, onded seu pedido tem varios estados como pendente de pagamento,
// aprovado, a caminho, etc... Todos essses exemplos são estaddos de uma mesma coisa (pedido), e através
// do enumerador todos ficam agrupados.

// o Enumerador cria a capacidade de fazer algo mais organizado e legível.

/* Repare que isso não é usual, fica grande e horrível. (Escrito com "_" pois é const, por boas práticas)
const int dia_da_semana_domingo = 1;
const int dia_da_semana_segunda = 2;
const int dia_da_semana_terca = 3;
*/

// DiasDaSemana dia = DiasDaSemana.Segunda; // usando o tipo de dado que criamos, temos as segurança de que só
// serão atribuidos valores do tipo DiasDaSemana

//Também é possível, ao invez de texto, exibir a representação numérica de Segunda

// Também é possível atribuir um valor do enum para uma variavel do tipo int, fazendo o casting nele.

int dia = (int)DiasDaSemana.Segunda; // Isso é necessário pois por padrão DiasDaSemana retornaria a palavra Segunda 
// Também é possível fazer a operação contrária.

/*
Também é possível apenas exibir Segunda em forma de numero sem gravar em uma variavel, seria
Console.WriteLine((int)dia); -> não seria convertido igual em cima, o valor original seria guardado em dia
*/

Console.WriteLine(dia);

StatusPedido statusPedido = StatusPedido.Aprovado;

// exemplo de checagem de pedido
if (statusPedido == StatusPedido.Cancelado){
    Console.WriteLine($"Seu pedido foi {StatusPedido.Cancelado}!");
}

// exemplo switch
switch (statusPedido){
    case StatusPedido.Aprovado:
        Console.WriteLine(StatusPedido.Aprovado);
        break;
    case StatusPedido.Cancelado:
        Console.WriteLine(StatusPedido.Cancelado);
        break;
    case StatusPedido.Recusado:
        Console.WriteLine(StatusPedido.Recusado);
        break;
}

// Estrutura do enum
enum DiasDaSemana {
    Domingo = 5,
    Segunda,
    Terca,
    Quarta = 12,
    Quinta,
    Sexta,
    Sabado,
}
// o enum cria um novo tipo de dado, neste caso, DiasDaSemana é um tipo de dado, que aceita apenas os valores
// pré-definidos nele como: Domingo, Segunda, Terca. Não é como um int por exemplo que aceita "qualquer" num.

// AS DEFINIÇÕES DE NOVOS TIPOS DEVEM FICAR NO FINAL DO ARQUIVO, pois se não da erro. 

// Cada valor recebe um número, que por padrão começa em 0, porém é possível customizar, passando o valor
// desejado. Os valores vão seguir sucessivamente a partir do valor definido.

// também é poss;ivwl customizar em outras posições sem ser a primeira, e a partir da customizada os valores
// a seguem sucessivamente.

enum StatusPedido{
    Aprovado = 15,
    Recusado = 23,
    Cancelado = 35,
}

// Uma boa aplicação para valores customizados é quando vamos se comunicar com algum outro sistema ou aplicação,
// que necessita de números específicos.

// Uma boa prática é sempre setar os valores, mesmo que tenha a tribuíção automática, pois isso previne problemas
// futuros, como quebra de sequencia dos valores.

// Note no switch que utilizar o enum deixa tudo muito claro e organizado, o que nos da a capacidade de ler melhor o código
// além disso, faz com só temos resultados esperados, pois todos os resultados estão contidos no enum.  