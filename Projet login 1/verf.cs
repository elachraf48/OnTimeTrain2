using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_login_1
{

    class verf
    {
        commerciaEntities db = new commerciaEntities();
        
        public  bool vrf_idmt_idTp(int idMT,int idTP)
        {
            //int vr = db.materiel.Where(w => w.id_materiel == idMT && w.id_type_materiel == idTP).Count();
            //if (vr == 0) return true;
            //else
            return false;
        }
    }
}
