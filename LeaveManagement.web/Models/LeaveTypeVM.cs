using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace LeaveManagement.web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Default Number of Days")]
        [Required]
        [Range (0, 30 ,ErrorMessage = "Enter Valid range between 0 to 30")]
        public int DefaultDays { get; set; }
    }
}
