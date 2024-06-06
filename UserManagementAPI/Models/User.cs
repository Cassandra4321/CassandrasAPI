using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagementAPI.Models
{
    [Table("AspNetUsers")]
    public class User
    {
        public string Id { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
    }
}
