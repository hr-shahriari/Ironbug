﻿using System;
using Grasshopper.Kernel;

namespace Ironbug.Grasshopper.Component
{
    public class Ironbug_EvaporativeFluidCoolerTwoSpeed : Ironbug_HVACComponent
    {
        
        
        /// Initializes a new instance of the Ironbug_BoilerHotWater class.
        
        public Ironbug_EvaporativeFluidCoolerTwoSpeed()
          : base("Ironbug_EvaporativeFluidCoolerTwoSpeed", "EvapFluidCooler2",
              "Description",
              "Ironbug", "02:LoopComponents", 
              typeof(HVAC.IB_EvaporativeFluidCoolerTwoSpeed_FieldSet))
        {
        }

        public override GH_Exposure Exposure => GH_Exposure.quarternary | GH_Exposure.obscure;

        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
        }

        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddGenericParameter("EvaporativeFluidCoolerTwoSpeed", "FluidCooler2", "EvaporativeFluidCoolerTwoSpeed", GH_ParamAccess.item);
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
            var obj = new HVAC.IB_EvaporativeFluidCoolerTwoSpeed();

            this.SetObjParamsTo(obj);
            DA.SetData(0, obj);
        }

        protected override System.Drawing.Bitmap Icon => Properties.Resources.FluidCooler2;

        public override Guid ComponentGuid => new Guid("{19F7EF16-4D32-44DA-B686-EA1807F1303D}");
    }
}