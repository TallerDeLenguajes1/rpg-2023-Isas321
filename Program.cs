using espacioPersonaje;

personaje nuevo;
FabricaDePersonajes fp= new FabricaDePersonajes();
nuevo = fp.crearPersonaje();

Console.WriteLine("La fecha de nacimiento del personaje es: "+nuevo.FechaNacimiento.ToString("dd-MM-yyyy"));

/*
public bool Existe(string nombreArchivo){
    //verifico que exista el archivo
    return
}

class PersonajeJson{
    public void GuardarPersonajes(List<personjaje>)
}*/