using System.ComponentModel.DataAnnotations;

namespace ContactManagerAPI.Models
{
    public class Contact
    {
        // define data structure of payload
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string? Salutation { get; set; }

        [Required]
        [MinLength(3)]
        public string? Firstname { get; set; }

        [Required]
        [MinLength(3)]
        public string? Lastname { get; set; }

        public string? Displayname
        {
            get
            {
                if (string.IsNullOrEmpty(Salutation) || string.IsNullOrEmpty(Firstname) || string.IsNullOrEmpty(Lastname))
                {
                    return null;
                }

                return $"{Salutation} {Firstname} {Lastname}";
            }
            set { }
        }

        public DateTime? Birthdate { get; set; }

        [Required]
        public DateTime CreationTimestamp { get; set; } = DateTime.UtcNow;

        public DateTime? LastChangeTimestamp { get; set; }

        public bool NotifyHasBirthdaySoon
        {
            get
            {
                if (Birthdate.HasValue)
                {
                    var daysUntilBirthday = (Birthdate.Value - DateTime.UtcNow).Days;

                    return daysUntilBirthday >= 0 && daysUntilBirthday <= 14;
                }

                return false;
            }
            set { }
        }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        public string? Phonenumber { get; set; }
    }
}
