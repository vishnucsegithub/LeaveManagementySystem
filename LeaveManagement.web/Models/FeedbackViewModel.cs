using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.web.Models
{
    public class FeedbackViewModel
    {   
        [Required]
        
        public int Id { get; set; }
       
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        
        public string Email { get; set; }
        [Required]

        public string Feedback { get; set; }
    }
}
