using Model;
using Service;


static void Main(string[] args)
{
    MainAsync(args).GetAwaiter().GetResult();
}
static async Task MainAsync(string[] args)
{
    Console.WriteLine(4444);
    ApiService apiService = new ApiService();
    CountriesList countrieslist = await apiService.GetAllCountries();
    Console.WriteLine(countrieslist.Count);
    int id = countrieslist.Last().Id;
    await apiService.DeleteCountry(id);
    countrieslist = await apiService.GetAllCountries();
    Console.WriteLine(countrieslist.Count);
    Countries country = new Countries() { CountryName = "TestCountry" };
    await apiService.InsertCountry(country);
    Countries MyCountry = countrieslist.First();
    MyCountry.CountryName = "UpdatedCountryName";
    await apiService.UpdateCountry(MyCountry);
    Console.WriteLine();






    ContinentsList continentslist = await apiService.GetAllContinents();
    Console.WriteLine(continentslist.Count);
    int id2 = continentslist.Last().Id;
    await apiService.DeleteCountry(id2);
    continentslist = await apiService.GetAllContinents();
    Console.WriteLine(continentslist.Count);
    Continents Continent = new Continents() { ContinentName = "TestContinent" };
    await apiService.InsertContinent(Continent);
    Continents MyContinent = continentslist.First();
    MyContinent.ContinentName = "UpdatedContinentName";
    await apiService.UpdateContinent(MyContinent);
    Console.WriteLine();





    LanguagesList languageslist = await apiService.GetAllLanguages();
    Console.WriteLine(languageslist.Count);
    int id3 = languageslist.Last().Id;
    await apiService.DeleteLanguage(id3);
    languageslist = await apiService.GetAllLanguages();
    Console.WriteLine(languageslist.Count);
    Languages Language = new Languages() { LanguageName = "TestLanguage" };
    await apiService.InsertLanguage(Language);
    Languages MyLanguage = languageslist.First();
    MyLanguage.LanguageName = "UpdatedLanguageName";
    await apiService.UpdateLanguage(MyLanguage);
    Console.WriteLine();




    WeatherList weatherlist = await apiService.GetAllWeather();
    Console.WriteLine(weatherlist.Count);
    int id4 = weatherlist.Last().Id;
    await apiService.DeleteWeather(id4);
    weatherlist = await apiService.GetAllWeather();
    Console.WriteLine(countrieslist.Count);
    Weather weather = new Weather() { WeatherName = "TestWeather" };
    await apiService.InsertWeather(weather);
    Weather MyWeather = weatherlist.First();
    MyWeather.WeatherName = "UpdatedWeatherName";
    await apiService.UpdateWeather(MyWeather);
    Console.WriteLine();





    UserDetailsList userDetailslist = await apiService.GetAllUserDetails();
    Console.WriteLine(userDetailslist.Count);
    int id5 = userDetailslist.Last().Id;
    await apiService.DeleteUserDetails(id);
    userDetailslist = await apiService.GetAllUserDetails();
    Console.WriteLine(userDetailslist.Count);
    UserDetails UserDetail = new UserDetails() { UserName = "TestUserDetails" };
    await apiService.InsertUserDetails(UserDetail);
    UserDetails MyUserDetails = userDetailslist.First();
    MyUserDetails.UserName = "UpdatedUserName";
    await apiService.UpdateUserDetails(MyUserDetails);
    Console.WriteLine();





    CategoryList categorylist = await apiService.GetAllCategory();
    Console.WriteLine(categorylist.Count);
    int id6 = categorylist.Last().Id;
    await apiService.DeleteCategory(id6);
    categorylist = await apiService.GetAllCategory();
    Console.WriteLine(categorylist.Count);
    Category category = new Category() { CategoryName = "TestCategory" };
    await apiService.InsertCategory(category);
    Category MyCategory = categorylist.First();
    MyCategory.CategoryName = "UpdatedCategoryName";
    await apiService.UpdateCategory(MyCategory);
    Console.WriteLine();





    AttractionsList attractionslist = await apiService.GetAllAttractions();
    Console.WriteLine(attractionslist.Count);
    int id7 = attractionslist.Last().Id;
    await apiService.DeleteAttraction(id7);
    attractionslist = await apiService.GetAllAttractions();
    Console.WriteLine(attractionslist.Count);
    Attractions Attraction = new Attractions() { AttractionName = "TestAttraction" };
    await apiService.InsertAttraction(Attraction);
    Attractions MyAttraction = attractionslist.First();
    MyAttraction.AttractionName = "UpdatedAttractionName";
    await apiService.UpdateAttraction(MyAttraction);
    Console.WriteLine();

}