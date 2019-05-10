// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.MaterialPropertyResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcWaterProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcWaterProperties : IIfcMaterialProperties
	{
		bool? @IsPotable { get;  set; }
		IfcIonConcentrationMeasure? @Hardness { get;  set; }
		IfcIonConcentrationMeasure? @AlkalinityConcentration { get;  set; }
		IfcIonConcentrationMeasure? @AcidityConcentration { get;  set; }
		IfcNormalisedRatioMeasure? @ImpuritiesContent { get;  set; }
		IfcPHMeasure? @PHLevel { get;  set; }
		IfcNormalisedRatioMeasure? @DissolvedSolidsContent { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.MaterialPropertyResource
{
	[ExpressType("IfcWaterProperties", 721)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWaterProperties : IfcMaterialProperties, IInstantiableEntity, IIfcWaterProperties, IContainsEntityReferences, IEquatable<@IfcWaterProperties>
	{
		#region IIfcWaterProperties explicit implementation
		bool? IIfcWaterProperties.IsPotable { 
 
			get { return @IsPotable; } 
			set { IsPotable = value;}
		}	
		IfcIonConcentrationMeasure? IIfcWaterProperties.Hardness { 
 
			get { return @Hardness; } 
			set { Hardness = value;}
		}	
		IfcIonConcentrationMeasure? IIfcWaterProperties.AlkalinityConcentration { 
 
			get { return @AlkalinityConcentration; } 
			set { AlkalinityConcentration = value;}
		}	
		IfcIonConcentrationMeasure? IIfcWaterProperties.AcidityConcentration { 
 
			get { return @AcidityConcentration; } 
			set { AcidityConcentration = value;}
		}	
		IfcNormalisedRatioMeasure? IIfcWaterProperties.ImpuritiesContent { 
 
			get { return @ImpuritiesContent; } 
			set { ImpuritiesContent = value;}
		}	
		IfcPHMeasure? IIfcWaterProperties.PHLevel { 
 
			get { return @PHLevel; } 
			set { PHLevel = value;}
		}	
		IfcNormalisedRatioMeasure? IIfcWaterProperties.DissolvedSolidsContent { 
 
			get { return @DissolvedSolidsContent; } 
			set { DissolvedSolidsContent = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWaterProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private bool? _isPotable;
		private IfcIonConcentrationMeasure? _hardness;
		private IfcIonConcentrationMeasure? _alkalinityConcentration;
		private IfcIonConcentrationMeasure? _acidityConcentration;
		private IfcNormalisedRatioMeasure? _impuritiesContent;
		private IfcPHMeasure? _pHLevel;
		private IfcNormalisedRatioMeasure? _dissolvedSolidsContent;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public bool? @IsPotable 
		{ 
			get 
			{
				if(_activated) return _isPotable;
				Activate();
				return _isPotable;
			} 
			set
			{
				SetValue( v =>  _isPotable = v, _isPotable, value,  "IsPotable", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcIonConcentrationMeasure? @Hardness 
		{ 
			get 
			{
				if(_activated) return _hardness;
				Activate();
				return _hardness;
			} 
			set
			{
				SetValue( v =>  _hardness = v, _hardness, value,  "Hardness", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcIonConcentrationMeasure? @AlkalinityConcentration 
		{ 
			get 
			{
				if(_activated) return _alkalinityConcentration;
				Activate();
				return _alkalinityConcentration;
			} 
			set
			{
				SetValue( v =>  _alkalinityConcentration = v, _alkalinityConcentration, value,  "AlkalinityConcentration", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcIonConcentrationMeasure? @AcidityConcentration 
		{ 
			get 
			{
				if(_activated) return _acidityConcentration;
				Activate();
				return _acidityConcentration;
			} 
			set
			{
				SetValue( v =>  _acidityConcentration = v, _acidityConcentration, value,  "AcidityConcentration", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcNormalisedRatioMeasure? @ImpuritiesContent 
		{ 
			get 
			{
				if(_activated) return _impuritiesContent;
				Activate();
				return _impuritiesContent;
			} 
			set
			{
				SetValue( v =>  _impuritiesContent = v, _impuritiesContent, value,  "ImpuritiesContent", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcPHMeasure? @PHLevel 
		{ 
			get 
			{
				if(_activated) return _pHLevel;
				Activate();
				return _pHLevel;
			} 
			set
			{
				SetValue( v =>  _pHLevel = v, _pHLevel, value,  "PHLevel", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcNormalisedRatioMeasure? @DissolvedSolidsContent 
		{ 
			get 
			{
				if(_activated) return _dissolvedSolidsContent;
				Activate();
				return _dissolvedSolidsContent;
			} 
			set
			{
				SetValue( v =>  _dissolvedSolidsContent = v, _dissolvedSolidsContent, value,  "DissolvedSolidsContent", 8);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_isPotable = value.BooleanVal;
					return;
				case 2: 
					_hardness = value.RealVal;
					return;
				case 3: 
					_alkalinityConcentration = value.RealVal;
					return;
				case 4: 
					_acidityConcentration = value.RealVal;
					return;
				case 5: 
					_impuritiesContent = value.RealVal;
					return;
				case 6: 
					_pHLevel = value.RealVal;
					return;
				case 7: 
					_dissolvedSolidsContent = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcWaterProperties other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Material != null)
					yield return @Material;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}