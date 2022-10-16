using E_Commerce.Service.Helpers;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Service.Extensions.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MaxFileSizeAttribute : ValidationAttribute
    {
        private readonly bool _isFileNullable;
        private readonly int _maxFileSize;

        public MaxFileSizeAttribute(int maxFileSize, bool isFileNullable = false)
        {
            _maxFileSize = maxFileSize;
            _isFileNullable = isFileNullable;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            // ReSharper disable once ConvertIfStatementToSwitchStatement
            if (value is null && _isFileNullable)
                return ValidationResult.Success;

            if (value is null) return new ValidationResult("Value cannot be null");

            var file = (IFormFile)value;

            return FileSizeHelper.ByteToMB(file.Length) > _maxFileSize
                ? new ValidationResult($"Image must be less than {_maxFileSize} MB")
                : ValidationResult.Success;
        }
    }
}
