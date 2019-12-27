﻿using MicroRabbit.Transfer.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options) :base(options)
        {
                
        } 
        public DbSet<TransferLog> TransferLog { get; set; }  

    }
}