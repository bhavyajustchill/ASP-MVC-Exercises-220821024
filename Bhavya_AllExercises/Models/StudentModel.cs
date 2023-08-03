using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhavya_AllExercises.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public string GuardianName { get; set; }
        public string GuardianPhone { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime GraduationDate { get; set; }
        public string Major { get; set; }
        public int CreditsCompleted { get; set; }
        public float GPA { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string MedicalHistory { get; set; }
        public string Allergies { get; set; }
        public string ExtracurricularActivities { get; set; }
        public decimal ScholarshipAmount { get; set; }
        public string DormitoryName { get; set; }
        public string RoomNumber { get; set; }
        public string ClubMemberships { get; set; }
        public string AcademicAdvisor { get; set; }
        public string TransportationMode { get; set; }
        public string LibraryCardNumber { get; set; }
        public string InternshipCompany { get; set; }
        public bool IsActive { get; set; }
        public bool IsRegistered { get; set; }
        public bool IsInternationalStudent { get; set; }
        public string Nationality { get; set; }
        public string PassportNumber { get; set; }
        public DateTime VisaExpiryDate { get; set; }
        public string KnownLanguages { get; set; }
        public string GraduationProjectTopic { get; set; }
        public string GraduationProjectSupervisor { get; set; }
        public string SocialMediaAccounts { get; set; }
        public string DormitoryRA { get; set; }
        public string SportsTeams { get; set; }
        public string AwardsReceived { get; set; }
        public string FavoriteSubject { get; set; }
    }
}