using System;
public class Vehiculo{
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
    }
    public int Kilometros{
        get {
            return kilometros;
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
    virtual public void mostrarInformacion(){
        Console.WriteLine( "Codigo: " + Codigo);
        Console.WriteLine( "Marca: " + Marca);
        Console.WriteLine( "Modelo: " + Modelo);
        Console.WriteLine( "Año: " + Año);
        Console.WriteLine( "Tipo: " + Tipo);
        Console.WriteLine( "Estado: " + Estado);
        Console.WriteLine( "Kilometros: " + Kilometros);
    }
    public void registrarKilometraje(int nuevoKilometraje){
        if (nuevoKilometraje <= 0){
            Console.WriteLine( "El kilometraje debe ser mayor que 0.");
        }
        else if (nuevoKilometraje < kilometros){
            Console.WriteLine("ERROR: no puede ser menor al kilometraje actual.");
        }else{
            kilometros = nuevoKilometraje;
            Console.WriteLine( "Kilometraje actualizado correctamente.");
        }
    }
    public void cambiarEstado(string nuevoEstado){
        if (string.IsNullOrWhiteSpace(nuevoEstado)){
            Console.WriteLine("ERROR: el estado no puede estar vacío.");
        }else if (nuevoEstado.Equals("Disponible", StringComparison.OrdinalIgnoreCase)){
            estado = "Disponible";
            Console.WriteLine("Estado actualizado correctamente.");
        }else if (nuevoEstado.Equals("Rentado", StringComparison.OrdinalIgnoreCase)){
            estado = "Rentado";
            Console.WriteLine("Estado actualizado correctamente.");
        }else if (nuevoEstado.Equals("En mantenimiento", StringComparison.OrdinalIgnoreCase)){
            estado = "En mantenimiento";
            Console.WriteLine("Estado actualizado correctamente.");
        }else if (nuevoEstado.Equals("Fuera de servicio", StringComparison.OrdinalIgnoreCase)){
            estado = "Fuera de servicio";
            Console.WriteLine("Estado actualizado correctamente.");
        }else{
            Console.WriteLine("Estados permitidos:");
            Console.WriteLine("- Disponible");
            Console.WriteLine("- Rentado");
            Console.WriteLine("- En mantenimiento");
            Console.WriteLine("- Fuera de servicio");
    }
    }
    public int calcularCosto(int dias){
        return 250 * dias;
    }
     public int calcularCosto(int dias, int descuento){
        int total = 250 * dias;
        if (descuento < 0 || descuento > 100){
            Console.WriteLine("ERROR: El descuento debe estar entre 0 y 100.");
            return total;
        }
        int montoDescuento = total * descuento / 100;
        return total - montoDescuento;
    }
}