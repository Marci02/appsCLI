using appsCLI;
using System.Text;

List<App> apps = App.LoadFromCsv("apps.csv");

Console.WriteLine("6. feladat - Kiírás");
int i = 1;
foreach (App app in apps)
{
    Console.WriteLine($"{i++}. {app.ToString()}");
}

Console.WriteLine("7. feladat - Válogatás");
var year = apps.Max(x => x.updateYear);
var month = apps.Where(y => y.updateYear == year).Max(x => x.updateMonth);

var f7 = apps.Where(x => x.ContentRating.ContentRatingName == "Everyone" && x.Category.CategoryName == "PHOTOGRAPHY" && x.updateYear == year && x.updateMonth == month);

Console.WriteLine($"Frissítve: {year}.{month}");
foreach (App app in f7)
{
    Console.WriteLine(app.ToString());
}

using(StreamWriter sw = new StreamWriter(@"..\..\..\src\bests.txt", false, Encoding.UTF8))
{
    foreach (App app in apps.OrderByDescending(x => x.rating))
    {
        sw.WriteLine($"{(app.rating > 0 ? app.rating : "NO RESULT")}\t {app.appName}-{app.currentVer}");
    }
}

Console.WriteLine("8. feladat - Adatok fájlba írása");