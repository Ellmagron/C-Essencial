/*
 Tipos de relacionamentos entre classes

1- Relacionamento "É um" (Herança)
   - Descrição: Representa uma relação de herança onde uma classe derivada herda propriedades e comportamentos de uma classe base.
   - Exemplo: Uma classe "Cachorro" que herda de uma classe "Animal".
2- Relacionamento "Tem um" (Composição)
   - Descrição: Representa uma relação onde uma classe contém uma instância de outra classe como parte de sua composição.
   - Exemplo: Uma classe "Carro" que tem um objeto "Motor".

A Compisição e agração são técnicas de programação que permitem que uma classe "contenha" um ou mais objetos de outras classes para formar um grande objeto realizando algumas funcionalidades específicas.

O contêiner é a superclasse ou classe pai e as classes contidas na superclasse são subclasses ou classes filhas, onde a classe pai (superclasse) e as classes filhas (subclasses) possuem um relacionamento "tem um" ou "tem vários".

Um relacionamento de composição ocorre quando um objeto de uma classe é composto de um ou mais objetos de outras classes.
    Exemplo: Uma classe "Casa" que é composta por objetos "Quarto", "Cozinha" e "Banheiro".
Este relacionamento é formado quando uma classe te uma referência a outra classe como uma propriedade. de instacia.
    Exemplo: Uma classe "Biblioteca" que tem uma lista de objetos "Livro".
Na composição, uma classe que contém a referência a outra classe é a classe pai sendo a proprietária da classe filha não existe sem a classe pai.
    Exemplo: Uma classe "Carro" que tem um objeto "Motor". Se o carro for destruído, o motor também deixa de existir.
 */ 