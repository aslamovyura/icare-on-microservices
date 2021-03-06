using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Report.API.Common.Constants;
using Report.API.Common.Interfaces;
using Report.API.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Report.API.Infrastructure
{
    /// <summary>
    /// Seed report context with test data.
    /// </summary>
    public class ReportContextSeed
    {
        /// <summary>
        /// Fill database with initial data.
        /// </summary>
        /// <param name="serviceProvider">Service provider.</param>
        public static void Initialize(IServiceProvider serviceProvider)
        {
            try
            {
                var contextOptions = serviceProvider.GetRequiredService<DbContextOptions<ReportContext>>();

                using var reportContext = new ReportContext(contextOptions);
                SeedAsync(reportContext).GetAwaiter().GetResult();

                Log.Information(InitializationConstants.SEED_SUCCEESS);
            }
            catch (Exception ex)
            {
                Log.Error(ex, InitializationConstants.SEED_ERROR);
            }
        }

        /// <summary>
        /// Seed application context.
        /// </summary>
        /// <param name="context">Application context.</param>
        public static async Task SeedAsync(IReportContext context)
        {
            if (!context.Reports.Any())
            {
                await context.Reports.AddRangeAsync(GetPreconfiguredReportsModels());
                await context.SaveChangesAsync(new CancellationToken());
            }
        }

        /// <summary>
        /// Get preconfigured report models for application context seed.
        /// </summary>
        /// <returns>Report models.</returns>
        public static ICollection<ReportModel> GetPreconfiguredReportsModels()
        {
            return new List<ReportModel>()
            {
                new ReportModel()
                {
                    RecordId = 1,
                    Date = DateTime.Parse("04-01-2018"),
                    HealthStatus = "Healthy",
                    HealthDescription = "You are totally healthy",
                    DataType = "Acoustic",
                    Diseases = string.Empty,
                    Accuracy = 97,
                },

                new ReportModel()
                {
                    RecordId = 2,
                    Date = DateTime.Parse("02-01-2018"),
                    HealthStatus = "Diseased",
                    HealthDescription = "Several health problems have been recognized...",
                    DataType = "Acoustic",
                    Diseases = "Mitral valve prolapse",
                    Accuracy = 76,
                },

                new ReportModel()
                {
                    RecordId = 3,
                    Date = DateTime.Parse("01-01-2018"),
                    HealthStatus = "Diseased",
                    HealthDescription = "Several health problems have been recognized...",
                    DataType = "Acoustic",
                    Diseases = "Mitral valve prolapse",
                    Accuracy = 76,
                },

                new ReportModel()
                {
                    RecordId = 4,
                    Date = DateTime.Parse("01-01-2019"),
                    HealthStatus = "Unknown",
                    HealthDescription = "There are some problems with data processing... Try again later, please.",
                    DataType = "Temperature",
                    Diseases = string.Empty,
                    Accuracy = 57,
                },

                new ReportModel()
                {
                    RecordId = 5,
                    Date = DateTime.Parse("02-01-2019"),
                    HealthStatus = "Healthy",
                    HealthDescription = "No health problem have been recognized. You are totally healthy!",
                    DataType = "Temperature",
                    Diseases = string.Empty,
                    Accuracy = 81,
                },
            };
        }
    }
}