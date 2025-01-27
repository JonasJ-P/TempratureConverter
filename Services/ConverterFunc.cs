public class ConverterFunc
{
    public static double ConvertNumber(double number, string fromDegree, string toDegree)
    {
        double result = 0;
        if(fromDegree == toDegree)
        {
            result = number;
        }
        else if(fromDegree == "celcius" && toDegree == "fahrenheit")
        {
            result = (number * 9/5) + 32;
        }
        else if(fromDegree=="fahrenheit" && toDegree == "celcius")
        {
            result = (number - 32) * 5/9;
        }
        else if(fromDegree == "celcius" && toDegree == "kelvin")
        {
            result = number + 273.15;
        }
        else if(fromDegree == "fahrenheit" && toDegree == "kelvin")
        {
            result = ((number - 32) * 5/9) + 273.15;
        }
        else if(fromDegree == "kelvin" && toDegree == "celcius")
        {
            result = number - 273.15;
        }
        else if(fromDegree == "kelvin" && toDegree == "fahrenheit")
        {
            result = ((number-273.15)*9/5)+32;
        }
    return result;
    }
}