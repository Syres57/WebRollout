using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rollout.Data.EntityModels
{
    public class Domain
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int DomainId { get; set; }

        public string Name { get; set; }

        //foreignkey

        public static void AddDomain(string name, string description, int minDuration, int maxDuration)
        {
            // Add method to add a Domain
        }
        public static void RemoveDomain(string name, string description, int minDuration, int maxDuration)
        {
            // Add method to add a Domain
        }


    }
}
