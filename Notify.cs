namespace LopLevelStatement;

public class WorkingDay
{
    
    
    public static string GetEndDateAfter7WorkingDays2Method(DateTime startDate)
    {
        DateTime endDate = startDate.AddDays(7);
        int daysToAdd = 0;
        while (startDate <= endDate)
        {
            if (startDate.DayOfWeek != DayOfWeek.Friday && startDate.DayOfWeek != DayOfWeek.Saturday)
            {
                daysToAdd++;
            }
            startDate = startDate.AddDays(1);
        }
        endDate = endDate.AddDays(daysToAdd);
        return endDate.ToShortDateString();
    }

    public static string GetEndDateAfter7WorkingDays(DateTime startDate)
    {
        DateTime endDate = startDate.AddDays(7);
        int daysToAdd = 0;
        int daysToInclude = 7;
        while (daysToInclude >0)
        {
            if (startDate.DayOfWeek != DayOfWeek.Friday && startDate.DayOfWeek != DayOfWeek.Saturday)
            {
               
                daysToInclude--;
               // if (daysToInclude < 1) break;
            }
            else
            {
                daysToAdd++;
            }
            startDate = startDate.AddDays(1);
        }
        endDate = endDate.AddDays(daysToAdd);
        return endDate.ToShortDateString();
    }

    public static string GetEndDateAfter15WorkingDays(DateTime startDate)
    {
        DateTime endDate = startDate.AddDays(15);
        int daysToAdd = 0;
        int daysToInclude = 15;
        while (daysToInclude >0)
        {
            if (startDate.DayOfWeek != DayOfWeek.Friday && startDate.DayOfWeek != DayOfWeek.Saturday)
            {
               
                daysToInclude--;
                // if (daysToInclude < 1) break;
            }
            else
            {
                daysToAdd++;
            }
            startDate = startDate.AddDays(1);
        }
        endDate = endDate.AddDays(daysToAdd);
        return endDate.ToShortDateString();
    }
    
    
    
    public static DateTime GetDateBefore3WorkingDays(DateTime startDate)
    {
        // Initialize variables
        int daysBefore = 3;
        int daysCount = 0;
        DateTime currentDate = startDate;

        // Loop backwards through days until we find the target date
        while (daysCount < daysBefore)
        {
            

            // Check if the current date is a working day
            if (currentDate.DayOfWeek != DayOfWeek.Friday && currentDate.DayOfWeek != DayOfWeek.Saturday)
            {
                // If it is a working day, increment the days count
                daysCount++;
            }
            
            // if (startDate.DayOfWeek != DayOfWeek.Friday && startDate.DayOfWeek != DayOfWeek.Saturday)
            // {
            //    
            //     daysToInclude--;
            //     // if (daysToInclude < 1) break;
            // }
            // else
            // {
            //     daysToAdd++;
            // }
            
            // Subtract one day from the current date
            currentDate = currentDate.AddDays(-1);
        }

        return currentDate;
    }

    
    public static string GetDateBefore3WorkingDays2M(DateTime startDate)
    {
        // Initialize variables
        int daysBefore = 4;
        int daysCount = 0;
        // DateTime currentDate = startDate;
        DateTime endDate = startDate.AddDays(-3);

        // Loop backwards through days until we find the target date
        while (daysBefore >0)
        {
            

            // // Check if the current date is a working day
            // if (currentDate.DayOfWeek != DayOfWeek.Friday && currentDate.DayOfWeek != DayOfWeek.Saturday)
            // {
            //     // If it is a working day, increment the days count
            //     daysCount++;
            // }
            //
            if (startDate.DayOfWeek != DayOfWeek.Friday && startDate.DayOfWeek != DayOfWeek.Saturday)
            {
               
                daysBefore--;
                // if (daysToInclude < 1) break;
            }
            else
            {
                daysCount++;
            }
            
            // Subtract one day from the current date
            startDate = startDate.AddDays(-1);
        }
        endDate = endDate.AddDays(-daysCount);

        return endDate.ToShortDateString();
    }


}
