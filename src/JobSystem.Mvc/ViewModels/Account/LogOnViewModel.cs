﻿using System.ComponentModel.DataAnnotations;

namespace JobSystem.Mvc.ViewModels.Account
{
    public class LogOnViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}