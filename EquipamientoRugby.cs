using Equipamiento;
namespace Equip.Rugby
{
    class EquipamientoRugby : EquipamientoDeportivo {
        public double peso;
        
        public EquipamientoRugby(string nombre, double precio, double peso) : base(nombre, precio) {
            this.peso = peso;
        }
        
        public override string Descripcion() {
            return $"Equipamiento para {nombre} con peso de {peso}, precio: {precio}";
        }
    }
}
