using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArkanoTest.Service.Computer.Data
{
    public class Brand
    {
        /// <summary>
        /// Brand Identifier
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Name of the Brand
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the Brand
        /// </summary>
        public string Description { get; set; }

    }
}