using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rollout.Data.EntityModels
{
    public class WorkStations
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int WorkStationId { get; set; }
        public string Serialnumber { get; set; }
        public DateTime EmissionsReport { get; set; }
        public int Ticketnumber { get; set; }

        // ForeignKeys
        public Domain Domain { get; set; }
        public StorageLocation StorageLocation { get; set; }
        public WorkSteps WorkSteps { get; set; }
        public Battery Battery { get; set; }
        public WorkStationState WorkStationState { get; set; }
        public Customer customer { get; set; }

    }
}
