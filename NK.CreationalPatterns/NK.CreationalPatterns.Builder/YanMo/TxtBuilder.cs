using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.Builder.YanMo
{
    public class TxtBuilder : IBuilder
    {
        private StringBuilder stringBuilder = new StringBuilder();
        public void BuildBody(List<ExportDataModel> exportDataList)
        {
            stringBuilder.Append("txt BuildBody");
        }

        public void BuildFooter(ExportFooterModel exportFooterModel)
        {
            stringBuilder.Append("txt BuildFooter");
        }

        public void BuildHeader(ExportHeaderModel exportHeaderModel)
        {
            stringBuilder.Append("txt Header");
        }

        public StringBuilder GetStringBuilder()
        {
            return this.stringBuilder;
        }
    }
}
