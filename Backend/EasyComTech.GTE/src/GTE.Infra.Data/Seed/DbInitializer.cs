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
                    new WillingnessToWork{ Description = "Up to 4 hours per day."},
                    new WillingnessToWork{ Description = "4 to 6 hours per day."},
                    new WillingnessToWork{ Description = "6 to 8 hours per day."},
                    new WillingnessToWork{ Description = "Up to 8 hours a day. (Are sure?)"},
                    new WillingnessToWork{ Description = "Only weekend.."}
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
                    new BestTimeToWork{Description = "Morning (from 08:00 to 12:00)."},
                    new BestTimeToWork{Description = "Afternoon (from 1:00 p.m. to 6:00 p.m.)."},
                    new BestTimeToWork{Description = "Night (from 7:00 p.m. to 10:00 p.m.)."},
                    new BestTimeToWork{Description = "Dawn (10:00 p.m. onwards)."},
                    new BestTimeToWork{Description = "Business (from 8:00 a.m. from 06:00 p.m.)."}
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
                    new AccountType{Description= "Chain"},
                    new AccountType{Description= "Savings"}
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
