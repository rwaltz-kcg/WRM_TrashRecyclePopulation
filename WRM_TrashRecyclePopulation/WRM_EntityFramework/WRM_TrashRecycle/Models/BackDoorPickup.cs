﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WRM_TrashRecyclePopulation.WRM_EntityFramework.WRM_TrashRecycle.Models
{
    public partial class BackDoorPickup
    {
        public int BackDoorPickupId { get; set; }
        public int ResidentId { get; set; }
        public int? AddressId { get; set; }
        public string BackdoorType { get; set; }
        public string BackdoorStatus { get; set; }
        public DateTime? BackdoorStatusDate { get; set; }
        public DateTime? BackdoorApprovalDate { get; set; }
        public DateTime? BackdoorWithdrawalDate { get; set; }
        public string Note { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual Address Address { get; set; }
        public virtual Resident Resident { get; set; }
    }
}