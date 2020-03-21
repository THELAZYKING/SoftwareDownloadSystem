using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace SoftwareDownloadSystem.Models
{
    public class SDS_DBContext : DbContext
    {
        public SDS_DBContext(DbContextOptions<SDS_DBContext> options) : base(options)
        {
        }
        public DbSet<SoftwareDownload> softwareDownloads{get; set;}
        

    }
}
