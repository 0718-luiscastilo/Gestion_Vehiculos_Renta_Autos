using System;
public class Program{
    public static void Main(string[] args){
        const int MAX_VEHICULOS =100;
        int totalVehiculos =0;
        Vehiculo[]  vehiculo = new Vehiculo[MAX_VEHICULOS];

        Automovil vehiculo1 = new Automovil(1,"Nissan","V25",2025,"Normal","Disponible",2000,4,"Standar","Disel",true,4);
        vehiculo[totalVehiculos] = vehiculo1;
        totalVehiculos++;
        Camioneta vehiculo2 = new Camioneta(2,"Vento","V01",2025,"Normal","Disponible",2026,300,"Standar",true,5);
        vehiculo[totalVehiculos] = vehiculo2;
        totalVehiculos++;
        Motocicleta vehiculo3 = new Motocicleta(3,"Kia","NW23",2024,"Doble","Disponible",2024,1,"Automatica",true,1);
        vehiculo[totalVehiculos] = vehiculo3;
        totalVehiculos++;
        
        for(int i=0; i<totalVehiculos;i++){
            vehiculo[i].mostrarInformacion();
            Console.WriteLine("------------------------------");
            
            IMantenimiento mantenimiento = (IMantenimiento)vehiculo[i];
            mantenimiento.realizarMantenimiento();
            mantenimiento.consultarMantenimiento();
            Console.WriteLine("==============================");
        }
    }
}
