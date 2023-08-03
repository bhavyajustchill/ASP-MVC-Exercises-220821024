using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhavya_AllExercises.Models
{
    public class CountryModel
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string IsoAlpha2 { get; set; }
        public string IsoAlpha3 { get; set; }
        public int IsoNumeric { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }
        public decimal AreaSqKm { get; set; }
        public string Continent { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public string PhoneCode { get; set; }
        public string Languages { get; set; }
        public string Timezones { get; set; }
        public string InternetTLD { get; set; }
        public string Neighbors { get; set; }
        public string OfficialName { get; set; }
        public DateTime IndependenceDate { get; set; }
        public string GovernmentType { get; set; }
        public string HeadOfState { get; set; }
        public string HeadOfGovernment { get; set; }
        public string PoliticalSystem { get; set; }
        public string OfficialReligion { get; set; }
        public string EthnicGroups { get; set; }
        public string MajorReligions { get; set; }
        public string NationalAnimal { get; set; }
        public string NationalFlower { get; set; }
        public string NationalSport { get; set; }
        public string NationalMotto { get; set; }
        public string NationalAnthem { get; set; }
        public string NationalEmblem { get; set; }
        public string NationalCurrencyName { get; set; }
        public string NationalMonument { get; set; }
        public decimal GdpUSD { get; set; }
        public decimal GdpGrowthRate { get; set; }
        public decimal GdpPerCapitaUSD { get; set; }
        public decimal GiniIndex { get; set; }
        public decimal HDIIndex { get; set; }
        public decimal LiteracyRate { get; set; }
        public decimal LifeExpectancyYears { get; set; }
        public decimal UnemploymentRate { get; set; }
        public decimal PovertyRate { get; set; }
        public decimal InternetUsersPercent { get; set; }
        public decimal MobileSubscriptionsPer100 { get; set; }
        public decimal LandBorderLengthKm { get; set; }
        public decimal CoastlineLengthKm { get; set; }
        public string HighestPointName { get; set; }
        public decimal HighestPointElevationM { get; set; }
        public string LowestPointName { get; set; }
        public decimal LowestPointElevationM { get; set; }
    }
}