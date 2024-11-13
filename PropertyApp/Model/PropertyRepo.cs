using System;
using System.Collections.Generic;

namespace PropertyApp.Model
{
    class PropertyRepo
    {
        private const string FillerImage = "https://img-v2.gtsstatic.net/reno/imagereader.aspx?imageurl=https%3A%2F%2Fsir.azureedge.net%2F1253i215%2F405swgs93msvmbtn32cn6f8xw3i215&option=N&h=472&permitphotoenlargement=false";

        public static List<Property> AllProperties = new List<Property>
        {
            new Property
            {
                Address = "Manhattan, New York",
                Price = 350550,
                DefaultImage = FillerImage,
                Images = new List<string> { FillerImage, FillerImage, FillerImage }
            },
            new Property
            {
                Address = "Brooklyn Heights, New York",
                Price = 275000,
                DefaultImage = FillerImage,
                Images = new List<string> { FillerImage, FillerImage, FillerImage }
            },
            new Property
            {
                Address = "Upper East Side, New York",
                Price = 520000,
                DefaultImage = FillerImage,
                Images = new List<string> { FillerImage, FillerImage, FillerImage }
            },
            new Property
            {
                Address = "SoHo, New York",
                Price = 425000,
                DefaultImage = FillerImage,
                Images = new List<string> { FillerImage, FillerImage, FillerImage }
            },
            new Property
            {
                Address = "Greenwich Village, New York",
                Price = 390000,
                DefaultImage = FillerImage,
                Images = new List<string> { FillerImage, FillerImage, FillerImage }
            }
        };
    }
}