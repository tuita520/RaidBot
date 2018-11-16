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
    public class Weapon : Item, IData
    {
        
        public virtual int ApCost
        {
            get
            {
                return mApCost;
            }
            set
            {
                mApCost = value;
            }
        }
        
        private int mApCost;
        
        public virtual int MinRange
        {
            get
            {
                return mMinRange;
            }
            set
            {
                mMinRange = value;
            }
        }
        
        private int mMinRange;
        
        public virtual int Range
        {
            get
            {
                return mRange;
            }
            set
            {
                mRange = value;
            }
        }
        
        private int mRange;
        
        public virtual uint MaxCastPerTurn
        {
            get
            {
                return mMaxCastPerTurn;
            }
            set
            {
                mMaxCastPerTurn = value;
            }
        }
        
        private uint mMaxCastPerTurn;
        
        public virtual bool CastInLine
        {
            get
            {
                return mCastInLine;
            }
            set
            {
                mCastInLine = value;
            }
        }
        
        private bool mCastInLine;
        
        public virtual bool CastInDiagonal
        {
            get
            {
                return mCastInDiagonal;
            }
            set
            {
                mCastInDiagonal = value;
            }
        }
        
        private bool mCastInDiagonal;
        
        public virtual bool CastTestLos
        {
            get
            {
                return mCastTestLos;
            }
            set
            {
                mCastTestLos = value;
            }
        }
        
        private bool mCastTestLos;
        
        public virtual int CriticalHitProbability
        {
            get
            {
                return mCriticalHitProbability;
            }
            set
            {
                mCriticalHitProbability = value;
            }
        }
        
        private int mCriticalHitProbability;
        
        public virtual int CriticalHitBonus
        {
            get
            {
                return mCriticalHitBonus;
            }
            set
            {
                mCriticalHitBonus = value;
            }
        }
        
        private int mCriticalHitBonus;
        
        public virtual int CriticalFailureProbability
        {
            get
            {
                return mCriticalFailureProbability;
            }
            set
            {
                mCriticalFailureProbability = value;
            }
        }
        
        private int mCriticalFailureProbability;
        
        public Weapon()
        {
        }
    }
}