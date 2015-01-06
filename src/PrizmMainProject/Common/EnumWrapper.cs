﻿using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Common
{
    /// <summary>
    /// Generic wrapper for Enum type which use embedded resources 
    /// </summary>
    /// <typeparam name="TEnum"> Enum type </typeparam>
    public class EnumWrapper<TEnum>
    {
        /// <summary>
        /// The Enum value, which will be wrapped
        /// </summary>
        public TEnum Value { get; set; }
        /// <summary>
        /// The nativ name of Enum value
        /// </summary>
        public string Name
        {
            get
            {
                if (Value == null)
                {
                    return string.Empty;
                }
                return Enum.GetName(typeof(TEnum), Value);
            }
            set
            {
                if (value != Name)
                {
                    Value = (TEnum)Enum.Parse(typeof(TEnum), value);
                }
            }
        }

        /// <summary>
        /// the translated value  of Enum, which is displayed in the control
        /// </summary>
        public string Text
        {
            get
            {
                string result = Resources.ResourceManager.GetString(typeof(TEnum).Name + "_" + Name);
                result = String.IsNullOrEmpty(result) ? Resources.ResourceManager.GetString(Name) : result;
                return result;
            }
        }

        /// <summary>
        /// overridden for comboBox displaying
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Text;
        }
    }
}
