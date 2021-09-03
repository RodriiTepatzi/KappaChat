using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kappa.Models
{
    class UserModel
    {
        /// <summary>
        /// Gets or sets the id of the user
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the user
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the country of the user
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the telephone number country of the user
        /// </summary>
        public string TNumber { get; set; }

    }
}
