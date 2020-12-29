using System;
using System.ComponentModel.DataAnnotations;
namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Name Ris required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location Required!")]
        public string Location { get; set; }


    }
}