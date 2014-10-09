// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sim_EX1_241.cs" company="">
//   
// </copyright>
// <summary>
//   The sim_ e x 1_241.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HREngine.Bots
{
    /// <summary>
    /// The sim_ e x 1_241.
    /// </summary>
    class Sim_EX1_241 : SimTemplate
	{
	    // lavaburst

// verursacht $5 schaden. überladung:/ (2)

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
            int dmg = ownplay ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
            p.minionGetDamageOrHeal(target, dmg);
            if (ownplay) p.ueberladung += 2;
		}

	}
}