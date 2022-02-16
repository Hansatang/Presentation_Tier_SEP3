using System;

namespace Presentation_Tier_SEP3.Data.Refresh
{
    public class RefreshServiceNavMem : IRefreshServiceNavMem
    {
        /// <summary>
        /// Method occurs when an update of the content has been initiated
        /// </summary>
        public event Action RefreshRequested;
        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }
    }
}