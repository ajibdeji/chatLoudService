using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ChatLoudService.Model;

namespace ChatLoudService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private ChatLoud context = new ChatLoud();

        public void ConnectUser(OnlineUser online)
        {
            try
            {
                context.OnlineUsers.Add(online);
                context.SaveChanges();
            }
            catch(FaultException ex)
            {
                ServiceFault df = new ServiceFault();
                df.Error = ex.Message;
                df.Details = "An Error Occured in Establishing a Connection";
                throw new FaultException<ServiceFault>(df);
            }
            
        }

        public void DisconnectUser(string id)
        {
            try
            {
                var onlineUser = context.OnlineUsers.Where(x => x.Id == id).FirstOrDefault();
                if (onlineUser != null)
                {
                    context.OnlineUsers.Remove(onlineUser);
                    context.SaveChanges();
                }
            }

            catch (FaultException ex)
            {
                ServiceFault df = new ServiceFault();
                df.Error = ex.Message;
                df.Details = "An Error Occured in Establishing a Connection";
                throw new FaultException<ServiceFault>(df);
            }
        }

        public IEnumerable<Channel> GetChannels()
        {
            var channels= context.Channels.ToList();
            var channelList = (from channel in channels
                               select channel
                             );
            var channelCount = channelList.Count();
            return channelList;
        }

        public IEnumerable<OnlineUserModel> GetOnlineUsers()
        {
            var onlineUserModels = new List<OnlineUserModel>();
            try
            {
               var onlineUsers= context.OnlineUsers.ToList();
                onlineUserModels = (from e in onlineUsers
                                    select new OnlineUserModel
                                    {
                                      Id= e.Id,
                                      ConnId=e.ConnId
                                    }).ToList();
            }catch(FaultException ex)
            {
                ServiceFault df = new ServiceFault();
                df.Error = ex.Message;
                df.Details = "An Error Occured in Getting the users"+ex.InnerException.Message;
                throw new FaultException<ServiceFault>(df);
            }
            return onlineUserModels;
        }

        public IEnumerable<UserProfile> GetSearchedUsers(string userName)
        {
            var usersList = context.AspNetUsers.Where(x => x.UserName.Contains(userName) );
            var userProfiles = (from user in usersList
                                select new UserProfile
                                {
                                    Id=user.Id,
                                    UserName=user.UserName
                                }
                                    );
            return userProfiles.ToList();
        }

        public UserProfile GetUserProfile(string id)
        {
            if (id == null)
            {
                return null;
            }
            var user = context.AspNetUsers.Where(x => x.Id==id).FirstOrDefault();
            var userProfile = new UserProfile()
            {
                Id=user.Id,
                UserName=user.UserName
            };
            return userProfile;
        }

        public UserProfile GetUserProfileByUserName(string userName)
        {
            if(userName == null)
            {
                return null;
            }
            var user = context.AspNetUsers.Where(x => x.UserName == userName).FirstOrDefault();
            var userProfile = new UserProfile()
            {
                Id = user.Id,
                UserName = user.UserName
            };
            return userProfile;
        }

        public IEnumerable<UserProfile> GetUsers()
        {
            var usersList = new List<AspNetUser>();
            var userProfiles = new List<UserProfile>();

            try
            {
                usersList = context.AspNetUsers.ToList();
                userProfiles = (from user in usersList
                                select new UserProfile
                                {
                                    Id = user.Id,
                                    UserName = user.UserName
                                }
                                        ).ToList();
            }
            catch(FaultException ex)
            {
                ServiceFault df = new ServiceFault();
                df.Error = ex.Message;
                df.Details = "An Error Occured in Getting the users" + ex.InnerException.Message;
                throw new FaultException<ServiceFault>(df);
            }
            
            return userProfiles;
        }
    }
}
