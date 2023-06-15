using espacioPersonaje;

personaje nuevo;
FabricaDePersonajes fp= new FabricaDePersonajes();
nuevo = fp.crearPersonaje();

Console.WriteLine("El nombre del personaje es"+nuevo.Nombre);

/*
public bool Existe(string nombreArchivo){
    //verifico que exista el archivo
    return
}

class PersonajeJson{
    public void GuardarPersonajes(List<personjaje>)
}*/