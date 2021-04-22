using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktárMenedzsment
{
    class CollarDecorator : PlushDecoratorBase
    {
        public override string GetEquipments()
        {
            return base.GetEquipments()+" |Nyakörv";
        }

        public CollarDecorator(PlushBase plushBase) : base(plushBase)
        {
        }
    }
}
