// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sim_EX1_308.cs" company="">
//   
// </copyright>
// <summary>
//   The sim_ e x 1_308.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace HREngine.Bots
{
    /// <summary>
    /// The sim_ e x 1_308.
    /// </summary>
    class Sim_EX1_308 : SimTemplate
	{
	    // soulfire

// verursacht $4 schaden. werft eine zufällige karte ab.

        /// <summary>
        /// The on card play.
        /// </summary>
        /// <param name="p">
        /// The p.
        /// </param>
        /// <param name="ownplay">
        /// The ownplay.
        /// </param>
        /// <param name="target">
        /// The target.
        /// </param>
        /// <param name="choice">
        /// The choice.
        /// </param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = ownplay ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
            p.minionGetDamageOrHeal(target, dmg);
            if (ownplay)
            {
                p.owncarddraw -= Math.Min(1, p.owncards.Count);
                p.owncards.RemoveRange(0, Math.Min(1, p.owncards.Count));
            }
		}

	}
}