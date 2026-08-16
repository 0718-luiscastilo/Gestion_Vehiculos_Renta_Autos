using System;
class Camioneta : Vehiculo, IMantenimiento{
    private double capacidadCarga;
    private string tipoTraccion;
    private bool tieneDobleCabina;
    private int numeroPasajeros;

    public double CapacidadCarga{
        get {
            return capacidadCarga;
        }
        set{
            capacidadCarga = value;
        }
    }
    public string TipoTraccion{
        get {
            return tipoTraccion;
        }
        set{
            tipoTraccion = value;
        }
    }
    public bool TieneDobleCabina{
        get {
            return tieneDobleCabina;
        }
        set{
            tieneDobleCabina = value;
        }
    }
    public int NumeroPasajeros{
        get {
            return numeroPasajeros;
        }
        set{
            numeroPasajeros = value;
        }
    }
    public Camioneta(int codigo, string marca, string modelo, int año, string tipo, string estado,int kilometros,
    double capacidadCarga, string tipoTraccion,bool tieneDobleCabina, 
    int numeroPasajeros) : base(codigo, marca, modelo, año, tipo, estado, kilometros){
        this.capacidadCarga = capacidadCarga;
        this.tipoTraccion = tipoTraccion;
        this.tieneDobleCabina = tieneDobleCabina;
        this.numeroPasajeros = numeroPasajeros;
    }
    public Camioneta() : base(){
        capacidadCarga = 0;
        tipoTraccion = "Sin traccion ";
        tieneDobleCabina = false;
        numeroPasajeros = 2;
    }
    public void cambiarPsajeros(int pasajeros){
        if (pasajeros <= 0){
            Console.WriteLine("ERROR: El número de pasajeros debe ser mayor que 0.");
        }else{
            numeroPasajeros = pasajeros;
            Console.WriteLine("Número de pasajeros actualizado correctamente.");
        }
    }
    public override void mostrarInformacion(){
        Console.WriteLine( "Codigo: " + Codigo);
        Console.WriteLine( "Marca: " + Marca);
        Console.WriteLine( "Modelo: " + Modelo);
        Console.WriteLine( "Año: " + Año);
        Console.WriteLine( "Tipo: " + Tipo);
        Console.WriteLine( "Estado: " + Estado);
        Console.WriteLine( "Kilometros: " + Kilometros);
        Console.WriteLine( "Capacidad de Carga: " + CapacidadCarga);
        Console.WriteLine( "Tipo de Traccion: " + TipoTraccion);
        Console.WriteLine( "Doble cabina: " + TieneDobleCabina);
        Console.WriteLine( "Numero de Pasajeros: " + NumeroPasajeros);
    }
    public void realizarMantenimiento(){
        Console.WriteLine("La Camioneta neceita Mantenimiento");
    }
    public void consultarMantenimiento(){
        Console.WriteLine("El mantenimiento de La Camioneta se realizara pronto");
    }
}