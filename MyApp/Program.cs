
using System;
using klasa_rycerz;
using klasa_lucznik;
using klasa_mag;
using Ork;
using kupiec;

    




// public class Character {
//     public    int hp = 100;
//     public    int mana = 20;
//     public    int gold = 20;
//     public    string typ_ataku = "melee";
//     public    string  name = "TOP G";
//     public    string rasa = "ssak";
//     public    string  x = "nic";
//     public    string wybor = "nic";
//     public    string przedmioty = "pusto";
//     public    int co_robisz = 0;
//     public    int petla = 1;
 
    

//     public override string ToString() {
//         return "Nazywam się: " + name;
//     }   

//     // public string displayObject(){
//     //     return "Nazywam się: " + name;
//     // }

//     public Enemy attack(Enemy enemy_to_kill){
//         enemy_to_kill.Enemy_hp -= 10;
//         return enemy_to_kill;
//     }


    


// }

// public class Enemy {
//     public    int Enemy_hp = 20;
//     public    int Enemy_mana = 20;
//     public    string  Enemy_name = "ORK";
//     public    string Enemy_rasa = "ORKOWIE";

//     public override string ToString(){
//         return "Postać: " + Enemy_name + "hp: " + Enemy_hp;
//     }

//     public Character attack(Character character_to_kill){
//         character_to_kill.hp -= 10;
//         return character_to_kill;
//     }

    
// }

// public class Mag {
//     public    int Mag_hp = 60;
//     public    int Mag_mana = 120;
//     public    int gold = 20;
//     public    string typ_ataku = "range";
//     public    string  Mag_name = "Hernandez";
//     public    string Mag_rasa = "Mag";
//     public    string Mag_wybor = "nic";
//     public    string Mag_uciekasz = "nic";
//     public    string przedmioty = "pusto";

//     public Enemy attack(Enemy enemy_to_kill){
//         enemy_to_kill.Enemy_hp -= 20;
//         return enemy_to_kill;
//     }
    
//     public Enemy attack_kostur(Enemy enemy_to_kill){
//         enemy_to_kill.Enemy_hp -= 15;
//         return enemy_to_kill;
//     }

    
// }

// public class lucznik {
//     public    int lucznik_hp = 80;
//     public    int lucznik_mana = 40;
//     public    int gold = 20;
//     public    string typ_ataku = "range";
//     public    string  lucznik_name = "Elciapo";
//     public    string lucznik_rasa = "człowiek";
//     public    string lucznik_wybor = "nic";
//     public    string przedmioty = "pusto";

//     public Enemy attack(Enemy enemy_to_kill){
//         enemy_to_kill.Enemy_hp -= 15;
//         return enemy_to_kill;
//     }
    
// }

// public class duch_lochow{
//     public int hp_potion = 20;
//     public int ulepszenie_ataku = 0;
// }

public class wybor {
    public string rola = "nic";

