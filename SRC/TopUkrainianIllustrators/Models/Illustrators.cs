using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopUkrainianIllustrators.Models
{
    public class Illustrators
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string From { get; set; }
        public string AlmaMater { get; set; }
        public string MagnumOpusHtml { get; set; }

        public string DisplayText
        {
            get
            {
                return Name + From;
            }
        }
        public string CoverImageFileName
        {
            get
            {
                return Name.Replace("", "-").ToLower() + ".jpg";
            }
        }
    }
}