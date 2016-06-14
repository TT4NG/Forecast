using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace weather
{
    class Weather
    {
        enum day { Sun, Mon, Tues, Wed, Thurs, Fri, Sat};
        enum weather { cloudy, sunny, rainy, muggy, foggy}
        public void Cast()
        {
            string[] days = Enum.GetNames(typeof(day));
            string[] weather = Enum.GetNames(typeof(weather));
            Random random = new Random();
            

            for (int i = 0; i<days.Length;i++)
            {
                int rand = random.Next(0, weather.Length);
                Console.WriteLine(days[i] + " - " + weather[rand]);
            }
        }
    }
}
