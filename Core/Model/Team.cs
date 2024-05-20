using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Team : BaseEntity
    {
         public string title { get; set; } = null;
         public string FullName { get; set; } 
         public string Position { get; set; }
         public string? ImageUrl { get; set; }
         [NotMapped]
         public IFormFile? ImgFile  { get; set; }


    }
}
