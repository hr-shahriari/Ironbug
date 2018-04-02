﻿using System;
using Ironbug.HVAC.BaseClass;
using OpenStudio;

namespace Ironbug.HVAC
{
    public class IB_PumpConstantSpeed : IB_Pump
    {
        private static PumpConstantSpeed InitMethod(Model model) => new PumpConstantSpeed(model);
        public IB_PumpConstantSpeed():base(InitMethod(new Model()))
        {
            
        }
        public override bool AddToNode(Node node)
        {
            var model = node.model();
            return ((PumpConstantSpeed)this.ToOS(model)).addToNode(node);
        }

        public override IB_ModelObject Duplicate()
        {
            return base.DuplicateIBObj(() => new IB_PumpConstantSpeed());
        }

        public override ModelObject ToOS(Model model)
        {
            return base.ToOS(InitMethod, model);
        }
    }

    public sealed class IB_PumpConstantSpeed_DataFields 
        : IB_DataFieldSet<IB_PumpConstantSpeed_DataFields, PumpConstantSpeed>
    {
        private IB_PumpConstantSpeed_DataFields() {}


        public IB_DataField RatedPumpHead { get; }
            = new IB_BasicDataField("RatedPumpHead", "PumpHead");

        public IB_DataField MotorEfficiency { get; }
            = new IB_BasicDataField("MotorEfficiency", "Efficiency");

        public IB_DataField RatedFlowRate { get; }
            = new IB_ProDataField("RatedFlowRate", "FlowRate");

        public IB_DataField PumpControlType { get; }
            = new IB_ProDataField("PumpControlType", "ControlType");

       

    }
}
