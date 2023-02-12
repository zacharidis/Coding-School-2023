using CoffeeShop.Model.Enums;

namespace CoffeeShop.Web.Models.EmployeeDTO
{
    public class EmployeeDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
}
