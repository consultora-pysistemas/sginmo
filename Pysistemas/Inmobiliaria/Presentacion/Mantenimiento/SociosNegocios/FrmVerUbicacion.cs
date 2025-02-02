using System;
using System.Device.Location;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.Mantenimiento.SociosNegocios
{
    public partial class FrmVerUbicacion : Genericos.FrmMaestro
    {
        public Uri url { get; set; }
        public FrmVerUbicacion()
        {
            InitializeComponent();
        }

        private void FrmVerUbicacion_Load(object sender, EventArgs e)
        {
            if (url == null)
            {
                GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

                watcher.PositionChanged += (sender1, e1) =>
                {
                    var coordinate = e1.Position.Location;
                    Console.WriteLine("Lat: {0}, Long: {1}", coordinate.Latitude,
                        coordinate.Longitude);
                    url = new Uri(@"https://www.google.com/maps/place/" + coordinate.Latitude + "," + coordinate.Latitude + "/@"+ coordinate.Latitude+","+ coordinate.Latitude+", 17z / data = !3m1!4b1!4m5!3m4!1s0x0: 0x0!8m2!3d"+ coordinate.Latitude+"!4d"+ coordinate.Latitude);
                    webBrowser1.Url = url;
                    watcher.Stop();
                };

                watcher.Start();
                
            }
            else
            {
                webBrowser1.Url = url;

            }
            
        }

        private void FrmVerUbicacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            url = webBrowser1.Url;
            DialogResult = DialogResult.OK;
            Hide();
        }
    }
}
