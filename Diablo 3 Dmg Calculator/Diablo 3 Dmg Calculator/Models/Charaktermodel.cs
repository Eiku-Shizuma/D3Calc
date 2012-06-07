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
    public class Charactermodel
    {
        private string _name;
        /// <summary>
        /// Gets or sets the character name
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; } 
        }

        private int _character;
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
            get { return _character; }
            set { if (value >= 0) { _character = value; } }
        }

        private int _lvl;
        /// <summary>
        /// Gets or sets the character Level
        /// </summary>
        public int Lvl
        {
            get { return _lvl; }
            set { if (value >= 0) { _lvl = value; } }
        }

        private int _str;
        /// <summary>
        /// Gets or sets the character Strengh
        /// </summary>
        public int Str
        {
            get { return _str; }
            set { if (value >= 0) { _str = value; } }
        }

        private int _dex;
        /// <summary>
        /// Gets or sets the character dexterity
        /// </summary>
        public int Dex
        {
            get { return _dex; }
            set { if (value >= 0) { _dex = value; } }
        }

        private int _inte;
        /// <summary>
        /// Gets or sets the character Intelligence
        /// </summary>
        public int Inte
        {
            get { return _inte; }
            set { if (value >= 0) { _inte = value; } }
        }

        private int _vit;
        /// <summary>
        /// Gets or sets the character Vitality
        /// </summary>
        public int Vit
        {
            get { return _vit; }
            set { if (value >= 0) { _vit = value; } }
        }

        private int _skill1;
        /// <summary>
        /// Gets or sets number of the first skill
        /// </summary>
        public int Skill1
        {
            get { return _skill1; }
            set { if (value >= 0) { _skill1 = value; } }
        }

        private int _skill2;
        /// <summary>
        /// Gets or sets number of the second skill
        /// </summary>
        public int Skill2
        {
            get { return _skill2; }
            set { if (value >= 0) { _skill2 = value; } }
        }

        private int _skill3;
        /// <summary>
        /// Gets or sets number of the third skill
        /// </summary>
        public int Skill3
        {
            get { return _skill3; }
            set { if (value >= 0) { _skill3 = value; } }
        }
    }
}
