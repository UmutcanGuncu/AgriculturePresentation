using BusinnesLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class TeamManager : ITeamService
    {
        private readonly ITeamDal _teamDal;
        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public void Delete(Team item)
        {
            _teamDal.Delete(item);
        }

        public Team GetById(int id)
        {
            return _teamDal.GetById(id);
        }

        public List<Team> GetListAll()
        {
            return _teamDal.GetListAll();
        }

        public void Insert(Team item)
        {
            _teamDal.Insert(item);
        }

        public void Update(Team item)
        {
            _teamDal.Update(item);
        }
    }
}
