// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.DateTimeResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ApprovalResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcApproval
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcApproval : IPersistEntity
	{
		IfcText? @Description { get;  set; }
		IIfcDateTimeSelect @ApprovalDateTime { get;  set; }
		IfcLabel? @ApprovalStatus { get;  set; }
		IfcLabel? @ApprovalLevel { get;  set; }
		IfcText? @ApprovalQualifier { get;  set; }
		IfcLabel @Name { get;  set; }
		IfcIdentifier @Identifier { get;  set; }
		IEnumerable<IIfcApprovalActorRelationship> @Actors {  get; }
		IEnumerable<IIfcApprovalRelationship> @IsRelatedWith {  get; }
		IEnumerable<IIfcApprovalRelationship> @Relates {  get; }
	
	}
}

namespace Xbim.Ifc2x3.ApprovalResource
{
	[ExpressType("IfcApproval", 626)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcApproval : PersistEntity, IInstantiableEntity, IIfcApproval, IContainsEntityReferences, IEquatable<@IfcApproval>
	{
		#region IIfcApproval explicit implementation
		IfcText? IIfcApproval.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		IIfcDateTimeSelect IIfcApproval.ApprovalDateTime { 
 
 
			get { return @ApprovalDateTime; } 
			set { ApprovalDateTime = value as IfcDateTimeSelect;}
		}	
		IfcLabel? IIfcApproval.ApprovalStatus { 
 
			get { return @ApprovalStatus; } 
			set { ApprovalStatus = value;}
		}	
		IfcLabel? IIfcApproval.ApprovalLevel { 
 
			get { return @ApprovalLevel; } 
			set { ApprovalLevel = value;}
		}	
		IfcText? IIfcApproval.ApprovalQualifier { 
 
			get { return @ApprovalQualifier; } 
			set { ApprovalQualifier = value;}
		}	
		IfcLabel IIfcApproval.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		IfcIdentifier IIfcApproval.Identifier { 
 
			get { return @Identifier; } 
			set { Identifier = value;}
		}	
		 
		IEnumerable<IIfcApprovalActorRelationship> IIfcApproval.Actors {  get { return @Actors; } }
		IEnumerable<IIfcApprovalRelationship> IIfcApproval.IsRelatedWith {  get { return @IsRelatedWith; } }
		IEnumerable<IIfcApprovalRelationship> IIfcApproval.Relates {  get { return @Relates; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcApproval(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcText? _description;
		private IfcDateTimeSelect _approvalDateTime;
		private IfcLabel? _approvalStatus;
		private IfcLabel? _approvalLevel;
		private IfcText? _approvalQualifier;
		private IfcLabel _name;
		private IfcIdentifier _identifier;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(_activated) return _description;
				Activate();
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 2)]
		public IfcDateTimeSelect @ApprovalDateTime 
		{ 
			get 
			{
				if(_activated) return _approvalDateTime;
				Activate();
				return _approvalDateTime;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _approvalDateTime = v, _approvalDateTime, value,  "ApprovalDateTime", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcLabel? @ApprovalStatus 
		{ 
			get 
			{
				if(_activated) return _approvalStatus;
				Activate();
				return _approvalStatus;
			} 
			set
			{
				SetValue( v =>  _approvalStatus = v, _approvalStatus, value,  "ApprovalStatus", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcLabel? @ApprovalLevel 
		{ 
			get 
			{
				if(_activated) return _approvalLevel;
				Activate();
				return _approvalLevel;
			} 
			set
			{
				SetValue( v =>  _approvalLevel = v, _approvalLevel, value,  "ApprovalLevel", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcText? @ApprovalQualifier 
		{ 
			get 
			{
				if(_activated) return _approvalQualifier;
				Activate();
				return _approvalQualifier;
			} 
			set
			{
				SetValue( v =>  _approvalQualifier = v, _approvalQualifier, value,  "ApprovalQualifier", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcIdentifier @Identifier 
		{ 
			get 
			{
				if(_activated) return _identifier;
				Activate();
				return _identifier;
			} 
			set
			{
				SetValue( v =>  _identifier = v, _identifier, value,  "Identifier", 7);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("Approval")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 8)]
		public IEnumerable<IfcApprovalActorRelationship> @Actors 
		{ 
			get 
			{
				return Model.Instances.Where<IfcApprovalActorRelationship>(e => Equals(e.Approval), "Approval", this);
			} 
		}
		[InverseProperty("RelatedApproval")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 9)]
		public IEnumerable<IfcApprovalRelationship> @IsRelatedWith 
		{ 
			get 
			{
				return Model.Instances.Where<IfcApprovalRelationship>(e => Equals(e.RelatedApproval), "RelatedApproval", this);
			} 
		}
		[InverseProperty("RelatingApproval")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 10)]
		public IEnumerable<IfcApprovalRelationship> @Relates 
		{ 
			get 
			{
				return Model.Instances.Where<IfcApprovalRelationship>(e => Equals(e.RelatingApproval), "RelatingApproval", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_description = value.StringVal;
					return;
				case 1: 
					_approvalDateTime = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 2: 
					_approvalStatus = value.StringVal;
					return;
				case 3: 
					_approvalLevel = value.StringVal;
					return;
				case 4: 
					_approvalQualifier = value.StringVal;
					return;
				case 5: 
					_name = value.StringVal;
					return;
				case 6: 
					_identifier = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcApproval other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@ApprovalDateTime != null)
					yield return @ApprovalDateTime;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}