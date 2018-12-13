﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using System.Linq;
using System.Web;

namespace Profilz.Models
{
    [Table("Users")]
    public class User : Model
    {

        [Required(ErrorMessage="Nom d'utilisateur requis")]
        [DisplayName("Nom utilisateur")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Adresse email requise")]
        [DisplayName("Adresse Email")]
        [StringLength(64)]
        [EmailAddress(ErrorMessage ="Adresse Email invalide")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Mot de passe requis")]
        [DisplayName("Mot de passe")]
        [MinLength(8)]
        public string Password { get; set; }

        [NotMapped]
        [HiddenInput(DisplayValue = false)]
        public bool IsAuthenticated { get; set; } = false;

        public User()
        {

        }
        
        public override void UpdateFrom(Model source)
        {
            if (source is User user && user.Id == Id)
            {
                this.Username = user.Username;
                this.Email = user.Email;
            }
        }

        
        
    }

    
}