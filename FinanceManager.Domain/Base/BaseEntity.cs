namespace FinanceManager.Domain.Base
{
    //uma classe abstrata não pode ser instanciada (criar outro objeto a partir dela [new "className])
    public abstract class BaseEntity<TID> : IBaseEntity
    {
        protected BaseEntity() { }

        protected BaseEntity(TID id)
        { //não obrigatório
            Id = id;
        }
        public TID? Id { get; set; }
    }
}