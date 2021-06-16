﻿// <auto-generated />
using System;
using LCA_Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LCA_Model.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210613132808_connectionid")]
    partial class connectionid
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LCA_Model.Entities.ChatRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedComputerName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIp")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("FriendshipId")
                        .HasColumnType("int");

                    b.Property<string>("LastMessage")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ModifiedComputerName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedIp")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FriendshipId")
                        .IsUnique();

                    b.ToTable("ChatRooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedComputerName = "Admin",
                            CreatedDate = new DateTime(2021, 6, 13, 16, 28, 7, 156, DateTimeKind.Local).AddTicks(8747),
                            CreatedIp = "127.0.0.1",
                            FriendshipId = 1,
                            ModifiedComputerName = "Admin",
                            ModifiedDate = new DateTime(2021, 6, 13, 16, 28, 7, 156, DateTimeKind.Local).AddTicks(8755),
                            ModifiedIp = "127.0.0.1",
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedComputerName = "Admin",
                            CreatedDate = new DateTime(2021, 6, 13, 16, 28, 7, 156, DateTimeKind.Local).AddTicks(9229),
                            CreatedIp = "127.0.0.1",
                            FriendshipId = 2,
                            ModifiedComputerName = "Admin",
                            ModifiedDate = new DateTime(2021, 6, 13, 16, 28, 7, 156, DateTimeKind.Local).AddTicks(9235),
                            ModifiedIp = "127.0.0.1",
                            Status = 1
                        });
                });

            modelBuilder.Entity("LCA_Model.Entities.Friendship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActionUserId")
                        .HasColumnType("int");

                    b.Property<int>("ChatRoomId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedComputerName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIp")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("FriendShipStatus")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedComputerName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedIp")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserOneId")
                        .HasColumnType("int");

                    b.Property<int>("UserTwoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActionUserId");

                    b.HasIndex("UserOneId");

                    b.HasIndex("UserTwoId");

                    b.ToTable("Friendships");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActionUserId = 2,
                            ChatRoomId = 1,
                            CreatedComputerName = "Admin",
                            CreatedDate = new DateTime(2021, 6, 13, 16, 28, 7, 156, DateTimeKind.Local).AddTicks(876),
                            CreatedIp = "127.0.0.1",
                            FriendShipStatus = 1,
                            ModifiedComputerName = "Admin",
                            ModifiedDate = new DateTime(2021, 6, 13, 16, 28, 7, 156, DateTimeKind.Local).AddTicks(892),
                            ModifiedIp = "127.0.0.1",
                            Status = 0,
                            UserOneId = 1,
                            UserTwoId = 2
                        },
                        new
                        {
                            Id = 2,
                            ActionUserId = 3,
                            ChatRoomId = 2,
                            CreatedComputerName = "Admin",
                            CreatedDate = new DateTime(2021, 6, 13, 16, 28, 7, 156, DateTimeKind.Local).AddTicks(3205),
                            CreatedIp = "127.0.0.1",
                            FriendShipStatus = 1,
                            ModifiedComputerName = "Admin",
                            ModifiedDate = new DateTime(2021, 6, 13, 16, 28, 7, 156, DateTimeKind.Local).AddTicks(3214),
                            ModifiedIp = "127.0.0.1",
                            Status = 0,
                            UserOneId = 1,
                            UserTwoId = 3
                        });
                });

            modelBuilder.Entity("LCA_Model.Entities.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ConnectionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedComputerName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIp")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("LastLoginDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastLogoutDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("MemberStatus")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedComputerName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedIp")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ProfilePicId")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "hope",
                            CreatedComputerName = "Admin",
                            CreatedDate = new DateTime(2021, 6, 13, 16, 28, 7, 149, DateTimeKind.Local).AddTicks(8045),
                            CreatedIp = "127.0.0.1",
                            Email = "furkan_aslan2209@hotmail.com",
                            FirstName = "Furkan",
                            LastLoginDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastLogoutDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Aslan",
                            MemberStatus = 0,
                            ModifiedComputerName = "Admin",
                            ModifiedDate = new DateTime(2021, 6, 13, 16, 28, 7, 151, DateTimeKind.Local).AddTicks(8983),
                            ModifiedIp = "127.0.0.1",
                            Password = "1903",
                            ProfilePicId = 0,
                            Role = 0,
                            Status = 0,
                            UserName = "HostGhost"
                        },
                        new
                        {
                            Id = 2,
                            About = "Turkiye",
                            CreatedComputerName = "Admin",
                            CreatedDate = new DateTime(2021, 6, 13, 16, 28, 7, 152, DateTimeKind.Local).AddTicks(4215),
                            CreatedIp = "127.0.0.1",
                            Email = "mehmetcankural@hotmail.com",
                            FirstName = "Mehmetcan",
                            LastLoginDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastLogoutDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Kural",
                            MemberStatus = 0,
                            ModifiedComputerName = "Admin",
                            ModifiedDate = new DateTime(2021, 6, 13, 16, 28, 7, 152, DateTimeKind.Local).AddTicks(4226),
                            ModifiedIp = "127.0.0.1",
                            Password = "1907",
                            ProfilePicId = 0,
                            Role = 0,
                            Status = 0,
                            UserName = "DarkSouls"
                        },
                        new
                        {
                            Id = 3,
                            About = "But I can't walk on the path of the right, because I'm wrong..",
                            CreatedComputerName = "Admin",
                            CreatedDate = new DateTime(2021, 6, 13, 16, 28, 7, 152, DateTimeKind.Local).AddTicks(4234),
                            CreatedIp = "127.0.0.1",
                            Email = "frkkrm16@hotmail.com",
                            FirstName = "Kerem",
                            LastLoginDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastLogoutDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Buğra",
                            MemberStatus = 0,
                            ModifiedComputerName = "Admin",
                            ModifiedDate = new DateTime(2021, 6, 13, 16, 28, 7, 152, DateTimeKind.Local).AddTicks(4236),
                            ModifiedIp = "127.0.0.1",
                            Password = "1907",
                            ProfilePicId = 0,
                            Role = 0,
                            Status = 0,
                            UserName = "frkkrm16"
                        });
                });

            modelBuilder.Entity("LCA_Model.Entities.MembersProfilePicture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedComputerName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIp")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Filename")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Filepath")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedComputerName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedIp")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MemberId")
                        .IsUnique();

                    b.ToTable("MembersProfilePictures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedComputerName = "Admin",
                            CreatedDate = new DateTime(2021, 6, 13, 16, 28, 7, 155, DateTimeKind.Local).AddTicks(2112),
                            CreatedIp = "127.0.0.1",
                            Filename = ".jpg",
                            Filepath = "http://localhost:52941/uploads/furkanaslan.jpg",
                            MemberId = 1,
                            ModifiedComputerName = "Admin",
                            ModifiedDate = new DateTime(2021, 6, 13, 16, 28, 7, 155, DateTimeKind.Local).AddTicks(2152),
                            ModifiedIp = "127.0.0.1",
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedComputerName = "Admin",
                            CreatedDate = new DateTime(2021, 6, 13, 16, 28, 7, 155, DateTimeKind.Local).AddTicks(3998),
                            CreatedIp = "127.0.0.1",
                            Filename = ".jpg",
                            Filepath = "http://localhost:52941/uploads/default.jpg",
                            MemberId = 2,
                            ModifiedComputerName = "Admin",
                            ModifiedDate = new DateTime(2021, 6, 13, 16, 28, 7, 155, DateTimeKind.Local).AddTicks(4008),
                            ModifiedIp = "127.0.0.1",
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            CreatedComputerName = "Admin",
                            CreatedDate = new DateTime(2021, 6, 13, 16, 28, 7, 155, DateTimeKind.Local).AddTicks(4012),
                            CreatedIp = "127.0.0.1",
                            Filename = ".jpg",
                            Filepath = "http://localhost:52941/uploads/kerembugra",
                            MemberId = 3,
                            ModifiedComputerName = "Admin",
                            ModifiedDate = new DateTime(2021, 6, 13, 16, 28, 7, 155, DateTimeKind.Local).AddTicks(4018),
                            ModifiedIp = "127.0.0.1",
                            Status = 0
                        });
                });

            modelBuilder.Entity("LCA_Model.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<int>("ChatRoomId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedComputerName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIp")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("MessageImageStatus")
                        .HasColumnType("int");

                    b.Property<int>("MessageStatus")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedComputerName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedIp")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("ReceivId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChatRoomId");

                    b.HasIndex("ReceivId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "Junior, nasılsın?",
                            ChatRoomId = 1,
                            CreatedComputerName = "Admin",
                            CreatedDate = new DateTime(2021, 6, 13, 16, 28, 7, 157, DateTimeKind.Local).AddTicks(3819),
                            CreatedIp = "127.0.0.1",
                            MessageImageStatus = 1,
                            MessageStatus = 1,
                            ModifiedComputerName = "Admin",
                            ModifiedDate = new DateTime(2021, 6, 13, 16, 28, 7, 157, DateTimeKind.Local).AddTicks(3827),
                            ModifiedIp = "127.0.0.1",
                            ReceivId = 1,
                            SenderId = 3,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            Body = "İyiyim, sen nasılsın?",
                            ChatRoomId = 1,
                            CreatedComputerName = "Admin",
                            CreatedDate = new DateTime(2021, 6, 13, 16, 28, 7, 157, DateTimeKind.Local).AddTicks(8122),
                            CreatedIp = "127.0.0.1",
                            MessageImageStatus = 1,
                            MessageStatus = 1,
                            ModifiedComputerName = "Admin",
                            ModifiedDate = new DateTime(2021, 6, 13, 16, 28, 7, 157, DateTimeKind.Local).AddTicks(8134),
                            ModifiedIp = "127.0.0.1",
                            ReceivId = 3,
                            SenderId = 1,
                            Status = 0
                        });
                });

            modelBuilder.Entity("LCA_Model.Entities.ChatRoom", b =>
                {
                    b.HasOne("LCA_Model.Entities.Friendship", "Friendship")
                        .WithOne("ChatRoom")
                        .HasForeignKey("LCA_Model.Entities.ChatRoom", "FriendshipId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Friendship");
                });

            modelBuilder.Entity("LCA_Model.Entities.Friendship", b =>
                {
                    b.HasOne("LCA_Model.Entities.Member", "ActionUser")
                        .WithMany("ActionFriendships")
                        .HasForeignKey("ActionUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LCA_Model.Entities.Member", "UserOne")
                        .WithMany("FirstFriendships")
                        .HasForeignKey("UserOneId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LCA_Model.Entities.Member", "UserTwo")
                        .WithMany("SecondFriendships")
                        .HasForeignKey("UserTwoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ActionUser");

                    b.Navigation("UserOne");

                    b.Navigation("UserTwo");
                });

            modelBuilder.Entity("LCA_Model.Entities.MembersProfilePicture", b =>
                {
                    b.HasOne("LCA_Model.Entities.Member", "Member")
                        .WithOne("MembersProfilePicture")
                        .HasForeignKey("LCA_Model.Entities.MembersProfilePicture", "MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("LCA_Model.Entities.Message", b =>
                {
                    b.HasOne("LCA_Model.Entities.ChatRoom", "ChatRoom")
                        .WithMany("Messages")
                        .HasForeignKey("ChatRoomId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LCA_Model.Entities.Member", "Receiv")
                        .WithMany("ReceivingMessages")
                        .HasForeignKey("ReceivId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LCA_Model.Entities.Member", "Sender")
                        .WithMany("SendingMessages")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ChatRoom");

                    b.Navigation("Receiv");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("LCA_Model.Entities.ChatRoom", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("LCA_Model.Entities.Friendship", b =>
                {
                    b.Navigation("ChatRoom");
                });

            modelBuilder.Entity("LCA_Model.Entities.Member", b =>
                {
                    b.Navigation("ActionFriendships");

                    b.Navigation("FirstFriendships");

                    b.Navigation("MembersProfilePicture");

                    b.Navigation("ReceivingMessages");

                    b.Navigation("SecondFriendships");

                    b.Navigation("SendingMessages");
                });
#pragma warning restore 612, 618
        }
    }
}