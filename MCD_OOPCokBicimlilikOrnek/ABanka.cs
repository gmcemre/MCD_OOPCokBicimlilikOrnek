using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPCokBicimlilikOrnek
{
    public class ABanka:Banka 
    {
        //Bu banka da aynı indirim oranını kullanıyor.
        public override void IndirimOraninaGöreIndirimYap()
        {
            base.IndirimOraninaGöreIndirimYap();
        }
    }
}
