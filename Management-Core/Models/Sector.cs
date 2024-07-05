using System.ComponentModel.DataAnnotations;

namespace Management_Core.Models
{
    public class Sector
    {
        [Key]
        public int SectorID { get; set; }
        public string SectorName { get; set; }
        public IList<Employee> Employees { get; set; }
    }
}
