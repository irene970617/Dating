using Microsoft.AspNetCore.Components;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; } 
        // if the name is Id it will be the primary key by default
        // Default is 0
        public string UserName { get; set; }
        // make the default optional so put the ? after string
        // or we can go to API.csproj and change the Nullable into disable
    }
}