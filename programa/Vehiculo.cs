using System;
class Vehiculo{
    private int codigo;
    private string marca;
    private string modelo;
    private int año;
    private string tipo;
    private string estado;
    private int kilometros;

    public int codigo{
        get {
            return codigo;
        }
        set{
            codigo = value;
        }
    }
    public string marca{
        get {
            return marca;
        }
        set{
            marca = value;
        }
    }
    public string modelo{
        get {
            return modelo;
        }
        set{
            modelo = value;
        }
    }
    public int año{
        get {
            return año;
        }
        set{
            año = value;
        }
    }
    public string tipo{
        get {
            return tipo;
        }
        set{
            tipo = value;
        }
    }
    public string estado{
        get {
            return estado;
        }
        set{
            estado = value;
        }
    }
    public int kilometros{
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
        codigo = 0000;
        marca = "Sin Marca";
        modelo = "000-000";
        año = 1990;
        tipo = "General";
        estado = "No estados";
        kilometros = 0;
    }



}