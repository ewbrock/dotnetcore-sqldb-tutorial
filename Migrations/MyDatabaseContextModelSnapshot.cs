using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DotNetCoreSqlDb.Models;

namespace DotNetCoreSqlDb.Migrations
{
    [DbContext(typeof(MyDatabaseContext))]
    partial class MyDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("DotNetCoreSqlDb.Models.Climate", b =>
                {
                    b.Property<int>("ClimateID")
                        .ValueGeneratedOnAdd();
                    b.Property<string>("Name");
                    b.Property<string>("Description");
                    b.Property<string>("Rain_in_Winter");
                    b.Property<string>("Rain_during_Growing_Season");
                    b.Property<string>("Rain_during_Harvest");
                    b.Property<string>("Temp_in_Winter");                    
                    b.Property<string>("Temp_during_Growing_Season");
                    b.Property<string>("Temp_Continentality");                    
                    b.Property<string>("Temp_Diurnal");                    
                    b.Property<string>("Vintage_Variation");                    
                    b.Property<string>("Proximity_to_Large_Bodies_of_Water");                    
                    b.HasKey("ClimateID");

                    b.ToTable("Climate");
                });
        }
    }
}
