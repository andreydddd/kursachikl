using GMap.NET.MapProviders;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.WindowsForms;

namespace kursachikl
{
    public partial class Veil_map : Form
    {
        public Veil_map()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = CzechTuristMapProvider.Instance; gMapControl1.CacheLocation = Application.StartupPath + @"\maps\OSMCache";
            GMaps.Instance.Mode = AccessMode.ServerAndCache; gMapControl1.CanDragMap = true;
            gMapControl1.DragButton = MouseButtons.Left; gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter; gMapControl1.MinZoom = 10;
            gMapControl1.MaxZoom = 20; gMapControl1.Zoom = 15;
            gMapControl1.Position = new PointLatLng(59.9386, 30.3141); gMapControl1.ShowCenter = false;
            Createmarker();
        }
        private void Createmarker()
        {
            GMapOverlay ListOfCar = new GMapOverlay("Car");
            // Загружаем изображение
            Bitmap originalImage = new Bitmap(@"E:\фотк\ishod.png");
            // Уменьшаем размер изображения (например, до 50% от оригинала)    int newWidth = (int)(originalImage.Width * 0.03);
            int newHeight = (int)(originalImage.Height * 0.1); Bitmap resizedImage = new Bitmap(originalImage, new Size(newHeight, newHeight));
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(59.958434, 30.439293), resizedImage);

            marker.ToolTip = new GMapRoundedToolTip(marker); marker.ToolTipText = "Отель";

            ListOfCar.Markers.Add(marker);

            GMarkerGoogle marker11 = new GMarkerGoogle(new PointLatLng(59.799800, 30.273000), GMarkerGoogleType.red_small); marker11.ToolTip = new GMapRoundedToolTip(marker11);

            marker11.ToolTipText = "Мое место положение"; ListOfCar.Markers.Add(marker11);

            gMapControl1.Overlays.Add(ListOfCar);
        }

        private void обратноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Veil veil = new Veil();
            veil.Show();
            this.Close();
        }
    }
}
