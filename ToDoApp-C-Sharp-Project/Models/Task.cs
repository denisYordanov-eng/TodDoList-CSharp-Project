using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoApp_C_Sharp_Project.Models
{
    public class Task
    {
    
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
    }
}