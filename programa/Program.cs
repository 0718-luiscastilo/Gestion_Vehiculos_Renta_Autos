using System;
public class Program{
    public static void Main(string[] args){
        const int MAX_VEHICULOS =100;
        int totalVehiculos =0;
        Vehiculo[]  vehiculo = new Vehiculo[MAX_VEHICULOS];
        int opcion;
        do{
            opcion = MostrarMenu();
            switch(opcion){
                case 1:
                RegistrarVhiculo(vehiculo, ref totalVehiculos, MAX_VEHICULOS);
                break;
                case 2:
                MostrarTodosLosVehiculos(vehiculo, totalVehiculos);
                break;
                case 3:
                BuscarVehiculoPorCodigo(vehiculo, totalVehiculos);
                break;
                case 4:
                MostrarVehiculosDisponibles(vehiculo, totalVehiculos);
                break;
                case 5:
                MostrarVehiculosRentados(vehiculo, totalVehiculos);
                break;
                case 6:
                cambiarEstado(vehiculo, totalVehiculos);
                break;
                case 7:
                MostrarVehiculoMayorKilometraje(vehiculo, totalVehiculos);
                break;
                case 8:
                CalcularPrecioPromedioRenta(vehiculo, totalVehiculos);
                break;
                case 9:
                CantidadVehiculosPorTipo(vehiculo, totalVehiculos);
                break;
                case 10:
                RealizarMantenimiento(vehiculo, totalVehiculos);
                break;
                case 11:
                Console.WriteLine("Gracias por utilizar el Sistema de Gestión de Activos..");
                break;
            }
        }while(opcion != 11);
    }
}
