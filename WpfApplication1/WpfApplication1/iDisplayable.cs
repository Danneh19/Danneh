﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApplication1
{
    /// <summary>
    /// Interface voor de DisplayOn methode.
    /// </summary>
    public interface iDisplayable
    {
        void DisplayOn(Canvas drawArea);
    }
}
