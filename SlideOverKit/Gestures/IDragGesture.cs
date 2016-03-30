﻿using System;

namespace SlideOverKit
{
    internal struct Rect
    {
        public double left, top, right, bottom;

    }

    internal interface IDragGesture
    {
        void DragBegin (double x, double y);

        void DragMoving (double x, double y);

        void DragFinished ();

        Action<double, double, double, double, double> RequestLayout { get; set; }

        void LayoutShowStatus ();

        void LayoutHideStatus ();

        Rect GetShowPosition ();

        Rect GetHidePosition ();

        void UpdateLayoutSize (SlideMenuView view);

        Action<bool, double> NeedShowBackgroundView { get; set; }
    }
}

