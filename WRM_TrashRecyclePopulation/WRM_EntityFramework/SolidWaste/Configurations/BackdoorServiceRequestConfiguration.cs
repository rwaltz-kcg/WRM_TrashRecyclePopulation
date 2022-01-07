﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using WRM_TrashRecyclePopulation.WRM_EntityFramework.SolidWaste;
using WRM_TrashRecyclePopulation.WRM_EntityFramework.SolidWaste.Models;

namespace WRM_TrashRecyclePopulation.WRM_EntityFramework.SolidWaste.Configurations
{
    public partial class BackdoorServiceRequestConfiguration : IEntityTypeConfiguration<BackdoorServiceRequest>
    {
        public void Configure(EntityTypeBuilder<BackdoorServiceRequest> entity)
        {
            entity.HasKey(e => e.BackdoorId);

            entity.ToTable("BackdoorService_Request");

            entity.Property(e => e.BackdoorId).HasColumnName("Backdoor_ID");

            entity.Property(e => e.AltName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Alt_Name");

            entity.Property(e => e.AltPhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Alt_Phone");

            entity.Property(e => e.ChoosingNotToSignUpForBackdoorService)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Choosing_Not_To_Sign_Up_for_Backdoor_Service");

            entity.Property(e => e.City)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("COMMENTS");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Created_By");

            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation_Date");

            entity.Property(e => e.CurrentlyEnrolledInCurbSideRecycling)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Currently_Enrolled_In_Curb_Side_Recycling");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("First_Name");

            entity.Property(e => e.LastName)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("Last_Name");

            entity.Property(e => e.LastUpdatedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Last_Updated_By");

            entity.Property(e => e.LastUpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Updated_Date");

            entity.Property(e => e.MedicalNeedForBackdoorService)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Medical_Need_For_Backdoor_Service");

            entity.Property(e => e.Over75NoOneToTransportCans)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Over_75_No_One_To_Transport_Cans");

            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("Phone_Number");

            entity.Property(e => e.PointX)
                .HasColumnType("numeric(18, 8)")
                .HasColumnName("POINT_X");

            entity.Property(e => e.PointY)
                .HasColumnType("numeric(18, 8)")
                .HasColumnName("POINT_Y");

            entity.Property(e => e.Recycler)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.SaveDuplicate)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatusDate)
                .HasColumnType("datetime")
                .HasColumnName("Status_Date");

            entity.Property(e => e.StreetName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Street_Name");

            entity.Property(e => e.StreetNamePrefix)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Street_Name_Prefix");

            entity.Property(e => e.StreetNameSuffix)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Street_Name_Suffix");

            entity.Property(e => e.StreetNumber).HasColumnName("Street_Number");

            entity.Property(e => e.StreetSuffixDirection)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Street_Suffix_Direction");

            entity.Property(e => e.UnitNumber)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Unit_Number");

            entity.Property(e => e.WantsRecyclingCart)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Wants_Recycling_Cart");

            entity.Property(e => e.WantsToEnrollInFeeBasedService)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Wants_To_Enroll_In_Fee_Based_Service");

            entity.Property(e => e.ZipCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Zip_Code");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<BackdoorServiceRequest> entity);
    }
}
