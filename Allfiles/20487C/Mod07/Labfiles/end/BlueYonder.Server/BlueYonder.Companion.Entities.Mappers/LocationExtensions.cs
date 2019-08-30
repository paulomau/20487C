﻿using BlueYonder.Entities;
using BlueYonder.Companion.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueYonder.Companion.Entities.Mappers
{
    public static class LocationExtensions
    {
        public static LocationDTO ToLocationDTO(this Location Location)
        {
            LocationDTO dto = new LocationDTO()
            {
                City = Location.City,
                Country = Location.Country,
                LocationId = Location.LocationId,
                State = Location.State,
                TimeZoneId = Location.TimeZoneId,
                CountryCode = Location.CountryCode,
                ThumbnailImageFile = Location.ThumbnailImageFile
            };
            return dto;
        }

        public static Location ToLocation(this LocationDTO dto)
        {
            Location location = new Location()
            {
                City = dto.City,
                Country = dto.Country,
                LocationId = dto.LocationId,
                State = dto.State,
                TimeZoneId = dto.TimeZoneId,
                CountryCode = dto.CountryCode,
                ThumbnailImageFile = dto.ThumbnailImageFile
            };
            return location;
        }
    }
}
