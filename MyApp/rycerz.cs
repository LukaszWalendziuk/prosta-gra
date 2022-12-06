using System;
using klasa_lucznik;
using klasa_mag;
using Ork;
using kupiec;
namespace klasa_rycerz
{
    public class Character {
        public    int hp = 100;
        public    int mana = 20;
        public    int gold = 20;
        public    string typ_ataku = "melee";
        public    int atak = 10;
        public    string  name = "TOP G";
        public    string rasa = "ssak";
        public    string  x = "nic";
        public    string ktore = "nic";
        public    string przedmioty = "pusto";
        public    int co_robisz = 0;
        public    int petla = 1;

        public override string ToString() {
            return "Nazywam się: " + name;
        }

        public Enemy attack(Enemy enemy_to_kill){
            enemy_to_kill.Enemy_hp -= atak;
            return enemy_to_kill;
        }      
        
        public void rycerz_historia(Enemy ORK, Random rnd, duch_lochow sprzedawca, wybor te_czy_te){
            if (te_czy_te.rola=="rycerz"){
                Console.WriteLine ("Trafiasz na Orka!!!");
                Console.WriteLine ("---------------------------------------------------");
                Console.WriteLine ("Twoje statystyki: ");
                Console.WriteLine ("Nazwa: " + this.name + "\nHP Bohatera: " + this.hp + "\nRodzaj ataku: "+this.typ_ataku+"\nMana Bohatera: "+ this.mana);
                Console.WriteLine ("---------------------------------------------------");
                Console.WriteLine ("Statystyki Orka: ");
                Console.WriteLine ("Nazwa wroga: "+ORK.Enemy_name+ "\nHP Wroga: "+ORK.Enemy_hp+"\nMana Wroga: "+ORK.Enemy_mana);
                Console.WriteLine ("---------------------------------------------------");

                while (ORK.Enemy_hp>0){
                    Console.WriteLine("Co robisz?");
                    Console.WriteLine("Wpisz (1) Atak | (2) Plecak |");
                    this.co_robisz = Convert.ToInt32(Console.ReadLine());
                    if (this.co_robisz==1){
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Atakujesz");
                        Console.WriteLine("Życie Orka: " +ORK.Enemy_hp);
                        this.attack(ORK);
                        Console.WriteLine("Życie Orka: " +ORK.Enemy_hp);
                        Console.WriteLine("------------------------");
                        if (ORK.Enemy_hp>0){
                            Console.WriteLine("------------------------");
                            Console.WriteLine("Ork naciera!!!!");
                            Console.WriteLine("Twoje życie: " +this.hp);
                            ORK.attack(this);
                            Console.WriteLine("Twoje życie: " +this.hp);
                            Console.WriteLine("------------------------");
                        }
                    }
                    if (this.co_robisz==2){
                        Console.WriteLine("---------");
                        Console.WriteLine(this.przedmioty);
                        Console.WriteLine("---------");
                    }
                }
                
                
                Console.WriteLine("Ork pokonany");
                int wypadlo = rnd.Next(5, 7);
                Console.WriteLine("------------------------");
                Console.WriteLine("Z Orka wypadło: "+wypadlo+" golda");
                Console.WriteLine("------------------------");
                this.gold += wypadlo ; 
                Console.WriteLine ("Nazwa: " + this.name + "\nHP Bohatera: " + this.hp + "\nRodzaj ataku: "+this.typ_ataku+"\nMana Bohatera: "+ this.mana);

                Console.WriteLine ("Przed kolejnym orkiem trafiasz na nikogo innego jak ducha starego poległego bohatera któremu nie udało pokonać się wroga");
                while (this.petla==1){   
                    Console.WriteLine ("Oferuje on tobie | (1) Hp potion | (2) Ulepszenie ataku | (3) Idź dalej |");
                    this.co_robisz = 0;
                    this.co_robisz = Convert.ToInt32(Console.ReadLine());
                    if (this.co_robisz==1){
                        this.co_robisz = 0;
                        Console.WriteLine("Hp potion kosztuje 10 golda");
                        if (this.gold>=10){
                            Console.WriteLine("Uwaga jeżeli wypijesz hp potion twoje zdrowie możę zwiększyć się niż ponad maksymalne");
                            Console.WriteLine("Czy chcesz zobaczyć swoje statystki?");
                            this.ktore="nic";
                            this.ktore=Console.ReadLine();
                            if (this.ktore=="tak"){
                                Console.WriteLine ("Nazwa: " + this.name + "\nHP Bohatera: " + this.hp + "\nRodzaj ataku: "+this.typ_ataku+"\nMana Bohatera: "+ this.mana);
                            }
                            Console.WriteLine("Czy chcesz dokonać zakupu?");
                            this.ktore="nic";
                            this.ktore=Console.ReadLine();
                            if (this.ktore=="tak"){
                                this.hp += sprzedawca.hp_potion;
                                Console.WriteLine ("Nazwa: " + this.name + "\nHP Bohatera: " + this.hp + "\nRodzaj ataku: "+this.typ_ataku+"\nMana Bohatera: "+ this.mana);
                                this.gold -= 20 ; 
                                Console.WriteLine("Nowa ilość golda:"+this.gold);
                            }
                        }
                        else if(this.gold<10){
                            Console.WriteLine("Posiadasz za mało golda");
                            Console.WriteLine("Twój gold:"+this.gold);
                        }
                    }
                    if (this.co_robisz==3){
                        this.petla=0;
                    }   

                    if (this.co_robisz==2){
                        if (this.gold>=15){
                            Console.WriteLine("Twój obecny atak wynosi:"+this.atak);
                            Console.WriteLine("Ulepszenie ataku kosztuje 15 golda\nCzy chcesz dokonać zakupu?");
                            Console.WriteLine("------------------------");
                            this.ktore=Console.ReadLine();
                            if(this.ktore=="tak"){
                                Console.WriteLine("------------------------");
                                Console.WriteLine("Twój obecny atak wynosi:"+this.atak);
                                this.atak=15;
                                Console.WriteLine("Twój NOWY atak wynosi:"+this.atak);
                                Console.WriteLine("------------------------");
                                this.gold -= 15;
                                Console.WriteLine("Nowa ilość golda:"+this.gold);
                                Console.WriteLine("------------------------");
                            }
                        }
                        else if (this.gold<15){
                            Console.WriteLine("Masz za mało golda");
                            Console.WriteLine("Twój gold:"+this.gold);

                        }
                        

                    }
                    
                }

            this.petla=1;
            Console.WriteLine("Ciąg dalszy nastąpi");
            }
        }
    }
}