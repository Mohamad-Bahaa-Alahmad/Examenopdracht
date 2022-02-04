using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShoppingWebsite.Areas.Identity.Data;
using ShoppingWebsite.Models;

namespace ShoppingWebsite.Data
{
    public class SeedDatabase
    {
        public static void Initialize(IServiceProvider serviceProvider, Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager)
        {
            using var context = new ApplicationContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationContext>>());
            {
                if (!context.Language.Any())
                {
                    context.Language.AddRange(
                        new Language() { Id = "-", Name = "-", Cultures = "-", IsSystemLanguage = false },
                        new Language() { Id = "de", Name = "Deutsch", Cultures = "DE", IsSystemLanguage = false },
                        new Language() { Id = "en", Name = "English", Cultures = "UK;US", IsSystemLanguage = true },
                        new Language() { Id = "es", Name = "Español", Cultures = "ES", IsSystemLanguage = false },
                        new Language() { Id = "fr", Name = "français", Cultures = "BE;FR", IsSystemLanguage = true },
                        new Language() { Id = "nl", Name = "Nederlands", Cultures = "BE;NL", IsSystemLanguage = true }
                    );
                    context.SaveChanges();
                }
                ApplicationUser user = null;

                if (!context.Users.Any())
                {
                    ApplicationUser dummy = new ApplicationUser { Id = "-", FirstName = "-", LastName = "-", UserName = "-", Email = "?@?.?", LanguageId = "-" };
                    context.Users.Add(dummy);
                    context.SaveChanges();
                    user = new ApplicationUser
                    {
                        
                        FirstName = "System",
                        LastName = "Administrator",
                        UserName = "Admin",
                        Email = "System.Administrator@GroupSpace.be",
                        LanguageId = "nl",
                        EmailConfirmed = true
                    };
                    userManager.CreateAsync(user, "Student+1");
                }
                if (!context.Roles.Any())
                {
                    context.Roles.AddRange(
                        new IdentityRole { Id = "User", Name = "User", NormalizedName = "User" },
                        new IdentityRole { Id = "Admin", Name = "Admin", NormalizedName = "Admin" });
                    context.SaveChanges();
                }
                if (!context.Product.Any())
                {
                    context.Product.AddRange(
                        new Product { Title = "Lenovo ThinkPad", Description = "Lenovo ThinkPad T560 I 15.6 display(1920x1080 Full HD) I Intel Core i5 6200U tot 280 GHz I 8 GB RAM I 240 GB SSD I HDMI I USB I Intel HD Graphics 520 I Windows 10 Pro(gereviseerd)", ImagePath = "download3.jpg", Price = 584.00 },
                        new Product { Title = "Laptop Notebook", Description = "Laptop 15,6 inch, TECLAST F15S Notebook, Intel Apollo Lake, 1920 × 1080 FHD IPS, 6GB RAM 128GB ROM Ultrabook, Windows 10, 38000mWh, 256GB TF-extensie, Mini-HDMI, Bluetooth, Dual-Band WiFi, 2x USB 3, 0", ImagePath = "download4.jpg", Price = 339.99 },
                        new Product { Title = "Gaming Laptop", Description = "Razer Blade 15 Gaming Laptop (2020): 15.6'' FHD-144Hz Basismodel, Intel Core i7-10750H 6-Core, NVIDIA GeForce GTX 1660 Ti, 16GB RAM, 512GB SSD, Chroma RGB Verlichting | QWERTY, US-Layout", ImagePath = "download5.jpg", Price = 1.799 },
                        new Product { Title = "Apple iPhone 12", Description = "6,1-inch Super Retina XDR-display Ceramic Shield.Sterker dan welk smartphone - glas ook Klaar voor 5G A14 Bionic - chip,de snelste chip ooit in een smartphone 12‑MP dual camera - systeem: ultragroothoek‑ en groothoek­camera’s; 2x optisch uitzoomen", ImagePath = "phone1.jpg", Price = 893.00 },
                        new Product { Title = "Apple iPhone 13 Pro", Description = "Een 6,1‑inch Super Retina XDR-display dat sneller en soepeler reageert dankzij ProMotion Filmmodus verkleint de scherptediepte en verlegt automatisch de focus in je video’s Pro - camerasysteem met nieuwe 12‑MP telelens -, groothoek - en ultragroothoek­camera; LiDAR - scanner; 6x optische zoom; macro - fotografie; Fotografische stijlen, ProRes-video, Slimme HDR 4, Nachtmodus, Apple ProRAW, 4K HDR-opnamen in Dolby Vision 12 - MP TrueDepth - camera aan de voorkant met Nachtmodus, 4K HDR-opnamen in Dolby Vision A15 Bionic-chip voor razendsnelle prestaties Tot 22 uur video afspelen", ImagePath = "phone3.jpg", Price = 1.599 },
                        new Product { Title = "Samsung Galaxy S21 Ultra ", Description = "Samsung Galaxy S21 Ultra 5G, Android smartphone without subscription, quad camera, Infinity-O display, 256GB memory, powerful battery, Phantom Black Your life in focus: With the Galaxy S21 Ultra 5G's four main cameras, you can take impressive photos. The 108 megapixel camera leaves no details undiscovered and 8K video provides you with the highest resolution on a Galaxy smartphone.", ImagePath = "phone2.jpg", Price = 1.250 },
                        new Product { Title = "Apple Watch", Description = "The Apple Watch magnetic charging dock lets you charge your Apple Watch while lying on its side, or loosen flat with the strap When your watch is on its side in the dock, it automatically switches to the night clock mode, so you can also use it as an alarm clock The Apple Watch magnetic charging dock uses the same inductive charging connector included with Apple Watch It is suitable for charging any model and any format of Apple Watch And with the Lightning to USB cable, you can connect the dock to the Apple USB 5W power adapter Compatibility: Apple Watch Series 6, Apple Watch Series 5, Apple Watch Series 4, Apple Watch Series 3, Apple Watch Series 2, Apple Watch Series 1, Apple Watch(1st Gen)", ImagePath = "applewatch1.jpg", Price = 200.00 },
                        new Product { Title = "Samsung Galaxy Watch", Description = "Samsung Galaxy Watch Active2 Fitness Tracker Aluminium Large Display Durable Battery Waterproof 44 mm Bluetooth Black The slim, lightweight and almost frameless design is available in many variants and fits any occasion With a huge selection of different bracelets1 and dials, a very personal look is possible The world's first digital bezel allows features to be called quickly and intuitively", ImagePath = "samsungwatch1.jpg", Price = 211.00 },
                        new Product { Title = "Samsung Galaxy Watch Active2", Description = "Samsung Galaxy Watch Active2 Stainless Steel Fitness Tracker Large Display Durable Battery Waterproof 40 mm Bluetooth Silver", ImagePath = "samsungwatch2.jpg", Price = 261.00 },
                        new Product { Title = "USB C", Description = "USB C to C video cable 2M, Cuxnoo 4K USB Type C monitor cable supports 100W fast charging and 10Gbps data synchronization", ImagePath = "cablec.jpg", Price = 19.99 },
                        new Product { Title = "iPhone cable", Description = "UGREEN USB C to Lightning Cable MFi Certified Nylon PD Charger Cable for iPhone 13/13 Mini/ 13 Pro/ 13 Pro Max/SE/ 12/12 Pro/ 11/ XR/XS MAX, etc.(1M, Black)", ImagePath = "applecable.jpg", Price = 15.99 },
                        new Product { Title = "iPhone cable", Description = "Anker Powerline+ II iPhone cable, 3m, Lightning cable, nylon, MFI certified with iPhone SE/XS/XS Max/XR/X, 8/8 Plus, 7/6s/6/iPad and more (black)", ImagePath = "applecableb.jpg", Price = 18.99 }) ;
                    context.SaveChanges();
                }

                List<string> supportedLanguages = new List<string>();
                Language.AllLanguages = context.Language.ToList();
                Language.LanguageDictionary = new Dictionary<string, Language>();
                Language.SystemLanguages = new List<Language>();

                supportedLanguages.Add("nl-BE");
                foreach (Language l in Language.AllLanguages)
                {
                    Language.LanguageDictionary[l.Id] = l;
                    if (l.Id != "-")
                    {
                        if (l.IsSystemLanguage)
                            Language.SystemLanguages.Add(l);
                        supportedLanguages.Add(l.Id);
                        string[] even = l.Cultures.Split(";");
                        foreach (string e in even)
                        {
                            supportedLanguages.Add(l.Id + "-" + e);
                        }
                    }
                }
                Language.SupportedLanguages = supportedLanguages.ToArray();
                if (user != null)
                {
                    context.UserRoles.AddRange(
                        new IdentityUserRole<string> { UserId = user.Id, RoleId = "User" },
                        new IdentityUserRole<string> { UserId = user.Id, RoleId = "Admin" });
                    context.SaveChanges();
                }
            }
        }
    }
}
