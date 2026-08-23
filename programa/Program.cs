using System;
public class Program{
    public static void Main(string[] args){
        const int MAX_VEHICULOS =100;
        int totalVehiculos =0;
        Vehiculo[]  vehiculo = new Vehiculo[MAX_VEHICULOS];
        int opcion;
        do{
            opcion = Funciones.MostrarMenu();
            switch(opcion){
                case 1:
                Funciones.RegistrarVhiculo(vehiculo, ref totalVehiculos, MAX_VEHICULOS);
                break;
                case 2:
                Funciones.MostrarTodosLosVehiculos(vehiculo, totalVehiculos);
                break;
                case 3:
                Funciones.BuscarVehiculoPorCodigo(vehiculo, totalVehiculos);
                break;
                case 4:
                Funciones.MostrarVehiculosDisponibles(vehiculo, totalVehiculos);
                break;
                case 5:
                Funciones.MostrarVehiculosRentados(vehiculo, totalVehiculos);
                break;
                case 6:
                Funciones.CambiarEstado(vehiculo, totalVehiculos);
                break;
                case 7:
                Funciones.MostrarVehiculoMayorKilometraje(vehiculo, totalVehiculos);
                break;
                case 8:
                Funciones.CalcularPrecioPromedioRenta(vehiculo, totalVehiculos);
                break;
                case 9:
                Funciones.CantidadVehiculosPorTipo(vehiculo, totalVehiculos);
                break;
                case 10:
                Funciones.RealizarMantenimiento(vehiculo, totalVehiculos);
                break;
                case 11:
                Console.WriteLine("Gracias por utilizar el Sistema..");
                break;
            }
        }while(opcion != 11);
    }
}
