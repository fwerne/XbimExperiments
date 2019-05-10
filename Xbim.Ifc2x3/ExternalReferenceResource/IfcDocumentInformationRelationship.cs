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
using Xbim.Ifc2x3.ExternalReferenceResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDocumentInformationRelationship
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDocumentInformationRelationship : IPersistEntity
	{
		IIfcDocumentInformation @RelatingDocument { get;  set; }
		IItemSet<IIfcDocumentInformation> @RelatedDocuments { get; }
		IfcLabel? @RelationshipType { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	[ExpressType("IfcDocumentInformationRelationship", 491)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDocumentInformationRelationship : PersistEntity, IInstantiableEntity, IIfcDocumentInformationRelationship, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcDocumentInformationRelationship>
	{
		#region IIfcDocumentInformationRelationship explicit implementation
		IIfcDocumentInformation IIfcDocumentInformationRelationship.RelatingDocument { 
 
 
			get { return @RelatingDocument; } 
			set { RelatingDocument = value as IfcDocumentInformation;}
		}	
		IItemSet<IIfcDocumentInformation> IIfcDocumentInformationRelationship.RelatedDocuments { 
			get { return new Common.Collections.ProxyItemSet<IfcDocumentInformation, IIfcDocumentInformation>( @RelatedDocuments); } 
		}	
		IfcLabel? IIfcDocumentInformationRelationship.RelationshipType { 
 
			get { return @RelationshipType; } 
			set { RelationshipType = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDocumentInformationRelationship(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedDocuments = new ItemSet<IfcDocumentInformation>( this, 0,  2);
		}

		#region Explicit attribute fields
		private IfcDocumentInformation _relatingDocument;
		private readonly ItemSet<IfcDocumentInformation> _relatedDocuments;
		private IfcLabel? _relationshipType;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcDocumentInformation @RelatingDocument 
		{ 
			get 
			{
				if(_activated) return _relatingDocument;
				Activate();
				return _relatingDocument;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingDocument = v, _relatingDocument, value,  "RelatingDocument", 1);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 2)]
		public IItemSet<IfcDocumentInformation> @RelatedDocuments 
		{ 
			get 
			{
				if(_activated) return _relatedDocuments;
				Activate();
				return _relatedDocuments;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcLabel? @RelationshipType 
		{ 
			get 
			{
				if(_activated) return _relationshipType;
				Activate();
				return _relationshipType;
			} 
			set
			{
				SetValue( v =>  _relationshipType = v, _relationshipType, value,  "RelationshipType", 3);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_relatingDocument = (IfcDocumentInformation)(value.EntityVal);
					return;
				case 1: 
					_relatedDocuments.InternalAdd((IfcDocumentInformation)value.EntityVal);
					return;
				case 2: 
					_relationshipType = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDocumentInformationRelationship other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@RelatingDocument != null)
					yield return @RelatingDocument;
				foreach(var entity in @RelatedDocuments)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingDocument != null)
					yield return @RelatingDocument;
				foreach(var entity in @RelatedDocuments)
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