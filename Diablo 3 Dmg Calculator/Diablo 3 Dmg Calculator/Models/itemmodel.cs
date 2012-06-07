// -----------------------------------------------------------------------
// <copyright file="item.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Diablo_3_Dmg_Calculator.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    /// <summary>
    /// A class for the item values.
    /// </summary>
    public class itemmodel
    {
        private bool _indestructible;

        public bool Indestructible
        {
            get { return _indestructible; }
            set { _indestructible = value; }
        }

        ///
        ///4 of each because of the possibility to socket gems into items. Max is 3 sockets on any item.
        ///

        private int _str1;
        public int Str1
        {
            get { return _str1; }
            set { _str1 = value; }
        }

        private int _str2;

        public int Str2
        {
            get { return _str2; }
            set { _str2 = value; }
        }
        private int _str3;

        public int Str3
        {
            get { return _str3; }
            set { _str3 = value; }
        }
        private int _str4;

        public int Str4
        {
            get { return _str4; }
            set { _str4 = value; }
        }

        private int _dex1;

        public int Dex1
        {
            get { return _dex1; }
            set { _dex1 = value; }
        }
        private int _dex2;

        public int Dex2
        {
            get { return _dex2; }
            set { _dex2 = value; }
        }
        private int _dex3;

        public int Dex3
        {
            get { return _dex3; }
            set { _dex3 = value; }
        }
        private int _dex4;

        public int Dex4
        {
            get { return _dex4; }
            set { _dex4 = value; }
        }

        private int _int1;

        public int Int1
        {
            get { return _int1; }
            set { _int1 = value; }
        }
        private int _int2;

        public int Int2
        {
            get { return _int2; }
            set { _int2 = value; }
        }
        private int _int3;

        public int Int3
        {
            get { return _int3; }
            set { _int3 = value; }
        }
        private int _int4;

        public int Int4
        {
            get { return _int4; }
            set { _int4 = value; }
        }

        private int _vit1;

        public int Vit1
        {
            get { return _vit1; }
            set { _vit1 = value; }
        }
        private int _vit2;

        public int Vit2
        {
            get { return _vit2; }
            set { _vit2 = value; }
        }
        private int _vit3;

        public int Vit3
        {
            get { return _vit3; }
            set { _vit3 = value; }
        }
        private int _vit4;

        public int Vit4
        {
            get { return _vit4; }
            set { _vit4 = value; }
        }

        private int _armor;

        public int Armor
        {
            get { return _armor; }
            set { _armor = value; }
        }
        private int _minDmg;

        public int MinDmg
        {
            get { return _minDmg; }
            set { _minDmg = value; }
        }
        private int _maxDmg;

        public int MaxDmg
        {
            get { return _maxDmg; }
            set { _maxDmg = value; }
        }
        private int _bonusExperience;

        public int BonusExperience
        {
            get { return _bonusExperience; }
            set { _bonusExperience = value; }
        }

        private double _chanceToBlind;

        public double ChanceToBlind
        {
            get { return _chanceToBlind; }
            set { _chanceToBlind = value; }
        }
        private double _chanceToFreeze;

        public double ChanceToFreeze
        {
            get { return _chanceToFreeze; }
            set { _chanceToFreeze = value; }
        }
        private double _chanceToImmobilize;

        public double ChanceToImmobilize
        {
            get { return _chanceToImmobilize; }
            set { _chanceToImmobilize = value; }
        }
        private double _chanceToKnockback;

        public double ChanceToKnockback
        {
            get { return _chanceToKnockback; }
            set { _chanceToKnockback = value; }
        }
        private double _chanceToSlow;

        public double ChanceToSlow
        {
            get { return _chanceToSlow; }
            set { _chanceToSlow = value; }
        }

        private double _attSpeed;

        public double AttSpeed
        {
            get { return _attSpeed; }
            set { _attSpeed = value; }
        }
        private double _critChance;

        public double CritChance
        {
            get { return _critChance; }
            set { _critChance = value; }
        }
        private double _critDmg;

        public double CritDmg
        {
            get { return _critDmg; }
            set { _critDmg = value; }
        }
        private double _blockAmount;

        public double BlockAmount
        {
            get { return _blockAmount; }
            set { _blockAmount = value; }
        }
        private double _blockChance;

        public double BlockChance
        {
            get { return _blockChance; }
            set { _blockChance = value; }
        }
        private double _dodgeChance;

        public double DodgeChance
        {
            get { return _dodgeChance; }
            set { _dodgeChance = value; }
        }
        private double _dmgReduction;

        public double DmgReduction
        {
            get { return _dmgReduction; }
            set { _dmgReduction = value; }
        }
        private double _pysicalResistance;

        public double PysicalResistance
        {
            get { return _pysicalResistance; }
            set { _pysicalResistance = value; }
        }
        private double _coldResistance;

        public double ColdResistance
        {
            get { return _coldResistance; }
            set { _coldResistance = value; }
        }
        private double _fireResistance;

        public double FireResistance
        {
            get { return _fireResistance; }
            set { _fireResistance = value; }
        }
        private double _lightningResistance;

        public double LightningResistance
        {
            get { return _lightningResistance; }
            set { _lightningResistance = value; }
        }
        private double _poisonResistance;

        public double PoisonResistance
        {
            get { return _poisonResistance; }
            set { _poisonResistance = value; }
        }
        private double _arcaneResistance;

        public double ArcaneResistance
        {
            get { return _arcaneResistance; }
            set { _arcaneResistance = value; }
        }
        private double _crowdCrontrolReduction;

        public double CrowdCrontrolReduction
        {
            get { return _crowdCrontrolReduction; }
            set { _crowdCrontrolReduction = value; }
        }
        private double _missileDmgReduction;

        public double MissileDmgReduction
        {
            get { return _missileDmgReduction; }
            set { _missileDmgReduction = value; }
        }
        private double _meeleDmgReduction;

        public double MeeleDmgReduction
        {
            get { return _meeleDmgReduction; }
            set { _meeleDmgReduction = value; }
        }
        private double _dmgReflect;

        public double DmgReflect
        {
            get { return _dmgReflect; }
            set { _dmgReflect = value; }
        }
        private double _movementSpeed;

        public double MovementSpeed
        {
            get { return _movementSpeed; }
            set { _movementSpeed = value; }
        }
        private double _goldFind;

        public double GoldFind
        {
            get { return _goldFind; }
            set { _goldFind = value; }
        }
        private double _magicFind;

        public double MagicFind
        {
            get { return _magicFind; }
            set { _magicFind = value; }
        }
        private double _bonusToLife;

        public double BonusToLife
        {
            get { return _bonusToLife; }
            set { _bonusToLife = value; }
        }
        private double _lifePerSecond;

        public double LifePerSecond
        {
            get { return _lifePerSecond; }
            set { _lifePerSecond = value; }
        }
        private double _lifeSteal;

        public double LifeSteal
        {
            get { return _lifeSteal; }
            set { _lifeSteal = value; }
        }
        private double _lifePerKill;

        public double LifePerKill
        {
            get { return _lifePerKill; }
            set { _lifePerKill = value; }
        }
        private double _livePerHit;

        public double LivePerHit
        {
            get { return _livePerHit; }
            set { _livePerHit = value; }
        }
        private double _healthGlobes;

        public double HealthGlobes
        {
            get { return _healthGlobes; }
            set { _healthGlobes = value; }
        }
        private double _pickUpRange;

        public double PickUpRange
        {
            get { return _pickUpRange; }
            set { _pickUpRange = value; }
        }
    }
}
