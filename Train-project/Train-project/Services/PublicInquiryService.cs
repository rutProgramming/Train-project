using Train_project.classes;
using Train_project.DataContext;

namespace Train_project.services
{
    public class PublicInquiryService
    {
        public DataContextManager DataContextP { get; set; } = new DataContextManager();
        valid valid = new valid();
        public List<PublicInquiry> Get()
        {
            return DataContextP.Data_Context.PublicInquiries;
        }
        public PublicInquiry GetById(int id)
        {
            return DataContextP.Data_Context.PublicInquiries.Find(publicInquiry => publicInquiry.InquiryId == id);
        }
        public bool AddPublicInquiry(PublicInquiry publicInquiry)
        {
            if (valid.IsIsraeliPhoneNumberValid(publicInquiry.ComplainantsPhone))
            {
                DataContextP.Data_Context.PublicInquiries.Add(publicInquiry);
                return true;
            }
            return false;
        }
        public bool UpdatePublicInquiry(int id, PublicInquiry publicInquiry)
        {
            int indexPublicInquiry = DataContextP.Data_Context.PublicInquiries.FindIndex(publicInquiry => publicInquiry.InquiryId == id);
            if (indexPublicInquiry != -1)
            {
                DataContextP.Data_Context.PublicInquiries[indexPublicInquiry] = publicInquiry;
                return true;
            }
            return false;

        }
        public bool DeletePublicInquiry(int id)
        {
            PublicInquiry publicInquiry = DataContextP.Data_Context.PublicInquiries.Find(publicInquiry => publicInquiry.InquiryId == id);
            if (publicInquiry != null)
            {
                DataContextP.Data_Context.PublicInquiries.Remove(publicInquiry);
                return true;
            }
            return false;

        }
    }
}
