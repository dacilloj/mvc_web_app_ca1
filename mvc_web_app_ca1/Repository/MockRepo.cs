using mvc_web_app_ca1.Models;

namespace mvc_web_app_ca1.Repository
{
    public class MockRepo : IMockRepo
    {
        //add private repo
        //private static List<PackageModel> = new List<PackageModel>();

        public List<PackageModel> PackageStats()
        {
            throw new NotImplementedException();
        }
    }
}
