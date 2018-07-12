using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perspective
{
    class GraphicsRenderer
    {
        static internal Bitmap DrawCube(PictureBox pictureBox, double xAngle, double yAngle, double zAngle, PointF centrePoint, float actualEdgeLength)
        {
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                float halfWidth = pictureBox.Width / 2;
                float halfHeight = pictureBox.Height / 2;
                float halfEdgeLength = actualEdgeLength / 2F;

                double radX = HelperFunctions.ConvertDegreesToRadians(xAngle);
                double radY = HelperFunctions.ConvertDegreesToRadians(yAngle);
                double radZ = HelperFunctions.ConvertDegreesToRadians(zAngle);
                // X and Y angles are both 20ish. It is the Z angle that will change.
                // 90 for x and y looks directly at the screen, 0 would show a line
                double perceivedLengthXDouble = actualEdgeLength * Math.Cos(radX);
                double perceivedLengthYDouble = actualEdgeLength * Math.Cos(radY);

                float perceivedEdgeLengthX = Convert.ToSingle(perceivedLengthXDouble);

                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                float leftXs = centrePoint.X - halfEdgeLength;
                float rightXs = centrePoint.X + halfEdgeLength;
                float topYs = centrePoint.X - halfEdgeLength;
                float bottomYs = centrePoint.X + halfEdgeLength;

                float halfPercX = perceivedEdgeLengthX / 2F;

                PointF pointA = new PointF(leftXs, bottomYs + halfPercX);
                PointF pointB = new PointF(rightXs, bottomYs + halfPercX);
                PointF pointC = new PointF(rightXs + halfPercX, topYs + halfPercX);
                PointF pointD = new PointF(leftXs + halfPercX, topYs + halfPercX);

                PointF pointE = new PointF(leftXs, bottomYs + halfPercX - actualEdgeLength);
                PointF pointF = new PointF(rightXs, bottomYs + halfPercX - actualEdgeLength);
                PointF pointG = new PointF(rightXs + halfPercX, topYs + halfPercX - actualEdgeLength);
                PointF pointH = new PointF(leftXs + halfPercX, topYs + halfPercX - actualEdgeLength);

                PointF[] bottomFacePoints = new PointF[] { pointA, pointE, pointF, pointB };
                PointF[] topFacePoints = new PointF[] { pointB, pointF, pointG, pointC };
                PointF[] leftBackFacePoints = new PointF[] { pointC, pointG, pointH, pointD };
                PointF[] rightBackFacePoints = new PointF[] { pointA, pointD, pointH, pointE };
                PointF[] bottoms = new PointF[] { pointA, pointB, pointC, pointD };
                PointF[] tops = new PointF[] { pointE, pointF, pointG, pointH };

                PointF[] rotatedAroundZBot = HelperFunctions.RotatePolygon(bottomFacePoints, zAngle, centrePoint);
                PointF[] rotatedAroundZTop = HelperFunctions.RotatePolygon(topFacePoints, zAngle, centrePoint);
                PointF[] rotatedAroundZL = HelperFunctions.RotatePolygon(leftBackFacePoints, zAngle, centrePoint);
                PointF[] rotatedAroundZR = HelperFunctions.RotatePolygon(rightBackFacePoints, zAngle, centrePoint);
                PointF[] rotatedAroundZactbot = HelperFunctions.RotatePolygon(bottoms, zAngle, centrePoint);
                PointF[] rotatedAroundZacttop = HelperFunctions.RotatePolygon(tops, zAngle, centrePoint);

                graphics.FillPolygon(Brushes.LightBlue, rotatedAroundZBot);
                graphics.FillPolygon(Brushes.SteelBlue, rotatedAroundZTop);
                graphics.FillPolygon(Brushes.LightSteelBlue, rotatedAroundZR);
                graphics.FillPolygon(Brushes.AliceBlue, rotatedAroundZL);
                graphics.FillPolygon(Brushes.Gray, rotatedAroundZactbot);
                //  graphics.FillPolygon(Brushes.CadetBlue, rotatedAroundZacttop);


                graphics.DrawPolygon(Pens.Black, rotatedAroundZBot);
                graphics.DrawPolygon(Pens.Black, rotatedAroundZTop);
                graphics.DrawPolygon(Pens.Black, rotatedAroundZR);
                graphics.DrawPolygon(Pens.Black, rotatedAroundZL);


                graphics.Dispose();
            }
            return bitmap;
        }
    }
}
