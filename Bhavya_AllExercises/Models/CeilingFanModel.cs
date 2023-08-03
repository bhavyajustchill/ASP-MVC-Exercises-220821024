using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhavya_AllExercises.Models
{
    public class CeilingFanModel
    {
        public int FanId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal BladeSpanInches { get; set; }
        public int NumberOfBlades { get; set; }
        public int MotorPowerWatts { get; set; }
        public int NumberOfSpeeds { get; set; }
        public int AirflowCfm { get; set; }
        public string MountingType { get; set; }
        public string ControlType { get; set; }
        public bool IsRemoteControlled { get; set; }
        public bool HasLightKit { get; set; }
        public string LightBulbType { get; set; }
        public int LightBulbWattageWatts { get; set; }
        public bool IsLightDimmable { get; set; }
        public bool HasReverseMode { get; set; }
        public string HousingMaterial { get; set; }
        public string BladeMaterial { get; set; }
        public string HousingFinish { get; set; }
        public decimal FanWidthMm { get; set; }
        public decimal FanHeightMm { get; set; }
        public decimal FanDepthMm { get; set; }
        public decimal WeightKg { get; set; }
        public decimal NoiseLevelDb { get; set; }
        public int EnergyUsageWatts { get; set; }
        public int VoltageVolts { get; set; }
        public int WarrantyYears { get; set; }
        public string Certifications { get; set; }
        public bool SmartHomeCompatible { get; set; }
        public string SmartHomePlatforms { get; set; }
        public string WifiSupport { get; set; }
        public string VoiceAssistantCompatibility { get; set; }
        public string MobileAppCompatibility { get; set; }
        public string AdditionalControlFeatures { get; set; }
        public bool IsEnergyStarCertified { get; set; }
        public bool IsULListed { get; set; }
        public bool IsEnergyEfficient { get; set; }
        public decimal AirflowEfficiencyCfmPerWatt { get; set; }
        public bool TemperatureRegulation { get; set; }
        public bool HumidityRegulation { get; set; }
        public bool AirPurificationCapability { get; set; }
        public bool IsDustproof { get; set; }
        public bool IsRustproof { get; set; }
        public bool IsWaterproof { get; set; }
        public bool IsHumidProof { get; set; }
        public bool RemoteBatteriesRequired { get; set; }
        public int MotorWarrantyYears { get; set; }
        public decimal BladePitchDegrees { get; set; }
    }
}