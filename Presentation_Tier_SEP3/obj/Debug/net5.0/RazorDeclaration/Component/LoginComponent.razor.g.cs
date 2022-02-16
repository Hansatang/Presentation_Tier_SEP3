// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Presentation_Tier_SEP3.Component
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\_Imports.razor"
using Presentation_Tier_SEP3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\_Imports.razor"
using Presentation_Tier_SEP3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\LoginComponent.razor"
using Presentation_Tier_SEP3.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\LoginComponent.razor"
using Presentation_Tier_SEP3.Data.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\LoginComponent.razor"
using Presentation_Tier_SEP3.Data.Notifications.NotificationModel;

#line default
#line hidden
#nullable disable
    public partial class LoginComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\LoginComponent.razor"
       
    //Declaring instance variables
    private string _username;
    private string _password;
    
    // To perform an asynchronous operation we override OnInitializedAsync 
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
    }

    //Method for pefroming login
    public async Task PerformLogin()
    {
        Notification notification = await ((CustomAuthenticationStateProvider) _authenticationStateProvider).ValidateLogin(_username, _password);
        _notificationManager.Show(notification);
        _navigationManager.NavigateTo("/");
        _username = "";
        _password = "";
    }

    //Navigate to new page to register
    public void Register()
    {
        _navigationManager.NavigateTo("/Register");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationManager _notificationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
