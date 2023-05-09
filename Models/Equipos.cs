public static class Equipos
{
    public static List<string> ListaEquipos{get;private set;}= new List<string>{"Boca", "River", "Independiente", "Racing", "San Lorenzo", "Estudiantes", "Velez", "Newell's", "Rosario Central", "Argentinos Juniors"};
    public static List<string> ListaMedias{get;private set;} = new List<string>{"medias boca", "medias river", "medias independiente", "medias racing", "medias san lorenzo", "medias estudiantes", "medias velez", "medias newells", "medias rosario", "medias argentinos"};
    public static List<string> ListaPantalones{get;private set;} = new List<string>{"short boca", "short river", "short independiente", "short racing", "short san lorenzo", "short estudiantes", "short velez", "short newells", "short rosario", "short argentinos"};
    public static List<string> ListaCamisetas{get;private set;} = new List<string>{"camiseta boca", "camiseta river", "camiseta independiente", "camiseta racing", "camiseta san lorenzo", "camiseta estudiantes", "camiseta velez", "camiseta newells", "camiseta rosario", "camiseta argentinos"};
    public static Dictionary<string, Indumentaria> EquiposIndumentaria {get;private set;}
    public static bool ingresarIndumentaria(string equipoSeleccionado, Indumentaria item)
    {
        bool equipoExiste = false;
        if(EquiposIndumentaria.ContainsKey(equipoSeleccionado))
        {
            equipoExiste = true;
        }
        else
        {
            equipoExiste = false;
            EquiposIndumentaria.Add(equipoSeleccionado, item);
        }
        return equipoExiste;
    }

}