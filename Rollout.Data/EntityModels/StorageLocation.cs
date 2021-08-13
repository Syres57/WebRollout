using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rollout.Data.EntityModels
{
    public class StorageLocation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int LocationId { get; set; }
        public string Name { get; set; }

        //foreignkey

        // Methods

        public static void AddLocation(string name)
        {
            // Add method to add a StorageLocation
        }
        public static void RemoveStorageLocation(int primaryKey)
        {
            // Add method to add a StorageLocation
        }
        public static void ChangeStorageLocationName(string name)
        {
            // Change method to change StorageLocation Name
        }

    }
}
