﻿using WebSqlInjectionApi.Helpers;

namespace WebSqlInjectionApi.Models
{
    public class UserInputModel
    {
        public string Email { get; set; }

        [LogExclude] // Exclude this field from logging
        public string Password { get; set; }

        public string Name { get; set; }
    }
}