    public void selectRole(Character myHero, mag Mag, Łucznik lucznik) {
        Console.WriteLine("Obecnie działa jedynie klasa rycerz, reszta jest w trakcie robienia");
        Console.WriteLine("Jaką klasę wybierasz rycerz | mag | łucznik ");
        string rola = Console.ReadLine();
        Console.WriteLine ("---------------------------------------------------");
        if (rola=="rycerz"){
            Console.WriteLine ("Nazwa: "+myHero.name+ "\nHP Bohatera: "+myHero.hp+"\nMana Bohatera: "+myHero.mana+"\nRodzaj ataku: "+myHero.typ_ataku+"\nGold Bohatera: "+myHero.gold);
            this.rola = rola;
        }
        else if (rola=="mag"){
            Console.WriteLine ("Nazwa: "+Mag.Mag_name+ "\nHP Bohatera: "+Mag.Mag_hp+"\nMana Bohatera: "+Mag.Mag_mana+"\nRodzaj ataku: "+Mag.typ_ataku+"\nGold Bohatera: "+Mag.gold);
            this.rola = rola;
        }
        else if (rola=="łucznik"){
            Console.WriteLine ("Nazwa: "+lucznik.lucznik_name+ "\nHP Bohatera: "+lucznik.lucznik_hp+"\nMana Bohatera: "+lucznik.lucznik_mana+"\nRodzaj ataku: "+lucznik.typ_ataku+"\nGold Bohatera: "+lucznik.gold);
            this.rola = rola;
        } 
        else if(this.rola != "rycerz" || this.rola != "mag" || this.rola != "lucznik"){
            Console.WriteLine("Wybierz rycerza | maga | łucznika!");
            selectRole(myHero, Mag, lucznik);
        } else {
            Console.WriteLine("Jakiś nierozpatrozny warunek!!");
        }
        Console.WriteLine ("---------------------------------------------------");
        Console.WriteLine("Aby dostać się do LeJacy musisz pokonać 5 orków\nOrkowie będą stawiali coraz większy opór więc walcz ostrożnie");
        Console.WriteLine ("---------------------------------------------------");
    }
}
public class Program
{
    public static void Main()
    {
        
        Character myHero = new Character();
        Enemy ORK = new Enemy();
        mag Mag = new mag();
        Łucznik lucznik = new Łucznik();
        wybor te_czy_te = new wybor();
        Random rnd = new Random();
        duch_lochow sprzedawca = new duch_lochow();
        
        Console.WriteLine("----------WITAJ W DUNGEON OF JACA----------");
        Console.WriteLine("Wchodzisz do miejsca pełnego magii i róznorakich stworzeń");
        Console.WriteLine("Twoim celem jest pokananie LeJaca największego i najgorszego z Jaców");
        Console.WriteLine("Na początku musisz wybrać klasę: ");
        Console.WriteLine ("---------------------------------------------------");

        
        te_czy_te.selectRole(myHero, Mag, lucznik);
        if (te_czy_te.rola=="rycerz"){
                int redo = 0;
                int width = 15;
                int height = 10;

                ConsoleKeyInfo KeyInfo;
                do
                {
                    string text = System.IO.File.ReadAllText(@"/home/ukasz/C# programy/MyApp/mapa.txt");


                    KeyInfo = Console.ReadKey(true);
                    Console.Clear();
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine(text);

                    Console.SetCursorPosition(22, 15);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write('W');
                


                    switch (KeyInfo.Key)

                    {
                        case ConsoleKey.RightArrow:
                            width++;
                            Console.SetCursorPosition(width, height);
                            Console.Write("X");
                            break;
                        case ConsoleKey.LeftArrow:
                            width--;
                            Console.SetCursorPosition(width, height);
                            Console.Write("X");
                            break;
                        case ConsoleKey.UpArrow:
                            height--;
                            Console.SetCursorPosition(width, height);
                            Console.Write("X");
                            break;
                        case ConsoleKey.DownArrow:
                            height++;
                            Console.SetCursorPosition(width, height);
                            Console.Write("X");
                            break;
                    }
                    if (width==22 && height == 15){
                        myHero.rycerz_historia(ORK, rnd, sprzedawca, te_czy_te);
                    }
                }while (redo == 0);

            
        }
        // if (te_czy_te.rola=="rycerz"){
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
   
        // if (rola=="mag"){
            
        //     Console.WriteLine ("Moja nazwa: "+Mag.Mag_name+ "\nHP Bohatera: "+Mag.Mag_hp+"\nMana Bohatera: "+Mag.Mag_mana);


        //     Console.WriteLine ("---------------------------------------------------");

        //     Console.WriteLine ("Nazwa wroga: "+ORK.Enemy_name+ "\nHP Wroga: "+ORK.Enemy_hp+"\nMana Wroga: "+ORK.Enemy_mana);
            
        //     Console.WriteLine ("---------------------------------------------------");

        //     Console.WriteLine("Chcesz używać kostura tak czy nie? ");

        //     Mag.Mag_wybor = Console.ReadLine();
        //     if (Mag.Mag_wybor=="tak") {
        //         Console.WriteLine ("---------------------------------------------------");
        //         Console.WriteLine("Wybrałeś kostur czarno-księżnika!!!\nOrk naciera co robisz uciekasz czy walczysz?");
        //         Mag.Mag_uciekasz = Console.ReadLine();
        //         if (Mag.Mag_uciekasz=="uciekasz") {
        //             Console.WriteLine ("---------------------------------------------------");
        //             Console.WriteLine("Udało ci się zwiać ale Ork będzie dalej żył i żerował na ludziach D: ");
        //         }
        //         else {
        //             Console.WriteLine("Życie Orka: " +ORK.Enemy_hp);
        //             while(ORK.Enemy_hp>0){
        //                 Mag.Mag_mana -= 5;
        //                 Mag.attack_kostur(ORK);
        //                 Console.WriteLine("Życie Orka: " +ORK.Enemy_hp);
        //             }
        //             Console.WriteLine("Zabijasz Orka bez problemu JESTEŚ BOHATEREM ");
        //         }
                
        //     }

            

        //     else {
        //         Console.WriteLine("Walczysz gołymi pięśćmi!");
        //         Console.WriteLine("Życie Orka: " +ORK.Enemy_hp);
        //         while (ORK.Enemy_hp>0){
        //             myHero.attack(ORK);
        //             Console.WriteLine("Życie Orka: " +ORK.Enemy_hp);
        //         }
        //         Console.WriteLine("Wygrywasz");
        //     }
        // }

    }
}