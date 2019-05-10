// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MaterialResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMaterialLayer
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMaterialLayer : IIfcMaterialDefinition
	{
		IIfcMaterial @Material { get;  set; }
		IfcNonNegativeLengthMeasure @LayerThickness { get;  set; }
		IfcLogical? @IsVentilated { get;  set; }
		IfcLabel? @Name { get;  set; }
		IfcText? @Description { get;  set; }
		IfcLabel? @Category { get;  set; }
		IfcInteger? @Priority { get;  set; }
		IIfcMaterialLayerSet @ToMaterialLayerSet {  get; }
	
	}
}

namespace Xbim.Ifc4.MaterialResource
{
	[ExpressType("IfcMaterialLayer", 446)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialLayer : IfcMaterialDefinition, IInstantiableEntity, IIfcMaterialLayer, IContainsEntityReferences, IEquatable<@IfcMaterialLayer>
	{
		#region IIfcMaterialLayer explicit implementation
		IIfcMaterial IIfcMaterialLayer.Material { 
 
 
			get { return @Material; } 
			set { Material = value as IfcMaterial;}
		}	
		IfcNonNegativeLengthMeasure IIfcMaterialLayer.LayerThickness { 
 
			get { return @LayerThickness; } 
			set { LayerThickness = value;}
		}	
		IfcLogical? IIfcMaterialLayer.IsVentilated { 
 
			get { return @IsVentilated; } 
			set { IsVentilated = value;}
		}	
		IfcLabel? IIfcMaterialLayer.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		IfcText? IIfcMaterialLayer.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		IfcLabel? IIfcMaterialLayer.Category { 
 
			get { return @Category; } 
			set { Category = value;}
		}	
		IfcInteger? IIfcMaterialLayer.Priority { 
 
			get { return @Priority; } 
			set { Priority = value;}
		}	
		 
		IIfcMaterialLayerSet IIfcMaterialLayer.ToMaterialLayerSet {  get { return @ToMaterialLayerSet; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialLayer(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcMaterial _material;
		private IfcNonNegativeLengthMeasure _layerThickness;
		private IfcLogical? _isVentilated;
		private IfcLabel? _name;
		private IfcText? _description;
		private IfcLabel? _category;
		private IfcInteger? _priority;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcMaterial @Material 
		{ 
			get 
			{
				if(_activated) return _material;
				Activate();
				return _material;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _material = v, _material, value,  "Material", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcNonNegativeLengthMeasure @LayerThickness 
		{ 
			get 
			{
				if(_activated) return _layerThickness;
				Activate();
				return _layerThickness;
			} 
			set
			{
				SetValue( v =>  _layerThickness = v, _layerThickness, value,  "LayerThickness", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcLogical? @IsVentilated 
		{ 
			get 
			{
				if(_activated) return _isVentilated;
				Activate();
				return _isVentilated;
			} 
			set
			{
				SetValue( v =>  _isVentilated = v, _isVentilated, value,  "IsVentilated", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
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
				SetValue( v =>  _description = v, _description, value,  "Description", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 9)]
		public IfcLabel? @Category 
		{ 
			get 
			{
				if(_activated) return _category;
				Activate();
				return _category;
			} 
			set
			{
				SetValue( v =>  _category = v, _category, value,  "Category", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public IfcInteger? @Priority 
		{ 
			get 
			{
				if(_activated) return _priority;
				Activate();
				return _priority;
			} 
			set
			{
				SetValue( v =>  _priority = v, _priority, value,  "Priority", 7);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("MaterialLayers")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, null, null, 11)]
		public IfcMaterialLayerSet @ToMaterialLayerSet 
		{ 
			get 
			{
				return Model.Instances.FirstOrDefault<IfcMaterialLayerSet>(e => e.MaterialLayers != null &&  e.MaterialLayers.Contains(this), "MaterialLayers", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_material = (IfcMaterial)(value.EntityVal);
					return;
				case 1: 
					_layerThickness = value.RealVal;
					return;
				case 2: 
					_isVentilated = value.BooleanVal;
					return;
				case 3: 
					_name = value.StringVal;
					return;
				case 4: 
					_description = value.StringVal;
					return;
				case 5: 
					_category = value.StringVal;
					return;
				case 6: 
					_priority = value.IntegerVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMaterialLayer other)
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