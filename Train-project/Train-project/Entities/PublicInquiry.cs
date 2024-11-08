namespace Train_project.classes
{
    public class PublicInquiry
    {
   

        public int InquiryId { get; set; }
        public int DriverId { get; set; }
        public DateTime DateAndTime { get; set; }
        public string DescriptionInquiry { get; set; }
        public bool StatusInquiry { get; set; }
        public int TreatedBy { get; set; }
        public string ComplainantsName { get; set; }
        public string ComplainantsPhone { get; set; }
        public PublicInquiry()
        {
            
        }
        public PublicInquiry(int inquiryId, int driverId, DateTime dateAndTime, string descriptionInquiry, bool statusInquiry, int treatedBy, string complainantsName, string complainantsPhone)
        {
            InquiryId = inquiryId;
            DriverId = driverId;
            DateAndTime = dateAndTime;
            DescriptionInquiry = descriptionInquiry;
            StatusInquiry = statusInquiry;
            TreatedBy = treatedBy;
            ComplainantsName = complainantsName;
            ComplainantsPhone = complainantsPhone;
        }
    }
}
