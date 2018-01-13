using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cylinder
{
    using System.Windows.Media.Media3D;
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            G3D.Geometry = GenMesh();

        }
        MeshGeometry3D GenMesh()
        {   // 00 - 01 - 02 - 03 ...
            //    /    /
            // 10 - 11 - 12
            // Nx * Ny Points
            // triangles = (Nx-1)*(Ny-1) * 2
            int Nx = 20;
            int Ny = 5;
            // th = 180 ~ 0 dth = + 180/(Nx-1)
            double th0 = -180;
            double dth = (0 - 360.0) / (double)(Nx - 1);
            double x0 = 0.5;
            //double R0 = 0.5;
            Point3D[,] p3Dm2D = new Point3D[Nx, Ny];
            for (int i = 0; i < Nx; i++)
                for (int j = 0; j < Ny; j++)
                {
                    // Rectangle
                    /* double x = 1.0 / (double)(Nx - 1) * i;
                     double y = 1.0 / (double)(Ny - 1) * j;
                     double z = 0; */
                    // Cylinder
                    double th = th0 + i * dth;
                    double x = x0 + R0*Math.Cos(th/180*Math.PI);
                    double y = 1.0 / (double)(Ny - 1) * j;
                    double z = R0 * Math.Sin(th / 180 * Math.PI);
                    p3Dm2D[i, j] = new Point3D(x, y , z);

                }
            Point[,] pTexture = new Point[Nx, Ny];
            for (int i = 0; i < Nx; i++)
                for (int j = 0; j < Ny; j++)
                    pTexture[i, j] = new Point(1.0 / (double)(Nx - 1) * i, 1.0 - (1.0 / (double)(Ny - 1) * j));
            MeshGeometry3D mesh1 = new MeshGeometry3D();
            Point3DCollection pts = new Point3DCollection();
            for (int i = 0; i < Nx; i++)
                for (int j = 0; j < Ny; j++)
                    pts.Add(p3Dm2D[i, j]);
            PointCollection tpts = new PointCollection();
            for (int i = 0; i < Nx; i++)
                for (int j = 0; j < Ny; j++)
                    tpts.Add(pTexture[i, j]);
            Int32Collection tri = new Int32Collection();
            // (i,j)  (1)    i+1,j (2)
            //
            // i, j+1 (0)   i+1, j+1 (3)
            // tri 0,1,2,2,3,1
            for (int i = 0; i < Nx - 1; i++)
                for (int j = 0; j < Ny - 1; j++)
                {

                    tri.Add(j + Ny * i);  //1
                    tri.Add(j + 1 + Ny * i); //0
                    
                    tri.Add(j + Ny * (i + 1));  //2
                    
                    tri.Add((j + 1) + Ny * (i + 1)); //3
                    tri.Add(j + Ny * (i + 1)); //2
                    tri.Add(j + 1 + Ny * i); //0

                }
            mesh1.Positions = pts;
            mesh1.TextureCoordinates = tpts;
            mesh1.TriangleIndices = tri;

            return mesh1;
        }

        double R0 = 1.8;
        double th0 = 0;

        private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            double x, y, z;
            // x = CAM.Position.X;
            y = CAM.Position.Y;
            // z = CAM.Position.Z;
            if (e.Delta > 0)
                th0 += 5;
            else
                th0 -= 5;
            x = R0 * Math.Sin(th0 / 180 * Math.PI) + 0.5;
            z = R0 * Math.Cos(th0 / 180 * Math.PI);
            CAM.Position = new Point3D(0.5, 0.5, 0);
            CAM.LookDirection = new Vector3D(0.5- x, 0.5 -y, -z);
        }
    }
}
