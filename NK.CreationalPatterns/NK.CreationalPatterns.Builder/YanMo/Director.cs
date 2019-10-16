using System;
using System.Collections.Generic;
using System.Text;

namespace NK.CreationalPatterns.Builder.YanMo
{
    public class Director
    {
        private readonly IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void construct(ExportHeaderModel headerModel, List<ExportDataModel> list, ExportFooterModel footerModel)
        {
            builder.BuildHeader(headerModel);
            builder.BuildBody(list);
            builder.BuildFooter(footerModel);
        }
    }
}
