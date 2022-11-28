using mvc_web_app_ca1.Models;
using System;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvc_web_app_ca1.Repository;

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

        public PackageModel GetPackage(int id)
        {
            //linq not working currently
   
            var found = FirstOrDefault(x => x.MatchID == Id);
        
            return found;
        }

        public void EditPackage(PackageModel m)
        {
            var found = PackageModel.Find(x => x.Id == m.Id);
            if (found != null)
            {
                found.Id = m.Id;
                found.ClientName = m.ClientName;
            }

        }
    }
}
