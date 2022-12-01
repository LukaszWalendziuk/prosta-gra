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

        // public string displayObject(){
        //     return "Nazywam się: " + name;
        // }

        public Enemy attack(Enemy enemy_to_kill){
            enemy_to_kill.Enemy_hp -= 10;
            return enemy_to_kill;
        }
        
        Character myHero = new Character();
        Enemy ORK = new Enemy();
        mag Mag = new mag();
        Łucznik lucznik = new Łucznik();
        wybor te_czy_te = new wybor();
        Random rnd = new Random();
        duch_lochow sprzedawca = new duch_lochow();
        
        // public void rycerz_historia(Character myHero,Enemy ORK,mag Mag,Łucznik lucznik,Random rnd,duch_lochow sprzedawca){
        //     if (rola=="rycerz"){
        //         Console.WriteLine ("Trafiasz na Orka!!!");
        //         Console.WriteLine ("---------------------------------------------------");
        //         Console.WriteLine ("Twoje statystyki: ");
        //         Console.WriteLine ("Nazwa: "+myHero.name+ "\nHP Bohatera: "+myHero.hp+"\nMana Bohatera: "+myHero.mana);
        //         Console.WriteLine ("---------------------------------------------------");
        //         Console.WriteLine ("Statystyki Orka: ");
        //         Console.WriteLine ("Nazwa wroga: "+ORK.Enemy_name+ "\nHP Wroga: "+ORK.Enemy_hp+"\nMana Wroga: "+ORK.Enemy_mana);
        //         Console.WriteLine ("---------------------------------------------------");

        //         while (ORK.Enemy_hp>0){
        //             Console.WriteLine("Co robisz?");
        //             Console.WriteLine("Wpisz 1 Atak | 2 Plecak |");
        //             myHero.co_robisz = Convert.ToInt32(Console.ReadLine());
        //             if (myHero.co_robisz==1){
        //                 Console.WriteLine("------------------------");
        //                 Console.WriteLine("Atakujesz");
        //                 Console.WriteLine("Życie Orka: " +ORK.Enemy_hp);
        //                 myHero.attack(ORK);
        //                 Console.WriteLine("Życie Orka: " +ORK.Enemy_hp);
        //                 Console.WriteLine("------------------------");
        //                 if (ORK.Enemy_hp>0){
        //                     Console.WriteLine("------------------------");
        //                     Console.WriteLine("Ork naciera!!!!");
        //                     Console.WriteLine("Twoje życie: " +myHero.hp);
        //                     ORK.attack(myHero);
        //                     Console.WriteLine("Twoje życie: " +myHero.hp);
        //                     Console.WriteLine("------------------------");
        //                 }
        //             }
        //             if (myHero.co_robisz==2){
        //                 Console.WriteLine("---------");
        //                 Console.WriteLine(myHero.przedmioty);
        //                 Console.WriteLine("---------");
        //             }
        //         }
                
                
        //         Console.WriteLine("Ork pokonany");
        //         int wypadlo = rnd.Next(5, 7);
        //         Console.WriteLine("------------------------");
        //         Console.WriteLine("Z Orka wypadło: "+wypadlo+" golda");
        //         Console.WriteLine("------------------------");
        //         myHero.gold += wypadlo ; 
        //         Console.WriteLine ("Nazwa: "+myHero.name+ "\nHP Bohatera: "+myHero.hp+"\nMana Bohatera: "+myHero.mana+"\nIlosć golda: "+ myHero.gold);

        //         Console.WriteLine ("Przed kolejnym orkiem trafiasz na nikogo innego jak ducha starego poległego bohatera któremu nie udało pokonać się wroga");
        //         while (myHero.petla==1){   
        //             Console.WriteLine ("Oferuje on tobie | 1 Hp potion | 2 Ulepszenie ataku | 3 Idź dalej |");
        //             myHero.co_robisz = 0;
        //             myHero.co_robisz = Convert.ToInt32(Console.ReadLine());
        //             if (myHero.co_robisz==1){
        //                 myHero.co_robisz = 0;
        //                 Console.WriteLine("Uwaga jeżeli wypijesz hp potion twoje zdrowie nie zwiększy niż ponad maksymalne");
        //                 Console.WriteLine("Czy chcesz zobaczyć swoje statystki?");
        //                 myHero.ktore="nic";
        //                 myHero.ktore=Console.ReadLine();
        //                 if (myHero.ktore=="tak"){
        //                     Console.WriteLine ("Nazwa: "+myHero.name+ "\nHP Bohatera: "+myHero.hp+"\nMana Bohatera: "+myHero.mana+"\nIlosć golda: "+ myHero.gold);
        //                 }
        //                 Console.WriteLine("Czy chcesz dokonać zakupu?");
        //                 myHero.ktore="nic";
        //                 myHero.ktore=Console.ReadLine();
        //                 if (myHero.ktore=="tak"){
        //                     myHero.hp += sprzedawca.hp_potion;
        //                     Console.WriteLine ("Nazwa: "+myHero.name+ "\nHP Bohatera: "+myHero.hp+"\nMana Bohatera: "+myHero.mana+"\nIlosć golda: "+ myHero.gold);
        //                     myHero.gold -= 20 ; 
        //                 }
        //                 if (myHero.ktore=="nie"){
        //                     myHero.petla=0;
        //                 }

                        
        //             }
        //         }

        //     myHero.petla=1;
        //     }
        // }
    }
}