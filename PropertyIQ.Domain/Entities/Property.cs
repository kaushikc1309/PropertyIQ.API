using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyIQ.Domain.Entities
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string? AlternateKey { get; set; }
        public string? Name { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? County { get; set; }
        public string? ZipCode { get; set; }
        public decimal? TotalBuildingSqFt { get; set; }
        public decimal? ClearHeight { get; set; }
        public int? YearBuilt { get; set; }
        public decimal? SiteCoverage { get; set; }
        public string? Ownership { get; set; }
        public int? SubMarketId { get; set; }
        public int? PropertyUseId { get; set; }
        public int? ResearchPropertyId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }

        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int? DockDoors { get; set; }
        public string? BuildingStatus { get; set; }
        public string? ExpectedCompletion { get; set; }
        public bool? IsLeased { get; set; }
        public bool? IsBuildToSuit { get; set; }
        public decimal? PercentLeased { get; set; }
        public bool? IsSingleTenant { get; set; }
        public int? YearRenovated { get; set; }
        public bool? TemperatureControlled { get; set; }
    }
}
