
namespace Equipamiento{
    abstract class EquipamientoDeportivo {
        public string nombre;
        public double precio;
        
        public EquipamientoDeportivo(string nombre, double precio) {
            this.nombre = nombre;
            this.precio = precio;
        }
        
        public abstract string Descripcion();
    }

}