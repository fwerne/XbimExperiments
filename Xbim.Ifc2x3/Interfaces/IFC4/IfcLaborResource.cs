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
namespace Xbim.Ifc2x3.ConstructionMgmtDomain
{
	public partial class @IfcLaborResource : IIfcLaborResource
	{

		private  Ifc4.Interfaces.IfcLaborResourceTypeEnum? _predefinedType;


		[CrossSchemaAttribute(typeof(IIfcLaborResource), 11)]
		Ifc4.Interfaces.IfcLaborResourceTypeEnum? IIfcLaborResource.PredefinedType 
		{ 
			get
			{
				return _predefinedType;
			} 
			set
			{
				SetValue(v => _predefinedType = v, _predefinedType, value, "PredefinedType", -11);
				
			}
		}
	//## Custom code
	//##
	}
}