using mvc_web_app_ca1.Models;

namespace mvc_web_app_ca1.Repository
{
    public class MockRepo : IMockRepo
    {
        //add private repo
        private static List<PackageModel> Packages = new List<PackageModel>();

        public List<PackageModel> GetPackages()
        {
            return Packages;
        }

        public void CreatePackage(PackageModel m)
        {
            Packages.Add(m);
        }
    }
}
