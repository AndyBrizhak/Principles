using System;

#region ? Проблема
//Использование статических методов часто сигнализирует о сильной связанности.
//В данном случае сильные связи протянулись от классов Customer и Store к классу IdHelper
#endregion

public static class IdHelper
{
    public static long CalculateId()
    {
        long id = DateTime.Now.Ticks;
        return id;
    }
}
