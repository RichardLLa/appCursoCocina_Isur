using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;
using AE;

namespace BL
{
    public class blMenu
    {
        public aeMenu GetRow(int pIdMenu, ref string pResult)
        {
            aeMenu oList = daMenu.GetDataById(pIdMenu, ref pResult);
            return oList;
        }
        public List<aeMenu> GetRows(int pIdUser, ref string pResult)
        {
            List<aeMenu> oList = daMenu.GetDataByUser(pIdUser, ref pResult);
            return oList;
        }
        public List<aeMenu> GetRowsByParent(int pIdParent, ref string pResult)
        {
            List<aeMenu> oList = daMenu.GetDataByParent(pIdParent, ref pResult);
            return oList;
        }
        public void InsertRow(aeMenu pMenu, ref string pResult)
        {
            daMenu.InsertData(pMenu, ref pResult);
        }
        public void UpdateRow(aeMenu pMenu, ref string pResult)
        {
            daMenu.UpdateData(pMenu, ref pResult);
        }
        public List<aeMenu> GetRowsByIdUser(int pIdUser, ref string pResult)
        {
            return daMenu.GetDataByIdUser(pIdUser, ref pResult);
        }
    }
}
