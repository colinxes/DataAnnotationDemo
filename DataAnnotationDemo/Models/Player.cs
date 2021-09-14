using System;
using System.Drawing;

namespace DataAnnotationDemo.Models
{
    public class Player
    {
        public virtual Image Profilepicture { get; set; }

        public virtual int Id { get; set; }

        public virtual string Forname { get; set; }

        public virtual string LastName { get; set; }

        public virtual string Email { get; set; }

        public virtual string Password { get; set; }

        public virtual DateTime? BirthDate { get; set; }

        public virtual int PlayerPosition { get; set; }
    }
}