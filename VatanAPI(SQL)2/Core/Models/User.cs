using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using VatanAPI.Domain.Models;

namespace VatanAPI.Core.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(255)]
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public ICollection<UserRole> UserRoles { get; set; } = new Collection<UserRole>();
        public IList<Sepet> Sepetler { get; set; }
        public IList<Siparis> Siparisler { get; set; }
    }
}