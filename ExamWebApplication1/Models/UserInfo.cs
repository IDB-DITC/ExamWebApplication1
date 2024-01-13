using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamWebApplication1.Models
{
    [Table("UserInfo")]
	public class UserInfo
	{
        [Key]
        public Guid UserId { get; set; } = Guid.NewGuid();
        [Required]
        [StringLength(50,MinimumLength = 4)]
        public string UserName { get; set; }
        [Required]
		[StringLength(50, MinimumLength = 6)]
        [DataType(DataType.Password)]
		public string Password { get; set; }

        [EnumDataType(typeof(UserRole))]
        public UserRole Role { get; set; }

	}

    public enum UserRole
    {
        Admin, User, Student, Teacher
    }
}