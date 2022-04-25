using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class EmployeeForCreationDto
    {
        [Required(ErrorMessage = "Employee name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age is required and it can't be lower than 18")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Postion is a required field")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Position is 20characters.")]
        public string Position { get; set; }
    }
}
