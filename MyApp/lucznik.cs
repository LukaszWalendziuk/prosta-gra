using System;
using klasa_rycerz;
using klasa_mag;
using Ork;
using kupiec;


namespace klasa_lucznik{
    public class Łucznik {
    public    int lucznik_hp = 80;
    public    int lucznik_mana = 40;
    public    int gold = 20;
    public    string typ_ataku = "range";
    public    string  lucznik_name = "Elciapo";
    public    string lucznik_rasa = "człowiek";
    public    string lucznik_wybor = "nic";
    public    string przedmioty = "pusto";

        public Enemy attack(Enemy enemy_to_kill){
            enemy_to_kill.Enemy_hp -= 15;
            return enemy_to_kill;
        }

        Character myHero = new Character();
        Enemy ORK = new Enemy();
        mag Mag = new mag();
        Łucznik lucznik = new Łucznik();
        wybor te_czy_te = new wybor();
        Random rnd = new Random();
        duch_lochow sprzedawca = new duch_lochow();
    
    }
}