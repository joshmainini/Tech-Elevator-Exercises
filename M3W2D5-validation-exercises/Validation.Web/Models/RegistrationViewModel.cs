using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Web.Models
{
    public class RegistrationViewModel
    {
		[Required]
		[MaxLength(20, ErrorMessage = "Name cannot exceed 20 characters")]
		public string FirstName { get; set; }

		[Required]
		[MaxLength(20, ErrorMessage = "Name cannot exceed 20 characters")]
		public string LastName { get; set; }

		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required]
		[MinLength(8, ErrorMessage = "Password must be 8 characters or more")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Compare("Password")]
		[DataType(DataType.Password)]
		public string ConfirmPassword { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime BirthDate { get; set; }

		[Required]
		[Range(1,10)]
		public int NumberOfTickets { get; set; }


	}
}
	