using System;


namespace RepeatLogic
{
    //class Customer : EntityBase
    class Customer
    {
        private readonly IIdGenerator idGenerator;
        public long Id { get; private set; }

        //public long Id { get; set; }
        public string Description { get; set; }

        #region Customer()

        //public Customer()
        public Customer(IIdGenerator IdGenerator)
        {

            //Id = CalculateId();
            //Id = IdHelper.CalculateId();
            idGenerator = IdGenerator;
            Id = idGenerator.CalculateId();
        }

        #endregion

        #region CalculateId()

        //private long CalculateId()
        //{
        //    long id = DateTime.Now.Ticks;
        //    return id;
        //}

        #endregion
    }
}
