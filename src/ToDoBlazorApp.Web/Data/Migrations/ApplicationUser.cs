using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ToDoBlazorApp.Web.Data.Migrations
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.Todos = new HashSet<Todo>();
        }

        public virtual ICollection<Todo> Todos { get; set; }
    }
}
