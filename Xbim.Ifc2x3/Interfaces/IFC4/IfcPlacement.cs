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
namespace Xbim.Ifc2x3.GeometryResource
{
	public partial class @IfcPlacement : IIfcPlacement
	{

		[CrossSchemaAttribute(typeof(IIfcPlacement), 1)]
		IIfcCartesianPoint IIfcPlacement.Location 
		{ 
			get
			{
				return Location;
			} 
			set
			{
				Location = value as IfcCartesianPoint;
				
			}
		}
		Ifc4.GeometryResource.IfcDimensionCount IIfcPlacement.Dim 
		{
			get 
			{
				return new Ifc4.GeometryResource.IfcDimensionCount(Dim);
			}
		}

	//## Custom code
	//##
	}
}