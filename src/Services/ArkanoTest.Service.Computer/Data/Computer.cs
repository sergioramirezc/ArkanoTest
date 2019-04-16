using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ArkanoTest.Service.Computer.Data
{
    public class Computer
    {
        /// <summary>
        /// Computer Identifier
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Serial Number of the Computer
        /// </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// Tag of the Computer
        /// </summary>
        public string ItemTag { get; set; }
        /// <summary>
        /// Model of the Computer
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// RAM of the Computer
        /// </summary>
        public virtual RAM Ram { get; set; }
        /// <summary>
        /// HDD of the Computer
        /// </summary>
        public virtual HDD Hdd { get; set; }
        /// <summary>
        /// SSD of the computer
        /// </summary>
        public virtual SSD Ssd { get; set; }
        /// <summary>
        /// Processor of the Computer
        /// </summary>
        public virtual Processor Processor { get; set; }
        /// <summary>
        /// Brand of the Computer
        /// </summary>
        public virtual Brand Brand { get; set; }
        /// <summary>
        /// Computer Asigned to
        /// </summary>
        public string AsignedTo { get; set; }
    }
}