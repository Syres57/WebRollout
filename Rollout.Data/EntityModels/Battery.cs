using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rollout.Data.EntityModels
{
    public class Battery
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int BatteryId { get; set; }
        public string BatteryChange { get; set; }
        public string ChargeDate { get; set; }

        //foreignkey

    }
}
