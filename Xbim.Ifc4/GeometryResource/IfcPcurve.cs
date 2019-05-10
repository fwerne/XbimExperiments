// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPcurve
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPcurve : IIfcCurve, IfcCurveOnSurface
	{
		IIfcSurface @BasisSurface { get;  set; }
		IIfcCurve @ReferenceCurve { get;  set; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcPcurve", 1220)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPcurve : IfcCurve, IInstantiableEntity, IIfcPcurve, IContainsEntityReferences, IEquatable<@IfcPcurve>
	{
		#region IIfcPcurve explicit implementation
		IIfcSurface IIfcPcurve.BasisSurface { 
 
 
			get { return @BasisSurface; } 
			set { BasisSurface = value as IfcSurface;}
		}	
		IIfcCurve IIfcPcurve.ReferenceCurve { 
 
 
			get { return @ReferenceCurve; } 
			set { ReferenceCurve = value as IfcCurve;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPcurve(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcSurface _basisSurface;
		private IfcCurve _referenceCurve;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcSurface @BasisSurface 
		{ 
			get 
			{
				if(_activated) return _basisSurface;
				Activate();
				return _basisSurface;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _basisSurface = v, _basisSurface, value,  "BasisSurface", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcCurve @ReferenceCurve 
		{ 
			get 
			{
				if(_activated) return _referenceCurve;
				Activate();
				return _referenceCurve;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _referenceCurve = v, _referenceCurve, value,  "ReferenceCurve", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_basisSurface = (IfcSurface)(value.EntityVal);
					return;
				case 1: 
					_referenceCurve = (IfcCurve)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPcurve other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@BasisSurface != null)
					yield return @BasisSurface;
				if (@ReferenceCurve != null)
					yield return @ReferenceCurve;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}