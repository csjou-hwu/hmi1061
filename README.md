# hmi1061
## Wk1 目標: 1. 工具/環境介紹(欠Visual Studio 改用 mono) 2. C#程式基本架構
1-1 Join google classroom (by personal gmail account) <br/>
1-2 Screen copy for assignment. <br/>
1-3 使用mono (download/install/practice) <br/>
1-4 編譯 mcs xxx.cs  <br/>
1-5 執行 mono xxx.exe  <br/>
1-6 C# fundamentals <br/>
1-6-1 3-layer structure <br/>
namespace/class/method <br/>
1-6-2 Entry point <br/>
Public static void Main()<br/>
1-6-3 Statement<br/>
Console.WriteLine(“xxx”);<br/>
1-7 記事本<br/>
Save as xxx.cs UTF-8<br/>

## Wk2 課程簡介/雲端教室
2-0. 課程簡介/雲端教室<br/>
課程規劃3個模組(以輸出裝置為主的介面實作)<br/>
2-0-1.	2D 動畫<br/>
2-0-2.	3D 動畫<br/>
2-0-3.	網路3D(略)<br/>
2-1. 工具/環境介紹(欠Visual Studio 改用 mono) <br/>
編譯<br/>
mcs xxx.cs<br/>
mcs xxx.cs -r:System.Windows.Forms.DLL -r:System.Drawing.DLL<br/>
--- Mac   mcs xxx.cs -r:System.Windows.Forms.DLL -r:System.Drawing.DLL<br/> 
執行<br/>
mono xxx.exe<br/>
2-2. C#程式基本架構<br/>
namespace/class/method (Main as entry point)<br/>
2-3. 類別/物件<br/>
classname objectname = new classname();<br/>
classname.classmethod();<br/>
objectname.objectmethod();<br/>
2-4. 類別/物件/建構元方法<br/>
using System;<br/>
// cd <br/>
// dir <br/>
// mcs wk22.cs <br/>
// mono wk22.exe <br/>
namespace N1<br/>
{... <br/>
2-5. 表單程式 <br/>
// cd<br/>
// dir<br/>
// mcs wk22.cs -r:System.Windows.Forms.DLL <br/>
// mono wk22.exe <br/>
using System;<br/>
using System.Windows.Forms;<br/>
namespace N1<br/>
{... <br/>
## Wk4. 目標: 平面動畫
4-1 比較動畫檔案在不同控制項下的差異(rendering)。<br/>
Form.BackgroundImage vs PictureBox.Image <br/>
4-1-1 Download gif 動畫檔案 <br/>
4-1-2 Form.BackgroundImage (gif) <br/>
4-1-3 PictureBox (gif) <br/>
4-1-3 gif Split <br/>
https://ezgif.com/split (略) <br/>
## Wk5. 目標: 平面動畫
5-0 Visual Studio 2017 工作環境介紹 <br/> 
5-0-1 方案(專案) <br/>
5-0-2 智慧標籤(以TAB結束)<br/>
5-0-3 常見錯誤<br/>
5-0-3-1.	https://developercommunity.visualstudio.com/content/problem/26630/the-debugger-is-not-properly-installed-cannot-debu.html?page=2&pageSize=10&sort=votes <br/>
5-0-3-2.	ctrl+F5 非偵錯模式 <br/>
5-0-3-3.	alt+ctrl+del 工作管理員，手動移除未關閉程序 <br/>
5-1 繼承 (PictureBox) <br/>
比較 gif動畫在Form.BackgroundImage 與 PictureBox.Image 間差異 <br/>
PictureBox.SizeMode => Stretchmode <br/>
5-2 陣列(Array) 與 Random 應用<br/>
迴圈語法<br/>
for (int i=0; i<5; i++)<br/>
{	… 指令; } <br/>
5-3 全域計時器<br/>
5-4 物件計時器<br/>
## Wk6. 目標: 平面動畫
6-1 陣列(Array) 與 Random 應用<br/>
6-1-1 <br/>
類別名稱 [ ] 物件名稱 = new 類別名稱[數目]; <br/>
for (int i=0; i<數目; i++)<br/>
	{		物件名稱[i] = new 類別名稱();	} <br/>
// 陣列物件要 new 一次， 每一陣列物件要再 new 一次 <br/>
https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/arrays/multidimensional-arrays <br/>
https://msdn.microsoft.com/zh-tw/library/2dx6wyd4(v=vs.110).aspx <br/>
https://docs.microsoft.com/zh-tw/dotnet/csharp/language-reference/keywords/foreach-in <br/>
6-2 全域計時器<br/>
單一計時器，個別單位時間位移距離(陣列) <br/>
6-3 物件計時器<br/>

## Wk7. 目標: 平面動畫
7-1 WPF GIF <br/>
7-1-1 Background <br/>
xaml (標籤語法) <br/>
次標籤<br/>
<Grid><br/>
        <Grid.Background><br/>
            <ImageBrush ImageSource="C:\Users\G521\source\repos\wk7\wk71\bin\Debug\run.gif" /><br/>
        </Grid.Background><br/>
</Grid><br/>
7-1-2 Image <br/>
7-1-3 MediaElement <br/>
7-1-3a <br/>
 <MediaElement Name="M1"  LoadedBehavior="play" UnloadedBehavior="Manual"  Source="C:\Users\G521\source\repos\wk7\wk71\bin\Debug\run.gif" ></MediaElement> <br/>
7-1-3b <br/>
<MediaElement Name="M1" MediaEnded="MediaElement_MediaEnded"  LoadedBehavior="play" UnloadedBehavior="Manual"  Source="C:\Users\G521\source\repos\wk7\wk71\bin\Debug\run.gif" ></MediaElement><br/>
 private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)<br/>
{ M1.Position = new TimeSpan(0, 0, 1);            M1.Play();        }<br/>
https://stackoverflow.com/questions/5975388/c-sharp-wpf-how-to-repeat-mediaelement-playback-from-mediaended-event-handler-wi <br/>
7-1-4 WpfAnimatedGif <br/>
https://github.com/XamlAnimatedGif/WpfAnimatedGif <br/>
## Wk8. 目標:動畫類別庫
Brief <br/>
1.	C# for Console/Form/WPF/Web <br/>
2.	Coding for class <br/>
3.	MS class/ Home made class <br/>
4.	Picture in various controls / Form/Image/MediaElement <br/>
8-1 WPF C# Animation <br/>
https://msdn.microsoft.com/zh-tw/library/ms745186(v=vs.110).aspx <br/>
8-2 WPF xaml Animation <br/>
https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.media.animation.pointanimation<br/>
8-3 座標轉換 <br/>
https://msdn.microsoft.com/zh-tw/library/ms750596(v=vs.110).aspx <br/>
ScaleTransform <br/>
## Wk9. 2D 四格動畫
精簡型影片與示意圖如下：<br/>
https://www.youtube.com/watch?v=cDdLk5jGdcI <br/>
## Wk10. 目標: 3D(WPF) 繪圖
10-1 WPF 3D Brief (三角網格)<br/>
https://msdn.microsoft.com/zh-tw/library/ms747437(v=vs.110).aspx<br/>
<MeshGeometry3D <br/>
              Positions="-1 -1 0  1 -1 0  -1 1 0  1 1 0"<br/>
              Normals="0 0 1  0 0 1  0 0 1  0 0 1" (可略)<br/>
              TextureCoordinates="0 1  1 1  0 0  1 0   "<br/>
              TriangleIndices="0 1 2  1 3 2" /><br/>
1-1 範例複製貼上 Grid 內copy and paste<br/>
1-2 更改曲面(4點平面)replace MeshGeometry3D<br/> 
1-3 更改曲面三角網格向量方向 change triangleindices<br/>
1-4 更改相機距離 change camera position<br/>
1-5 更改光源方向 change light source direction<br/>
10-2 3D立體場景<br/>
https://msdn.microsoft.com/zh-tw/library/ms752082(v=vs.110).aspx<br/>
10-3 3D 基本元素<br/>
<Viewport3D><br/>
<Viewport3D.Camera><br/>
            <ModelVisual3D><br/>
                <ModelVisual3D.Content><br/>
                    <Model3DGroup><br/>
                        <AmbientLight Color="White"/><br/>
                        <GeometryModel3D><br/>
TexttureCoordinate<br/>
https://stackoverflow.com/questions/18776406/wpf-3d-understanding-texture-coordinates<br/>


















