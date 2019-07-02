using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models.Controls;

namespace WebApplication1.Models.Controls
{
    public class CtrlDatePickerModel : CtrlBaseModel
    {

        public string Id { get; set; }
        public string Label { get; set; }
        public string Type { get; set; }
        public string Placeholder { get; set; }
        public string ColumnDataName { get; set; }

        public CtrlDatePickerModel()
        {
            ViewName = "";
        }

    }
}