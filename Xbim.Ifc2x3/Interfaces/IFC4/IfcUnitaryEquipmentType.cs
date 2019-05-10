// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.HVACDomain
{
	public partial class @IfcUnitaryEquipmentType : IIfcUnitaryEquipmentType
	{

		[CrossSchemaAttribute(typeof(IIfcUnitaryEquipmentType), 10)]
		Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum IIfcUnitaryEquipmentType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcUnitaryEquipmentTypeEnum.AIRHANDLER:
						return Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum.AIRHANDLER;
					case IfcUnitaryEquipmentTypeEnum.AIRCONDITIONINGUNIT:
						return Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum.AIRCONDITIONINGUNIT;
					case IfcUnitaryEquipmentTypeEnum.SPLITSYSTEM:
						return Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum.SPLITSYSTEM;
					case IfcUnitaryEquipmentTypeEnum.ROOFTOPUNIT:
						return Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum.ROOFTOPUNIT;
					case IfcUnitaryEquipmentTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
                        if (ElementType.HasValue)
                        {
                            Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum result;
                            if (System.Enum.TryParse(ElementType.Value, false, out result))
                                return result;
                        }
						//##
						return Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum.USERDEFINED;
					case IfcUnitaryEquipmentTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum.AIRHANDLER:
						PredefinedType = IfcUnitaryEquipmentTypeEnum.AIRHANDLER;
						return;
					case Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum.AIRCONDITIONINGUNIT:
						PredefinedType = IfcUnitaryEquipmentTypeEnum.AIRCONDITIONINGUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum.DEHUMIDIFIER:
						//## Handle setting of DEHUMIDIFIER member from IfcUnitaryEquipmentTypeEnum in property PredefinedType
						ElementType = value.ToString();
                        PredefinedType = IfcUnitaryEquipmentTypeEnum.USERDEFINED;
				        return;
						//##
										case Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum.SPLITSYSTEM:
						PredefinedType = IfcUnitaryEquipmentTypeEnum.SPLITSYSTEM;
						return;
					case Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum.ROOFTOPUNIT:
						PredefinedType = IfcUnitaryEquipmentTypeEnum.ROOFTOPUNIT;
						return;
					case Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum.USERDEFINED:
						PredefinedType = IfcUnitaryEquipmentTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcUnitaryEquipmentTypeEnum.NOTDEFINED:
						PredefinedType = IfcUnitaryEquipmentTypeEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}