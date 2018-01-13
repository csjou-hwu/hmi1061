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

namespace wk121
{
    using System.Windows.Media.Media3D;
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        //<MeshGeometry3D
        //      Positions = "-1 -1 0  1 -1 0  -1 1 0  1 1 0"
        //      Normals="0 0 1  0 0 1  0 0 1  0 0 1"
        //      TextureCoordinates="0 1  1 1  0 0  1 0   "
        //      TriangleIndices="0 1 2  1 3 2" />
        public MainWindow()
        {
            InitializeComponent();
            int M = 10, N = 5;
            double Rx = 1.0, Ry=1.0;
            double dRx = (Rx + Rx) / (double)M;
            double dRy = (Ry + Ry) / (double)N;
            double t2Dx = 1.0;
            double t2Dy = 1.0;
            double dt2Dx = t2Dx / (double)M;
            double dt2Dy = t2Dy / (double)N;
            MeshGeometry3D 三維曲面 = new MeshGeometry3D();
            Point3DCollection 三維位置 = new Point3DCollection();
            for (int i=0; i<=M; i++)
                for (int j=0; j<=N; j++)
                {
                    double x, y, z;
                    z = 0;
                    x = -Rx + dRx * i;
                    y = -Ry + dRy * j;
                    三維位置.Add(new Point3D(x, y, z));
                }
            //三維位置.Add(new Point3D(-1, -1, 0));
            //三維位置.Add(new Point3D(1, -1, 0));
            //三維位置.Add(new Point3D(-1, 1, 0));
            //三維位置.Add(new Point3D(1, 1, 0));
            PointCollection 貼圖位置 = new PointCollection();
            for (int i = 0; i <= M; i++)
                for (int j = 0; j <= N; j++)
                {
                    double x, y;
                    x =  t2Dx * i;
                    y =  1.0- t2Dy * j;
                    貼圖位置.Add(new Point(x, y));
                }
            //貼圖位置.Add(new Point(0, 1));
            //貼圖位置.Add(new Point(1, 1));
            //貼圖位置.Add(new Point(0, 0));
            //貼圖位置.Add(new Point(1, 0));
            Int32Collection 法向量 = new Int32Collection();
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                {   // i,j
                    // 0 1 2 1 3 2
                    法向量.Add(i*(N+1)+j);
                    法向量.Add((i + 1) * (N+1) + j);
                    法向量.Add(i*(N+1)+j+1);
                    法向量.Add((i + 1) * (N+1) + j);
                    法向量.Add((i + 1) * (N+1) + j+1);
                    法向量.Add(i * (N+1) + j+1);
                }
            //法向量.Add(0);
            //法向量.Add(1);
            //法向量.Add(2);
            //法向量.Add(1);
            //法向量.Add(3);
            //法向量.Add(2);
            三維曲面.Positions = 三維位置;
            三維曲面.TextureCoordinates = 貼圖位置;
            三維曲面.TriangleIndices = 法向量;
            G3D.Geometry = 三維曲面;
        }
    }
}
