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
using Xbim.Ifc2x3.ProfileResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRectangleHollowProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRectangleHollowProfileDef : IIfcRectangleProfileDef
	{
		IfcPositiveLengthMeasure @WallThickness { get;  set; }
		IfcPositiveLengthMeasure? @InnerFilletRadius { get;  set; }
		IfcPositiveLengthMeasure? @OuterFilletRadius { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.ProfileResource
{
	[ExpressType("IfcRectangleHollowProfileDef", 562)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRectangleHollowProfileDef : IfcRectangleProfileDef, IInstantiableEntity, IIfcRectangleHollowProfileDef, IContainsEntityReferences, IEquatable<@IfcRectangleHollowProfileDef>
	{
		#region IIfcRectangleHollowProfileDef explicit implementation
		IfcPositiveLengthMeasure IIfcRectangleHollowProfileDef.WallThickness { 
 
			get { return @WallThickness; } 
			set { WallThickness = value;}
		}	
		IfcPositiveLengthMeasure? IIfcRectangleHollowProfileDef.InnerFilletRadius { 
 
			get { return @InnerFilletRadius; } 
			set { InnerFilletRadius = value;}
		}	
		IfcPositiveLengthMeasure? IIfcRectangleHollowProfileDef.OuterFilletRadius { 
 
			get { return @OuterFilletRadius; } 
			set { OuterFilletRadius = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRectangleHollowProfileDef(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _wallThickness;
		private IfcPositiveLengthMeasure? _innerFilletRadius;
		private IfcPositiveLengthMeasure? _outerFilletRadius;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcPositiveLengthMeasure @WallThickness 
		{ 
			get 
			{
				if(_activated) return _wallThickness;
				Activate();
				return _wallThickness;
			} 
			set
			{
				SetValue( v =>  _wallThickness = v, _wallThickness, value,  "WallThickness", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcPositiveLengthMeasure? @InnerFilletRadius 
		{ 
			get 
			{
				if(_activated) return _innerFilletRadius;
				Activate();
				return _innerFilletRadius;
			} 
			set
			{
				SetValue( v =>  _innerFilletRadius = v, _innerFilletRadius, value,  "InnerFilletRadius", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcPositiveLengthMeasure? @OuterFilletRadius 
		{ 
			get 
			{
				if(_activated) return _outerFilletRadius;
				Activate();
				return _outerFilletRadius;
			} 
			set
			{
				SetValue( v =>  _outerFilletRadius = v, _outerFilletRadius, value,  "OuterFilletRadius", 8);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_wallThickness = value.RealVal;
					return;
				case 6: 
					_innerFilletRadius = value.RealVal;
					return;
				case 7: 
					_outerFilletRadius = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRectangleHollowProfileDef other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Position != null)
					yield return @Position;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}