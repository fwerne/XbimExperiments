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
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCurveStyleFontPattern
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCurveStyleFontPattern : IPersistEntity
	{
		IfcLengthMeasure @VisibleSegmentLength { get;  set; }
		IfcPositiveLengthMeasure @InvisibleSegmentLength { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IfcCurveStyleFontPattern", 637)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurveStyleFontPattern : PersistEntity, IInstantiableEntity, IIfcCurveStyleFontPattern, IEquatable<@IfcCurveStyleFontPattern>
	{
		#region IIfcCurveStyleFontPattern explicit implementation
		IfcLengthMeasure IIfcCurveStyleFontPattern.VisibleSegmentLength { 
 
			get { return @VisibleSegmentLength; } 
			set { VisibleSegmentLength = value;}
		}	
		IfcPositiveLengthMeasure IIfcCurveStyleFontPattern.InvisibleSegmentLength { 
 
			get { return @InvisibleSegmentLength; } 
			set { InvisibleSegmentLength = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurveStyleFontPattern(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLengthMeasure _visibleSegmentLength;
		private IfcPositiveLengthMeasure _invisibleSegmentLength;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcLengthMeasure @VisibleSegmentLength 
		{ 
			get 
			{
				if(_activated) return _visibleSegmentLength;
				Activate();
				return _visibleSegmentLength;
			} 
			set
			{
				SetValue( v =>  _visibleSegmentLength = v, _visibleSegmentLength, value,  "VisibleSegmentLength", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcPositiveLengthMeasure @InvisibleSegmentLength 
		{ 
			get 
			{
				if(_activated) return _invisibleSegmentLength;
				Activate();
				return _invisibleSegmentLength;
			} 
			set
			{
				SetValue( v =>  _invisibleSegmentLength = v, _invisibleSegmentLength, value,  "InvisibleSegmentLength", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_visibleSegmentLength = value.RealVal;
					return;
				case 1: 
					_invisibleSegmentLength = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCurveStyleFontPattern other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}