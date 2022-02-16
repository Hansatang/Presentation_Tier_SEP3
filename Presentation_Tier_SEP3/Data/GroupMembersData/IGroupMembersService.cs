using System.Collections.Generic;
using System.Threading.Tasks;
using Presentation_Tier_SEP3.Data.Notifications.NotificationModel;
using Presentation_Tier_SEP3.Model;

namespace Presentation_Tier_SEP3.Data.GroupMembersData
{
    /// <summary>
    /// Interface for GroupMembersService
    /// </summary>
    public interface IGroupMembersService
    {
        public Task<Notification> AddGroupMember(int groupId, int userId);
        public Task<Notification> LeaveGroup(int groupId, int userId);
        public Task<Notification> DeleteGroupMember(int id);
        public Task<IList<GroupMembers>> GetGroupMemberList(int groupId);
    }
}