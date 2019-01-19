﻿using Ironbug.HVAC.BaseClass;
using OpenStudio;
using System;

namespace Ironbug.HVAC
{
    public class IB_HeatExchangerAirToAirSensibleAndLatent : IB_HVACObject, IIB_AirLoopObject
    {
        protected override Func<IB_ModelObject> IB_InitSelf => () => new IB_HeatExchangerAirToAirSensibleAndLatent();

        private static HeatExchangerAirToAirSensibleAndLatent NewDefaultOpsObj(Model model) => new HeatExchangerAirToAirSensibleAndLatent(model);

        public IB_HeatExchangerAirToAirSensibleAndLatent() : base(NewDefaultOpsObj(new Model()))
        {
        }

        public override bool AddToNode(Node node)
        {
            var model = node.model();
            return ((HeatExchangerAirToAirSensibleAndLatent)this.ToOS(model)).addToNode(node);
        }
        

        protected override ModelObject NewOpsObj(Model model)
        {
            return base.OnNewOpsObj(NewDefaultOpsObj, model).to_HeatExchangerAirToAirSensibleAndLatent().get();
        }
    }

    public sealed class IB_HeatExchangerAirToAirSensibleAndLatent_DataFieldSet
        : IB_FieldSet<IB_HeatExchangerAirToAirSensibleAndLatent_DataFieldSet, HeatExchangerAirToAirSensibleAndLatent>
    {
        private IB_HeatExchangerAirToAirSensibleAndLatent_DataFieldSet() {}
    }
}