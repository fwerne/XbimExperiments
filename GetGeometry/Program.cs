using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbim.Ifc;
using Xbim.ModelGeometry.Scene;
using Xbim.Geometry.Engine.Interop;

namespace GetGeometry
{
    public static class Extensions
    {
        public static void P<T>(this IEnumerable<T> items) { foreach (T item in items) System.Console.WriteLine(item); }
    }
    class Program
    {

        static void Main(string[] args)
        {
            
            string file = @"C:\Users\Flo\source\repos\XbimToolkit\IfcFiles\miniExample20080731_CoordView_SweptSolid.ifc";
            var model = IfcStore.Open(file, null);
            Xbim3DModelContext context = new Xbim3DModelContext(model);
            var c = context.CreateContext();
        }
    }
}
