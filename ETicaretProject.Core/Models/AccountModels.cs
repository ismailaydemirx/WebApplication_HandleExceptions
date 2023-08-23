﻿using System.ComponentModel.DataAnnotations;

namespace ETicaretProject.Core.Models
{
    public class ApplymentAccountRequestsModel
    {
        [Required]
        [StringLength(25)]
        public string Username { get; set; }
        [Required]
        [StringLength(16, MinimumLength = 6)]
        public string Password { get; set; }
        [Required]
        [StringLength(16, MinimumLength = 6)]
        [Compare(nameof(Password))]
        public string RePassword { get; set; }
        [StringLength(50)]
        public string CompanyName { get; set; }
        [StringLength(50)]
        public string ContactName { get; set; }
        [StringLength(50)]
        [EmailAddress]
        public string ContactEmail { get; set; }
    }

    public class ApplymentAccountResponseModel
    { // response olduğu için annotations'lara gerek yok
        public int Id { get; set; }
        public string Username { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
    }

    public class RegisterRequestModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [Compare(nameof(Password))]
        public string RePassword { get; set; }
    }

    public class RegisterResponseModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
    }

    public class AuthenticateRequestModel
    {
        [Required]
        [StringLength(25)]
        public string Username { get; set; }
        [Required]
        [StringLength(16, MinimumLength = 6)]
        public string Password { get; set; }
    }

    public class AuthenticateResponseModel
    {
        public string Token { get; set; }
    }
}
