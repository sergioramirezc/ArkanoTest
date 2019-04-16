using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArkanoTest.Service.Computer.Data
{
    public class RAM
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Brand of the RAM
        /// </summary>
        public virtual Brand Brand { get; set; }
        /// <summary>
        /// Capacity of the RAM in GB
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// Tag of the RAM
        /// </summary>
        public string ItemTag { get; set; }
        /// <summary>
        /// Serial Number of the RAM
        /// </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// Serial Number of the RAM
        /// </summary>
        public string Standart { get; set; }
        /// <summary>
        /// Computer Assigned
        /// </summary>
        public virtual Computer Computer { get; set; }
    }
}