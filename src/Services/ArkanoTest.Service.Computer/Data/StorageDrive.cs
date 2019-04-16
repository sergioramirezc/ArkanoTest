using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArkanoTest.Service.Computer.Data
{
    public class StorageDrive
    {
        /// <summary>
        /// Storage Drive Identifier
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Model of the Storage Drive
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Capacity of the Storage Drive in GB
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// Tag of the Storage Drive
        /// </summary>
        public string ItemTag { get; set; }
        /// <summary>
        /// Brand of the Storage Drive
        /// </summary>
        public virtual Brand Brand { get; set; }
    }
}