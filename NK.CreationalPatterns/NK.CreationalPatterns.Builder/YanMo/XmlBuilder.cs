using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.Builder.YanMo
{
    public class XmlBuilder : IBuilder
    {
        private StringBuilder stringBuilder = new StringBuilder();

        public void BuildBody(List<ExportDataModel> exportDataList)
        {
            stringBuilder.Append("XmlBuilder.BuildBody");
        }

        public void BuildFooter(ExportFooterModel exportFooterModel)
        {
            stringBuilder.Append("XmlBuilder.BuildFooter");
        }

        public void BuildHeader(ExportHeaderModel exportHeaderModel)
        {
            stringBuilder.Append("XmlBuilder.BuildHeader");
        }

        public StringBuilder GetStringBuilder()
        {
            return stringBuilder;
        }
    }
}
