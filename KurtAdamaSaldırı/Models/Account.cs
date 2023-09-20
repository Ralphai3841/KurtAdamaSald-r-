using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurtAdamaSaldırı.Models
{
    public class Account
    {
        public string userName { get; set; }
        public string race { get; set; }
        public string branch { get; set; }
        public string weapon { get; set; }
        public int damage { get; set; }

        Random random = new Random();
        public void Attack()
        {
            /*
                ırk => human = +5 , monster = +10
                warrior => 40
                mage => 30 - 50
                archer => 10 - 70
                assasin => 5 - 60
             */
            if (race == "Human")
            {
            damage = +5;
            }
            else
            {
                damage = +10;

            }
            switch (branch)
            {
                case "Warrior":
                    damage = +40;
                    break;
                case "Mage":
                    damage += random.Next(30, 50);
                        break;
                case "assasin":
                    break;
                case "Archer":
                    int number = random.Next(0, 2);
                    damage += number == 0 ? 5 : 60;
                    if(number == 0)
                    {
                        damage += 5;
                    }
                    else
                    {
                        damage += 60;
                    }
                    break;
            }

        }

    }
}
