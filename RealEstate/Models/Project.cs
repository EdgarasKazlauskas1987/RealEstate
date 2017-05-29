using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RealEstate.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.SharedTexts.SharedTexts), ErrorMessageResourceName = "RequiredField")]
        [Display(Name = "Title", ResourceType = typeof(Resources.ProjectModelTexts.ProjectModelTexts))]
        public string Title { get; set; }

        [Display(Name = "Address", ResourceType = typeof(Resources.ProjectModelTexts.ProjectModelTexts))]
        public string Address { get; set; }

        [Display(Name = "TypeOfBuilding", ResourceType = typeof(Resources.ProjectModelTexts.ProjectModelTexts))]
        public string TypeOfBuilding { get; set; }

        [Display(Name = "YearBuilt", ResourceType = typeof(Resources.ProjectModelTexts.ProjectModelTexts))]
        public string Year { get; set; }

        [Display(Name = "AreaSize", ResourceType = typeof(Resources.ProjectModelTexts.ProjectModelTexts))]
        public int Area { get; set; }

        [Display(Name = "PlotArea", ResourceType = typeof(Resources.ProjectModelTexts.ProjectModelTexts))]
        public int PlotArea { get; set; }

        [Display(Name = "NumberOfFloors", ResourceType = typeof(Resources.ProjectModelTexts.ProjectModelTexts))]
        public int NumberOfFloors { get; set; }

        [Display(Name = "NumberOfRooms", ResourceType = typeof(Resources.ProjectModelTexts.ProjectModelTexts))]
        public int NumberOfRooms { get; set; }

        [Display(Name = "Price", ResourceType = typeof(Resources.ProjectModelTexts.ProjectModelTexts))]
        public string Price { get; set; }

        [Display(Name = "AdditionalFacilities", ResourceType = typeof(Resources.ProjectModelTexts.ProjectModelTexts))]
        public string AdditionalFacilities { get; set; }

        [Display(Name = "AdditionalInformation", ResourceType = typeof(Resources.ProjectModelTexts.ProjectModelTexts))]
        public string AdditionalInformation { get; set; }

        [Display(Name = "Images", ResourceType = typeof(Resources.ProjectModelTexts.ProjectModelTexts))]
        public ICollection<Image> Images { set; get; }

    }

    public class Image
    {
        public int Id { set; get; }
        public byte[] ImageData { set; get; }
        public int ProjectBelongsId { set; get; }
    }
}