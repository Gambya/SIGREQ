using SIGREQ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGREQ.Controller
{
    public class TipoStackholderController
    {
        public List<TIPOSTACKHOLDER> GetAll()
        {
            using(sigreqEntities ctx = new sigreqEntities())
            {
                var tstackholder = ctx.TIPOSTACKHOLDER.ToList();
                return tstackholder;
            }
        }

        public TIPOSTACKHOLDER GetTipoStackholder(int tipoStackholderId)
        {
            using(sigreqEntities ctx = new sigreqEntities())
            {
                return ctx.TIPOSTACKHOLDER.Where(t => t.TIPOSTACKHOLDERID == tipoStackholderId).FirstOrDefault();
            }
        }

        public void InserirTipoStackholder(TIPOSTACKHOLDER tipoStackholder)
        {
            using (sigreqEntities ctx = new sigreqEntities())
            {
                ctx.TIPOSTACKHOLDER.Add(tipoStackholder);
                ctx.SaveChanges();
            }
        }
    }
}
