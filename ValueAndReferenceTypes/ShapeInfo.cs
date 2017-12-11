using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    public struct Rectangle
    {
        // The Rectangle structure contains a reference type member.
        public ShapeInfo rectInfo;
        public int rectTop, rectLeft, rectBottom, rectRight;

        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            rectInfo = new ShapeInfo(info);
            rectTop = top;
            rectLeft = left;
            rectBottom = bottom;
            rectRight = right;
        }

        public void Display()
        {
            Console.WriteLine($"String = {rectInfo.infoString}, Top = {rectTop}, Bottom = {rectBottom}, Left = {rectLeft}, Right = {rectRight}");
        }

    }

    public class ShapeInfo
    {
        public string infoString;

        public ShapeInfo(string info)
        {
            infoString = info;
        }
    }
}
