using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.web.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id {  get; set; }
        [Display (Name =  "Number of Days")]
        [Required]
        [Range(1,40,ErrorMessage ="Invalid number please enter number in range of 1 to 40")]
        public int NumberOfdays { get; set; }
        [Display(Name = "Allocation Period")]
        [Required]

        public int Period { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }
    }
}