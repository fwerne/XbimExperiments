// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ExternalReferenceResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ApprovalResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcApprovalRelationship
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcApprovalRelationship : IIfcResourceLevelRelationship
	{
		IIfcApproval @RelatingApproval { get;  set; }
		IItemSet<IIfcApproval> @RelatedApprovals { get; }
	
	}
}

namespace Xbim.Ifc4.ApprovalResource
{
	[ExpressType("IfcApprovalRelationship", 552)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcApprovalRelationship : IfcResourceLevelRelationship, IInstantiableEntity, IIfcApprovalRelationship, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcApprovalRelationship>
	{
		#region IIfcApprovalRelationship explicit implementation
		IIfcApproval IIfcApprovalRelationship.RelatingApproval { 
 
 
			get { return @RelatingApproval; } 
			set { RelatingApproval = value as IfcApproval;}
		}	
		IItemSet<IIfcApproval> IIfcApprovalRelationship.RelatedApprovals { 
			get { return new Common.Collections.ProxyItemSet<IfcApproval, IIfcApproval>( @RelatedApprovals); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcApprovalRelationship(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedApprovals = new ItemSet<IfcApproval>( this, 0,  4);
		}

		#region Explicit attribute fields
		private IfcApproval _relatingApproval;
		private readonly ItemSet<IfcApproval> _relatedApprovals;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcApproval @RelatingApproval 
		{ 
			get 
			{
				if(_activated) return _relatingApproval;
				Activate();
				return _relatingApproval;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingApproval = v, _relatingApproval, value,  "RelatingApproval", 3);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 4)]
		public IItemSet<IfcApproval> @RelatedApprovals 
		{ 
			get 
			{
				if(_activated) return _relatedApprovals;
				Activate();
				return _relatedApprovals;
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
					_relatingApproval = (IfcApproval)(value.EntityVal);
					return;
				case 3: 
					_relatedApprovals.InternalAdd((IfcApproval)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcApprovalRelationship other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@RelatingApproval != null)
					yield return @RelatingApproval;
				foreach(var entity in @RelatedApprovals)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingApproval != null)
					yield return @RelatingApproval;
				foreach(var entity in @RelatedApprovals)
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