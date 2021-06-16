using LCA_Service.Service.Base;
using EF = LCA_Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using LCA_Model.Context;

namespace LCA_Service.Service.MembersProfilePictureService
{
    public class MembersProfilePictureService : BaseService<EF.MembersProfilePicture>, IMembersProfilePictureService
    {
        public MembersProfilePictureService(DataContext context) : base(context)
        {
        }
    }
}
