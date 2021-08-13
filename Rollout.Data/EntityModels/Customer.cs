using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rollout.Data.EntityModels
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CustomerId { get; set; }
        public string GivenName { get; set; }
        public string SureName { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string EmailAddress { get; set; }
        public string Location { get; set; }
        public string LocationDescription { get; set; }
        public int PostalCode { get; set; }
        public string StreetAdress { get; set; }

        //Foreignkey

        public List<WorkStations> WorkStations { get; set; }

        public static void AddCustomer(string name)
        {
            // Add method to add a Customer
        }
        public static void RemoveStorageCustomer(int primaryKey)
        {
            // Add method to add aCustomer
        }
        public static void setGivenName(string name)
        {
            // pass
        }
        public static void setSureName(string name)
        {
            // pass
        }
        public static void setPhoneNumber(string name)
        {
            // pass
        }
        public static void setCountry(string name)
        {
            // pass
        }
        public static void setEmailAddress(string name)
        {
            // pass
        }
        public static void setLocation(string name)
        {
            // pass
        }
        public static void setLocationDescription(string name)
        {
            // pass
        }
        public static void setPostalCode(string name)
        {
            // pass
        }
        public static void setStreetAdress(string name)
        {
            // pass
        }

        public object getCustomer() {
            return this.CustomerId;
        }
    }
}
