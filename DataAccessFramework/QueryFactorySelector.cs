using DataAccessFramework.Dao.Subjects;
using DataAccessFramework.Dao.Teachers;
using DataAccessFramework.Dao.Users;
using SqlFacade;
using System;

namespace DataAccessFramework
{
    public class QueryFactorySelector
    {
        public QueryFactorySelector(FacadeBuilder facadeBuilder)
        {
            var connectionFacade = facadeBuilder.GetFacade();
            UsersQueryFactory = new UsersQueryFactory();
            TeachersQueryFactory = new TeachersQueryFactory(new FakeTeachersQueries());
        }

        public UsersQueryFactory UsersQueryFactory { get; }
        public TeachersQueryFactory TeachersQueryFactory { get; }
    }
}
