using System.Collections.Generic;
using System.Linq;

namespace HomeForms.Actions
{
    public static class UpdateHeartBeat
    {
        public static void ClearAll()
        {
            foreach (ServerNameStatusData sns in (ServerNameStatus.ServerList))
            {
                sns.Status = "Unknown";
            }
        }

        public static List<string> ServerNames()
        {
            return ServerNameStatus.ServerList.Select(x => x.Name).ToList();
        }

        public static void UpdateHeartBeart()
        {
            UpdateList(ServerNameStatus.ServerList);
        }

        public static void UpdateHeartBeartGroup(string group)
        {
            group = group.ToUpper();
            List<ServerNameStatusData> servers = ServerNameStatus.ServerList.Where(x => x.Group.Contains(group)).ToList();
            UpdateList(servers);
        }

        private static void UpdateList(List<ServerNameStatusData> servers)
        {
            foreach (ServerNameStatusData sns in servers)
            {
                sns.UpdateStatus();
            }
        }
    }
}
