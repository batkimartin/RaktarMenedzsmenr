using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktárMenedzsment
{
   abstract class PlushDecoratorBase:PlushBase
    {
        private PlushBase plushBase;

        public override string GetEquipments()
        {
            return plushBase.GetEquipments();
        }

        public PlushDecoratorBase(PlushBase plushBase)
        {
            this.plushBase = plushBase;
        }



    }
}
