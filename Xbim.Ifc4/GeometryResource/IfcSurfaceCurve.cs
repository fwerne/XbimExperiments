// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSurfaceCurve
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSurfaceCurve : IIfcCurve, IfcCurveOnSurface
	{
		IIfcCurve @Curve3D { get;  set; }
		IItemSet<IIfcPcurve> @AssociatedGeometry { get; }
		IfcPreferredSurfaceCurveRepresentation @MasterRepresentation { get;  set; }
		List<IfcSurface> @BasisSurface  { get ; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcSurfaceCurve", 1327)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceCurve : IfcCurve, IInstantiableEntity, IIfcSurfaceCurve, IContainsEntityReferences, IEquatable<@IfcSurfaceCurve>
	{
		#region IIfcSurfaceCurve explicit implementation
		IIfcCurve IIfcSurfaceCurve.Curve3D { 
 
 
			get { return @Curve3D; } 
			set { Curve3D = value as IfcCurve;}
		}	
		IItemSet<IIfcPcurve> IIfcSurfaceCurve.AssociatedGeometry { 
			get { return new Common.Collections.ProxyItemSet<IfcPcurve, IIfcPcurve>( @AssociatedGeometry); } 
		}	
		IfcPreferredSurfaceCurveRepresentation IIfcSurfaceCurve.MasterRepresentation { 
 
			get { return @MasterRepresentation; } 
			set { MasterRepresentation = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceCurve(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_associatedGeometry = new ItemSet<IfcPcurve>( this, 2,  2);
		}

		#region Explicit attribute fields
		private IfcCurve _curve3D;
		private readonly ItemSet<IfcPcurve> _associatedGeometry;
		private IfcPreferredSurfaceCurveRepresentation _masterRepresentation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcCurve @Curve3D 
		{ 
			get 
			{
				if(_activated) return _curve3D;
				Activate();
				return _curve3D;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _curve3D = v, _curve3D, value,  "Curve3D", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { 2 }, 4)]
		public IItemSet<IfcPcurve> @AssociatedGeometry 
		{ 
			get 
			{
				if(_activated) return _associatedGeometry;
				Activate();
				return _associatedGeometry;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 5)]
		public IfcPreferredSurfaceCurveRepresentation @MasterRepresentation 
		{ 
			get 
			{
				if(_activated) return _masterRepresentation;
				Activate();
				return _masterRepresentation;
			} 
			set
			{
				SetValue( v =>  _masterRepresentation = v, _masterRepresentation, value,  "MasterRepresentation", 3);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { 2 }, 0)]
		public List<IfcSurface> @BasisSurface 
		{
			get 
			{
				//## Getter for BasisSurface
				//TODO: Implement getter for derived attribute BasisSurface
				throw new NotImplementedException();
				//##
			}
		}

		#endregion


		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_curve3D = (IfcCurve)(value.EntityVal);
					return;
				case 1: 
					_associatedGeometry.InternalAdd((IfcPcurve)value.EntityVal);
					return;
				case 2: 
                    _masterRepresentation = (IfcPreferredSurfaceCurveRepresentation) System.Enum.Parse(typeof (IfcPreferredSurfaceCurveRepresentation), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSurfaceCurve other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Curve3D != null)
					yield return @Curve3D;
				foreach(var entity in @AssociatedGeometry)
					yield return entity;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}