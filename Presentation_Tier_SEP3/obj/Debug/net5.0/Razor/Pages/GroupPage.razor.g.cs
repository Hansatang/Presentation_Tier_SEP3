#pragma checksum "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afcf54a06b6dfc9295260d8a298cc994b166cc53"
// <auto-generated/>
#pragma warning disable 1591
namespace Presentation_Tier_SEP3.Pages
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
#line 4 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
using Microsoft.AspNetCore.Components.Web.Extensions.Head;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
using Presentation_Tier_SEP3.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
using Presentation_Tier_SEP3.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
using Presentation_Tier_SEP3.Data.GroupMembersData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
using Presentation_Tier_SEP3.Data.NoteData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
using Presentation_Tier_SEP3.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
using Presentation_Tier_SEP3.Data.GroupData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
using Presentation_Tier_SEP3.Data.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
using Presentation_Tier_SEP3.Data.Notifications.NotificationModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
using Presentation_Tier_SEP3.Data.Refresh;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GroupPage")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/GroupPage/{Id:int}/{GroupName}")]
    public partial class GroupPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Web.Extensions.Head.Title>(0);
            __builder.AddAttribute(1, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
                "Group " + Id

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(3);
            __builder.AddAttribute(4, "Roles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
                       Id.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "<p>You don\'t belong to this group</p>\r\n        ");
                __builder2.AddMarkupContent(7, "<a href=\"/\">Go back</a>");
            }
            ));
            __builder.AddAttribute(8, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "d-flex flex-row align-items-center justify-content-between");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "style", "margin-top: 0.5rem");
                __builder2.OpenElement(13, "h3");
                __builder2.AddContent(14, "GroupPage ");
                __builder2.AddContent(15, 
#nullable restore
#line 34 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
                               GroupName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenElement(17, "div");
                __builder2.OpenElement(18, "button");
                __builder2.AddAttribute(19, "class", "btn btn-danger btn-sm");
                __builder2.AddAttribute(20, "data-bs-toggle", "modal");
                __builder2.AddAttribute(21, "data-bs-target", 
#nullable restore
#line 37 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
                                                                                               "#exampleDelete" + Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(22, "\r\n                    Delete group\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "modal fade");
                __builder2.AddAttribute(26, "id", 
#nullable restore
#line 40 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
                                              "exampleDelete" + Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(27, "tabindex", "-1");
                __builder2.AddAttribute(28, "role", "dialog");
                __builder2.AddAttribute(29, "aria-labelledby", 
#nullable restore
#line 40 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
                                                                                                                    "exampleModalCenterTitle" + Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(30, "aria-hidden", "true");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "modal-dialog modal-dialog-centered");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "modal-content");
                __builder2.AddAttribute(35, "style", "background-color: white");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "modal-header");
                __builder2.OpenElement(38, "h5");
                __builder2.AddAttribute(39, "class", "modal-title");
                __builder2.AddAttribute(40, "id", 
#nullable restore
#line 44 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
                                                              "#exampleModalLongTitle" + Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(41, "style", "color: black;");
                __builder2.AddContent(42, "Are you sure you want to delete this group?");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                                <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"modal\" aria-label=\"Cancel\"></button>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                            ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "modal-footer");
                __builder2.AddMarkupContent(47, "<button type=\"button\" class=\"btn btn-secondary\" data-bs-dismiss=\"modal\">Cancel</button>\r\n                                ");
                __builder2.OpenElement(48, "button");
                __builder2.AddAttribute(49, "type", "button");
                __builder2.AddAttribute(50, "class", "btn btn-primary");
                __builder2.AddAttribute(51, "data-bs-dismiss", "modal");
                __builder2.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
                                                                                                                  RemoveGroup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(53, "Save changes");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.OpenComponent<Presentation_Tier_SEP3.Component.TabControl>(55);
                __builder2.AddAttribute(56, "Page", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 56 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
                           Page

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Presentation_Tier_SEP3.Component.TabPage>(58);
                    __builder3.AddAttribute(59, "Text", "Notes");
                    __builder3.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Presentation_Tier_SEP3.Component.NoteListComponent>(61);
                        __builder4.AddAttribute(62, "GroupId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 58 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
                                             Id

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(63, "GroupName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
                                                             GroupName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\r\n            ");
                    __builder3.OpenComponent<Presentation_Tier_SEP3.Component.TabPage>(65);
                    __builder3.AddAttribute(66, "Text", "Members");
                    __builder3.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(68, "div");
                        __builder4.AddAttribute(69, "class", "row d-flex justify-content-between");
                        __builder4.OpenElement(70, "div");
                        __builder4.AddAttribute(71, "class", "col-sm-6");
                        __builder4.OpenComponent<Presentation_Tier_SEP3.Component.MemberListComponent>(72);
                        __builder4.AddAttribute(73, "GroupId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 63 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
                                                       Id

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(74, "GroupName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
                                                                       GroupName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(75, "\r\n                    ");
                        __builder4.OpenElement(76, "div");
                        __builder4.AddAttribute(77, "class", "col-sm-6");
                        __builder4.OpenComponent<Presentation_Tier_SEP3.Component.InviteComponent>(78);
                        __builder4.AddAttribute(79, "GroupId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 66 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
                                                   Id

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(80, "GroupName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
                                                                   GroupName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Pages\GroupPage.razor"
       

    //Instance variables
    [Parameter]
    public int Id { get; set; }
    [Parameter]
    public string? GroupName { get; set; }
    [Parameter]
    public int Page { get; set; }
    [CascadingParameter]
    protected Task<AuthenticationState> AuthStat { get; set; }
    
    public IList<Note> Notes { get; set; }
    public IList<GroupMembers> GroupMembersList { get; set; }

    // Method to run, when user enters this page.
    protected override async Task OnInitializedAsync()
    {
        Notes = await _noteService.GetNoteList(Id.ToString());
        GroupMembersList = await _groupMembersService.GetGroupMemberList(Id);
    }
    
    //This method notifies the component that its state has changed.

    protected override void OnParametersSet()
    {
        StateHasChanged();
    }

    //Method removes group
    private async void RemoveGroup()
    {
        Notification notification = await _groupService.DeleteGroup(Id.ToString());
        _notificationManager.Show(notification);
        await ((CustomAuthenticationStateProvider) _authenticationStateProvider).ModifyClaims();
        _navigationManager.NavigateTo("/");
        _refreshServiceNavMem.CallRequestRefresh();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationManager _notificationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGroupService _groupService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRefreshServiceNavMem _refreshServiceNavMem { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGroupMembersService _groupMembersService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INoteService _noteService { get; set; }
    }
}
#pragma warning restore 1591
