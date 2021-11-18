using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yechtch.IMS
{
    public class SysConfigHelper
    {
        private static IMSDBHelper<sysconfig> sysconfigDbHelper = null;
        private static IList<sysconfig> g_listsysconfig = null;
        static SysConfigHelper()
        {
            sysconfigDbHelper = new IMSDBHelper<sysconfig>();
            g_listsysconfig = sysconfigDbHelper.FindList(x => x.id >0);
        }

        public static IList<sysconfig> GetConfigByGroupName(string groupName)
        {
            IList<sysconfig> sysconfigs = new List<sysconfig>();

            var restult = g_listsysconfig.Where(x =>x.groupname == groupName);

            foreach(var v in restult)
            {
                sysconfigs.Add(v);
            }

            return sysconfigs;
        }




    }

}
