using System;
using System.Linq;


namespace WebApiServer.Models
{
    public class User
    {
        //TODO:implementation here
        public Int64 Id { get;private set; }
        public string Login { get; set; }
        public string Password { get; set; }
        private static readonly AppHarborDB Db=new AppHarborDB();
        public User()
        {
            
        }
        public void Create()
        {
            if(Db.Client.Any(p=>p.login==Login))
                throw new InvalidOperationException("Login is already in use");
            Db.Client.Add(new Client(this));
            Db.SaveChanges();
            Id=Db.Client.First(p => p.login == Login).id;
        }
        protected User(UserLogInData user,Int64 id)
        {
            Id = id;
            Login = user.Login;
            Password = user.Password;
        }
        public static User login (UserLogInData user)
        {
            var request= Db.Client.Where(p => p.login == user.Login && p.password == user.Password);
            if(!request.Any())
                throw new ArgumentException("Incorrect login/password","user"); 
            return new User(user,request.First().id);

        }
        public void ApplyChanges()
        {
            if(Id==0)
                throw new InvalidOperationException("User not registered yet");
            var user=Db.Client.Find(Id);
            user.login = Login;
            user.password = Password;
            Db.SaveChanges();
        }
        public static string GetUserName(Int64 id)
        {
            var user = Db.Client.Find(id);
            if(user==null)
                throw new ArgumentException("Bad id","id");
            return user.login;
        }
        public void LogOut()
        {
            
        }
    }
}