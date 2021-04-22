using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktárMenedzsment
{
    class SunglassesDecorator: PlushDecoratorBase
    {
        public override string GetEquipments()
        {
            return base.GetEquipments() + " | Napszemüveg";
        }

        public SunglassesDecorator(PlushBase plushBase) : base(plushBase)
        {
        }
    }
}
