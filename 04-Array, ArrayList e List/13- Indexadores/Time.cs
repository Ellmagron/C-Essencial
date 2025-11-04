namespace _13__Indexadores;

public  class Time
{
    string[] valor = new string[10];
    public string this[int i]
    {
        get
        {
            if(i >= 0 && i < valor.Length)
            {
                //Retornando valor
                return valor[i];
            }
            return "Error";
        }
        set 
        {
            if (i >= 0 && i < valor.Length)
            {
                valor[i] = value;
            }
        }
    }
}
