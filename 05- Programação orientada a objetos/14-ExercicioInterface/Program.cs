using _14_ExercicioInterface;
using System.Security.AccessControl;

SalvarJson salvarJson = new SalvarJson();
salvarJson.Nome();
salvarJson.Salvar();

//salvarJson.CompactarArquivo(); // <- Chamar um método com impletementação que foi definido na interface não funciona diretamente na classe que implementa a interface.

// Para chamar o método CompactarArquivo() da interface ISalvar, é necessário fazer um cast para a interface.

ISalvar iSalvarJson = new SalvarJson(); // <- Cast para a interface ISalvar.
iSalvarJson.CompactarArquivo(); // <- Agora é possível chamar o método CompactarArquivo() da interface ISalvar.


/* Qual a Diferença entre
 ISalvar iSalvarJson = salvarJson;
e
 ISalvar iSalvarJson = new SalvarJson()
?
R: A diferença entre as duas formas de atribuição está na maneira como o objeto é criado e referenciado.
1. ISalvar iSalvarJson = salvarJson;
   - Nesta forma, você está criando uma referência do tipo ISalvar que aponta para um objeto já existente do tipo SalvarJson (que foi criado anteriormente com a linha SalvarJson salvarJson = new SalvarJson();).
   - Aqui, você está reutilizando o objeto já criado, e a variável iSalvarJson simplesmente referencia esse objeto.
   - Isso é útil quando você já tem uma instância do objeto e deseja tratá-la como uma interface.
2. ISalvar iSalvarJson = new SalvarJson();
    - Nesta forma, você está criando uma nova instância do objeto SalvarJson diretamente e atribuindo-a a uma variável do tipo ISalvar.
    - Aqui, um novo objeto é criado na memória, e a variável iSalvarJson referencia esse novo objeto.
    - Isso é útil quando você deseja criar uma nova instância do objeto e tratá-la como uma interface desde o início.
 */
