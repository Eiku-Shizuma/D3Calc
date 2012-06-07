// -----------------------------------------------------------------------
// <copyright file="Model.cs" company="Microsoft">
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
    /// A class for the character values.
    /// </summary>
    public class Model
    {
        private string name;
        /// <summary>
        /// Gets or sets the character name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; } 
        }

        private int character;
        /// <summary>
        /// Gets or sets the character value
        /// Barbarian = 1
        /// Monk = 2
        /// Demon Hunter = 3
        /// Wizard = 4
        /// Witch Doctor = 5
        /// </summary>
        public int Character 
        {
            get { return character; }
            set { if (value >= 0) { character = value; } }
        }

        private int lvl;
        /// <summary>
        /// Gets or sets the character Level
        /// </summary>
        public int Lvl
        {
            get { return lvl; }
            set { if (value >= 0) { lvl = value; } }
        }

        private int str;
        /// <summary>
        /// Gets or sets the character Strengh
        /// </summary>
        public int Str
        {
            get { return str; }
            set { if (value >= 0) { str = value; } }
        }

        private int dex;
        /// <summary>
        /// Gets or sets the character dexterity
        /// </summary>
        public int Dex
        {
            get { return dex; }
            set { if (value >= 0) { dex = value; } }
        }

        private int inte;
        /// <summary>
        /// Gets or sets the character Intelligence
        /// </summary>
        public int Inte
        {
            get { return inte; }
            set { if (value >= 0) { inte = value; } }
        }

        private int vit;
        /// <summary>
        /// Gets or sets the character Vitality
        /// </summary>
        public int Vit
        {
            get { return vit; }
            set { if (value >= 0) { vit = value; } }
        }

        private int skill1;
        /// <summary>
        /// Gets or sets number of the first skill
        /// </summary>
        public int Skill1
        {
            get { return skill1; }
            set { if (value >= 0) { skill1 = value; } }
        }

        private int skill2;
        /// <summary>
        /// Gets or sets number of the second skill
        /// </summary>
        public int Skill2
        {
            get { return skill2; }
            set { if (value >= 0) { skill2 = value; } }
        }

        private int skill3;
        /// <summary>
        /// Gets or sets number of the third skill
        /// </summary>
        public int Skill3
        {
            get { return skill3; }
            set { if (value >= 0) { skill3 = value; } }
        }
    }

    /// <summary>
    /// A class for the item values.
    /// </summary>
    public class item
    {
        private bool indestructible;

        ///
        ///4 of each because of the possibility to socket gems into items. Max is 3 sockets on any item.
        ///

        private int str1;
        private int str2;
        private int str3;
        private int str4;

        private int dex1;
        private int dex2;
        private int dex3;
        private int dex4;

        private int int1;
        private int int2;
        private int int3;
        private int int4;  
   
        private int vit1;
        private int vit2;
        private int vit3;
        private int vit4;

        private int armor;
        private int minDmg;
        private int maxDmg;
        private int bonusExperience;

        private double chanceToBlind;
        private double chanceToFreeze;
        private double chanceToImmobilize;
        private double chanceToKnockback;
        private double chanceToSlow;

        private double attspeed;
        private double critchrance;
        private double critdmg;
        private double blockAmount;
        private double blockChance;
        private double dodgeChance;
        private double dmgReduction;
        private double pysicalResistance;
        private double coldResistance;
        private double fireResistance;
        private double lightningResistance;
        private double poisonResistance;
        private double arcanResistance;
        private double crowdCrontrolReduction;
        private double missileDmgReduction;
        private double meeleDmgReduction;
        private double dmgReflect;
        private double movementSpeed;
        private double goldFind;
        private double magicFind;
        private double bonusToLife;
        private double livePerSecond;
        private double liveSteal;
        private double livePerKill;
        private double livePerHit;
        private double healthGlobes;
        private double pickUpRange;   
    }
}
