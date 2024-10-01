using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CIS174_CoreApp.Models
{
    public class Student
    {
        // EF Core will configure the database to generate this value
        public int StudentId { get; set; }

        // string.Empty is used to inialize the empty string, clarify it's data type and more.
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Grade { get; set; } = string.Empty;

    }
}
