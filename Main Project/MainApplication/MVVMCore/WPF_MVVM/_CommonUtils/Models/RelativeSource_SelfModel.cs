using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.WPF_MVVM.Models
{
    public class RelativeSource_SelfModel
    {
        public bool ToolTipVisible
        {
            get
            {
                return m_ToolTipVisible;
            }
            set
            {
                m_ToolTipVisible = value;
                Notify("ToolTipVisible");
            }
        }

        private void Notify(string v)
        {
            throw new NotImplementedException();
        }

        private bool m_ToolTipVisible = true;
        //public void SetTooltipVisibility(bool b)
        //{
        //    ToolTipVisible = b;
        //    if (DataItems != null)
        //    {
        //        DataItems.ToolTipVisible = b;
        //    }
        //}

        //public RibbonLikeItemsSource DataItems
        //{
        //    get
        //    {
        //        return m_dataItems;
        //    }
        //    set
        //    {
        //        m_dataItems = value;
        //        Notify("DataItems");
        //    }
        //}
    }
}
