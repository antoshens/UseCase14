using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Globalization;
using UseCase14.Models;

namespace UseCase14.Controllers
{
    public class TestController : Controller
    {
        private readonly RequestLocalizationOptions _localizationOptions;

        public TestController(
            IOptions<RequestLocalizationOptions> localizationOptions)
        {
            _localizationOptions = localizationOptions.Value;
        }

        public IActionResult CultureTest(string culture)
        {
            if (string.IsNullOrEmpty(culture))
            {
                culture = _localizationOptions.DefaultRequestCulture.Culture.Name;
            }

            CultureInfo.CurrentCulture = new CultureInfo(culture);
            CultureInfo.CurrentUICulture = new CultureInfo(culture);

            var date = DateTime.Now;
            var number = 123456789.123;

            double inches = 10;
            double centimeters = inches * 2.54;

            double pounds = 10;
            double kilograms = pounds * 0.45359237;

            double liters = 10;
            double ounces = liters * 33.814;

            var viewModel = new LocalizationViewModel
            {
                DateFormat1 = date.ToString("D"),
                DateFormat2 = date.ToString("f"),
                DateFormat3 = date.ToString("F"),
                DateFormat4 = date.ToString("O"),

                NumberFormat1 = number.ToString("N0"),
                NumberFormat2 = number.ToString("N1"),
                NumberFormat3 = number.ToString("N2"),
                NumberFormat4 = number.ToString("N3"),

                InchesFormat = inches.ToString(),
                CentimetersFormat = centimeters.ToString("N"),
                PoundsFormat = pounds.ToString(),
                KilogramsFormat = kilograms.ToString("N"),
                LitersFormat = liters.ToString(),
                OuncesFormat = ounces.ToString("N")
            };

            return View(viewModel);
        }
    }
}
