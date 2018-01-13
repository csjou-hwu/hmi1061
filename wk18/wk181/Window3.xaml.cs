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
using System.Windows.Shapes;

namespace wk181
{
    using System.Windows.Media.Media3D;
    using System.Threading;
    using System.Diagnostics;
    /// <summary>
    /// Window3.xaml 的互動邏輯
    /// </summary>
    public partial class Window3 : Window
    {
        private Stopwatch watch;
        private Thread integratorThread;
        Flag [] FlagO;
        ModelVisual3D [] M3D;
        public Window3()
        {
            InitializeComponent();
            AddFlag();
        }
        private void AddFlag()
        {
            FlagO = new Flag[3];
            string[] flagname = { "FlagOfNorway.png", "roc.png", "utaipei.png" };
            M3D = new ModelVisual3D[3];
            for (int i = 0; i < 3; i++)
            {
                M3D[i] = new ModelVisual3D();
                GeometryModel3D FlagModel = new GeometryModel3D();
                FlagO[i] = new Flag(@"E:\Course1061\uTaipei\HMI\wk18\wk181\wk181\" + flagname[i]);
                FlagO[i].WindDirection = -20;
                FlagO[i].Init();
                FlagModel = new GeometryModel3D
                {
                    Geometry = FlagO[i].Mesh,
                    Material = FlagO[i].Material,
                    BackMaterial = FlagO[i].Material
                };
                
                TranslateTransform3D TR = new TranslateTransform3D(i *4 - 4, 0, -5);
                M3D[i].Transform = TR;
                M3D[i].Content = FlagModel;
                VP.Children.Add(M3D[i]);
            }
            watch = new Stopwatch();
            watch.Start();
            integratorThread = new Thread(IntegrationWorker);
            integratorThread.Start();

            CompositionTarget.Rendering += this.OnCompositionTargetRendering;
            this.Closing += MainWindow_Closing;
        }

        void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            integratorThread.Abort();
        }
        private void IntegrationWorker()
        {
            while (true)
            {
                double dt = 1.0 * watch.ElapsedTicks / Stopwatch.Frequency;
                watch.Restart();
                foreach (Flag flag in FlagO)
                { flag.Update(dt); }
            }
        }

        void OnCompositionTargetRendering(object sender, EventArgs e)
        {
            foreach (Flag flag in FlagO)
            { flag.Transfer(); }
        }

    }
}
