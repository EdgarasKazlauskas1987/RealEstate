
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RealEstate.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.SharedTexts.SharedTexts), ErrorMessageResourceName = "RequiredField")]
        [StringLength(40, ErrorMessage = "Max 40 characters")]
        [Display(Name = "Title", ResourceType = typeof(Resources.ProjectModelTexts.ProjectModelTexts))]
        public string Title { get; set; }

        [StringLength(40, ErrorMessage = "Max 40 characters")]
        [Display(Name = "Address", ResourceType = typeof(Resources.ProjectModelTexts.ProjectModelTexts))]
        public string Address { get; set; }

        [Display(Name = "TypeOfBuilding", ResourceType = typeof(Resources.ProjectModelTexts.ProjectModelTexts))]
        public string TypeOfBuilding { get; set; }

        [StringLength(10, ErrorMessage = "Max 10 characters")]
        [RegularExpression(@"([0-9]+)", ErrorMessage = "Must be a Number.")]
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

        [RegularExpression(@"([0-9]+)", ErrorMessage = "Must be a Number.")]
        [Display(Name = "Price", ResourceType = typeof(Resources.ProjectModelTexts.ProjectModelTexts))]
        public string Price { get; set; }

        [StringLength(500, ErrorMessage = "Max 500 characters")]
        [Display(Name = "AdditionalFacilities", ResourceType = typeof(Resources.ProjectModelTexts.ProjectModelTexts))]
        public string AdditionalFacilities { get; set; }

        [StringLength(500, ErrorMessage = "Max 500 characters")]
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