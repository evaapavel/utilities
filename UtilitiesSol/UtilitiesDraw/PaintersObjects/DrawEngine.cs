using System;
using System.Collections.Generic;
using System.Drawing;

using UtilitiesDraw.BusinessObjects.HouseBuilding;



namespace UtilitiesDraw.PaintersObjects
{



    public class DrawEngine
    {



        private BuildingElement rootElement;
        private Graphics graphics;
        private CanvasContext rootContext;



        public DrawEngine(BuildingElement rootElement, Graphics graphics, CanvasContext rootContext)
        {
            this.rootElement = rootElement;
            this.graphics = graphics;
            this.rootContext = rootContext;
        }



        public void DrawAllElements()
        {
            DrawElementAndItsChildren(rootElement, rootContext);
        }



        private void DrawElementAndItsChildren(BuildingElement element, CanvasContext context)
        {
            rootElement.DrawSelf(graphics, context);
            //CanvasContext context = GetCanvasForChildren(rootContext);
            //DrawChildren(rootElement, )
            List<BuildingElement> childElements = element.GetChildren();
            CanvasContext contextForChildren = element.GetContextForChildren(context);
            LayoutType layoutForChildren = element.GetLayoutForChildren();
            double sizeRecalcRatio = GetSizeRecalculationRatio(childElements, contextForChildren, layoutForChildren);
            int childLeft = contextForChildren.Left;
            int childTop = contextForChildren.Top;
            foreach (BuildingElement childElement in childElements)
            {
                //int childWidth = CalculateWidth(childLeft, childElement.GetRealWidth(), sizeRecalcRatio, contextForChildren, layoutForChildren);
                //int childHeight = CalculateHeight(childTop, childElement.GetRealHeight(), sizeRecalcRatio, contextForChildren, layoutForChildren);
                int childWidth = CalculateWidth(childElement.GetRealWidth(), sizeRecalcRatio, contextForChildren, layoutForChildren);
                int childHeight = CalculateHeight(childElement.GetRealHeight(), sizeRecalcRatio, contextForChildren, layoutForChildren);
                CanvasContext childContext = GenerateChildContext(childLeft, childTop, childWidth, childHeight);
                DrawElementAndItsChildren(childElement, childContext);
                childLeft += childWidth;
                childTop += childHeight;
            }
        }



        private double GetSizeRecalculationRatio(List<BuildingElement> elements, CanvasContext context, LayoutType layoutType)
        {
            switch (layoutType)
            {
                case LayoutType.Horizontal:
                    double sumOfRealWidths = 0.0;
                    foreach (BuildingElement element in elements)
                    {
                        sumOfRealWidths += element.GetRealWidth();
                    }
                    double contextWidth = context.Width;
                    double widthRatio = contextWidth / sumOfRealWidths;
                    return widthRatio;
                    //break;

                case LayoutType.Vertical:
                    double sumOfRealHeigths = 0.0;
                    foreach (BuildingElement element in elements)
                    {
                        sumOfRealHeigths += element.GetRealWidth();
                    }
                    double contextHeight = context.Height;
                    double heightRatio = contextHeight / sumOfRealHeigths;
                    return heightRatio;
                    //break;

                default:
                    throw new NotSupportedException($"This layout type is not supported here: {layoutType}");
            }
        }



        private int CalculateWidth(double realWidth, double sizeRecalcRatio, CanvasContext totalContext, LayoutType layoutType)
        {
            switch (layoutType)
            {
                case LayoutType.Horizontal:
                    double recalculatedWidth = realWidth * sizeRecalcRatio;
                    return Convert.ToInt32(Math.Truncate(recalculatedWidth));
                    //break;

                case LayoutType.Vertical:
                    return totalContext.Width;
                    //break;

                default:
                    throw new NotSupportedException($"This layout type is not supported here: {layoutType}");
            }
        }



        private int CalculateHeight(double realHeight, double sizeRecalcRatio, CanvasContext totalContext, LayoutType layoutType)
        {
            switch (layoutType)
            {
                case LayoutType.Horizontal:
                    return totalContext.Height;
                    //break;

                case LayoutType.Vertical:
                    double recalculatedHeight = realHeight * sizeRecalcRatio;
                    return Convert.ToInt32(Math.Truncate(recalculatedHeight));
                //break;

                default:
                    throw new NotSupportedException($"This layout type is not supported here: {layoutType}");
            }
        }



        private CanvasContext GenerateChildContext(int left, int top, int width, int height)
        {
            //CanvasContext context = new CanvasContext(left, top, width, height);
            CanvasContext context = new CanvasContext(left, top, width - 1, height - 1);
            return context;
        }



    }



}
