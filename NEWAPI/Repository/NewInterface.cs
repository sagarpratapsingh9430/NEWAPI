
using NEWAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace NEWAPI.Repository
{
    public interface NewInterface
    {
        List<ApiModel> Get();
        bool Create(ApiModel Mac);
        void Delete(int id);
        ApiModel Edit(int id);
    }

    public abstract class repo : NewInterface
    {
        public abstract bool Create(ApiModel Mac);

        public abstract void Delete(int id);

        public abstract ApiModel Edit(int id);

        public abstract List<ApiModel> Get();
    }

    public class IFisrtRepository : repo
    {

        private readonly Apicontext dbcontext;
        public IFisrtRepository(Apicontext _db)
        {
            dbcontext = _db;
        }

        public override List<ApiModel> Get()
        {
            return dbcontext.MVCDemo6.ToList();
        }


        public override bool Create(ApiModel Mac)
        {
            if (Mac == null)
            {
                return false;
            }
            else
            {
                if (Mac.Id == 0)
                {
                    dbcontext.MVCDemo6.Add(Mac);
                    dbcontext.SaveChanges();
                    return true;
                }
                else
                {
                    dbcontext.Entry(Mac).State = EntityState.Modified;
                    dbcontext.SaveChanges();
                    return true;
                }
            }

        }


        public override void Delete(int id)
        {

            var student = dbcontext.MVCDemo6.Find(id);


            dbcontext.MVCDemo6.Remove(student);
            dbcontext.SaveChangesAsync();
            return;
        }


        public override ApiModel Edit(int id)
        {
            return dbcontext.MVCDemo6.Find(id);
        }

    }
}