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
using Xbim.Ifc4.TopologyResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSubedge
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSubedge : IIfcEdge
	{
		IIfcEdge @ParentEdge { get;  set; }
	
	}
}

namespace Xbim.Ifc4.TopologyResource
{
	[ExpressType("IfcSubedge", 487)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSubedge : IfcEdge, IInstantiableEntity, IIfcSubedge, IContainsEntityReferences, IEquatable<@IfcSubedge>
	{
		#region IIfcSubedge explicit implementation
		IIfcEdge IIfcSubedge.ParentEdge { 
 
 
			get { return @ParentEdge; } 
			set { ParentEdge = value as IfcEdge;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSubedge(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcEdge _parentEdge;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcEdge @ParentEdge 
		{ 
			get 
			{
				if(_activated) return _parentEdge;
				Activate();
				return _parentEdge;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _parentEdge = v, _parentEdge, value,  "ParentEdge", 3);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_parentEdge = (IfcEdge)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSubedge other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@EdgeStart != null)
					yield return @EdgeStart;
				if (@EdgeEnd != null)
					yield return @EdgeEnd;
				if (@ParentEdge != null)
					yield return @ParentEdge;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}