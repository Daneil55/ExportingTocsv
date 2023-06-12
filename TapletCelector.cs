using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportingTocsv
{
    internal class TapletCelector : DataTemplateSelector
    {
        public DataTemplate names { get; set; }
        public TapletCelector() { }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            throw new NotImplementedException();
        }
    }
}
