using System;


namespace RepeatLogic
{
    class Customer
    {
        public long Id { get; set; }
        public string Description { get; set; }

        #region Customer()

        public Customer()
        {
            Id = CalculateId();
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
}
