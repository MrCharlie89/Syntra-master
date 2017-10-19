using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra.Models
{
    /// <summary>
    /// This is the entity af a client
    /// </summary>
    public class Client
    {
        /// <summary>
        ///gets/sets the first name of the client
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets/sets the last name of the client
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// Gets/sets the birthdate of the client
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets/sets the gender of the client
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets/sets the adress of the client
        /// </summary>
        public Adress Adress { get; set; }

        /// <summary>
        /// Gets/sets the contact records of the client
        /// </summary>
        public ContactRecord ContactRecord { get; set; }
    }

}
