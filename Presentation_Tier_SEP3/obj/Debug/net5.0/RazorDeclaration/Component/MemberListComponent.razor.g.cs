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
#line 1 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\MemberListComponent.razor"
using Presentation_Tier_SEP3.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\MemberListComponent.razor"
using Presentation_Tier_SEP3.Data.GroupMembersData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\MemberListComponent.razor"
using Presentation_Tier_SEP3.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\MemberListComponent.razor"
using Presentation_Tier_SEP3.Data.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\MemberListComponent.razor"
using Presentation_Tier_SEP3.Data.Notifications.NotificationModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\MemberListComponent.razor"
using Presentation_Tier_SEP3.Data.Refresh;

#line default
#line hidden
#nullable disable
    public partial class MemberListComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 101 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\MemberListComponent.razor"
       
    // Parameter to specify which group the members are in.
    [Parameter]
    public int GroupId { get; set; }

    [Parameter]
    public string GroupName { get; set; }

    // List of object GroupMembers.
    public IList<GroupMembers> GroupMembersList { get; set; }

    // User object to be initialized as the user logged in.
    private User _cachedUser;

    // Method that is first to run when component is initialized.
    protected override async Task OnInitializedAsync()
    {
        _cachedUser = ((CustomAuthenticationStateProvider) _authenticationStateProvider).CachedUser;
        GroupMembersList = await _groupMembersService.GetGroupMemberList(GroupId);
    }

    protected override async void OnParametersSet()
    {
        GroupMembersList = await _groupMembersService.GetGroupMemberList(GroupId);
        StateHasChanged();
    }

    // Method to let the user logged in leave to group. 
    private async Task LeaveGroup()
    {
        Notification notification = await _groupMembersService.LeaveGroup(GroupId, _cachedUser.id);
        _notificationManager.Show(notification);
        await ((CustomAuthenticationStateProvider) _authenticationStateProvider).ModifyClaims();
        _refreshServiceNavMem.CallRequestRefresh();
        _navigationManager.NavigateTo("/");
    }

    // Method to let user logged in remove other members from the group.
    private async Task DeleteMember(int id)
    {
        Notification notification = await _groupMembersService.DeleteGroupMember(id);
        _notificationManager.Show(notification);
        GroupMembersList = await _groupMembersService.GetGroupMemberList(GroupId);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationManager _notificationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRefreshServiceNavMem _refreshServiceNavMem { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGroupMembersService _groupMembersService { get; set; }
    }
}
#pragma warning restore 1591