using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }

    //adapt command
    //dotnet aspnet-codegenerator --configuration "Debug" --project "/home/user/Documents/Dotnettests/RazorPagesMovie/RazorPagesMovie.csproj" razorpage --model User --dataContext NewUserContext  --referenceScriptLibraries  --useDefaultLayout --no-build -outDir "/home/user/Documents/Dotnettests/RazorPagesMovie/Pages/" --namespaceName AssetManager2.Pages.Users2 --useSqlite
}