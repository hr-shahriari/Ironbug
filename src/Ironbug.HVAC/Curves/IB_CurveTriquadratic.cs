﻿using Ironbug.HVAC.BaseClass;
using OpenStudio;
using System;

namespace Ironbug.HVAC.Curves
{
    public class IB_CurveTriquadratic : IB_Curve
    {
        protected override Func<IB_ModelObject> IB_InitSelf => () => new IB_CurveTriquadratic();
        private static CurveTriquadratic NewDefaultOpsObj(Model model)
            => new CurveTriquadratic(model);
        

        public IB_CurveTriquadratic():base(NewDefaultOpsObj(new Model()))
        {
        }
        protected override ModelObject NewOpsObj(Model model)
        {
            return base.OnNewOpsObj(NewDefaultOpsObj, model).to_CurveTriquadratic().get();
        }
    }

    public sealed class IB_CurveTriquadratic_DataFieldSet
        : IB_FieldSet<IB_CurveTriquadratic_DataFieldSet, CurveTriquadratic>
    {
        private IB_CurveTriquadratic_DataFieldSet() { }
        
    }
}
