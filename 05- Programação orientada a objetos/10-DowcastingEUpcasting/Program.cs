using _10_DowcastingEUpcasting;
/*
Upcasting
    - É converter um objeto de uma classe derivada para uma classe base.
    -Downcasting
 */

/*Upcasting*/
Forma circulo = new Circulo(10, 20); // Conversão implícita de Circulo para Forma
circulo.Desenhar();
//circulo.PintarCirculo();  // isso não é mais possível, porque circulo sofreu um upcasting, uma conversão para a classe base Forma

Circulo circuloVerdade = new Circulo(30, 40); // objeto do tipo Circulo
circuloVerdade.PintarCirculo(); // agora é possível chamar o método PintarCirculo. Porque a instacia é do tipo Circulo e não sofreu upcasting

/*Segunda forma de realizar um upcasting*/
Forma forma = circulo;

Console.WriteLine(forma == circulo); // true, porque ambos apontam para o mesmo objeto na memória

/*Dowcasting*/
Circulo novoCirculo = new Circulo(20,20);
Forma novaForma = novoCirculo; // upcasting implícito 

Circulo formaDowcasting = (Circulo)novaForma; // downcasting explícito

formaDowcasting.Desenhar();
formaDowcasting.PintarCirculo(); // agora é possível chamar o método PintarCirculo, porque formaDowcasting é do tipo Circulo
