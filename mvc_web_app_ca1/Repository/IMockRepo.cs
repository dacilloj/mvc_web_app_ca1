using mvc_web_app_ca1.Models;

namespace mvc_web_app_ca1.Repository
{
    public interface IMockRepo
    {
        List<PackageModel> GetPackages();
        void CreatePackage(PackageModel m);

        PackageModel GetPackage(int id);

        void EditPackage(PackageModel m);
    }
}
