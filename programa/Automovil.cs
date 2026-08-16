using System;
class Automovil : Vehiculo, IMantenimiento{
    private int numeroPuertas;
    private string tipoTrasmision;
    private string tipoCombustible;
    private bool tieneAireAcondicionado;
    private int numeroPasajeros;

    public int NumeroPuertas{
        get {
            return numeroPuertas;
        }
        set{
            numeroPuertas = value;
        }
    }
    public string TipoTrasmision{
        get {
            return tipoTrasmision;
        }
        set{
            tipoTrasmision = value;
        }
    }
    public string TipoCombustible{
        get {
            return tipoCombustible;
        }
        set{
            tipoCombustible = value;
        }
    }
    public bool TieneAireAcondicionado{
        get {
            return tieneAireAcondicionado;
        }
        set{
            tieneAireAcondicionado = value;
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
    public Automovil(int codigo, string marca, string modelo, int año, string tipo, string estado,int kilometros,
    int numeroPuertas, string tipoTrasmision, string tipoCombustible,bool tieneAireAcondicionado,
    int numeroPasajeros) : base(codigo, marca, modelo, año, tipo, estado, kilometros){
        this.numeroPuertas = numeroPuertas;
        this.tipoTrasmision = tipoTrasmision;
        this.tipoCombustible = tipoCombustible;
        this.tieneAireAcondicionado = tieneAireAcondicionado;
        this.numeroPasajeros = numeroPasajeros;

    }
    public Automovil() : base(){
        tipoTrasmision = "Manual";
        tipoCombustible = "Gasolina";
        tieneAireAcondicionado = false;
        numeroPasajeros = 0;

    }
    public void CambiarTransmisión(string trasmision){
        tipoTrasmision = trasmision;
    }
    public override void mostrarInformacion(){
        Console.WriteLine( "Codigo: " + Codigo);
        Console.WriteLine( "Marca: " + Marca);
        Console.WriteLine( "Modelo: " + Modelo);
        Console.WriteLine( "Año: " + Año);
        Console.WriteLine( "Tipo: " + Tipo);
        Console.WriteLine( "Estado: " + Estado);
        Console.WriteLine( "Kilometros: " + Kilometros);
        Console.WriteLine( "Numero de puertas: " + NumeroPuertas);
        Console.WriteLine( "Tipo de Trasmision: " + TipoTrasmision);
        Console.WriteLine( "Tipo de Combustible: " + TipoCombustible);
        Console.WriteLine( "Aire Acondicionado: " + TieneAireAcondicionado);
        Console.WriteLine( "Numero de Pasajeros: " + NumeroPasajeros);
    }
    public void realizarMantenimiento(){
        Console.WriteLine("El Automovil neceita Mantenimiento");
    }
    public void consultarMantenimiento(){
        Console.WriteLine("El mantenimiento del Automovil se realizara pronto");
    }
}