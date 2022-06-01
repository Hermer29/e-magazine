using DataAccessFramework.Dao.Teachers;

namespace EMagazine.Pages
{
    public class DataView
    {
        private dynamic _dao;

        public DataView(dynamic dao)
        {
            _dao = dao;

            switch(dao)
            {
                case TeacherDao teacher:
                    HeadersAmount = 2;
                    break;
            }
        }

        public int HeadersAmount { get; }

        public string this[int index]
        {
            get
            {
                switch(index)
                {
                    case 0:
                        return IdField.ToString();
                    case 1:
                        return SecondField;
                }
                return "unexpected";
            }
        }

        public int IdField
        {
            get
            {
                switch (_dao)
                {
                    case TeacherDao teacher:
                        return teacher.Id;
                    default:
                        return 666;
                }
            }
        }

        public string SecondField
        {
            get
            {
                switch (_dao)
                {
                    case TeacherDao teacher:
                        return teacher.Name;
                    default:
                        return "Unexpected dao";
                }
            }

            set
            {
                switch (_dao)
                {
                    case TeacherDao teacher:
                        teacher.Name = value;
                        break;
                }
            }
        }
    }
}
