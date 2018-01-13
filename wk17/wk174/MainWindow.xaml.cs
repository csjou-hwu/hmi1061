﻿using System;
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

namespace wk174
{
    using System.Diagnostics;
    using System.Threading;
    using System.Windows.Media.Media3D;
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public GeometryModel3D FlagModel { get; set; }
        public Flag Flag { get; private set; }

        private readonly Stopwatch watch;
        private readonly Thread integratorThread;

        public MainWindow()
        {
            InitializeComponent();

            CreateFlag();

            DataContext = this;
            Loaded += MainWindow_Loaded;

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
                Flag.Update(dt);
            }
        }

        void OnCompositionTargetRendering(object sender, EventArgs e)
        {
            Flag.Transfer();
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            view1.ZoomExtents();
        }

        private void CreateFlag()
        {
            Flag = new Flag(@"E:\Course1061\uTaipei\HMI\wk17\wk17\wk174\FlagOfNorway.png");
            Flag.Init();

            FlagModel = new GeometryModel3D
            {
                Geometry = Flag.Mesh,
                Material = Flag.Material,
                BackMaterial = Flag.Material
            };
        }
    }
}
