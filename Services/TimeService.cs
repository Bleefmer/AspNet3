namespace LAB_3.Services
{
    public class TimeService
    {
        public string GetCurrentTimeOfDay()
        {
            var currentHour = DateTime.Now.Hour;

            if (currentHour >= 12 && currentHour < 18)
                return "Now afternoon";
            else if (currentHour >= 18 && currentHour < 24)
                return "Now eveninng";
            else if (currentHour >= 0 && currentHour < 6)
                return "Now night";
            else
                return "Now morning";
        }
    }

}
