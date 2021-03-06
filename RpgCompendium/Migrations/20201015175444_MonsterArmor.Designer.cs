﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RpgCompendium.Models;

namespace RpgCompendium.Migrations
{
    [DbContext(typeof(RpgCompendiumContext))]
    [Migration("20201015175444_MonsterArmor")]
    partial class MonsterArmor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RpgCompendium.Models.Armor", b =>
                {
                    b.Property<int>("ArmorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArmorDescription");

                    b.Property<string>("ArmorName");

                    b.Property<string>("ArmorSlot");

                    b.HasKey("ArmorId");

                    b.ToTable("Armors");
                });

            modelBuilder.Entity("RpgCompendium.Models.Behavior", b =>
                {
                    b.Property<int>("BehaviorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BehaviorDescription");

                    b.Property<string>("BehaviorName");

                    b.HasKey("BehaviorId");

                    b.ToTable("Behaviors");
                });

            modelBuilder.Entity("RpgCompendium.Models.MainType", b =>
                {
                    b.Property<int>("MainTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MainTypeDescription");

                    b.Property<string>("MainTypeName");

                    b.HasKey("MainTypeId");

                    b.ToTable("MainTypes");
                });

            modelBuilder.Entity("RpgCompendium.Models.Monster", b =>
                {
                    b.Property<int>("MonsterId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MonsterName");

                    b.HasKey("MonsterId");

                    b.ToTable("Monsters");
                });

            modelBuilder.Entity("RpgCompendium.Models.MonsterArmor", b =>
                {
                    b.Property<int>("MonsterArmorId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArmorId");

                    b.Property<string>("ArmorSlot");

                    b.Property<int>("MonsterId");

                    b.HasKey("MonsterArmorId");

                    b.HasIndex("ArmorId");

                    b.HasIndex("MonsterId");

                    b.ToTable("MonsterArmor");
                });

            modelBuilder.Entity("RpgCompendium.Models.MonsterBehavior", b =>
                {
                    b.Property<int>("MonsterBehaviorId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BehaviorId");

                    b.Property<int>("MonsterId");

                    b.HasKey("MonsterBehaviorId");

                    b.HasIndex("BehaviorId");

                    b.HasIndex("MonsterId");

                    b.ToTable("MonsterBehaviors");
                });

            modelBuilder.Entity("RpgCompendium.Models.MonsterMainType", b =>
                {
                    b.Property<int>("MonsterMainTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MainTypeId");

                    b.Property<int>("MonsterId");

                    b.HasKey("MonsterMainTypeId");

                    b.HasIndex("MainTypeId");

                    b.HasIndex("MonsterId");

                    b.ToTable("MonsterMainTypes");
                });

            modelBuilder.Entity("RpgCompendium.Models.MonsterArmor", b =>
                {
                    b.HasOne("RpgCompendium.Models.Armor", "Armor")
                        .WithMany("Monsters")
                        .HasForeignKey("ArmorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RpgCompendium.Models.Monster", "Monster")
                        .WithMany("Armors")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RpgCompendium.Models.MonsterBehavior", b =>
                {
                    b.HasOne("RpgCompendium.Models.Behavior", "Behavior")
                        .WithMany("Monsters")
                        .HasForeignKey("BehaviorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RpgCompendium.Models.Monster", "Monster")
                        .WithMany("Behaviors")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RpgCompendium.Models.MonsterMainType", b =>
                {
                    b.HasOne("RpgCompendium.Models.MainType", "MainType")
                        .WithMany("Monsters")
                        .HasForeignKey("MainTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RpgCompendium.Models.Monster", "Monster")
                        .WithMany("MainTypes")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
