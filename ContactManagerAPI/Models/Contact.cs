using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactManagerAPI.Models
{

    /// <summary>
    /// Represents a contact entity.
    /// </summary>
    [Index(nameof(Email), IsUnique = true)]
    public class Contact
    {
        private string _displayName;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }

        [Required]
        [MinLength(3)]
        public string Salutation { get; set; }

        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        public string LastName { get; set; }

        public string DisplayName
        {
            get
            {
                if (string.IsNullOrEmpty(_displayName))
                {
                    _displayName = $"{Salutation} {FirstName} {LastName}";
                }
                return _displayName;
            }
            set
            {
                _displayName = value;
            }
        }
        /// <summary>
        /// Date of birth of the person in yyyy-MM-dd format.
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The timestamp of when the record was created.
        /// </summary>
        /// <remarks>
        /// This value is computed by the database and cannot be modified.
        /// </remarks>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationTimestamp { get; private set; }

        /// <summary>
        /// The timestamp of when the record was last changed.
        /// </summary>
        /// <remarks>
        /// This value is automatically set to the current UTC time when the property is modified.
        /// </remarks>
        private DateTime _lastChangeTimestamp;
        public DateTime LastChangeTimestamp
        {
            get
            {
                return _lastChangeTimestamp;
            }
            private set
            {
                _lastChangeTimestamp = DateTime.UtcNow;
            }
        }
        
        public bool NotifyHasBirthdaySoon
        {
            get
            {
                if (BirthDate.HasValue)
                {
                    var daysUntilBirthday = (BirthDate.Value - DateTime.UtcNow).Days;

                    return daysUntilBirthday >= 0 && daysUntilBirthday <= 14;
                }

                return false;
            }
            private set { }
        }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string? PhoneNumber { get; set; }
    }
}
