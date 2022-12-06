using System;
using klasa_rycerz;
using klasa_lucznik;
using Ork;
using kupiec;


namespace klasa_mag{
    public class mag {
    public    int Mag_hp = 60;
    public    int Mag_mana = 120;
    public    int gold = 20;
    public    string typ_ataku = "range";
    public    string  Mag_name = "Hernandez";
    public    string Mag_rasa = "Mag";
    public    string Mag_wybor = "nic";
    public    string Mag_uciekasz = "nic";
    public    string przedmioty = "pusto";

        public Enemy attack(Enemy enemy_to_kill){
            enemy_to_kill.Enemy_hp -= 20;
            return enemy_to_kill;
        }
        
        public Enemy attack_kostur(Enemy enemy_to_kill){
            enemy_to_kill.Enemy_hp -= 15;
            return enemy_to_kill;
        }


    
    }
}