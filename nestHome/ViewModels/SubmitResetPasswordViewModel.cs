﻿using System.ComponentModel.DataAnnotations;

namespace nestHome.ViewModels
{
    public class SubmitResetPasswordViewModel
    {
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
