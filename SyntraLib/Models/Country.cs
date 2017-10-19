namespace Syntra.Models
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }

        public string ISO { get; set; }

        public bool IsActive { get; set; }

        public bool IsDefault { get; set; }

        public Country() : base()
        {
            IsActive = true;
            IsDefault = false;
        }

        public Country(string name, string iso, bool IsActive = true, bool IsDefault = false)
        {
            this.Name = name;
            this.ISO = iso;
            this.IsActive = IsActive;
            this.IsDefault = IsDefault;

        }
    }
}