using Core.Entities;


namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public int CategoryId { get; set; }
        public String QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
    }
}
