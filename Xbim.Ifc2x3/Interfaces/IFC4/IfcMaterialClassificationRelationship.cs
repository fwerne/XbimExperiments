// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.MaterialResource
{
	public partial class @IfcMaterialClassificationRelationship : IIfcMaterialClassificationRelationship
	{

		[CrossSchemaAttribute(typeof(IIfcMaterialClassificationRelationship), 1)]
		IEnumerable<IIfcClassificationSelect> IIfcMaterialClassificationRelationship.MaterialClassifications 
		{ 
			get
			{
				//## Handle return of MaterialClassifications for which no match was found
			    foreach (var materialClassification in MaterialClassifications)
			    {
			        var notation = materialClassification as ExternalReferenceResource.IfcClassificationNotation;
			        if (notation != null)
			        {
                        var items =
                                Model.Instances.Where<ExternalReferenceResource.IfcClassificationItem>(i => notation.NotationFacets.Any(f => i.Notation == f)).ToList();
                        if (items.Any())
                        {
                            foreach (var item in items)
                                yield return item;
                        }
                        else
                        {
                            yield return notation;
                        }
			            continue;
			        }
                    var reference = materialClassification as ExternalReferenceResource.IfcClassificationReference;
			        if (reference != null)
			            yield return reference;
			    }
				//##
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcMaterialClassificationRelationship), 2)]
		IIfcMaterial IIfcMaterialClassificationRelationship.ClassifiedMaterial 
		{ 
			get
			{
				return ClassifiedMaterial;
			} 
			set
			{
				ClassifiedMaterial = value as IfcMaterial;
				
			}
		}
	//## Custom code
	//##
	}
}