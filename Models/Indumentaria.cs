public class Indumentaria
{
    public string Medias{get;private set;}
    public string Pantalon{get;private set;}
    public string Camiseta{get;private set;}
    public Indumentaria(string medias, string pantalon, string camiseta)
    {
        Medias = medias;
        Pantalon = pantalon;
        Camiseta = camiseta;
    }
}