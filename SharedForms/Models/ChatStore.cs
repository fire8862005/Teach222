﻿
using Common;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedForms
{
    public class ChatStore
    {
        public ChatType ChatType { get; set; }

        public string ChatUserName { get; set; }

        //   public string ChatDisplayName { get; set; }

        // public DateTime ChatStartTime { get; set; }

        //  public ClientRole UserType { get; set; }
        //    private IList<TeamMember> teamMembers;




        public IList<ChatMessage> MessageList { get; set; }


        public IList<ChatMessage> NewMessageList { get; set; }



        public smsPanel HistoryMessagePanel { get; set; } //暂时使用

        //public IList<TeamMember> TeamMembers
        //{
        //    get
        //    {
        //        if (teamMembers == null)
        //        {
        //            teamMembers = new List<TeamMember>();
        //        }
        //        return teamMembers;
        //    }

        //    set
        //    {
        //        teamMembers = value;
        //    }
        //}

        //public string GetUserNames()
        //{
        //    return string.Join(",", TeamMembers.Select(d => d.UserName));
        //}

        //public string[] GetUserNameList()
        //{
        //    return TeamMembers.Select(d => d.UserName).ToArray();
        //}

        //public bool CheckLoginUserNameIsInTeam()
        //{
        //    string loginUserName = GlobalVariable.LoginUserInfo.UserName;
        //    var list = TeamMembers;
        //    foreach (var item in list)
        //    {
        //        if (item.UserName.Equals(loginUserName))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}



    }



}
