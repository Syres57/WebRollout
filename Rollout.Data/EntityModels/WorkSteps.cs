using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Rollout.Data;
using System.Linq;

namespace Rollout.Data.EntityModels
{
    public class WorkSteps
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int StepId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MinDuration { get; set; }
        public int MaxDuration { get; set; }

        //foreignkey

        public static void AddStep(string name, string description, int minDuration, int maxDuration) { 
            // Add method to add a WorkStep            
        }
        public static void RemoveStep(int PrimaryKey)
        {
            // Add method to remove WorkStep
        }

    }
}
