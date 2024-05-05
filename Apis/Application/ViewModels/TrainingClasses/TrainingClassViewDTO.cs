using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.ViewModels.TrainingClasses
{
    public class TrainingClassViewDTO
    {
        public string ClassName { get; set; }
        public string ClassCode { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ClassLocation ClassLocation { get; set; }
        public DateTime ClassTimeStart { get; set; }//
        public DateTime ClassTimeEnd { get; set; }
    }
}
