#pragma checksum "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\TabPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15663d5be5164829f8d8c576761c65ed4ef9f6f8"
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
    public partial class TabPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\TabPage.razor"
 if (Parent.ActivePage == this)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 3 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\TabPage.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 3 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\TabPage.razor"
                 
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\TabPage.razor"
       
    //To make use of cascading values we declare cascading parameter
    [CascadingParameter]
    private TabControl Parent { get; set; }

    //Instance variables
    [Parameter]
    public RenderFragment ChildContent { get; set; }
    
    [Parameter]
    public string Text { get; set; }

    // Method to run, when user enters this page.
    protected override void OnInitialized()
    {
        if (Parent == null)
            throw new ArgumentNullException(nameof(Parent), "TabPage must exist within a TabControl");
        base.OnInitialized();
        Parent.AddPage(this);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591