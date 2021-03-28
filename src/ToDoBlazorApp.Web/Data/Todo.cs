using System;
using Microsoft.AspNetCore.Identity;

namespace ToDoBlazorApp.Web.Data
{
    public class Todo
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsComplete { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserId { get; set; }

        public virtual IdentityUser User { get; set; }
    }
}
