using System;
class Motocicleta : Vehiculo{
    private int cilindrada;
    private string tipoMotocicleta;
    private bool tieneBaul;
    private int numeroCascos;


    public int Cilindrada{
        get {
            return cilindrada;
        }
        set{
            cilindrada = value;
        }
    }
    public string TipoMotocicleta{
        get {
            return tipoMotocicleta;
        }
        set{
            tipoMotocicleta = value;
        }
    }
    public bool TieneBaul{
        get {
            return tieneBaul;
        }
        set{
            tieneBaul = value;
        }
    }
    public int NumeroCascos{
        get {
            return numeroCascos;
        }
        set{
            numeroCascos = value;
        }
    }
    public Motocicleta(int codigo, string marca, string modelo, int año, string tipo, string estado,int kilometros,
    int  Cilindrada, string tipoMotocicleta, bool tieneBaul, 
    int numeroCascos) : base(codigo, marca, modelo, año, tipo, estado, kilometros){
        this.cilindrada = cilindrada;
        this.tipoMotocicleta = tipoMotocicleta;
        this.tieneBaul = tieneBaul;
        this.numeroCascos = numeroCascos;
    }
    public Motocicleta() : base(){
        cilindrada = 0;
        tipoMotocicleta = "Basica";
        tieneBaul = false;
        numeroCascos = 1;
    }
    public void CambiarCilindrada(int nuevaCilindrada){
        if (nuevaCilindrada <= 0){
            Console.WriteLine("ERROR: El número de cilindros debe ser mayor que 0.");
        }else{
            cilindrada = nuevaCilindrada;
            Console.WriteLine("Número de cilindros actualizado correctamente.");
        }

    }
    public void CambiarNumeroCascos(int cantidadCascos){
        if (cantidadCascos < 0){
            Console.WriteLine("ERROR: El número de pasajeros debe ser mayor que 0.");
        }else{
            numeroCascos = cantidadCascos;
            Console.WriteLine("Número de pasajeros actualizado correctamente.");
        }
    }
    public void mostrarespecificaciones(){
        Console.WriteLine( "Cilindrada: " + Cilindrada);
        Console.WriteLine( "Tipo de Motocicleta: " + TipoMotocicleta);
        Console.WriteLine( "Tiene Baul: " + TieneBaul);
        Console.WriteLine( "Numero de Casco: " + NumeroCascos);
    }
}