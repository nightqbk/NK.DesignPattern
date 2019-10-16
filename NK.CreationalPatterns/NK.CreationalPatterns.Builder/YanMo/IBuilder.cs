using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.Builder.YanMo
{
    public interface IBuilder
    {
        public void BuildHeader(ExportHeaderModel exportHeaderModel);

        public void BuildBody(List<ExportDataModel> exportDataList);

        public void BuildFooter(ExportFooterModel exportFooterModel);

        public StringBuilder GetStringBuilder();
    }
}
