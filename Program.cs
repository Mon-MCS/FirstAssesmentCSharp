using static System.Console;
using Equipamiento;
using Equip.Futbol;
using Equip.Baloncesto;
using Equip.Rugby;
namespace ProgramaPrincipal
{
    public class Program
    {
        public static void Main()
        {
            Clear();
            Write("Ingrese el nombre de equipamiento (Futbol, Basketball o Rugby): ");
            string? nombre = ReadLine();

            EquipamientoDeportivo? equipamiento = null;
                
            Write("Ingrese el precio del equipamiento: ");
            double precio = Convert.ToDouble(ReadLine());

            switch (nombre!.ToLower()) {
            case "futbol":
                Write("Ingrese la talla del equipamiento: ");
                string? tallaFutbol = ReadLine();

                equipamiento = new EquipamientoFutbol("Futbol", precio, tallaFutbol!);
                break;

            case "basketball":
                Write("Ingrese la talla del equipamiento: ");
                string? tallaBasketball = ReadLine();

                Write("Ingrese el material del equipamiento: ");
                string? materialBasketball = ReadLine();

                equipamiento = new EquipamientoBasketball("Basketball", precio, tallaBasketball!, materialBasketball!);
                break;

            case "rugby":
                Write("Ingrese el peso del equipamiento: ");
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
        }
    }
}

