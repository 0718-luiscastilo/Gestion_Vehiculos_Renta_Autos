using System;
class Vehiculo{
    private int codigo;
    private string marca;
    private string modelo;
    private int año;
    private string tipo;
    private string estado;
    private int kilometros;

    public int Codigo{
        get {
            return codigo;
        }
        set{
            codigo = value;
        }
    }
    public string Marca{
        get {
            return marca;
        }
        set{
            marca = value;
        }
    }
    public string Modelo{
        get {
            return modelo;
        }
        set{
            modelo = value;
        }
    }
    public int Año{
        get {
            return año;
        }
        set{
            año = value;
        }
    }
    public string Tipo{
        get {
            return tipo;
        }
        set{
            tipo = value;
        }
    }
    public string Estado{
        get {
            return estado;
        }
        set{
            estado = value;
        }
    }
    public int Kilometros{
        get {
            return kilometros;
        }
        set{
            kilometros = value;
        }
    }
    public Vehiculo(int codigo, string marca, string modelo, int año, string tipo, string estado,int kilometros){
        this.codigo = codigo;
        this.marca = marca;
        this.modelo = modelo;
        this.año = año;
        this.tipo = tipo;
        this.estado = estado;
        this.kilometros = kilometros;
    }
    public Vehiculo(){
        codigo = 0;
        marca = "Sin Marca";
        modelo = "000-000";
        año = 1990;
        tipo = "General";
        estado = "Sin estado";
        kilometros = 0;
    }
    public void mostrarInformacion(){
        Console.WriteLine( "Codigo: " + Codigo);
        Console.WriteLine( "Marca: " + Marca);
        Console.WriteLine( "Modelo: " + Modelo);
        Console.WriteLine( "Año: " + Año);
        Console.WriteLine( "Tipo: " + Tipo);
        Console.WriteLine( "Estado: " + Estado);
        Console.WriteLine( "Kilometros: " + Kilometros);
    }
    public void registrarKilometraje(int nuevoKilometraje){
        if(nuevoKilometraje <= 0){
            Console.WriteLine("El kilometraje no puede ser 0");
        }else if(nuevoKilometraje <Kilometros){
            Console.WriteLine("ERROR: no puede ser menor al kilometraje actual");
        }else{
            Kilometros =nuevoKilometraje;
            Console.WriteLine("Kilometraje actualizado correctamente.");
        } 
    }
    public void cambiarEstado(string nuevoEstado){
        if (string.IsNullOrWhiteSpace(nuevoEstado)){
            Console.WriteLine("ERROR: el estado no puede estar vacío.");
        }else if (nuevoEstado.Equals("Disponible", StringComparison.OrdinalIgnoreCase)){
            Estado = "Disponible";
            Console.WriteLine("Estado actualizado correctamente.");
        }else if (nuevoEstado.Equals("En mantenimiento", StringComparison.OrdinalIgnoreCase)){
            Estado = "En mantenimiento";
            Console.WriteLine("Estado actualizado correctamente.");
        }else if (nuevoEstado.Equals("Fuera de servicio", StringComparison.OrdinalIgnoreCase)){
            Estado = "Fuera de servicio";
            Console.WriteLine("Estado actualizado correctamente.");
        }else{
            Console.WriteLine("ERROR: estado no válido.");
            Console.WriteLine("Estados permitidos:");
            Console.WriteLine("- Disponible");
            Console.WriteLine("- En mantenimiento");
            Console.WriteLine("- Fuera de servicio");
        }
    }
}