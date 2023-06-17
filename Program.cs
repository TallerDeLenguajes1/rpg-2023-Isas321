using espacioPersonaje;

personaje nuevo;
FabricaDePersonajes fp= new FabricaDePersonajes();
nuevo = fp.crearPersonaje();

Console.WriteLine("La fecha de nacimiento del personaje es: "+nuevo.FechaNacimiento.ToString("dd-MM-yyyy"));

PersonajesJson pJon = new PersonajesJson();

string nombre "personajes.json";

List<personaje> ListPer;

pJon.GuardarPersonajes(ListPer,nombre);


