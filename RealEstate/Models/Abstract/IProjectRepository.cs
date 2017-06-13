using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RealEstate.Models.Abstract
{
   public interface IProjectRepository
    {
        IEnumerable<Project> GetAll();

        IEnumerable<Project> GetProjectsWithTypeOfBuilding(string typeOfBuilding);
        IEnumerable<Project> GetProjectsWithYear(string fromYear, string toYear);
        IEnumerable<Project> GetProjectsWithPrice(string fromPrice, string toPrice);

        IEnumerable<Project> GetProjectsWithYearFrom(string fromYear);
        IEnumerable<Project> GetProjectsWithYearTo(string toYear);
        IEnumerable<Project> GetProjectsWithPriceFrom(string fromPrice);
        IEnumerable<Project> GetProjectsWithPriceTo(string toPrice);

        IEnumerable<Project> GetProjectsWithTypeOfBuildingAndFromYear(string typeOfBuilding, string fromYear);
        IEnumerable<Project> GetProjectsWithTypeOfBuildingAndToYear(string typeOfBuilding, string toYear);
        IEnumerable<Project> GetProjectsWithTypeOfBuildingAndFromPrice(string typeOfBuilding, string fromPrice);
        IEnumerable<Project> GetProjectsWithTypeOfBuildingAndToPrice(string typeOfBuilding, string toYear);

        IEnumerable<Project> GetProjectsWithTypeOfBuildingAndYear(string typeOfBuilding, string fromYear, string toYear);
        IEnumerable<Project> GetProjectsWithTypeOfBuildingAndPrice(string typeOfBuilding, string fromPrice, string toPrice);
        IEnumerable<Project> GetProjectsWithTypeOfBuildingYearAndPrice(string typeOfBuilding, string fromYear, string toYear, string fromPrice, string toPrice);
        IEnumerable<Image> GetAllImages();
        IEnumerable<Image> GetImagesWithProjectId(Project project);
       // IEnumerable GetAllImages();
        Project Find(int? id);
        void InsertOrUpdate(Project project, IEnumerable<HttpPostedFileBase> images);
        void Delete(Project project);

        void Edit(Project project, IEnumerable<HttpPostedFileBase> images);
       
    }
}
