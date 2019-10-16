using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.Builder.YanMo
{
    public class TestClient
    {
        public static void Test()
        {
            IBuilder builder = new XmlBuilder();
            Director director = new Director(builder);
            director.construct(new ExportHeaderModel(), new List<ExportDataModel>(), new ExportFooterModel());

            Console.WriteLine(builder.GetStringBuilder().ToString()); 
        }
    }
}
