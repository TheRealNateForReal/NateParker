using System.ComponentModel.DataAnnotations;

namespace NateParker.ViewModels
{
    public class StravaViewModel : BaseViewModel
    {
        public StravaViewModel() { }

        [Display(Name = "Total rides:")]
        public int TotalRides { get; set; }

        [Display(Name = "Total distance:")]
        public double TotalDistance { get; set; }

        [Display(Name = "Total moving time:")]
        public string TotalMovingTime { get; set; }
    }
}
