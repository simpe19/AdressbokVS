
using AdressbokVS.Services;

var menu = new MenuService();
menu.FilePath =$@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\console.json";

menu.WelcomeMenu();