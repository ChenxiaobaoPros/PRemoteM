﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace PRM.Resources.Theme.AttachProperty
{
    public class VisionElement
    {
        #region Background Foreground 

        public static readonly DependencyProperty ForegroundOnMouseDownProperty = DependencyProperty.RegisterAttached("ForegroundOnMouseDown", typeof(Brush), typeof(VisionElement), new FrameworkPropertyMetadata(Brushes.Transparent, FrameworkPropertyMetadataOptions.Inherits));
        public static void SetForegroundOnMouseDown(DependencyObject element, Brush value) => element.SetValue(ForegroundOnMouseDownProperty, value);
        public static Brush GetForegroundOnMouseDown(DependencyObject element) => (Brush)element.GetValue(ForegroundOnMouseDownProperty);

        public static readonly DependencyProperty BackgroundOnMouseDownProperty = DependencyProperty.RegisterAttached("BackgroundOnMouseDown", typeof(Brush), typeof(VisionElement), new FrameworkPropertyMetadata(Brushes.Transparent, FrameworkPropertyMetadataOptions.Inherits));
        public static void SetBackgroundOnMouseDown(DependencyObject element, Brush value) => element.SetValue(BackgroundOnMouseDownProperty, value);
        public static Brush GetBackgroundOnMouseDown(DependencyObject element) => (Brush)element.GetValue(BackgroundOnMouseDownProperty);


        public static readonly DependencyProperty OpacityProperty = DependencyProperty.RegisterAttached("Opacity", typeof(double), typeof(VisionElement), new FrameworkPropertyMetadata(1.0, FrameworkPropertyMetadataOptions.Inherits));
        public static void SetOpacity(DependencyObject element, double value) => element.SetValue(OpacityProperty, value);
        public static double GetOpacity(DependencyObject element) => (double)element.GetValue(OpacityProperty);

        public static readonly DependencyProperty OpacityAccentProperty = DependencyProperty.RegisterAttached("OpacityAccent", typeof(double), typeof(VisionElement), new FrameworkPropertyMetadata(1.0, FrameworkPropertyMetadataOptions.Inherits));
        public static void SetOpacityAccent(DependencyObject element, double value) => element.SetValue(OpacityAccentProperty, value);
        public static double GetOpacityAccent(DependencyObject element) => (double)element.GetValue(OpacityAccentProperty);


        public static readonly DependencyProperty OpacityOnMouseDownProperty = DependencyProperty.RegisterAttached("OpacityOnMouseDown", typeof(double), typeof(VisionElement), new FrameworkPropertyMetadata(1.0, FrameworkPropertyMetadataOptions.Inherits));
        public static void SetOpacityOnMouseDown(DependencyObject element, double value) => element.SetValue(OpacityOnMouseDownProperty, value);
        public static double GetOpacityOnMouseDown(DependencyObject element) => (double)element.GetValue(OpacityOnMouseDownProperty);

        #endregion

        #region Border

        public static readonly DependencyProperty BorderCornerRadiusProperty = DependencyProperty.RegisterAttached("BorderCornerRadius", typeof(CornerRadius), typeof(VisionElement), new FrameworkPropertyMetadata(default(CornerRadius), FrameworkPropertyMetadataOptions.Inherits));
        public static void SetBorderCornerRadius(DependencyObject element, CornerRadius value) => element.SetValue(BorderCornerRadiusProperty, value);
        public static CornerRadius GetBorderCornerRadius(DependencyObject element) => (CornerRadius)element.GetValue(BorderCornerRadiusProperty);


        public static readonly DependencyProperty BorderBrushProperty = DependencyProperty.RegisterAttached("BorderBrush", typeof(Brush), typeof(VisionElement), new FrameworkPropertyMetadata(Brushes.Transparent, FrameworkPropertyMetadataOptions.Inherits));
        public static void SetBorderBrush(DependencyObject element, Brush value) => element.SetValue(BorderBrushProperty, value);
        public static Brush GetBorderBrush(DependencyObject element) => (Brush)element.GetValue(BorderBrushProperty);

        public static readonly DependencyProperty BorderBrushOnMouseOverProperty = DependencyProperty.RegisterAttached("BorderBrushOnMouseOver", typeof(Brush), typeof(VisionElement), new FrameworkPropertyMetadata(Brushes.Transparent, FrameworkPropertyMetadataOptions.Inherits));
        public static void SetBorderBrushOnMouseOver(DependencyObject element, Brush value) => element.SetValue(BorderBrushOnMouseOverProperty, value);
        public static Brush GetBorderBrushOnMouseOver(DependencyObject element) => (Brush)element.GetValue(BorderBrushOnMouseOverProperty);

        public static readonly DependencyProperty BorderBrushOnMouseDownProperty = DependencyProperty.RegisterAttached("BorderBrushOnMouseDown", typeof(Brush), typeof(VisionElement), new FrameworkPropertyMetadata(Brushes.Transparent, FrameworkPropertyMetadataOptions.Inherits));
        public static void SetBorderBrushOnMouseDown(DependencyObject element, Brush value) => element.SetValue(BorderBrushOnMouseDownProperty, value);
        public static Brush GetBorderBrushOnMouseDown(DependencyObject element) => (Brush)element.GetValue(BorderBrushOnMouseDownProperty);

        #endregion


        public static readonly DependencyProperty ForegroundAccentProperty = DependencyProperty.RegisterAttached("ForegroundAccent", typeof(Brush), typeof(VisionElement), new FrameworkPropertyMetadata(Brushes.Transparent, FrameworkPropertyMetadataOptions.Inherits));
        public static void SetForegroundAccent(DependencyObject element, Brush value) => element.SetValue(ForegroundAccentProperty, value);
        public static Brush GetForegroundAccent(DependencyObject element) => (Brush)element.GetValue(ForegroundAccentProperty);


        public static readonly DependencyProperty BackgroundAccentProperty = DependencyProperty.RegisterAttached("BackgroundAccent", typeof(Brush), typeof(VisionElement), new FrameworkPropertyMetadata(Brushes.Transparent, FrameworkPropertyMetadataOptions.Inherits));
        public static void SetBackgroundAccent(DependencyObject element, Brush value) => element.SetValue(BackgroundAccentProperty, value);
        public static Brush GetBackgroundAccent(DependencyObject element) => (Brush)element.GetValue(BackgroundAccentProperty);


        public static readonly DependencyProperty ContentGeometryProperty = DependencyProperty.RegisterAttached("ContentGeometry", typeof(Geometry), typeof(VisionElement), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        public static void SetContentGeometry(DependencyObject element, Geometry value) => element.SetValue(ContentGeometryProperty, value);
        public static Geometry GetContentGeometry(DependencyObject element) => (Geometry)element.GetValue(ContentGeometryProperty);
    }
}
