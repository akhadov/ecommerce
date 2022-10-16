﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Service.Extensions.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class AllowedFileExtensions : ValidationAttribute
    {
        private readonly string[] _extensions;
        private readonly bool _isFileNullable;

        public AllowedFileExtensions(string[] extensions, bool isFileNullable = false)
        {
            _extensions = extensions;
            _isFileNullable = isFileNullable;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            // ReSharper disable once ConvertIfStatementToSwitchStatement
            if (value is null && _isFileNullable)
                return ValidationResult.Success;

            if (value is null) return new ValidationResult("Value cannot be null");

            var file = (IFormFile)value;
            var extensions = Path.GetExtension(file.FileName);

            return _extensions.Contains(extensions.ToLower())
                ? ValidationResult.Success
                : new ValidationResult("The file extensions is not supported");
        }
    }
}
