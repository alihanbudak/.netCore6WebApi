using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace NLayer.Core.Models
{
    public class User : BaseEntity
    {
        public string UserName { get; set; } = string.Empty;
        [MaxLength(byte.MaxValue)]
        public byte[] PasswordHash { get; set; } = Array.Empty<byte>();
        [MaxLength(byte.MaxValue)]
        public byte[] PasswordSalt { get; set; } = Array.Empty<byte>();
    }
}
