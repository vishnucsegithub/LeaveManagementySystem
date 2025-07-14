﻿using LeaveManagement.web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.web.Models
{
    public class LeaveRequestVM : LeaveRequestCreateVM
    {
        public int Id { get; set; }
        [Display(Name = "Leave Name")]
        public LeaveTypeVM LeaveType { get; set; }  

        [Display (Name = "Requested Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date)]

        public DateTime DateRequested { get; set; }
       
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
        public string? RequestingEmployeeId { get; set; }
        public EmployeeListVM Employee { get; set; }

    }
}
