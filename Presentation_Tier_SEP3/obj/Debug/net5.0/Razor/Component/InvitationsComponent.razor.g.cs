#pragma checksum "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InvitationsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "007d96f93c08cda4822b87cc6f6d5ea809956e0c"
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
#line 1 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InvitationsComponent.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InvitationsComponent.razor"
using Presentation_Tier_SEP3.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InvitationsComponent.razor"
using Presentation_Tier_SEP3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InvitationsComponent.razor"
using Presentation_Tier_SEP3.Data.GroupMembersData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InvitationsComponent.razor"
using Presentation_Tier_SEP3.Data.InvitationData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InvitationsComponent.razor"
using Presentation_Tier_SEP3.Data.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InvitationsComponent.razor"
using Presentation_Tier_SEP3.Data.Notifications.NotificationModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InvitationsComponent.razor"
using Presentation_Tier_SEP3.Data.Refresh;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InvitationsComponent.razor"
using Presentation_Tier_SEP3.Model;

#line default
#line hidden
#nullable disable
    public partial class InvitationsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Pending invitations</h3>");
#nullable restore
#line 20 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InvitationsComponent.razor"
 if (InvitationList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<progress></progress>");
#nullable restore
#line 23 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InvitationsComponent.razor"
}
else if (InvitationList.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p>\r\n        You don\'t have any invitations yet.\r\n        <br>\r\n        You can wait for other users to invite or you can create group on the left\r\n    </p>");
#nullable restore
#line 31 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InvitationsComponent.razor"
}
else
{
    foreach (Invitation invitation in InvitationList)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card mb-2");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-header container");
            __builder.AddMarkupContent(7, "\r\n                User ");
            __builder.OpenElement(8, "b");
            __builder.AddContent(9, 
#nullable restore
#line 38 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InvitationsComponent.razor"
                         invitation.invitorName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(10, " wants you to be apart of group ");
            __builder.OpenElement(11, "b");
            __builder.AddContent(12, 
#nullable restore
#line 38 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InvitationsComponent.razor"
                                                                                       invitation.groupName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-body row");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "class", "col-6");
            __builder.AddAttribute(19, "style", "background-color: darkgreen ");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InvitationsComponent.razor"
                                    () => AcceptInvitation(invitation.inviteeId, invitation.groupId, invitation.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "\r\n                    Accept\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "type", "button");
            __builder.AddAttribute(25, "class", "col-6");
            __builder.AddAttribute(26, "style", "background-color: red");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InvitationsComponent.razor"
                                                                                              () => RemoveInvitation(invitation.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Decline");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InvitationsComponent.razor"
    }

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\InvitationsComponent.razor"
       
    // Parameter to specify which user opens the InvitationsComponent component
    [Parameter]
    public String UserId { get; set; }

    // List of invitations where the user which opened the component is the invitee of.
    public IList<Invitation> InvitationList { get; set; }

    // Method that is first to run when component is initialized.
    protected override async Task OnInitializedAsync()
    {
        InvitationList = await _invitationService.GetInvitationList(int.Parse(UserId));
    }

    // Method used by <EditForm> component to remove an invitation.
    private async Task RemoveInvitation(int id)
    {
        Notification notification = await _invitationService.DeleteInvitation(id);
        await _notificationManager.Show(notification);
        InvitationList = await _invitationService.GetInvitationList(int.Parse(UserId));
    }

    // Method used by <EditForm> component to accept an invitation.
    private async Task AcceptInvitation(int groupId, int userId, int invitationId)
    {
        Notification notification = await _groupMembersService.AddGroupMember(groupId, userId);
          await ((CustomAuthenticationStateProvider) _authenticationStateProvider).ModifyClaims();
        _notificationManager.Show(notification);
        _refreshServiceNavMem.CallRequestRefresh();
        _refreshServiceInvGroup.CallRequestRefresh();
        await _invitationService.DeleteInvitation(invitationId);
        InvitationList = await _invitationService.GetInvitationList(int.Parse(UserId));
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationManager _notificationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGroupMembersService _groupMembersService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRefreshServiceInvGroup _refreshServiceInvGroup { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRefreshServiceNavMem _refreshServiceNavMem { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInvitationService _invitationService { get; set; }
    }
}
#pragma warning restore 1591