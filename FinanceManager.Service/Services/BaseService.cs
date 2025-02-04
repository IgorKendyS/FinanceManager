using AutoMapper;
using FluentValidation;
using FinanceManager.Domain.Base;

namespace FinanceManager.Service.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity>
        where TEntity : IBaseEntity
    {
        private readonly IBaseRepository<TEntity> _baseRepository;
        private readonly IMapper _mapper;

        public BaseService(IBaseRepository<TEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public void AttachObject(object obj)
        {
            _baseRepository.AttachObject(obj);
        }

        public TOutputModel Add<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TInputModel : class
            where TOutputModel : class
            where TValidator : AbstractValidator<TEntity>
        {
            var entity = _mapper.Map<TEntity>(inputModel);
            Validate(entity, Activator.CreateInstance<TValidator>());
            _baseRepository.Insert(entity);
            var outputModel = _mapper.Map<TOutputModel>(entity);
            return outputModel;
        }

        public void Delete(int id)
        {
             _baseRepository.Delete(id);
        }

        public IEnumerable<TOutputModel> Get<TOutputModel>(bool tracking = true, IList<string>? includes = null)
            where TOutputModel : class
        {
            var entities = _baseRepository.Select(tracking, includes);
            var outputModel = entities.Select(entity => _mapper.Map<TOutputModel>(entity));
            return outputModel;
        }

        public TOutputModel GetById<TOutputModel>(int id, bool tracking = true, IList<string>? includes = null)
            where TOutputModel : class
        {

            var entity = _baseRepository.Select(id, tracking, includes);
            var outputModel = _mapper.Map<TOutputModel>(entity);
            return outputModel;

        }

        public TOutputModel Update<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TInputModel : class
            where TOutputModel : class
            where TValidator : AbstractValidator<TEntity>
        {
            var entity = _mapper.Map<TEntity>(inputModel);
            Validate(entity, Activator.CreateInstance<TValidator>());
            _baseRepository.Update(entity);
            return _mapper.Map<TOutputModel>(entity);
        }

        private void Validate(TEntity obj, AbstractValidator<TEntity> validator)
        {
            if (obj == null)
            {
                throw new Exception("Objeto inválido!");
            }

            validator.ValidateAndThrow(obj);
        }
    }
}
