using Exercicio_147;
A a = new A();
B b = new B();

A x;           // declaração: x existe, mas não foi inicializada (local)
x = a;         // agora x referencia o mesmo objeto que a
x.Exibir();    // chama A.Exibir() ou B.Exibir() dependendo da instância
x = b;         // agora x referencia o objeto b
x.Exibir();    // chamada polimórfica se Exibir for virtual/overridden