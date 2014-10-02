﻿// -----------------------------------------------------------------------
// <copyright file="TabItemStyle.cs" company="Steven Kirk">
// Copyright 2014 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace Perspex.Themes.Default
{
    using System.Linq;
    using Perspex.Controls;
    using Perspex.Controls.Presenters;
    using Perspex.Media;
    using Perspex.Styling;

    public class TabItemStyle : Styles
    {
        public TabItemStyle()
        {
            this.AddRange(new[]
            {
                new Style(x => x.OfType<TabItem>())
                {
                    Setters = new[]
                    {
                        new Setter(TextBlock.FontSizeProperty, 28.7),
                        new Setter(Control.ForegroundProperty, Brushes.Gray),
                        new Setter(TabItem.TemplateProperty, ControlTemplate.Create<TabItem>(this.Template)),
                    },
                },
                new Style(x => x.OfType<TabItem>().Class(":selected"))
                {
                    Setters = new[]
                    {
                        new Setter(Control.ForegroundProperty, Brushes.Black),
                    },
                },
            });
        }

        private Control Template(TabItem control)
        {
            return new ContentPresenter
            {
                [~ContentPresenter.ContentProperty] = control[~TabItem.HeaderProperty],
            };
        }
    }
}
