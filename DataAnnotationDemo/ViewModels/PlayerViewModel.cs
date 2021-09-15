using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using DataAnnotationDemo.Attributes.CustomValidations;
using DataAnnotationDemo.Enums;
using DataAnnotationDemo.Models;
using DataAnnotationDemo.Properties;

namespace DataAnnotationDemo.ViewModels
{
    public class PlayerViewModel : Player
    {
        [Display(Order = 0,
                 Name = "UserProfilepictureName",
                 ResourceType = typeof(Resources),
                 Description = "UserProfilepictureDescription"), 
         Editable(false)]
        public override Image Profilepicture { get; set; }

        [Display(ResourceType = typeof(Resources), 
                 Description = "UserIdDescription",
                 AutoGenerateField = false),
        Editable(false)]
        public override int Id { get; set; }

        [Display(GroupName = "{Tabs}/Persönliche Daten",
                 Name = "Vorname"),
         Required(AllowEmptyStrings = false, ErrorMessage = "Der Vorname ist ein Pflichtfeld.")]
        public override string Forname { get; set; }

        [Display(GroupName = "{Tabs}/Persönliche Daten", 
                 Order = 3,
                 Name = "Nachname"), 
         Required(AllowEmptyStrings = false, ErrorMessage = "Der Nachname ist ein Pflichtfeld.")]
        public override string LastName { get; set; }

        [Display(GroupName = "{Tabs}/Benutzerdaten"),
         DataType(DataType.EmailAddress),
         IsEmail(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "EmailErrorMessage")]
        public override string Email { get; set; }

        [Display(GroupName = "GroupNameBenutzerdatenTab",
                 ResourceType = typeof(Resources), 
                 Name = "PasswordName", 
                 Description = "PasswordDescription"),
         DataType(DataType.Password), 
         StringLength(20, MinimumLength = 5, 
                      ErrorMessageResourceType = typeof(Resources), 
                      ErrorMessageResourceName = "PasswordStringLengthErrorMessage")
        ]
        public override string Password { get; set; }

        [Display(GroupName = "{Tabs}/Persönliche Daten", 
                 Name = "Geburtsdatum")]
        public override DateTime? BirthDate { get; set; }

        [Display(Name = "Position",
                GroupName = "{Tabs}/Spielerdaten"),
         Required(ErrorMessage = "Der Typ des Benutzers ist ein Pflichtfeld."),
         EnumDataType(typeof(enmPlayerPositions))]
        public override int PlayerPosition { get; set; }
    }
}