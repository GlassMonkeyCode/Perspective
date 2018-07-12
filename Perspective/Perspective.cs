using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perspective
{
    public partial class Perspective : Form
    {
        Point centrePoint;
        float _acutalEdgeLength;
        int _xAngle;
        int _yAngle;
        int _zAngle;

        public Perspective()
        {
            InitializeComponent();
        }

        private void Perspective_Load(object sender, EventArgs e)
        {
            timer1.Start();

            centrePoint = new Point((picMain.Width / 2), (picMain.Height / 2) + 100);
            _acutalEdgeLength = (picMain.Height / 2F);

            _yAngle = 20;
            _xAngle = 20;
            _zAngle = 45;
        }

        private void Perspective_Resize(object sender, EventArgs e)
        {
            centrePoint = new Point((picMain.Width / 2), (picMain.Height / 2) + 200);
            picMain.BackgroundImage = GraphicsRenderer.DrawCube(picMain, tbXRotate.Value, _yAngle, tbZRotate.Value, centrePoint, tbLength.Value);
        }

        private void tbXRotate_Scroll(object sender, EventArgs e)
        {
            centrePoint.Y = tbYTransform.Value;
            centrePoint.X = tbXTransform.Value;
            picMain.BackgroundImage = GraphicsRenderer.DrawCube(picMain, tbXRotate.Value, _yAngle, tbZRotate.Value, centrePoint, tbLength.Value);
        }

        private void tbYRotate_Scroll(object sender, EventArgs e)
        {

        }

        private void tbZRotate_Scroll(object sender, EventArgs e)
        {
            centrePoint.Y = tbYTransform.Value;
            centrePoint.X = tbXTransform.Value;
            picMain.BackgroundImage = GraphicsRenderer.DrawCube(picMain, tbXRotate.Value, _yAngle, tbZRotate.Value, centrePoint, tbLength.Value);
        }

        private void tbLength_Scroll(object sender, EventArgs e)
        {
            centrePoint.Y = tbYTransform.Value;
            centrePoint.X = tbXTransform.Value;
            picMain.BackgroundImage = GraphicsRenderer.DrawCube(picMain, tbXRotate.Value, _yAngle, tbZRotate.Value, centrePoint, tbLength.Value);
        }

        private void tbXTransform_Scroll(object sender, EventArgs e)
        {
            centrePoint.Y = tbYTransform.Value;
            centrePoint.X = tbXTransform.Value;
            picMain.BackgroundImage = GraphicsRenderer.DrawCube(picMain, tbXRotate.Value, _yAngle, tbZRotate.Value, centrePoint, tbLength.Value);
        }

        private void tbYTransform_Scroll(object sender, EventArgs e)
        {
            centrePoint.Y = tbYTransform.Value;
            centrePoint.X = tbXTransform.Value;
            picMain.BackgroundImage = GraphicsRenderer.DrawCube(picMain, tbXRotate.Value, _yAngle, tbZRotate.Value, centrePoint, tbLength.Value);
        }
    }
}
