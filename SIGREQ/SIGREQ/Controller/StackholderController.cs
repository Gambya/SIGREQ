using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGREQ.Model;
using System.Collections;

namespace SIGREQ.Controller
{
    public class StackholderController
    {
        public List<STACKHOLDER> GetAll()
        {
            using (sigreqEntities ctx = new sigreqEntities())
            {
                return ctx.STACKHOLDER.ToList();
            }
        }

        public IEnumerable GetStackholders()
        {
            using (sigreqEntities ctx = new sigreqEntities())
            {
                return ctx.STACKHOLDER.Select(s=>new {
                    ID = s.STACKHOLDERID,
                    Nome = s.NOME,
                    Tipo = s.TIPOSTACKHOLDER.NOME,
                    Telefone = s.TELEFONE,
                    Registro = s.DATAREGISTRO
                }).ToList();
            }
        }

        public STACKHOLDER GetStackholder(int stackholderid)
        {
            using (sigreqEntities ctx = new sigreqEntities())
            {
                return ctx.STACKHOLDER.Where(s => s.STACKHOLDERID == stackholderid).FirstOrDefault();
            }
        }

        public void InserirStackholder(STACKHOLDER stackholder)
        {
            using(sigreqEntities ctx = new sigreqEntities())
            {
                ctx.STACKHOLDER.Add(stackholder);
                ctx.SaveChanges();
            }
        }
    }
}