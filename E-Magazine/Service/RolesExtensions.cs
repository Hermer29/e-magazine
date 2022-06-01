using EMagazine.UserData;
using System;

namespace EMagazine.Utility
{
    public static class RolesExtensions
    {
        public static string GetCorrespondingUri(this Role role)
        {
            switch(role)
            {
                case Role.Teacher:
                    return "/Magazine";
                case Role.Administer:
                    return "/Console";
                case Role.Student:
                    return "/Journal";
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
