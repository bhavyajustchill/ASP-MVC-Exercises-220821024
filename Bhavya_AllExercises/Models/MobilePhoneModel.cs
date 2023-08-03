using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhavya_AllExercises.Models
{
    public class MobilePhoneModel
    {
        public int PhoneId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal DisplaySizeInch { get; set; }
        public int StorageGB { get; set; }
        public int RamGB { get; set; }
        public int BatteryCapacitymAh { get; set; }
        public string OperatingSystem { get; set; }
        public int RearCameraResolutionMpx { get; set; }
        public int FrontCameraResolutionMpx { get; set; }
        public string Processor { get; set; }
        public decimal Price { get; set; }
        public bool IsWaterproof { get; set; }
        public bool IsDualSim { get; set; }
        public bool HasMicroSDSlot { get; set; }
        public bool HasFingerprintSensor { get; set; }
        public bool HasFaceUnlock { get; set; }
        public bool Is5GCompatible { get; set; }
        public bool IsWirelessChargingSupported { get; set; }
        public bool IsFastChargingSupported { get; set; }
        public bool HasHeadphoneJack { get; set; }
        public bool HasNFC { get; set; }
        public bool HasInfrared { get; set; }
        public string BodyMaterial { get; set; }
        public decimal WeightGrams { get; set; }
        public decimal HeightMm { get; set; }
        public decimal WidthMm { get; set; }
        public decimal ThicknessMm { get; set; }
        public string ScreenResolutionPixels { get; set; }
        public string ScreenType { get; set; }
        public string ScreenProtectorMaterial { get; set; }
        public bool IsRemovableBattery { get; set; }
        public string SimCardType { get; set; }
        public string BatteryType { get; set; }
        public string BluetoothVersion { get; set; }
        public string WifiStandard { get; set; }
        public string AvailableColors { get; set; }
        public int WarrantyDurationMonths { get; set; }
        public string AdditionalAccessories { get; set; }
        public string CustomerReviews { get; set; }
        public string ManufacturerWebsite { get; set; }
        public string ManufacturerSupportContact { get; set; }
        public string RepairCentersLocations { get; set; }
    }
}