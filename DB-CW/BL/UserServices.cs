using Models;
using DA;
using Error;
using System.Collections.Generic;

namespace BL
{
    public class UserServices
    {
        private UserDA userDA;
        public UserDA UserDA { get => userDA; set => userDA = value; }
        public UserServices(UserDA userDA)
        {
            this.UserDA = userDA;
        }
        public int login(string username, string pass_word)
        {
            #nullable enable
            User? user = this.UserDA.login(username, pass_word);
            #nullable disable
            if (user == null || user.Username != username || user.Pass_word != pass_word)
                throw new WrongLoginException();
            else
                return user.Id;
        }
        public string getRoleFromId(int id)
        {
            if (id < 1)
                throw new UserNotFoundException();
            string role = this.UserDA.getRoleFromId(id);
            if (role == string.Empty)
                throw new WrongLoginException();
            return role;
        }
        public List<User> getAllUser(string role)
        {
            return userDA.getAllUser(role);
        }
        public List<User> FindUser(string role, string str)
        {
            List<User> users = userDA.getAllUser(role);
            List<User> result = new List<User>();
            foreach (User user in users)
                if (user.Name.Contains(str) || user.Username.Contains(str))
                    result.Add(user);
            return result;
        }
        public void addUser(string name, string username, string role)
        {
            if (userDA.existsUser(username))
                throw new UserExistsException();
            userDA.addUser(name, username, role);
        }
        public int getIdFromUsername(string username)
        {
            if (!userDA.existsUser(username))
                throw new UserNotFoundException();
            return userDA.getIdFromUsername(username);
        }
        public void updateUser(int id, string name, string username)
        {
            if (id < 1)
                throw new UserNotFoundException();
            userDA.updateUser(id, name, username);
        }
        public void deleteUser(int id)
        {
            if(id < 1)
                throw new UserNotFoundException();
            userDA.deleteUser(id);
        }
        public void changePW(int id, string password = "Abcd@123")
        {
            if(id < 1)
                throw new UserNotFoundException();
            userDA.changePW(id, password);
        }
        public string getPasswordFromId(int id)
        {
            if(id < 0)
                throw new UserNotFoundException();
            return userDA.getPasswordFromId(id);
        }
    }
}
