﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace WRM_TrashRecyclePopulation.WRM_EntityFramework.WRM_TrashRecycle.Models
{
    public partial class Resident
    {
        public Resident()
        {
            BackDoorPickup = new HashSet<BackDoorPickup>();
        }

        public int ResidentId { get; set; }
        public int? AddressId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<BackDoorPickup> BackDoorPickup { get; set; }
    }
}