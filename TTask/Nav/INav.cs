using System;

namespace TTask.Nav
{
    interface INav
    {
        event Action<NavMsg> NewMsg;
    }
}
