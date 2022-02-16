using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Presentation_Tier_SEP3.Data.Notifications.NotificationModel;
using Presentation_Tier_SEP3.Model;

namespace Presentation_Tier_SEP3.Data.NoteData
{
    /// <summary>
    /// Interface for NoteService
    /// </summary>
    public interface INoteService
    {
        public Task<IList<Note>> GetNoteList(string s);
        public Task<Notification> AddNote(Note note);
        public Task<Notification> DeleteNote(int id);
        public Task<Notification> EditNote(Note note);
    }
}