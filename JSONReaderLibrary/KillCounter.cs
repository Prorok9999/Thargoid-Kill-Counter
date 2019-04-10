﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKC
{
    /// <summary>
    /// Handles kill counting
    /// </summary>
    public class KillCounter
    {
        /// <summary>
        /// last total before call of method CheckKillChange
        /// </summary>
        private int lastAllTypesKills;

        internal int scout;
        internal int cyclops;
        internal int basillisk;
        internal int medusa;
        internal int hydra;
        /// <summary>
        /// Variable which saves number of unknown thargoid type kills
        /// </summary>
        internal int unknown;
        /// <summary>
        /// total of all kills
        /// </summary>
        internal int allTypesKills;

        /// <summary>
        /// Method which resets all thargoid kills
        /// </summary>
        internal void ResetThargoidKills()
        {
            scout = 0;
            cyclops = 0;
            basillisk = 0;
            medusa = 0;
            hydra = 0;
            unknown = 0;
            allTypesKills = 0;
            lastAllTypesKills = 0;
        }

        /// <summary>
        /// Prints thargoid kills to text
        /// </summary>
        /// <returns>String of thargoid kills</returns>
        public string PrintAllKills()
        {
            /*"Thargoid Combat Kills\r\n" + "------------------------" + "\r\nScouts: " + scout + "\r\nCyclops: " + cyclops + "\r\nBasillisk: " + basillisk + "\r\nMedusa: " +
              medusa + "\r\nHydra: " + hydra + "\r\nUnknown: " + unknown + "\r\n------------------------" + "\r\nTotal: " + allTypesKills;*/
            return $"Thargoid Combat Kills\r\n------------------------\r\nScouts: {scout}\r\nCyclops: {cyclops}\r\nBasillisk: {basillisk} " +
                $"\r\nMedusa: {medusa}\r\nHydra: {hydra}\r\nUnknown: {unknown}\r\n------------------------\r\nTotal: {allTypesKills}";
        }

        /// <summary>
        /// Checks if kill count changed
        /// </summary>
        /// <returns>bool true or false</returns>
        public bool CheckKillChange()
        {

            if (allTypesKills > lastAllTypesKills)
            {
                lastAllTypesKills = allTypesKills;
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}