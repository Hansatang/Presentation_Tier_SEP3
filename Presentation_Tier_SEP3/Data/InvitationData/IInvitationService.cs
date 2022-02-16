using System.Collections.Generic;
using System.Threading.Tasks;
using Presentation_Tier_SEP3.Data.Notifications.NotificationModel;
using Presentation_Tier_SEP3.Model;

namespace Presentation_Tier_SEP3.Data.InvitationData
{
    /// <summary>
    /// Interface for InvitationService
    /// </summary>
    public interface IInvitationService
    {
        public Task<IList<Invitation>> GetInvitationList(int userId);
        public Task<Notification> AddInvitation(Invitation invitation);
        public Task<Notification> DeleteInvitation(int invitationId);
    }
}