﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workspacer.Bar.Widgets;

namespace workspacer.Bar
{
    public class BarPluginConfig
    {
        public string BarTitle { get; set; } = "workspacer.Bar";
        public int BarHeight { get; set; } = 30;
        public string FontName { get; set; } = "Consolas";
        public int FontSize { get; set; } = 16;
        public string FontStyle { get; set; } = "Regular";
        public Color DefaultWidgetForeground { get; set; } = Color.White;
        public Color DefaultWidgetBackground { get; set; } = Color.Black;
        public Color Background { get; set; } = Color.Black;

        public Boolean Transparent = false;
        

        public Func<IBarWidget[]> LeftWidgets { get; set; } = () => 
            new IBarWidget[] { new WorkspaceWidget(), new TextWidget(": "), new TitleWidget() };
        public Func<IBarWidget[]> RightWidgets { get; set; } = () => 
            new IBarWidget[] { new TimeWidget(), new ActiveLayoutWidget() };
    }
}
