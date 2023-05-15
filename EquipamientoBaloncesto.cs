using Equipamiento;
namespace Equip.Baloncesto
{
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
}