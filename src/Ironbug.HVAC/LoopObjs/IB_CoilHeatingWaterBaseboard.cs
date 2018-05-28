﻿using Ironbug.HVAC.BaseClass;
using OpenStudio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Ironbug.HVAC
{
    public class IB_CoilHeatingWaterBaseboard : IB_CoilBasic, IIB_ShareableObj, IIB_PlantLoopObjects
    {
        protected override Func<IB_ModelObject> IB_InitSelf => () => new IB_CoilHeatingWaterBaseboard();

        private static CoilHeatingWaterBaseboard InitMethod(Model model) => new CoilHeatingWaterBaseboard(model);
        
        public IB_CoilHeatingWaterBaseboard() : base(InitMethod(new Model()))
        {
        }
        
        public override bool AddToNode(Node node)
        {
            //this is only used in IB_ZoneHVACBaseboardConvectiveWater
            return true;

            //var model = node.model();
            //return ((CoilHeatingWaterBaseboard)this.InitOpsObj(model)).addToNode(node);
            
        }


        protected override ModelObject InitOpsObj(Model model)
        {
            return base.OnInitOpsObj(InitMethod, model).to_CoilHeatingWaterBaseboard().get();
        }


    }

    public sealed class IB_CoilHeatingWaterBaseboard_DataFieldSet
        : IB_DataFieldSet<IB_CoilHeatingWaterBaseboard_DataFieldSet, CoilHeatingWaterBaseboard>
    {
        private IB_CoilHeatingWaterBaseboard_DataFieldSet() {}
        
    }
    
    

}
