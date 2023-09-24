namespace Domain.Repository
{
    using Domain.Models;
    using Common.Interfaces;

    public class RoomRepository<TEntity> : IEntityRepository<Room>
    {
        public void Add(Room entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Room entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Room entity)
        {
            throw new NotImplementedException();
        }

        Room IEntityRepository<Room>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
