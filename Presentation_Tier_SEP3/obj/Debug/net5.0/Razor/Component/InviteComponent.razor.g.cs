#pragma checksum "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4a08c047c28dc0afbc2ea14f6249423e97ae0e9"
// <auto-generated/>
#pragma warning disable 1591
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
#line 1 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
using Presentation_Tier_SEP3.Data.UserData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
using Presentation_Tier_SEP3.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
using Presentation_Tier_SEP3.Data.InvitationData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
using Presentation_Tier_SEP3.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
using Presentation_Tier_SEP3.Data.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
using Presentation_Tier_SEP3.Data.Notifications.NotificationModel;

#line default
#line hidden
#nullable disable
    public partial class InviteComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "<br>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-12 ");
            __builder.AddMarkupContent(5, "<div class=\"p-3 mb-2 bg-primary text-white\">\r\n            Invite to group\r\n        </div>");
#nullable restore
#line 20 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
         if (!Temp)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group d-flex flex-row align-items-center justify-content-start m-1");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "d-flex flex-column");
            __builder.AddMarkupContent(10, "<div class=\"input-group\"><label>Search for a new member </label></div>\r\n                    ");
            __builder.OpenElement(11, "div");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "placeholder", "Type the username ");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
                                                                                         Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Username = __value, Username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "div");
            __builder.OpenElement(19, "div");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-primary btn-block m-2");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
                                                                                Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Search");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "d-flex flex-row align-items-center justify-content-start m-1");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "d-flex flex-column");
            __builder.AddMarkupContent(28, "<div class=\"input-group\"><label>Search for a new member </label></div>\r\n                    ");
            __builder.OpenElement(29, "div");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "text");
            __builder.AddAttribute(32, "placeholder", "Type the username ");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
                                                                                         Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Username = __value, Username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "div");
            __builder.OpenElement(37, "div");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn btn-primary btn-block m-2");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
                                                                                Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Search");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-sm-6");
            __builder.AddAttribute(45, "style", "display:inline");
            __builder.OpenElement(46, "ul");
            __builder.AddAttribute(47, "class", "list-group d-flex flex-row align-items-center justify-content-between");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-8");
#nullable restore
#line 58 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
                         foreach (var user in TempUsers)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "card mb-2");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "card-body row");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "col-6");
            __builder.AddMarkupContent(56, "<a>Name</a>: ");
            __builder.OpenElement(57, "b");
            __builder.AddContent(58, 
#nullable restore
#line 63 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
                                                         user.firstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(59, " ");
            __builder.AddContent(60, 
#nullable restore
#line 63 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
                                                                         user.lastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                    ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "col-6");
            __builder.AddMarkupContent(64, "<a>Username</a>: ");
            __builder.OpenElement(65, "b");
            __builder.AddContent(66, 
#nullable restore
#line 66 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
                                                             user.username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                                    ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "card-header container d-flex flex-row align-items-center justify-content-center");
            __builder.OpenElement(70, "a");
            __builder.AddAttribute(71, "class", "btn btn-primary");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
                                                                               () => InviteUser(user)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "style", "display:" + (
#nullable restore
#line 69 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
                                                                                                                        Temp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(74, "Invite");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 73 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 77 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InviteComponent.razor"
 
    // Parameter to specify which group the invitee will be invited to.
    [Parameter]
    public int GroupId { get; set; }

    [Parameter]
    public string GroupName { get; set; }

    // Object for <EditForm> to use as a username when inviting.
    public string Username = "";

    // ???
    public bool Temp = false;

    // Lists of users used when searching.
    public List<User> Users;
    public List<User> TempUsers;

    // User object reserved for the user which opens the component.
    private User _cachedUser;

    // Method that is first to run when component is initialized.
    protected override async Task OnInitializedAsync()
    {
        _cachedUser = ((CustomAuthenticationStateProvider) _authenticationStateProvider).CachedUser;
    }

    // Method to search for users.
    private async Task Search()
    {
      
        if (!Username.Equals(""))
        {
            Users = await _userService.GetUserList(Username);
            TempUsers = new List<User>();
            foreach (var user in Users)
            {
                if (!user.username.Equals(_cachedUser.username))
                {
                    TempUsers.Add(user);
                }
            }
            if (TempUsers != null)
            {
                Temp = true;
            }
        }
        else
        {
            Temp = false;
        }
    }

    // Method to invite a user to group the component is opened in.
    private async Task InviteUser(User user)
    {
        Invitation invitation = new Invitation(0, GroupId, null, user.id, null, _cachedUser.id, null);
        Notification notification = await _invitationService.AddInvitation(invitation);
        await _notificationManager.Show(notification);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationManager _notificationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInvitationService _invitationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _userService { get; set; }
    }
}
#pragma warning restore 1591
