using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArkanoTest.Service.Computer.Data
{
    public class SSD
    {
        /// <summary>
        /// SSD Identifier
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Interface connector of the SSD
        /// </summary>
        public string Interface { get; set; }
        public virtual StorageDrive StorageDrive { get; set; }
    }
}