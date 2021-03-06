﻿using AppKit;
using CompareImage;
using CompareImage.Mac.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

[assembly: ExportRenderer(typeof(CustomImage), typeof(CustomImageRenderer))]
namespace CompareImage.Mac.Renderer
{
    public class CustomImageRenderer : ImageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
                Control.RegisteredDragTypes();
        }

        public override NSDragOperation DraggingEntered(NSDraggingInfo sender)
        {
            return base.DraggingEntered(sender);
        }
    }

}
