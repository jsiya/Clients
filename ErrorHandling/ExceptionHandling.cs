using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace Clients.ErrorHandling;

public static class ExceptionHandling
{
    public static bool ForName(ref string name)
    {
        try
        {
            string pattern = @"^[A-Z][a-z]*$";
            Regex rg = new Regex(pattern);
            if (!rg.IsMatch(name)) throw new Exception("Name must start with uppercase!");
        }
        catch (Exception ex)
        {

        }
        return true;
    }

    public static bool ForSurname(ref string surname)
    {
        try
        {
            string pattern = @"^[A-Z][a-z]*$";
            Regex rg = new Regex(pattern);
            if (!rg.IsMatch(surname)) throw new Exception("Surname must start with uppercase!");
        }
        catch (Exception ex)
        {
           
        }
        return true;
    }

    public static bool ForPassword(string password)
    {
        try
        {
            //en az 8 simvol, en az bir kicik herf, boyuk herf, reqem ve simvol olmalidir!
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$";
            Regex rg = new Regex(pattern);
            if (!rg.IsMatch(password))
                throw new Exception("Password must contain at least eight characters, including at least one number and includes both lower and uppercase letters and special characters!");
        }
        catch (Exception ex)
        {
            
        }
        return true;
    }
    
    public static bool ForPhone(ref string phone)
    {
        try
        {
            //0501234567
            //+994501234567
            //0991234567
            //994991234567 formalarinda yazila biler
            string azPhonePattern = @"^(?:\+994|994|0)[1-9][0-9]{8}$";
            Regex rg = new Regex(azPhonePattern);
            if (!rg.IsMatch(phone))
                throw new Exception("Invalid phone number!");
        }
        catch (Exception ex)
        {
            
        }
        return true;
    }
    public static bool ForCity(ref string city)
    {
        try
        {
            string pattern = @"^[a-zA-Z\u00C0-\u017F\s-]+$";
            Regex rg = new Regex(pattern);
            if (!rg.IsMatch(city))
                throw new Exception("Invalid City name!");
        }
        catch (Exception ex)
        {

        }
        return true;
    }
    public static bool ForAge(ref string age)
    {
        try
        {
            int age_;
            string pattern = @"^(0?[1-9]|[1-9][0-9])$";
            Regex rg = new Regex(pattern);
            if (!rg.IsMatch(age)) throw new Exception("Invalid age format!");
            age_ = Int32.Parse(age);
            if (age_ < 18 || age_ > 130) throw new Exception("Age must be greater than 18 and smaller than 130!");
        }
        catch (Exception ex)
        {
            
        }
        return true;
    }
}
