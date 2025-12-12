/*
 * Interfaces
 * Porque utilizar interfaces?
 * - Permitem a criação de contratos que garantem que as classes que as implementam sigam uma estrutura específica.
 * o Permitem a implementação de múltiplas heranças, já que uma classe pode implementar várias interfaces.
 * O que sçao contratos?
 * - Contratos são acordos que definem um conjunto de métodos e propriedades que uma classe deve implementar.
 * - Vantagens das interfaces
 * - Promovem a flexibilidade e a reutilização de código.
 * - Facilitam a manutenção e a evolução do código, permitindo que diferentes partes do sistema sejam desenvolvidas de forma independente.
 * Diferença entre classes abstratas e interfaces
 * - Classes abstratas podem conter implementação de métodos, enquanto interfaces só podem declarar métodos e propriedades.
 * - Classes abstratas suportam herança simples, enquanto interfaces suportam herança múltipla.
 * - Classes podem herdar de uma única classe abstrata, mas podem implementar várias interfaces.
 * Onde devo utilizar interfaces?
 * - Quando se deseja definir um contrato comum para diferentes classes que não compartilham uma hierarquia de herança.
 * - Quando se deseja permitir a implementação de múltiplas heranças em uma classe.
 * - Quando se deseja promover a flexibilidade e a reutilização de código em um sistema.
 
 */


/*
 * Quando se realiza a instacia de uma classe derivada que herda uma interface, devemos utilizar o tipo da interface
 */
using _13_Interfaces;

//Dessa forma temos acesso apenas aos métodos e propriedades definidos na interface IControle
IControle demoControlr = new Demo();
demoControlr.Nome = "Interface de Controle";
demoControlr.Desenhar();


//Dessa forma temos acesso apenas aos métodos e propriedades definidos na interface IGrafico
IGrafico demoGrafico = new Demo();
demoGrafico.Pintar();
