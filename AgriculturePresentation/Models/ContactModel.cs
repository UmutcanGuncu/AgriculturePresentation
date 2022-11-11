using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class ContactModel
    {
        [Key]
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactMail { get; set; }
        public string ContactDetail { get; set; }
        public DateTime ContactDate { get; set; }
    }
}
