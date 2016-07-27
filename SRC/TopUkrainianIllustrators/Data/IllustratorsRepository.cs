using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopUkrainianIllustrators.Models;

namespace TopUkrainianIllustrators.Data
{
    public class IllustratorsRepository
    {
        private static Illustrators[] _illustrators = new Illustrators[]
            {
                new Illustrators()
                {
                Name = "Volodymyr Holozubov",
                From = "Kyiv",
                AlmaMater = "Taras Shevchenko State Art School",
                MagnumOpusHtml = "<p><strong>Maggie Magpie</strong> (1970, Kyiv, Veselka), <strong>Two chanticleers</strong> (1970, Kyiv, Veselka)</p>",
                },
                new Illustrators()
                {
                Name = "Vyacheslav Lehkobyt",
                From = "Khotovo (Kyiv region)",
                AlmaMater = "The National Academy of Fine Arts and Architecture",
                MagnumOpusHtml = "<p><strong>Stepan Rudanskyy – The Wolves</strong> (1967, Kyiv, Veselka), <strong>Mykola Palahuta – Burbura</strong> (1967, Kyiv, Veselka)</p>",
                },
                new Illustrators()
                {
                Name = "Kost Lavro",
                From = "Poltava",
                AlmaMater = "Taras Shevchenko State Art School",
                MagnumOpusHtml = "<p><strong>Pan Kotskyy</strong> (1997, Kyiv, A-BA-BA-HA-LA-MA-HA), <strong>Mykola Hohol – Christmas Eve</strong> (2005, Kyiv, A-BA-BA-HA-LA-MA-HA)</p>",
                }
            };

        public Illustrators GetIllustrators(int id)
        {
            Illustrators illustratorToReturn = null;

            foreach (var illustrator in _illustrators)
            {
                if (illustrator.Id == id)
                {
                    illustratorToReturn = illustrator;
                    break;
                }
            }

            return illustratorToReturn;
        }
    }
}