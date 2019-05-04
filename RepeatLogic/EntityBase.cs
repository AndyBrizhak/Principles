using System;

namespace RepeatLogic
{
    public abstract class EntityBase
    {
        public long Id { get; private set; }

        public EntityBase()
        {
            Id = CalculateId();
        }



    

        private long CalculateId()
        {
            //var id = DateTime.Now.Ticks;
            Random random = new Random();
            var id = random.Next();
            return id;
        }
    }
}
