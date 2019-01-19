﻿using Ironbug.HVAC.BaseClass;
using OpenStudio;
using System;

namespace Ironbug.HVAC
{
    public class IB_CoilCoolingLowTempRadiantConstFlow : IB_CoilCoolingBasic, IIB_DualLoopObj, IIB_PlantLoopObjects
    {
        private double waterHiT = 15; //59F
        private double waterLoT = 10; //50F
        private double airHiT = 25; //77F
        private double airLoT = 21; //70F


        protected override Func<IB_ModelObject> IB_InitSelf => () => new IB_CoilCoolingLowTempRadiantConstFlow(waterHiT, waterLoT, airHiT, airLoT);

        private static CoilCoolingLowTempRadiantConstFlow NewDefaultOpsObj(Model model, double waterHiT, double waterLoT, double airHiT, double airLoT) 
            => new CoilCoolingLowTempRadiantConstFlow(model, new ScheduleRuleset(model, waterHiT), new ScheduleRuleset(model, waterLoT), new ScheduleRuleset(model, airHiT), new ScheduleRuleset(model, airLoT));

        private CoilCoolingLowTempRadiantConstFlow NewDefaultOpsObj(Model model)
            => new CoilCoolingLowTempRadiantConstFlow(model, new ScheduleRuleset(model, waterHiT), new ScheduleRuleset(model, waterLoT), new ScheduleRuleset(model, airHiT), new ScheduleRuleset(model, airLoT));

        public new CoilCoolingLowTempRadiantConstFlow ToOS(Model model)
        {
            return (CoilCoolingLowTempRadiantConstFlow)base.ToOS(model);
        }

        public override bool AddToNode(Node node)
        {
            var model = node.model();
            return ((CoilCoolingLowTempRadiantConstFlow)this.ToOS(model)).addToNode(node);
        }
        
        protected override ModelObject NewOpsObj(Model model)
        {
            return base.OnNewOpsObj(NewDefaultOpsObj, model).to_CoilCoolingLowTempRadiantConstFlow().get();
        }

        public IB_CoilCoolingLowTempRadiantConstFlow(double waterHiT, double waterLoT, double airHiT, double airLoT) 
            : base(NewDefaultOpsObj(new Model(), waterHiT, waterLoT, airHiT, airLoT))
        {
            this.airHiT = airHiT;
            this.airLoT = airLoT;
            this.waterLoT = waterLoT;
            this.waterHiT = waterHiT;
        }

    }

    public sealed class IB_CoilCoolingLowTempRadiantConstFlow_DataFieldSet
        : IB_FieldSet<IB_CoilCoolingLowTempRadiantConstFlow_DataFieldSet, CoilCoolingLowTempRadiantConstFlow>
    {
        private IB_CoilCoolingLowTempRadiantConstFlow_DataFieldSet() { }

    }


}
