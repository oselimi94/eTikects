﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTikects.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePicture { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        public List<Actor_movie> Actors_Movies { get; set; }
    }
}