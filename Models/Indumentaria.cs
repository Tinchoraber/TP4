public class Indumentaria
{
    public string Medias{get;private set;}
    public string Pantalon{get;private set;}
    public string Camiseta{get;private set;}
    public Indumentaria(string pantalon, string medias, string camiseta)
    {
        Pantalon = pantalon;
        Medias = medias;
        Camiseta = camiseta;
    }
}