using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Presentation_Tier_SEP3.Data.Notifications.NotificationModel;
using Presentation_Tier_SEP3.Model;

namespace Presentation_Tier_SEP3.Data.GroupData
{
    /// <summary>
    /// Interface for GroupService
    /// </summary>
    public interface IGroupService
    {
        public Task<Notification> AddGroup(string groupName, int memberId);

        public Task<Notification> DeleteGroup(string s);

        public Task<IList<Group>> GetGroupList(int groupId);
    }
}