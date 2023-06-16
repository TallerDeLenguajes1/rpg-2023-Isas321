
namespace espacioPersonaje;

public class personaje{

//Datos
    private string? tipo;
    private string? nombre;
    private string? apodo;
    private DateTime fechaNacimiento;
    private int edad;

//Caracteristicas
    private int velocidad;
    private int destreza;
    private int fuerza;
    private int nivel;
    private int armadura;
    private int salud;


//  Constructor
    // public peronaje(string? tipo, string? nombre, string? apodo, DateTime fechaNacimiento, int edad, int velocidad, int destreza, int fuerza, int nivel, int armadura, int salud)
    // {
    //     Tipo = tipo;
    //     Nombre = nombre;
    //     Apodo = apodo;
    //     FechaNacimiento = fechaNacimiento;
    //     Edad = edad;
    //     Velocidad = velocidad;
    //     Destreza = destreza;
    //     Fuerza = fuerza;
    //     Nivel = nivel;
    //     Armadura = armadura;
    //     Salud = salud;
    // }



//   Get set 
    public string? Tipo { get => tipo; set => tipo = value; }
    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apodo { get => apodo; set => apodo = value; }
    public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public int Edad { get => edad; set => edad = value; }
    public int Velocidad { get => velocidad; set => velocidad = value; }
    public int Destreza { get => destreza; set => destreza = value; }
    public int Fuerza { get => fuerza; set => fuerza = value; }
    public int Nivel { get => nivel; set => nivel = value; }
    public int Armadura { get => armadura; set => armadura = value; }
    public int Salud { get => salud; set => salud = value; }
}


public class FabricaDePersonajes{
    public personaje crearPersonaje(){

        var personajeAleatorio = new personaje();

        personajeAleatorio.Nombre= nombreRandom();
        personajeAleatorio.Apodo= apodoRandom();
        personajeAleatorio.Edad= 20;
        personajeAleatorio.FechaNacimiento= new DateTime(obtieneRandom(2000,2020),obtieneRandom(1,12),obtieneRandom(1,31));
        personajeAleatorio.Tipo= tipoRandom();
        personajeAleatorio.Velocidad= obtieneRandom(1,10);
        personajeAleatorio.Destreza= obtieneRandom(1,5);
        personajeAleatorio.Fuerza= obtieneRandom(1,10);
        personajeAleatorio.Nivel= obtieneRandom(1,10);
        personajeAleatorio.Armadura= obtieneRandom(1,10);
        personajeAleatorio.Salud= 100;

        return personajeAleatorio;
    }


    public string nombreRandom(){
        string[] nombres= {"Paco", "Lucho", "JuanPablo"};
        return nombres[obtieneRandom(1,3)];
    }

    public string apodoRandom(){
        string[] apodos= {"Flaco", "Facha", "Manco"};
        return apodos[obtieneRandom(1,3)];
    }

    public string tipoRandom(){
        string[] tipo= {"Bueno", "Malo"};
        return tipo[obtieneRandom(1,2)];
    }

    public int obtieneRandom(int minimo, int maximo){
        Random random = new Random();
        return random.Next(minimo,maximo);;
    }
}

class PersonajeJson{
        public void GuardarPersonajes(List<personaje>nuevo, string archivo){
            string Json = JsonSerializador;
        }

        public List<personaje> LeerPersonajes(string archivo){
            List<personaje>listPer;
            return listPer;
        }

        public bool ExistePersonaje(personaje nuevo){
        return ;
        }
}