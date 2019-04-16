using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArkanoTest.Service.Computer.Data
{
    public class HDD
    {
        /// <summary>
        /// HDD Identifier
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Revolutions per minutes of the HDD
        /// </summary>
        public string Rpm { get; set; }
        public virtual StorageDrive StorageDrive { get; set; }
    }
}