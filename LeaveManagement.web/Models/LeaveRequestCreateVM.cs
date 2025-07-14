using LeaveManagement.web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.web.Models
{
    public class LeaveRequestCreateVM: IValidatableObject
    {
        [Required]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
        [Required]
        [Display(Name = "Leave")]
        public int LeaveTypeId { get; set; }
        public SelectList? LeaveTypes { get; set; }
        [Display(Name = "Description")]
        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            
            if (StartDate > EndDate)
            {
                yield  return new ValidationResult("Start Date must be before end date", new[] {nameof(StartDate),nameof(EndDate)});
            }
            if (RequestComments?.Length > 500)
            {
                yield return new ValidationResult("Too Long Description", new[] {nameof(RequestComments)});
            }
        }
    }
}
