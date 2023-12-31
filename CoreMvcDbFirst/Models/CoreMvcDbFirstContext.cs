﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CoreMvcDbFirst.Models;

public partial class CoreMvcDbFirstContext : DbContext
{
    public CoreMvcDbFirstContext()
    {
    }

    public CoreMvcDbFirstContext(DbContextOptions<CoreMvcDbFirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DEEPAK;Database=CoreMvcDbFirst;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
