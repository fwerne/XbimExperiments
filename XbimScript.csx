#r "C:\Users\Flo\source\repos\XbimToolkit\StartProject\bin\Debug\net47\Xbim.ModelGeometry.Scene.dll"
#r "C:\Users\Flo\source\repos\XbimToolkit\Output\Debug\net47\Xbim.Geometry.Engine64.dll"
using Xbim.Ifc;
using Xbim.ModelGeometry.Scene;
string file = @"C:\Users\Flo\source\repos\XbimToolkit\IfcFiles\miniExample20080731_CoordView_SweptSolid.ifc";
public static void P<T>(this IEnumerable<T> items) { foreach (T item in items) System.Console.WriteLine(item); }
var model = IfcStore.Open(file, null);
var context = new Xbim3DModelContext(model);