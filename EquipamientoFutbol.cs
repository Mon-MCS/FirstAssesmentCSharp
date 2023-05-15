using Equipamiento;
namespace Equip.Futbol
{
    class EquipamientoFutbol : EquipamientoDeportivo {
        public string talla;
        
        public EquipamientoFutbol(string nombre, double precio, string talla) : base(nombre, precio) {
            this.talla = talla;
        }
        
        public override string Descripcion() {
            return $"Equipamiento para {nombre}, talla {talla}, precio: {precio}";
        }
    }

}