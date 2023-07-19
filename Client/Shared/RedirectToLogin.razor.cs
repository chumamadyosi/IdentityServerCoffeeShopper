using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Client.Shared
{
    public partial class RedirectToLogin
    {
        [Inject] public NavigationManager Navigation { get; set; }
        public RedirectToLogin()
        {
            Navigation.NavigateTo($"/login?redirectUri={Uri.EscapeDataString(Navigation.Uri)}", true);
        }
    }
}
