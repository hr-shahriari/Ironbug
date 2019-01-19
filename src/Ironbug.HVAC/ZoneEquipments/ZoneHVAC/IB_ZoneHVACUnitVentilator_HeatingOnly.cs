﻿using Ironbug.HVAC.BaseClass;
using OpenStudio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ironbug.HVAC
{
    public class IB_ZoneHVACUnitVentilator_HeatingOnly : IB_ZoneEquipment
    {
        protected override Func<IB_ModelObject> IB_InitSelf => () => new IB_ZoneHVACUnitVentilator_HeatingOnly();

        private static ZoneHVACUnitVentilator NewDefaultOpsObj(Model model) => new ZoneHVACUnitVentilator(model);
        private IB_CoilBasic HeatingCoil => this.Children.Get<IB_CoilHeatingBasic>();
        private IB_Fan Fan => this.Children.Get<IB_Fan>();

        public IB_ZoneHVACUnitVentilator_HeatingOnly() : base(NewDefaultOpsObj(new Model()))
        {
            this.AddChild(new IB_CoilHeatingWater());
            this.AddChild(new IB_FanConstantVolume());
        }
        public void SetFan(IB_Fan Fan)
        {
            this.SetChild(Fan);
        }
        
        public void SetHeatingCoil(IB_CoilHeatingBasic Coil)
        {
            this.SetChild(Coil);
        }

        protected override ModelObject NewOpsObj(Model model)
        {
            var opsObj =  base.OnNewOpsObj(NewDefaultOpsObj, model).to_ZoneHVACUnitVentilator().get();
            opsObj.setHeatingCoil(this.HeatingCoil.ToOS(model));
            opsObj.setSupplyAirFan(this.Fan.ToOS(model));
            return opsObj;
            
        }
    }
    
}
