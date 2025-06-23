using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_EgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {

            lblLocationCount.Text = db.Location.Count().ToString();
            lblTotalCapacity.Text = db.Location.Sum(x=> x.Capacity).ToString(); 
            lblGuideCount.Text = db.Guide.Count().ToString();    
            lblAvgCapacity.Text = db.Location.Average(x=> x.Capacity).ToString();   
            lblAvgLocationPrice.Text = db.Location.Average(x=> x.Price).Value.ToString("F2");
            
            int lastCountryId = db.Location.Max(x => x.LocationID);
            lblLastCountry.Text = db.Location.Where(x => x.LocationID == lastCountryId).Select(y => y.Country).FirstOrDefault();

            lblCappadocia.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            lblTurkey.Text = db.Location.Where(x=> x.Country == "Türkiye").Average(y=> y.Capacity).ToString();

            var romeGuideId = db.Location.Where(x => x.City == "Roma Turistik").Select(y => y.GuideID).FirstOrDefault();
            lblRomeGuide.Text = db.Guide.Where(x=> x.GuideID == romeGuideId).Select(y=> y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();
            var maxCapacity = db.Location.Max(y=> y.Capacity);  
            lblMaxCapacity.Text = db.Location.Where(x=> x.Capacity == maxCapacity).Select(y=> y.City).FirstOrDefault().ToString();

            var maxPrice = db.Location.Max(x=> x.Price);
            lblMaxPrice.Text = db.Location.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();

            var guideIdAysegul = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideID).FirstOrDefault();
            lblAysegulTour.Text = db. Location.Where(x=> x.GuideID == guideIdAysegul).Count().ToString();   
        }
    }
}
