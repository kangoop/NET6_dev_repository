﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BikeShop.Models;

namespace BikeShop.ViewModels
{
    public class ViewCategory
    {

        public int? Id { get; set; }

        public string? name { get; set; }

        public ViewCategory(Category category)
        {
            Id = category.Id;
            name = category.name;
        }
    }
}
