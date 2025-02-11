﻿using System.ComponentModel.DataAnnotations;

namespace nestHome.ViewModels;

public class ForgotPasswordViewModel
{
    [Required, DataType(DataType.EmailAddress)]
    public string Email { get; set; }
}