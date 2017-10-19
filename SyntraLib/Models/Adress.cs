namespace Syntra.Models
{
    public class Adress : BaseEntity
    {
        public string Street { get; set; }

        public string Housenumber { get; set; }

        public string Appartment { get; set; }

        public string Zipcode { get; set; }

        public string City { get; set; }

        public Country Country { get; set; }
    }


}