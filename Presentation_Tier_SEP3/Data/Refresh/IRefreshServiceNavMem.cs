using System;

namespace Presentation_Tier_SEP3.Data.Refresh
{
    /// <summary>
    /// Interface for RefreshServiceNavMem
    /// </summary>
    public interface IRefreshServiceNavMem
    {
        event Action RefreshRequested;
        void CallRequestRefresh();
    }
}