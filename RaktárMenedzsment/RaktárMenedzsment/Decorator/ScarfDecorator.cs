using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktárMenedzsment
{
    class ScarfDecorator : PlushDecoratorBase
    {
        public override string GetEquipments()
        {
            return base.GetEquipments()+" |Sál";
        }

        public ScarfDecorator(PlushBase plushBase) : base(plushBase)
        {
        }
    }
}
