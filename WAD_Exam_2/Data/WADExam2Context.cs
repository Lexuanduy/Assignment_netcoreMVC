using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAD_Exam_2.Models;

namespace WAD_Exam_2.Data
{
    public class WADExam2Context: DbContext
    { 
        public WADExam2Context(DbContextOptions<WADExam2Context> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
