using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dice dice = new Dice();


            Character hero = new Character();
            hero.Name = "Easy Company";
            hero.Health = 110;
            hero.DamageMaximum = 60;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Bad guys";
            monster.Health = 150;
            monster.DamageMaximum = 45;
            monster.AttackBonus = true;

            if (hero.AttackBonus)
                monster.Defend(hero.Attack(dice));
            if (monster.AttackBonus)
                hero.Defend(monster.Attack(dice));


            /*
            int damage = hero.Attack();
            monster.Defend(damage);

            damage = monster.Attack();
            hero.Defend(damage);

            printStats(hero);
            printStats(monster); */

            while (hero.Health > 0 && monster.Health > 0)
            {
                monster.Defend(hero.Attack(dice));
                hero.Defend(monster.Attack(dice));

                outcome(hero);
                outcome(monster);
            }

            displayResults(hero, monster);
        }

        private void outcome(Character character)
        {
            resultLabel.Text += String.Format("<p>Name: {0} - Health: {1} - DamageMax: {2} - AttackBonus: {3}</p>", character.Name, character.Health, character.DamageMaximum.ToString(), character.AttackBonus.ToString());
        }
        
        private void displayResults(Character opponent1, Character opponent2)
        {
            if (opponent1.Health <= 0 && opponent2.Health <= 0)
                resultLabel.Text += String.Format("<p>There is no clear winner here seeing as the hero {0} and the villian {1} are now dead</p>", opponent1.Name, opponent2.Name);
            if (opponent1.Health > 0 && opponent2.Health <= 0)
                resultLabel.Text += String.Format("<p> {0} wins! </p>", opponent1.Name);
            if (opponent1.Health <= 0 && opponent2.Health > 0)
                resultLabel.Text += String.Format("<p> {0} win! </p>", opponent2.Name);
        }

        class Character
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int DamageMaximum { get; set; }
            public bool AttackBonus { get; set; }

            public int Attack(Dice dice)
            {
                //Random random = new Random();
                //int damage = random.Next(this.DamageMaximum);
                //return damage;

                dice.Sides = this.DamageMaximum;

                return dice.diceRoll();
            }

            public void Defend(int damage)
            {
                this.Health -= damage;
            }

        }

        class Dice
        {
            public int Sides { get; set; }
            Random random = new Random();
            public int diceRoll()
            {
                return random.Next(this.Sides);
            }
        }
    }
}