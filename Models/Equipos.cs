public static class Equipos
{
    public static List<string> ListaEquipos{get;private set;}= new List<string>{"","Boca", "River", "Independiente", "Racing", "San Lorenzo", "Estudiantes", "Velez", "Newell's", "Rosario Central", "Argentinos Juniors"};
    public static List<string> ListaMedias{get;private set;} = new List<string>{"", "mediasBoca.jpg", "mediasRiver.jpg", "mediasIndependiente.jpg", "mediasRacing.jpg", "mediasSanLorenzo.jpg", "mediasEstudiantes.jpg", "mediasVelez.jpg", "mediasNewells.jpg", "mediasRosario.jpg", "mediasArgentinos.jpg"};
    public static List<string> ListaPantalones{get;private set;} = new List<string>{"", "shortBoca.jpg", "shortRiver.jpg", "shortIndependiente.jpg", "shortRacing.jpg", "shortSanLorenzo.jpg", "shortEstudiantes.jpg", "shortVelez.jpg", "shortNewells.jpg", "shortRosario.jpg", "shortArgentinos.jpg"};
    public static List<string> ListaCamisetas{get;private set;} = new List<string>{"", "camisetaBoca.png", "camisetaRiver.jfif", "camisetaIndependiente.jpg", "camisetaRacing.jpg", "camisetaSanLorenzo.png", "camisetaEstudiantes.jpg", "camisetaVelez.jpg", "camisetaNewells.jpg", "camisetaRosario.jpg", "camisetaArgentinos.jpg"};
    public static Dictionary<string, Indumentaria> EquiposIndumentaria {get;private set;} = new Dictionary<string, Indumentaria>();
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