using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DearSanta.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Gifts.Any())
            {
                context.AddRange
                (
                    new Gift { Name = "Socks", Price = 10, ShortDesc = "You'll love it!", LongDesc = "Lego is a line of plastic construction toys that are manufactured by The Lego Group, a privately held company based in Billund, Denmark. The company's flagship product, Lego, consists of colourful interlocking plastic bricks accompanying an array of gears, figurines called minifigures, and various other parts.", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", ThumbnailUrl = "https://i2.wp.com/www.infiniteenergy.com/wp-content/uploads/2016/12/Christmas-gift-blog.jpg" },
                    new Gift { Name = "Socks", Price = 10, ShortDesc = "You'll love it!", LongDesc = "Lego is a line of plastic construction toys that are manufactured by The Lego Group, a privately held company based in Billund, Denmark. The company's flagship product, Lego, consists of colourful interlocking plastic bricks accompanying an array of gears, figurines called minifigures, and various other parts.", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", ThumbnailUrl = "https://i2.wp.com/www.infiniteenergy.com/wp-content/uploads/2016/12/Christmas-gift-blog.jpg" },
                    new Gift { Name = "Socks", Price = 10, ShortDesc = "You'll love it!", LongDesc = "Lego is a line of plastic construction toys that are manufactured by The Lego Group, a privately held company based in Billund, Denmark. The company's flagship product, Lego, consists of colourful interlocking plastic bricks accompanying an array of gears, figurines called minifigures, and various other parts.", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", ThumbnailUrl = "https://i2.wp.com/www.infiniteenergy.com/wp-content/uploads/2016/12/Christmas-gift-blog.jpg" },
                    new Gift { Name = "Socks", Price = 10, ShortDesc = "You'll love it!", LongDesc = "Lego is a line of plastic construction toys that are manufactured by The Lego Group, a privately held company based in Billund, Denmark. The company's flagship product, Lego, consists of colourful interlocking plastic bricks accompanying an array of gears, figurines called minifigures, and various other parts.", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", ThumbnailUrl = "https://i2.wp.com/www.infiniteenergy.com/wp-content/uploads/2016/12/Christmas-gift-blog.jpg" },
                    new Gift { Name = "Socks", Price = 10, ShortDesc = "You'll love it!", LongDesc = "Lego is a line of plastic construction toys that are manufactured by The Lego Group, a privately held company based in Billund, Denmark. The company's flagship product, Lego, consists of colourful interlocking plastic bricks accompanying an array of gears, figurines called minifigures, and various other parts.", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", ThumbnailUrl = "https://i2.wp.com/www.infiniteenergy.com/wp-content/uploads/2016/12/Christmas-gift-blog.jpg" },
                    new Gift { Name = "Socks", Price = 10, ShortDesc = "You'll love it!", LongDesc = "Lego is a line of plastic construction toys that are manufactured by The Lego Group, a privately held company based in Billund, Denmark. The company's flagship product, Lego, consists of colourful interlocking plastic bricks accompanying an array of gears, figurines called minifigures, and various other parts.", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", ThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg" }
                );

                context.SaveChanges(); 
            }       
        }
    }
}
