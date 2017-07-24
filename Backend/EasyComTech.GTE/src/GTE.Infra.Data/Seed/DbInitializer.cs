using GTE.Domain.Entities;
using GTE.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTE.Infra.Data.Seed
{
    public static class DbInitializer
    {
        public static void Initialize(GTEContext context)
        {
            context.Database.EnsureCreated();

            if (!context.WillingnessToWork.Any())
            {
                var works = new WillingnessToWork[]
                {
                    new WillingnessToWork{ Id= Guid.Parse("2AC4E68B-802C-4F51-E81F-08D4CD79B66D"), Description = "Up to 4 hours per day."},
                    new WillingnessToWork{ Id= Guid.Parse("3337AC76-76AC-4F6F-E820-08D4CD79B66D"), Description = "4 to 6 hours per day."},
                    new WillingnessToWork{ Id= Guid.Parse("C3D2D80D-CA30-4FC6-E821-08D4CD79B66D"), Description = "6 to 8 hours per day."},
                    new WillingnessToWork{ Id= Guid.Parse("4DCE7F2B-E366-4205-E822-08D4CD79B66D"), Description = "Up to 8 hours a day. (Are sure?)"},
                    new WillingnessToWork{ Id= Guid.Parse("F3C0A8FB-7B17-4001-E823-08D4CD79B66D"), Description = "Only weekend.."}
                };

                foreach (var work in works)
                {
                    context.WillingnessToWork.Add(work);
                }
                context.SaveChanges();
            }

            if (!context.BestTimeToWork.Any())
            {
                var bestTimes = new BestTimeToWork[]
                {
                    new BestTimeToWork{Id= Guid.Parse("A58A2398-6B6A-4718-80D2-08D4CD79B6A3"), Description = "Morning (from 08:00 to 12:00)."},
                    new BestTimeToWork{Id= Guid.Parse("86726A2C-FF30-4500-80D3-08D4CD79B6A3"), Description = "Afternoon (from 1:00 p.m. to 6:00 p.m.)."},
                    new BestTimeToWork{Id= Guid.Parse("FE66182F-868D-4C2B-80D4-08D4CD79B6A3"), Description = "Night (from 7:00 p.m. to 10:00 p.m.)."},
                    new BestTimeToWork{Id= Guid.Parse("8C29A736-7C47-46F4-80D5-08D4CD79B6A3"), Description = "Dawn (10:00 p.m. onwards)."},
                    new BestTimeToWork{Id= Guid.Parse("69ED6B2B-CE5A-48D3-80D6-08D4CD79B6A3"), Description = "Business (from 8:00 a.m. from 06:00 p.m.)."}
                };

                foreach (var time in bestTimes)
                {
                    context.BestTimeToWork.Add(time);
                }

                context.SaveChanges();
            }

            if (!context.AccountType.Any())
            {
                var types = new AccountType[]
                {
                    new AccountType{ Id= Guid.Parse("636FA9A1-811C-46E6-1956-08D4CD79B6A6"), Description= "Chain" },
                    new AccountType{ Id= Guid.Parse("B1C3FD3F-3BEC-46C8-1957-08D4CD79B6A6"), Description= "Savings"}
                };

                foreach (var type in types)
                {
                    context.AccountType.Add(type);
                }

                context.SaveChanges();
            }
        }
    }
}
