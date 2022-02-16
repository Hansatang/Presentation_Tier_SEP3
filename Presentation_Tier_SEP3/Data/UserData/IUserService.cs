using System.Collections.Generic;
using System.Threading.Tasks;
using Presentation_Tier_SEP3.Data.Notifications.NotificationModel;
using Presentation_Tier_SEP3.Model;

namespace Presentation_Tier_SEP3.Data.UserData
{
    /// <summary>
    /// Interface for UserService
    /// </summary>
    public interface IUserService
    {
        public Task<User> ValidateUser(string username, string password);
        public Task<Notification> RegisterUser(User user);
        public Task<Notification> EditUser(int id, string newPassword);
        public Task<List<User>> GetUserList(string username);
        public Task<Notification> DeleteUser(int id);
    }
}