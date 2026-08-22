using System;
public class Funciones{
    public static int selecionarVehiculo(){
    int op;
    while (true){
        Console.WriteLine("========================================");
        Console.WriteLine("===== REGISTRAR VEHÍCULO =====");
        Console.WriteLine("1.- Automóvil");
        Console.WriteLine("2.- Camioneta");
        Console.WriteLine("3.- Motocicleta");
        Console.Write("Seleccione una opción: ");

        if (int.TryParse(Console.ReadLine(), out op) && op >= 1 && op <= 3) {
            return op;
        }
        Console.WriteLine("ERROR: Seleccione una opción entre 1 y 3.");
    }
}
 public static void RegistrarVhiculo(Vehiculo[] vehiculo, ref int totalVehiculos, int MAX_VEHICULOS){
    if(totalVehiculos >= MAX_VEHICULOS){
        Console.WriteLine("Ya no hay espacio para mas Vwhiculos");
        return;
    }
    int opcion = selecionarVehiculo();
    switch(opcion){
        case 1:{
        Console.WriteLine(" Ingrese el Codigo: ");
        int codigo;
        while (!int.TryParse(Console.ReadLine(), out codigo) || codigo <= 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
        }

        Console.WriteLine(" Ingrese la Marca: ");
        string marca = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(marca)){
            Console.Write("Error. La marca no puede estar vacío. Intente nuevamente: ");
            marca = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese el Modelo: ");
        string modelo = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(modelo)){
            Console.Write("Error. El modelo no puede estar vacío. Intente nuevamente: ");
            modelo = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese el año: ");
        int año;
        while (!int.TryParse(Console.ReadLine(), out año) || año <= 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
        }
        Console.WriteLine(" Ingrese el Tipo: ");
        string tipo = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(tipo)){
            Console.Write("Error. El tipo no puede estar vacío. Intente nuevamente: ");
            tipo = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese el Estado: ");
        string estado = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(estado)){
            Console.Write("Error. El tipo no puede estar vacío. Intente nuevamente: ");
            estado = Console.ReadLine();
        }
        while (estado != "Disponible" && estado != "Rentado") {
            Console.Write("Estado inválido. Ingrese Disponible o Rentado: ");
            estado = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese los Kilometros: ");
        int kilometros;
        while (!int.TryParse(Console.ReadLine(), out kilometros) || kilometros <= 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
        }
        Console.WriteLine(" Ingrese el Numero de Puertas: ");
        int numeroPertas;
        while (!int.TryParse(Console.ReadLine(), out numeroPertas) || numeroPertas <= 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
        }
        Console.WriteLine(" Ingrese el Tipo de Trasmision: ");
        string tipotrasmision = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(tipotrasmision)){
            Console.Write("Error. La marca no puede estar vacío. Intente nuevamente: ");
            tipotrasmision = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese el Tipo de Combustible: ");
        string tipoCombustible = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(tipoCombustible)){
            Console.Write("Error. La marca no puede estar vacío. Intente nuevamente: ");
            tipoCombustible = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese Tiene Aire Acondicionado: ");
        Console.Write("¿Tiene aire acondicionado? (S/N): ");
        string respuestaAire = Console.ReadLine();
        while (respuestaAire != "S" && respuestaAire != "s" && respuestaAire != "N" && respuestaAire != "n"){
            Console.Write("Error. Ingrese S para Sí o N para No: ");
            respuestaAire = Console.ReadLine();
            }
            bool tieneAireAcondicionado;
            if (respuestaAire == "S" || respuestaAire == "s"){
                tieneAireAcondicionado = true;
            }else{
                tieneAireAcondicionado = false;
            }

        Console.WriteLine(" Ingrese los Numero de Pasjeros: ");
        int numeroPasajeros;
        while (!int.TryParse(Console.ReadLine(), out numeroPasajeros) || numeroPasajeros <= 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
        }

        Vehiculo a = new Automovil(codigo, marca,modelo, año, tipo, estado, kilometros, numeroPertas, 
        tipotrasmision, tipoCombustible, tieneAireAcondicionado, numeroPasajeros);
        vehiculo[totalVehiculos] = a;
        totalVehiculos++;
        Console.WriteLine("Automóvil registrado correctamente.");
        break;
        }
        case 2:{
        Console.WriteLine(" Ingrese el Codigo: ");
        int codigo;
        while (!int.TryParse(Console.ReadLine(), out codigo) || codigo <= 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
        }

        Console.WriteLine(" Ingrese la Marca: ");
        string marca = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(marca)){
            Console.Write("Error. La marca no puede estar vacío. Intente nuevamente: ");
            marca = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese el Modelo: ");
        string modelo = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(modelo)){
            Console.Write("Error. El modelo no puede estar vacío. Intente nuevamente: ");
            modelo = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese el año: ");
        int año;
        while (!int.TryParse(Console.ReadLine(), out año) || año <= 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
        }
        Console.WriteLine(" Ingrese el Tipo: ");
        string tipo = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(tipo)){
            Console.Write("Error. El tipo no puede estar vacío. Intente nuevamente: ");
            tipo = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese el Estado: ");
        string estado = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(estado)){
            Console.Write("Error. El tipo no puede estar vacío. Intente nuevamente: ");
            estado = Console.ReadLine();
        }
        while (estado != "Disponible" && estado != "Rentado") {
            Console.Write("Estado inválido. Ingrese Disponible o Rentado: ");
            estado = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese los Kilometros: ");
        int kilometros;
        while (!int.TryParse(Console.ReadLine(), out kilometros) || kilometros <= 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
        }
        Console.WriteLine(" Ingrese la Capacidad de Carga: ");
        double capacidadCarga;
        while (!double.TryParse(Console.ReadLine(), out capacidadCarga) || capacidadCarga <= 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
        }
        Console.WriteLine(" Ingrese el Tipo de Traccion: ");
        string tipoTaccion = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(tipoTaccion)){
            Console.Write("Error. El tipo no puede estar vacío. Intente nuevamente: ");
            tipoTaccion = Console.ReadLine();
        }
        Console.Write("¿Tiene ael Tiene Doble Cabina? (S/N): ");
        string respuestaCabina = Console.ReadLine();
        while (respuestaCabina != "S" && respuestaCabina != "s" && respuestaCabina != "N" && respuestaCabina != "n"){
            Console.Write("Error. Ingrese S para Sí o N para No: ");
            respuestaCabina = Console.ReadLine();
            }
            bool tieneDobleCabina;
            if (respuestaCabina == "S" || respuestaCabina == "s"){
                tieneDobleCabina = true;
            }else{
                tieneDobleCabina = false;
        }
        Console.WriteLine(" Ingrese los Numero de Psajeros: ");
        int numeroPasajeros;
        while (!int.TryParse(Console.ReadLine(), out numeroPasajeros) || numeroPasajeros <= 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
        }
        Vehiculo c = new Camioneta(codigo, marca,modelo, año, tipo, estado, kilometros, capacidadCarga,
        tipoTaccion,tieneDobleCabina,numeroPasajeros);
        vehiculo[totalVehiculos] = c;
        totalVehiculos++;
        Console.WriteLine("Camioneta registrada correctamente.");
        break;
        }

        case 3:{
        Console.WriteLine(" Ingrese el Codigo: ");
        int codigo;
        while (!int.TryParse(Console.ReadLine(), out codigo) || codigo <= 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
        }

        Console.WriteLine(" Ingrese la Marca: ");
        string marca = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(marca)){
            Console.Write("Error. La marca no puede estar vacío. Intente nuevamente: ");
            marca = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese el Modelo: ");
        string modelo = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(modelo)){
            Console.Write("Error. El modelo no puede estar vacío. Intente nuevamente: ");
            modelo = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese el año: ");
        int año;
        while (!int.TryParse(Console.ReadLine(), out año) || año <= 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
        }
        Console.WriteLine(" Ingrese el Tipo: ");
        string tipo = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(tipo)){
            Console.Write("Error. El tipo no puede estar vacío. Intente nuevamente: ");
            tipo = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese el Estado: ");
        string estado = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(estado)){
            Console.Write("Error. El tipo no puede estar vacío. Intente nuevamente: ");
            estado = Console.ReadLine();
        }
        while (estado != "Disponible" && estado != "Rentado") {
            Console.Write("Estado inválido. Ingrese Disponible o Rentado: ");
            estado = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese los Kilometros: ");
        int kilometros;
        while (!int.TryParse(Console.ReadLine(), out kilometros) || kilometros <= 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
        }
        Console.WriteLine(" Ingrese el Numero de Cilindros: ");
        int cilindros;
        while (!int.TryParse(Console.ReadLine(), out cilindros) || cilindros <= 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
        }
        Console.WriteLine(" Ingrese el Tipo de Motocicleta: ");
        string tipoMotocicleta = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(tipoMotocicleta)){
            Console.Write("Error. El tipo no puede estar vacío. Intente nuevamente: ");
            tipoMotocicleta = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese Tiene Baul: ");
        Console.Write("¿Tiene ael Tiene Baul? (S/N): ");
        string respuestaBaul = Console.ReadLine();
        while (respuestaBaul != "S" && respuestaBaul != "s" && respuestaBaul != "N" && respuestaBaul != "n"){
            Console.Write("Error. Ingrese S para Sí o N para No: ");
            respuestaBaul = Console.ReadLine();
            }
            bool tieneBaul;
            if (respuestaBaul == "S" || respuestaBaul == "s"){
                tieneBaul = true;
            }else{
                tieneBaul = false;
        }
        Console.WriteLine(" Ingrese los Numero de Cascos: ");
        int numeroCascos;
        while (!int.TryParse(Console.ReadLine(), out numeroCascos) || numeroCascos <= 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
        }
        Vehiculo m = new Motocicleta(codigo, marca,modelo, año, tipo, estado, kilometros, cilindros,
        tipoMotocicleta,tieneBaul, numeroCascos);
        vehiculo[totalVehiculos] = m;
        totalVehiculos++;
        Console.WriteLine("Motocicleta registrada correctamente.");
        break;
    }
    }
}
public static void MostrarTodosLosVehiculos(Vehiculo[] vehiculo, int totalVehiculos){
    if(totalVehiculos == 0 ){
        Console.WriteLine("No hay vehículos registrados.");
        return;
    }
    for(int i=0; i<totalVehiculos; i++){
        vehiculo[i].mostrarInformacion();
        Console.WriteLine("==============================");
    }
}
public static void BuscarVehiculoPorCodigo(Vehiculo[] vehiculo, int totalVehiculos){
    bool encontrado = false;
    if(totalVehiculos == 0 ){
        Console.WriteLine("No hay vehículos registrados.");
        return;
    }
    int buscarCodigo;
     Console.WriteLine("Ingrese el coodigo: ");
     while (!int.TryParse(Console.ReadLine(), out buscarCodigo) || buscarCodigo <= 0){
        Console.Write("Error. Ingrese un código numérico mayor que 0: ");
    }
    for(int i=0; i<totalVehiculos; i++){
        if(vehiculo[i].Codigo == buscarCodigo){
            encontrado = true;
            vehiculo[i].mostrarInformacion();
            break;
        }
    }
    if(!encontrado){
            Console.WriteLine("No se encontró un vehículo con ese código.");
        }
}
public static void MostrarVehiculosDisponibles(Vehiculo[] vehiculo, int totalVehiculos){
    bool hayDisponibles = false;
    if(totalVehiculos == 0 ){
        Console.WriteLine("No hay vehículos registrados.");
        return;
    }
    for(int i=0; i<totalVehiculos; i++){
        if(vehiculo[i].Estado == "Disponible"){
            hayDisponibles = true;
            vehiculo[i].mostrarInformacion();
        }
    }
    if(!hayDisponibles){
            Console.WriteLine("No se encontró un vehículo Dispobible.");
        }
}
public static void MostrarVehiculosRentados(Vehiculo[] vehiculo, int totalVehiculos){
    bool hayRentados = false;
    if(totalVehiculos == 0 ){
        Console.WriteLine("No hay vehículos registrados.");
        return;
    }
    for(int i=0; i<totalVehiculos; i++){
        if(vehiculo[i].Estado == "Rentado"){
            hayRentados = true;
            vehiculo[i].mostrarInformacion();
        }
    }
    if(!hayRentados){
            Console.WriteLine("No se encontró Vehiculos rentados.");
        }
}
public static void cambioEstado(Vehiculo[] vehiculo, int totalVehiculos){
    bool encontrado = false;
    if(totalVehiculos == 0 ){
        Console.WriteLine("No hay vehículos registrados.");
        return;
    }
    int buscarCodigo;
    Console.Write("Ingrese el código del vehículo: ");
    while (!int.TryParse(Console.ReadLine(), out buscarCodigo) || buscarCodigo <= 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
    }
    for(int i=0; i<totalVehiculos; i++){
        if(vehiculo[i].Codigo == buscarCodigo){
            encontrado = true;
            Console.WriteLine("\n Vehiculo encontrado:");
            vehiculo[i].mostrarInformacion();
            Console.WriteLine("Ingrese el nuevo Estado (Disponible, Rentado, En mantenimiento, Fuera de servicio):");
            string nuevoEstado = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(nuevoEstado) || (nuevoEstado != "Disponible" && nuevoEstado != "Rentado" && 
            nuevoEstado != "En Mantenimiento" && nuevoEstado != "Fuera de Sevicio ")){
                Console.Write("Estado inválido. Ingrese Disponible, Rentado, En mantenimiento, Fuera de servicio:");
                nuevoEstado = Console.ReadLine();
            }
            vehiculo[i].cambiarEstado(nuevoEstado);
            Console.WriteLine("\nEstado actualizado correctamente.\n");
            Console.WriteLine("Información actualizada:");
            vehiculo[i].mostrarInformacion();
            break;
        }
    }
    if(!encontrado){
        Console.WriteLine("No se encontró un vehículo con ese código.");
    }
}
public static void MostrarVehiculoMayorKilometraje(Vehiculo[] vehiculo, int totalVehiculos){
    if(totalVehiculos == 0 ){
        Console.WriteLine("No hay vehículos registrados.");
        return;
    }
    int posicionMayor = 0;
    for(int i=1; i<totalVehiculos; i++){
        if(vehiculo[i].Kilometros > vehiculo[posicionMayor].Kilometros){
            posicionMayor =i;
        }
        Console.WriteLine("===== VEHÍCULO CON MAYOR KILOMETRAJE =====");
        vehiculo[posicionMayor].mostrarInformacion();
    }
}
public static void CalcularPrecioPromedioRenta(Vehiculo[] vehiculo, int totalVehiculos){
    if(totalVehiculos == 0 ){
        Console.WriteLine("No hay vehículos registrados.");
        return;
    }
    double sumaPrecios = 0;
    int dias;
    Console.WriteLine("Ingrese la cantidad de días de renta: ");
    while (!int.TryParse(Console.ReadLine(), out dias) || dias <= 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
    }
    for(int i=0; i<totalVehiculos; i++){
        sumaPrecios += vehiculo[i].calcularCosto(dias);
    }
    double promedio = sumaPrecios /totalVehiculos;
    Console.WriteLine("El promedio de Renta es: " + promedio);

}
public static void CantidadVehiculosPorTipo(Vehiculo[] vehiculo, int totalVehiculos){
     if(totalVehiculos == 0 ){
        Console.WriteLine("No hay vehículos registrados.");
        return;
    }
    int contadorAutomoviles = 0;
    int contadorCamionetas = 0;
    int contadorMotocicletas = 0;
    for(int i=0; i<totalVehiculos; i++){
        if(vehiculo[i] is Automovil){
            contadorAutomoviles++;
        }
        if(vehiculo[i] is Camioneta){
            contadorCamionetas++;
        }
        if(vehiculo[i] is Motocicleta){
            contadorMotocicletas++;
        }
    }
    Console.Write("===== CANTIDAD DE VEHÍCULOS POR TIPO =====");
    Console.Write("Automóviles: " + contadorAutomoviles);
    Console.Write("Camionetas: " + contadorCamionetas);
    Console.Write("Motocicletas: " + contadorMotocicletas);
    Console.Write("Total de vehículos: " + totalVehiculos);    

}
public static void RealizarMantenimiento(Vehiculo[] vehiculo, int totalVehiculos){
    if(totalVehiculos == 0 ){
        Console.WriteLine("No hay vehículos registrados.");
        return;
    }
    bool encontrado = false;
    int buscarCodigo;
     Console.WriteLine("Ingrese el codigo: ");
     while (!int.TryParse(Console.ReadLine(), out buscarCodigo) || buscarCodigo <= 0){
        Console.Write("Error. Ingrese un código numérico mayor que 0: ");
    }
    for(int i=0; i<totalVehiculos; i++){
        if(vehiculo[i].Codigo == buscarCodigo){
            encontrado = true;
            Console.WriteLine("\n===== VEHÍCULO ENCONTRADO =====");
            vehiculo[i].mostrarInformacion();
            Console.WriteLine("\n===== RESULTADO DEL MANTENIMIENTO =====");
            IMantenimiento mantenimiento = (IMantenimiento)vehiculo[i];
            mantenimiento.realizarMantenimiento();
            break;
        }
    }
    if(!encontrado){
            Console.WriteLine("No se encontró un vehículo con ese código.");
        }
}
public static int MostrarMenu(){
    int op;
    do{
        Console.WriteLine("========================================");
        Console.WriteLine("=====SISTEMA DE RENTA DE VEHÍCULOS  =====");
        Console.WriteLine("========================================");
        Console.WriteLine("1.- Registrar vehículo.");
        Console.WriteLine("2.- Mostrar todos los vehículos.");
        Console.WriteLine("3.- Buscar vehículo por código");
        Console.WriteLine("4.- Mostrar vehículos disponibles");
        Console.WriteLine("5.- Mostrar vehículos rentados.");
        Console.WriteLine("6.- Cambiar estado.");
        Console.WriteLine("7.- Vehículo con mayor kilometraje.");
        Console.WriteLine("8.- Calcular precio promedio de renta.");
        Console.WriteLine("9.- Cantidad de vehículos por tipo.");
        Console.WriteLine("10.- Realizar mantenimiento.");
        Console.WriteLine("11.- Salir ");
        Console.WriteLine("Seleccione una opcion: ");
        if (int.TryParse(Console.ReadLine(), out op) && op >= 1 && op <= 11){
            return op;
        }
        Console.WriteLine("Error. Debe seleccionar una opcion valida. ");
        Console.WriteLine();
    }while(true);
}

}
 