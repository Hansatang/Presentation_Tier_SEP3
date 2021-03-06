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
#line 1 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\NoteListComponent.razor"
using Presentation_Tier_SEP3.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\NoteListComponent.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\NoteListComponent.razor"
using Presentation_Tier_SEP3.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\NoteListComponent.razor"
using Presentation_Tier_SEP3.Data.NoteData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\NoteListComponent.razor"
using Presentation_Tier_SEP3.Data.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\NoteListComponent.razor"
using Presentation_Tier_SEP3.Data.Notifications.NotificationModel;

#line default
#line hidden
#nullable disable
    public partial class NoteListComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 160 "C:\Users\krzys\RiderProjects\Presentation_Tier_SEP3\Presentation_Tier_SEP3\Component\NoteListComponent.razor"
      
    // Parameter to specify what Group and GroupName object is in focus.
    [Parameter]
    public int GroupId { get; set; }

    [Parameter]
    public string GroupName { get; set; }

    //To make use of cascading values we declare cascading parameter
    [CascadingParameter]
    protected Task<AuthenticationState> AuthStat { get; set; }
    
    //Instance variables
    private int _searchedWeek;
    private int _searchedYear;
    
    private IList<Note> NoteList { get; set; }
    private DateTime _time = DateTime.Today;

    // Note object to be used 
    private Note _template = new Note(0, 0, 0, 0, "", "", "");

    private User _loggedInUser;

    // Method to run, when user enters this page.
    protected override async Task OnInitializedAsync()
    {
        _searchedWeek = GetIsoWeekOfYear(_time);
        _searchedYear = GetIsoYear(_time);
    // Get the selected group's notes
        NoteList = await _noteService.GetNoteList(GroupId.ToString());

    // Set the LoggedInUser equal to the User the custom Authentication service gets.
        _loggedInUser = ((CustomAuthenticationStateProvider) _authenticationStateProvider).CachedUser;

    // Instantiate Template note for the EditForm component.
        _template = new Note(0, GroupId, GetIsoWeekOfYear(_time), GetIsoYear(_time), "", "Not started", "");
    }

    //This method notifies the component that its state has changed.
    protected override async void OnParametersSet()
    {
        NoteList = await _noteService.GetNoteList(GroupId.ToString());
        StateHasChanged();
    }

    // Show the notes further ahead in time and prevent going past week 52.
    private void NextPage()
    {
        var dateTime = _time.Add(TimeSpan.FromDays(7 * 3));
        _time = dateTime;
    }

    // Show the notes further behind in time and prevent going before week 1.
    private void PreviousPage()
    {
        var dateTime = _time.Subtract(TimeSpan.FromDays(7 * 3));
        _time = dateTime;
    }

    // Using Calender Library method to get the week of today??.
    private static int GetIsoWeekOfYear(DateTime time)
    {
        DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
        if (day is >= DayOfWeek.Monday and <= DayOfWeek.Wednesday)
        {
            time = time.AddDays(3);
        }
        return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
    }

    //Used to define the year in calander
    private static int GetIsoYear(DateTime time)
    {
        return CultureInfo.InvariantCulture.Calendar.GetYear(time);
    }

    //Method to get the date
    async Task ClickHandler()
    {
        NoteList = await _noteService.GetNoteList(GroupId.ToString());
    }

    //Method adds note
    private async Task SubmitAddNote()
    {
        if (_template.name.Equals("") || _template.name.Equals(null))
        {
            _template.name = "Note";
        }
        Notification notification = await _noteService.AddNote(new Note(0,  GroupId, _template.week, _template.year, _template.name, _template.status, _template.text));
        NoteList = await _noteService.GetNoteList(GroupId.ToString());
        _template = new Note(0, GroupId, GetIsoWeekOfYear(_time), GetIsoYear(_time), "", "Not started", "");
        _notificationManager.Show(notification);
    }

    //Method search by week and year
    private void Search()
    {
        if (_searchedWeek < 0)
        {
            _searchedWeek = 1;
        }
        else if (_searchedWeek > 52)
        {
            _searchedWeek = 52;
        }
        DateTime temp = FirstDateOfWeek(_searchedYear, _searchedWeek);
        _time = temp;
    }

    //Defines first date of the week in a new year
    public static DateTime FirstDateOfWeek(int year, int weekOfYear)
    {
        DateTime jan1 = new DateTime(year, 1, 1);
        int daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;

    // Use first Thursday in January to get first week of the year as
    // it will never be in Week 52/53
        DateTime firstThursday = jan1.AddDays(daysOffset);
        Calendar cal = CultureInfo.CurrentCulture.Calendar;
        int firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

        int weekNum = weekOfYear;
    // As we're adding days to a date in Week 1,
    // we need to subtract 1 in order to get the right date for week #1
        if (firstWeek == 1)
        {
            weekNum -= 1;
        }

    // Using the first Thursday as starting week ensures that we are starting in the right year
    // then we add number of weeks multiplied with days
        DateTime result = firstThursday.AddDays(weekNum * 7);

    // Subtract 3 days from Thursday to get Monday, which is the first weekday in ISO8601
        return result.AddDays(-3);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationManager _notificationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INoteService _noteService { get; set; }
    }
}
#pragma warning restore 1591
