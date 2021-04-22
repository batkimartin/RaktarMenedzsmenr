using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktárMenedzsment
{
    class HoodieDecorator : PlushDecoratorBase
    {
        public override string GetEquipments()
        {
            return base.GetEquipments() + " | Pulcsi";
        }

        public HoodieDecorator(PlushBase plushBase) : base(plushBase)
        {
        }
    }
}
