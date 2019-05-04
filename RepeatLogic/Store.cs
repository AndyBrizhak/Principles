using System;

public class Store
{
    public long Id { get; set; }

    #region Store()

    public Store()
    {
        //Id = CalculateId();
        Id = IdHelper.CalculateId();
    }

    #endregion

    #region CalculateId()

    private long CalculateId()
    {
        long id = DateTime.Now.Ticks;
        return id;
    }

    #endregion
}