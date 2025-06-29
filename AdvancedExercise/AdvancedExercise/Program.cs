using AdvancedExercise;

//ex1
/*

MyCoolCalc calc = new MyCoolCalc(1234);

int result = calc.Divide(1, 1);

System.Console.WriteLine(result);

ex2
השורה הראשונה בשגיאה מייצגת את סוג השגיאה
MyCoolCalcException היה כתוב בתרגיל שהסוג שגיאה צריך להיות מסוג 
אז זה שגיאה מהסוג הזה
ואז אחר כך כתוב מאיםה הגיעה השגיאה - מפונקצית divide שנמצאת במחלקה myCoolCalc
ואז מאיזה שורה בmainהיא הגיעה 
*/
MyCoolCalc calc = new MyCoolCalc(123456);

try
{
    int result = calc.Divide(5, 5);
    Console.WriteLine(result);
}
catch (MyCoolCalcException ex)
{
    Console.WriteLine(ex._userMessage);
    System.Console.WriteLine("eroor in numbers-");
    foreach (int number in ex.GetCoolCalcNumbers())
    {
        Console.WriteLine(number);
    }
    Console.WriteLine(ex);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}