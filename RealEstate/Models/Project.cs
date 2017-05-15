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

        public string Title { get; set; }

        public string Address { get; set; }

        public string TypeOfBuilding { get; set; }

        [Required(ErrorMessage = "Specify the year when the building was built")]
        public string Year { get; set; }

        public int Area { get; set; }

        public int PlotArea { get; set; }

        public int NumberOfFloors { get; set; }

        public int NumberOfRooms { get; set; }

        public string Price { get; set; }

        public string AdditionalFacilities { get; set; }

        public string AdditionalInformation { get; set; }

        public ICollection<Image> Images { set; get; }

    }

    public class Image
    {
        public int Id { set; get; }
        public byte[] ImageData { set; get; }
        public int ProjectBelongsId { set; get; }
    }
}