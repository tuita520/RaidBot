//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18408
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RaidBot.Protocol.DataCenter
{
    using System.Collections.Generic;
    using RaidBot.Common.IO;
    using System;
    
    
    [Serializable()]
    public class AchievementObjective : IData
    {
        
        public virtual uint Id
        {
            get
            {
                return mId;
            }
            set
            {
                mId = value;
            }
        }
        
        private uint mId;
        
        public virtual uint AchievementId
        {
            get
            {
                return mAchievementId;
            }
            set
            {
                mAchievementId = value;
            }
        }
        
        private uint mAchievementId;
        
        public virtual uint NameId
        {
            get
            {
                return mNameId;
            }
            set
            {
                mNameId = value;
            }
        }
        
        private uint mNameId;
        
        public virtual string Criterion
        {
            get
            {
                return mCriterion;
            }
            set
            {
                mCriterion = value;
            }
        }
        
        private string mCriterion;
        
        public AchievementObjective()
        {
        }
    }
}
