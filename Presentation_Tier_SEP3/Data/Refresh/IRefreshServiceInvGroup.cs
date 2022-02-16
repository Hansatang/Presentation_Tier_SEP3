using System;

namespace Presentation_Tier_SEP3.Data.Refresh
{
    /// <summary>
    /// Interface for RefreshServiceInvGroup
    /// </summary>
    public interface IRefreshServiceInvGroup
    {
        event Action RefreshRequested;
        void CallRequestRefresh();
    }
}