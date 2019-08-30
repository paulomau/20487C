﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BlueYonder.Entities
{
    public class Location
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocationId { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string CountryCode { get; set; }

        [NotMapped]
        public TimeZoneInfo LocationTimeZone { get; set; }

        public string ThumbnailImageFile { get; set; }

        public string TimeZoneId
        {
            get
            {
                return LocationTimeZone.Id;
            }
            set
            {
                LocationTimeZone = TimeZoneInfo.FindSystemTimeZoneById(value);                
            }
        }
    }
}