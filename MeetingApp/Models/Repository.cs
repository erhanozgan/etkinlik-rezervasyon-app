namespace MeetingApp.Models;

public static class Repository
{
     private static List<UserInfo> _userInfos = new();

     public static List<UserInfo> Users
     {
          get
          {
               return _userInfos;
          }
     }

     public static void CreateUser(UserInfo user)
     {
          user.id = _userInfos.Count() + 1;
          _userInfos.Add(user);
     }

     public static UserInfo GetById(int id)
     {
          return _userInfos.FirstOrDefault(user => user.id == id);
     }
}