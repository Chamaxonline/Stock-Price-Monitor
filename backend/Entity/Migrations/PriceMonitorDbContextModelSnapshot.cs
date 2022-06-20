﻿// <auto-generated />
using System;
using Entity.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entity.Migrations
{
    [DbContext(typeof(PriceMonitorDbContext))]
    partial class PriceMonitorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.Models.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<double>("PriceTag")
                        .HasColumnType("float");

                    b.Property<int>("SourceId")
                        .HasColumnType("int");

                    b.Property<int>("TickerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Price");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            PriceTag = 131.31386595454248,
                            SourceId = 1,
                            TickerId = 1,
                            Time = new DateTime(2022, 6, 20, 9, 49, 39, 751, DateTimeKind.Local).AddTicks(6434)
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            PriceTag = 146.20859177221479,
                            SourceId = 1,
                            TickerId = 2,
                            Time = new DateTime(2022, 6, 20, 9, 5, 39, 751, DateTimeKind.Local).AddTicks(8691)
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            PriceTag = 138.99798161384089,
                            SourceId = 1,
                            TickerId = 3,
                            Time = new DateTime(2022, 6, 20, 8, 46, 39, 751, DateTimeKind.Local).AddTicks(8732)
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            PriceTag = 143.07399778850564,
                            SourceId = 2,
                            TickerId = 1,
                            Time = new DateTime(2022, 6, 20, 10, 6, 39, 751, DateTimeKind.Local).AddTicks(8737)
                        },
                        new
                        {
                            Id = 5,
                            Active = true,
                            PriceTag = 146.49737605276863,
                            SourceId = 2,
                            TickerId = 2,
                            Time = new DateTime(2022, 6, 20, 7, 47, 39, 751, DateTimeKind.Local).AddTicks(8741)
                        },
                        new
                        {
                            Id = 6,
                            Active = true,
                            PriceTag = 150.47869721064748,
                            SourceId = 2,
                            TickerId = 3,
                            Time = new DateTime(2022, 6, 20, 9, 46, 39, 751, DateTimeKind.Local).AddTicks(8745)
                        },
                        new
                        {
                            Id = 7,
                            Active = true,
                            PriceTag = 160.39145526109331,
                            SourceId = 3,
                            TickerId = 1,
                            Time = new DateTime(2022, 6, 20, 4, 3, 39, 751, DateTimeKind.Local).AddTicks(8749)
                        },
                        new
                        {
                            Id = 8,
                            Active = true,
                            PriceTag = 155.48085744828492,
                            SourceId = 3,
                            TickerId = 2,
                            Time = new DateTime(2022, 6, 20, 9, 5, 39, 751, DateTimeKind.Local).AddTicks(8753)
                        },
                        new
                        {
                            Id = 9,
                            Active = true,
                            PriceTag = 156.28058332391578,
                            SourceId = 3,
                            TickerId = 3,
                            Time = new DateTime(2022, 6, 20, 8, 4, 39, 751, DateTimeKind.Local).AddTicks(8756)
                        },
                        new
                        {
                            Id = 10,
                            Active = true,
                            PriceTag = 143.56959137846698,
                            SourceId = 1,
                            TickerId = 1,
                            Time = new DateTime(2022, 6, 20, 7, 5, 39, 751, DateTimeKind.Local).AddTicks(8760)
                        },
                        new
                        {
                            Id = 11,
                            Active = true,
                            PriceTag = 153.50659426545565,
                            SourceId = 1,
                            TickerId = 2,
                            Time = new DateTime(2022, 6, 20, 6, 57, 39, 751, DateTimeKind.Local).AddTicks(8764)
                        },
                        new
                        {
                            Id = 12,
                            Active = true,
                            PriceTag = 159.04792691151516,
                            SourceId = 1,
                            TickerId = 3,
                            Time = new DateTime(2022, 6, 20, 5, 32, 39, 751, DateTimeKind.Local).AddTicks(8768)
                        },
                        new
                        {
                            Id = 13,
                            Active = true,
                            PriceTag = 161.24729167808653,
                            SourceId = 2,
                            TickerId = 1,
                            Time = new DateTime(2022, 6, 20, 5, 40, 39, 751, DateTimeKind.Local).AddTicks(8772)
                        },
                        new
                        {
                            Id = 14,
                            Active = true,
                            PriceTag = 151.14005629572554,
                            SourceId = 2,
                            TickerId = 2,
                            Time = new DateTime(2022, 6, 20, 5, 58, 39, 751, DateTimeKind.Local).AddTicks(8776)
                        },
                        new
                        {
                            Id = 15,
                            Active = true,
                            PriceTag = 169.18029039674917,
                            SourceId = 2,
                            TickerId = 3,
                            Time = new DateTime(2022, 6, 20, 4, 5, 39, 751, DateTimeKind.Local).AddTicks(8780)
                        },
                        new
                        {
                            Id = 16,
                            Active = true,
                            PriceTag = 154.88768958329115,
                            SourceId = 3,
                            TickerId = 1,
                            Time = new DateTime(2022, 6, 20, 4, 45, 39, 751, DateTimeKind.Local).AddTicks(8784)
                        },
                        new
                        {
                            Id = 17,
                            Active = true,
                            PriceTag = 151.68495841949013,
                            SourceId = 3,
                            TickerId = 2,
                            Time = new DateTime(2022, 6, 20, 9, 15, 39, 751, DateTimeKind.Local).AddTicks(8788)
                        },
                        new
                        {
                            Id = 18,
                            Active = true,
                            PriceTag = 162.41520505591538,
                            SourceId = 3,
                            TickerId = 3,
                            Time = new DateTime(2022, 6, 20, 7, 8, 39, 751, DateTimeKind.Local).AddTicks(8792)
                        },
                        new
                        {
                            Id = 19,
                            Active = true,
                            PriceTag = 141.82134033346145,
                            SourceId = 1,
                            TickerId = 1,
                            Time = new DateTime(2022, 6, 20, 9, 38, 39, 751, DateTimeKind.Local).AddTicks(8796)
                        },
                        new
                        {
                            Id = 20,
                            Active = true,
                            PriceTag = 133.33804441386278,
                            SourceId = 1,
                            TickerId = 2,
                            Time = new DateTime(2022, 6, 20, 8, 32, 39, 751, DateTimeKind.Local).AddTicks(8800)
                        },
                        new
                        {
                            Id = 21,
                            Active = true,
                            PriceTag = 148.57504089842786,
                            SourceId = 1,
                            TickerId = 3,
                            Time = new DateTime(2022, 6, 20, 9, 30, 39, 751, DateTimeKind.Local).AddTicks(8804)
                        },
                        new
                        {
                            Id = 22,
                            Active = true,
                            PriceTag = 131.84585339090594,
                            SourceId = 2,
                            TickerId = 1,
                            Time = new DateTime(2022, 6, 20, 9, 48, 39, 751, DateTimeKind.Local).AddTicks(8808)
                        },
                        new
                        {
                            Id = 23,
                            Active = true,
                            PriceTag = 141.7283985221099,
                            SourceId = 2,
                            TickerId = 2,
                            Time = new DateTime(2022, 6, 20, 6, 7, 39, 751, DateTimeKind.Local).AddTicks(8813)
                        },
                        new
                        {
                            Id = 24,
                            Active = true,
                            PriceTag = 136.78740818915767,
                            SourceId = 2,
                            TickerId = 3,
                            Time = new DateTime(2022, 6, 20, 5, 52, 39, 751, DateTimeKind.Local).AddTicks(8817)
                        },
                        new
                        {
                            Id = 25,
                            Active = true,
                            PriceTag = 145.66511094448862,
                            SourceId = 3,
                            TickerId = 1,
                            Time = new DateTime(2022, 6, 20, 3, 40, 39, 751, DateTimeKind.Local).AddTicks(8821)
                        },
                        new
                        {
                            Id = 26,
                            Active = true,
                            PriceTag = 142.14083366741932,
                            SourceId = 3,
                            TickerId = 2,
                            Time = new DateTime(2022, 6, 20, 9, 31, 39, 751, DateTimeKind.Local).AddTicks(8824)
                        },
                        new
                        {
                            Id = 27,
                            Active = true,
                            PriceTag = 143.33110280104964,
                            SourceId = 3,
                            TickerId = 3,
                            Time = new DateTime(2022, 6, 20, 9, 52, 39, 751, DateTimeKind.Local).AddTicks(8828)
                        },
                        new
                        {
                            Id = 28,
                            Active = true,
                            PriceTag = 151.15128850698531,
                            SourceId = 1,
                            TickerId = 1,
                            Time = new DateTime(2022, 6, 20, 9, 32, 39, 751, DateTimeKind.Local).AddTicks(8832)
                        },
                        new
                        {
                            Id = 29,
                            Active = true,
                            PriceTag = 156.34658773805788,
                            SourceId = 1,
                            TickerId = 2,
                            Time = new DateTime(2022, 6, 20, 8, 49, 39, 751, DateTimeKind.Local).AddTicks(8837)
                        },
                        new
                        {
                            Id = 30,
                            Active = true,
                            PriceTag = 159.96585849285864,
                            SourceId = 1,
                            TickerId = 3,
                            Time = new DateTime(2022, 6, 20, 5, 46, 39, 751, DateTimeKind.Local).AddTicks(8845)
                        },
                        new
                        {
                            Id = 31,
                            Active = true,
                            PriceTag = 161.25107814696668,
                            SourceId = 2,
                            TickerId = 1,
                            Time = new DateTime(2022, 6, 20, 5, 17, 39, 751, DateTimeKind.Local).AddTicks(8848)
                        },
                        new
                        {
                            Id = 32,
                            Active = true,
                            PriceTag = 151.77435503970102,
                            SourceId = 2,
                            TickerId = 2,
                            Time = new DateTime(2022, 6, 20, 8, 36, 39, 751, DateTimeKind.Local).AddTicks(8850)
                        },
                        new
                        {
                            Id = 33,
                            Active = true,
                            PriceTag = 157.13629252224521,
                            SourceId = 2,
                            TickerId = 3,
                            Time = new DateTime(2022, 6, 20, 8, 37, 39, 751, DateTimeKind.Local).AddTicks(8853)
                        },
                        new
                        {
                            Id = 34,
                            Active = true,
                            PriceTag = 168.29602944200209,
                            SourceId = 3,
                            TickerId = 1,
                            Time = new DateTime(2022, 6, 20, 3, 58, 39, 751, DateTimeKind.Local).AddTicks(8857)
                        },
                        new
                        {
                            Id = 35,
                            Active = true,
                            PriceTag = 161.67753523374327,
                            SourceId = 3,
                            TickerId = 2,
                            Time = new DateTime(2022, 6, 20, 5, 1, 39, 751, DateTimeKind.Local).AddTicks(8860)
                        },
                        new
                        {
                            Id = 36,
                            Active = true,
                            PriceTag = 160.54767777318028,
                            SourceId = 3,
                            TickerId = 3,
                            Time = new DateTime(2022, 6, 20, 4, 38, 39, 751, DateTimeKind.Local).AddTicks(8862)
                        },
                        new
                        {
                            Id = 37,
                            Active = true,
                            PriceTag = 148.37247486696694,
                            SourceId = 1,
                            TickerId = 1,
                            Time = new DateTime(2022, 6, 20, 10, 2, 39, 751, DateTimeKind.Local).AddTicks(8865)
                        },
                        new
                        {
                            Id = 38,
                            Active = true,
                            PriceTag = 133.13593984342458,
                            SourceId = 1,
                            TickerId = 2,
                            Time = new DateTime(2022, 6, 20, 9, 50, 39, 751, DateTimeKind.Local).AddTicks(8868)
                        },
                        new
                        {
                            Id = 39,
                            Active = true,
                            PriceTag = 133.90394395945313,
                            SourceId = 1,
                            TickerId = 3,
                            Time = new DateTime(2022, 6, 20, 7, 1, 39, 751, DateTimeKind.Local).AddTicks(8870)
                        },
                        new
                        {
                            Id = 40,
                            Active = true,
                            PriceTag = 141.48426321484814,
                            SourceId = 2,
                            TickerId = 1,
                            Time = new DateTime(2022, 6, 20, 7, 19, 39, 751, DateTimeKind.Local).AddTicks(8873)
                        },
                        new
                        {
                            Id = 41,
                            Active = true,
                            PriceTag = 149.81513666526655,
                            SourceId = 2,
                            TickerId = 2,
                            Time = new DateTime(2022, 6, 20, 8, 44, 39, 751, DateTimeKind.Local).AddTicks(8876)
                        },
                        new
                        {
                            Id = 42,
                            Active = true,
                            PriceTag = 133.82900936322241,
                            SourceId = 2,
                            TickerId = 3,
                            Time = new DateTime(2022, 6, 20, 9, 9, 39, 751, DateTimeKind.Local).AddTicks(8879)
                        },
                        new
                        {
                            Id = 43,
                            Active = true,
                            PriceTag = 159.27255671052382,
                            SourceId = 3,
                            TickerId = 1,
                            Time = new DateTime(2022, 6, 20, 8, 31, 39, 751, DateTimeKind.Local).AddTicks(8881)
                        },
                        new
                        {
                            Id = 44,
                            Active = true,
                            PriceTag = 142.71706721486854,
                            SourceId = 3,
                            TickerId = 2,
                            Time = new DateTime(2022, 6, 20, 9, 13, 39, 751, DateTimeKind.Local).AddTicks(8884)
                        },
                        new
                        {
                            Id = 45,
                            Active = true,
                            PriceTag = 147.1288085816702,
                            SourceId = 3,
                            TickerId = 3,
                            Time = new DateTime(2022, 6, 20, 9, 41, 39, 751, DateTimeKind.Local).AddTicks(8887)
                        },
                        new
                        {
                            Id = 46,
                            Active = true,
                            PriceTag = 156.41619675240767,
                            SourceId = 1,
                            TickerId = 1,
                            Time = new DateTime(2022, 6, 20, 9, 46, 39, 751, DateTimeKind.Local).AddTicks(8890)
                        },
                        new
                        {
                            Id = 47,
                            Active = true,
                            PriceTag = 152.34162784371136,
                            SourceId = 1,
                            TickerId = 2,
                            Time = new DateTime(2022, 6, 20, 10, 6, 39, 751, DateTimeKind.Local).AddTicks(8892)
                        },
                        new
                        {
                            Id = 48,
                            Active = true,
                            PriceTag = 154.81323877654188,
                            SourceId = 1,
                            TickerId = 3,
                            Time = new DateTime(2022, 6, 20, 8, 33, 39, 751, DateTimeKind.Local).AddTicks(8895)
                        },
                        new
                        {
                            Id = 49,
                            Active = true,
                            PriceTag = 165.27423602855032,
                            SourceId = 2,
                            TickerId = 1,
                            Time = new DateTime(2022, 6, 20, 5, 43, 39, 751, DateTimeKind.Local).AddTicks(8898)
                        },
                        new
                        {
                            Id = 50,
                            Active = true,
                            PriceTag = 162.40215829765989,
                            SourceId = 2,
                            TickerId = 2,
                            Time = new DateTime(2022, 6, 20, 8, 45, 39, 751, DateTimeKind.Local).AddTicks(8901)
                        },
                        new
                        {
                            Id = 51,
                            Active = true,
                            PriceTag = 157.21082490819546,
                            SourceId = 2,
                            TickerId = 3,
                            Time = new DateTime(2022, 6, 20, 5, 5, 39, 751, DateTimeKind.Local).AddTicks(8904)
                        },
                        new
                        {
                            Id = 52,
                            Active = true,
                            PriceTag = 165.55151789788226,
                            SourceId = 3,
                            TickerId = 1,
                            Time = new DateTime(2022, 6, 20, 3, 38, 39, 751, DateTimeKind.Local).AddTicks(8906)
                        },
                        new
                        {
                            Id = 53,
                            Active = true,
                            PriceTag = 162.47609874429466,
                            SourceId = 3,
                            TickerId = 2,
                            Time = new DateTime(2022, 6, 20, 9, 13, 39, 751, DateTimeKind.Local).AddTicks(8909)
                        },
                        new
                        {
                            Id = 54,
                            Active = true,
                            PriceTag = 161.65598993347305,
                            SourceId = 3,
                            TickerId = 3,
                            Time = new DateTime(2022, 6, 20, 4, 40, 39, 751, DateTimeKind.Local).AddTicks(8912)
                        });
                });

            modelBuilder.Entity("Entity.Models.Source", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("SourceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Source");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            SourceName = "SRC1"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            SourceName = "SRC2"
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            SourceName = "TBK1"
                        });
                });

            modelBuilder.Entity("Entity.Models.Ticker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ticker");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            Name = "IBM UN"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            Name = "IDM UK"
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            Name = "NIPM DA"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
