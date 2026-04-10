using _21_ExercicioFoto;

//LivroFotos livroFotos = new LivroFotos(); // <-- Isso é chamado de instância ou objeto da classe usando o construtor padrão da classe LivroFotos(quer dizer, sem passar nenhum argumento) resultando no número de páginas padrão definido no construtor padrão (16 páginas).

LivroFotos livroFotos = new LivroFotos(122); // <-- Já aqui estamos usando a chamada do cosntrutor adicional da classe LivroFotos, onde passamos uma rgumento de 122 páginas. 

livroFotos.GetNumeroPaginas(); // <-- Isso é chamado de método público

SuperLivrosFotos superLivrosFotos = new SuperLivrosFotos();

superLivrosFotos.GetNumeroPaginas(); // <-- Isso é chamado de método público herdado da classe base LivroFotos, onde o número de páginas é definido no construtor da classe SuperLivrosFotos (64 páginas).