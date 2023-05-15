## Escenario de Equipamiento deportivo: Código 11

Usted ha sido contratado para trabajar como `CSharp developer` en una empresa local de su ciudad.

El negocio central es la comercialización de Equipamiento:

Usted iniciará un proyecto que incluirá la elaboración de `site` en Internet para la gestión de las Equipamiento.

Las Equipamiento que se comercializan son de Futbol, Baketballs y Rugby, pero próximamente se añadirán mas variedades a la comercialización según como vayan siendo cerrados acuerdos con las federaciones y clubes deportivos más próximos.

Debe crear el proyecto de iniciación para comenzar a desarrollar en las siguientes jornadas toda la aplicación.

Hoy deberá entregar la validación de funcionalidad, con la jerarquía de clases, y con el funcionamiento de una aplicación de consola; incluyendo toda la información proporcionada en este documento. Y completarlas según las instrucciones recibidas.

- Jerarquía de clases

```
Equipamiento Deportivo: EquipamientoFutbol, EquipamientoBaketball, EquipamientoRugby.
```

``` CSharp
abstract class EquipamientoDeportivo {
    public string nombre;
    public double precio;
    
    public EquipamientoDeportivo(string nombre, double precio) {
        this.nombre = nombre;
        this.precio = precio;
    }
    
    public abstract string Descripcion();
}

class EquipamientoFutbol : EquipamientoDeportivo {
    public string talla;
    
    public EquipamientoFutbol(string nombre, double precio, string talla) : base(nombre, precio) {
        this.talla = talla;
    }
    
    public override string Descripcion() {
        return $"Equipamiento para {nombre}, talla {talla}, precio: {precio}";
    }
}

class EquipamientoBasketball : EquipamientoDeportivo {
    public string talla;
    public string material;
    
    public EquipamientoBasketball(string nombre, double precio, string talla, string material) : base(nombre, precio) {
        this.talla = talla;
        this.material = material;
    }
    
    public override string Descripcion() {
        return $"Equipamiento para {nombre}, talla {talla}, hecho de {material}, precio: {precio}";
    }
}

class EquipamientoRugby : EquipamientoDeportivo {
    public double peso;
    
    public EquipamientoRugby(string nombre, double precio, double peso) : base(nombre, precio) {
        this.peso = peso;
    }
    
    public override string Descripcion() {
        return $"Equipamiento para {nombre} con peso de {peso}, precio: {precio}";
    }
}
```

####  Aplicación principal

```CSharp
Clear();
Write("Ingrese el nombre de equipamiento (Futbol, Basketball o Rugby):");
string? nombre = ReadLine();

EquipamientoDeportivo? equipamiento = null;
    
Write("Ingrese el precio del equipamiento:");
double precio = Convert.ToDouble(ReadLine());

switch (nombre!.ToLower()) {
case "futbol":
    Write("Ingrese la talla del equipamiento:");
    string? tallaFutbol = ReadLine();

    equipamiento = new EquipamientoFutbol("Futbol", precio, tallaFutbol!);
    break;

case "basketball":
    Write("Ingrese la talla del equipamiento:");
    string? tallaBasketball = ReadLine();

    Write("Ingrese el material del equipamiento:");
    string? materialBasketball = ReadLine();

    equipamiento = new EquipamientoBasketball("Basketball", precio, tallaBasketball!, materialBasketball!);
    break;

case "rugby":
    Write("Ingrese el peso del equipamiento:");
    double pesoRugby = Convert.ToDouble(ReadLine());

    equipamiento = new EquipamientoRugby("Rugby", precio, pesoRugby);
    break;

default:
    WriteLine("Tipo de equipamiento no válido.");
    break;
}
if (equipamiento != null)
{
    WriteLine(equipamiento.Descripcion());
}
Write("Entre cualquier tecla");
ReadKey();
```

