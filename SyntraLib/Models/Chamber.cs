using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra.Models
{
    /// <summary>
    /// this is the entity of the chamnber
    /// </summary>
    public class Chamber : BaseEntity
    {
        /// <summary>
        /// Gets/sets the chamber type
        /// </summary>
        public Chambertype Type { get; set; }

        private decimal? _price;

        /// <summary>
        /// Gets/sets the price of the chamber
        /// When the price has no value or is equal of lower than 0
        /// then it takes the default price, defined by the chambertype.
        /// </summary>
        public decimal Price
        {
            get
            {
                if (!_price.HasValue || _price <= 0)
                {
                    _price = Type.DefaultPrice;
                }

                return _price.Value;
            }
            set { _price = value; }
        }

        /// <summary>
        /// Get/sets the capasity of the chamber
        /// </summary>
        public uint Capacity { get; set; }



        /// <summary>
        /// Default constructor
        /// </summary>
        public Chamber() : base()
        {
            Capacity = 1;
        }

    }
}
