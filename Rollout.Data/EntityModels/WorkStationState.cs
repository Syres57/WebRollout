using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rollout.Data.EntityModels
{
    public class WorkStationState
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string WorkStationStateId { get; set; }
        public string StateName { get; set; }
    }
}
