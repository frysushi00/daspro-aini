//Nama  : Aini Nurul Amri
//NIM   : 2207135967
//Prodi : Teknik Informatika - A

using System;

namespace GameAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Adventure Game");
            Console.WriteLine("Who are You? Please type your Name");
            Newbie player = new Newbie();
            player.Name = Console.ReadLine();
            Console.WriteLine("Hi "+player.Name+", Are you Ready to begin the Adventure?[yes/no]");
            string bReady = Console.ReadLine();
            if (bReady=="yes")
            {
                Console.WriteLine(player.Name+" is entering the Game...");
                Enemy enemy1 = new Enemy("The Dark Witch");
                Console.WriteLine(player.Name+" is encountering "+enemy1.Name);
                Console.WriteLine(enemy1.Name+" is attacking you!");
                Console.WriteLine(enemy1.Name+" : Watch Out");
                Console.WriteLine("Choose your action :");
                Console.WriteLine(" 1. Single Attack");
                Console.WriteLine(" 2. Swing Attack");
                Console.WriteLine(" 3. Run Away");
                Console.WriteLine(" 4. Defend");

                while (!player.IsDead && !enemy1.IsDead)
                {
                    string playerAction = Console.ReadLine();
                    switch(playerAction)
                    {
                        case "1" :
                        Console.WriteLine(player.Name+" is doing Single Attack");
                        enemy1.GetHit(player.AttackPower);
                        player.Experience += 0.5f;
                        enemy1.Attack(enemy1.AttackPower);
                        player.GetHit(enemy1.AttackPower);
                        Console.Write("Player Health: "+player.Health+" |Enemy Health: "+enemy1.Health);
                        break;

                        case "2" :
                        player.Swing();
                        player.Experience += 0.9f;
                        enemy1.GetHit(player.AttackPower);
                        Console.Write("Player Health: "+player.Health+" |Enemy Health: "+enemy1.Health);
                        break;

                        case "3" :
                        Console.WriteLine(player.Name+" is Running away...");
                        break;

                        case "4" :
                        player.Rest();   
                        Console.WriteLine("Energy is being recharged...");
                        enemy1.Attack(enemy1.AttackPower);
                        player.GetHit(enemy1.AttackPower);      
                        Console.Write("Player Health: "+player.Health+" |Enemy Health: "+enemy1.Health);             
                        break;
                    }
                }

                Console.WriteLine();
                Console.WriteLine(player.Name+" get "+player.Experience+" experience point.");
            }else{
                Console.WriteLine("Thank You and Goodbye...");
            }
        }
    }

    class Newbie
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool IsDead { get; set; }
        public float Experience { get; set; }
        Random rnd = new Random();

        public Newbie(){
            Health = 100;
            SkillSlot = 0;
            AttackPower = 1;
            IsDead = false;
            Experience = 0f;
            Name = "New Player";
        }
        public void Swing(){
            if(SkillSlot > 0){
                 Console.WriteLine("SWING!!!");
                 AttackPower = AttackPower + rnd.Next(10,21);
                 SkillSlot--;
            }else{
                Console.WriteLine("Your energy is not enough!");
            }
        }
        public void GetHit(int hitValue){
            Console.WriteLine(Name+" get hit by "+hitValue);
            Health = Health - hitValue;

            if(Health <= 0){
                Health = 0;
                Die(); 
            }
        }
        public void Rest(){
            SkillSlot = 3;
            AttackPower = 1;
        }
        public void Die(){
            Console.WriteLine("You are DEAD, Game Over!");
            IsDead = true;
        }
    }

    class Enemy
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random();

        public Enemy(string name){
            Health = 100;
            Name = name;
        }

        public void Attack(int damage){
            AttackPower = rnd.Next(10,21);
        }

        public void GetHit(int hitValue){
            Console.WriteLine(Name+" get Hit by "+hitValue);
            Health = Health - hitValue;

            if(Health <= 0){
                Health = 0;
                Die();
            }
        }

        public void Die(){
            Console.WriteLine(Name+" is Dead");
            IsDead = true;
        }
    }
}