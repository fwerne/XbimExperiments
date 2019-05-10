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
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcLine
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcLine : IIfcCurve
	{
		IIfcCartesianPoint @Pnt { get;  set; }
		IIfcVector @Dir { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IfcLine", 272)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLine : IfcCurve, IInstantiableEntity, IIfcLine, IContainsEntityReferences, IEquatable<@IfcLine>
	{
		#region IIfcLine explicit implementation
		IIfcCartesianPoint IIfcLine.Pnt { 
 
 
			get { return @Pnt; } 
			set { Pnt = value as IfcCartesianPoint;}
		}	
		IIfcVector IIfcLine.Dir { 
 
 
			get { return @Dir; } 
			set { Dir = value as IfcVector;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLine(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcCartesianPoint _pnt;
		private IfcVector _dir;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcCartesianPoint @Pnt 
		{ 
			get 
			{
				if(_activated) return _pnt;
				Activate();
				return _pnt;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _pnt = v, _pnt, value,  "Pnt", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcVector @Dir 
		{ 
			get 
			{
				if(_activated) return _dir;
				Activate();
				return _dir;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _dir = v, _dir, value,  "Dir", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_pnt = (IfcCartesianPoint)(value.EntityVal);
					return;
				case 1: 
					_dir = (IfcVector)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcLine other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Pnt != null)
					yield return @Pnt;
				if (@Dir != null)
					yield return @Dir;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}