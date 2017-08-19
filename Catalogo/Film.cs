using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    public class Film
    {
        public Film() { }

        public Film(int Id, String Name, String ImageUrl, Double Popularity, String Synopsis)
        {
            this.Id = Id;
            this.Name = Name;
            this.ImageUrl = ImageUrl;
            this.Popularity = Popularity;
            this.Synopsis = Synopsis;
        }

        public Film Clone()
        {
            return (Film)this.MemberwiseClone();
        }

        public int Id { get; set; }

        public String Name { get; set; }

        public String ImageUrl { get; set; }

        public Double Popularity { get; set; }

        public String Synopsis { get; set; }
    }
}