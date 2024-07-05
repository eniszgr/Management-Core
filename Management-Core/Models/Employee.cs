using System.ComponentModel.DataAnnotations;

namespace Management_Core.Models
{
    public class Employee
    {

        [Key]
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }    
        public int SectorID { get; set; }

        public Sector Sectors { get; set; }
    }
}
