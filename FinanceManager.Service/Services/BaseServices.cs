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
            try
            {
                _baseRepository.AttachObject(obj);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao anexar o objeto: {ex.Message}", ex);
            }
        }

        public TOutputModel Add<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TInputModel : class
            where TOutputModel : class
            where TValidator : AbstractValidator<TEntity>
        {
            try
            {
                var entity = _mapper.Map<TEntity>(inputModel);
                Validate(entity, Activator.CreateInstance<TValidator>());
                _baseRepository.Insert(entity);
                return _mapper.Map<TOutputModel>(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao adicionar a entidade: {ex.Message}", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _baseRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir a entidade com ID {id}: {ex.Message}", ex);
            }
        }

        public IEnumerable<TOutputModel> Get<TOutputModel>(bool tracking = true, IList<string>? includes = null)
            where TOutputModel : class
        {
            try
            {
                var entities = _baseRepository.Select(tracking, includes);
                return entities.Select(entity => _mapper.Map<TOutputModel>(entity));
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter as entidades: {ex.Message}", ex);
            }
        }

        public TOutputModel GetById<TOutputModel>(int id, bool tracking = true, IList<string>? includes = null)
            where TOutputModel : class
        {
            try
            {
                var entity = _baseRepository.Select(id, tracking, includes);
                return _mapper.Map<TOutputModel>(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter a entidade com ID {id}: {ex.Message}", ex);
            }
        }

        public TOutputModel Update<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TInputModel : class
            where TOutputModel : class
            where TValidator : AbstractValidator<TEntity>
        {
            try
            {
                var entity = _mapper.Map<TEntity>(inputModel);
                Validate(entity, Activator.CreateInstance<TValidator>());
                _baseRepository.Update(entity);
                return _mapper.Map<TOutputModel>(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar a entidade: {ex.Message}", ex);
            }
        }

        private void Validate(TEntity entity, AbstractValidator<TEntity> validator)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "A entidade não pode ser nula.");
            }

            validator.ValidateAndThrow(entity);
        }
    }
}
