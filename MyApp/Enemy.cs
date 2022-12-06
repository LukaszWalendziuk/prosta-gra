using System;
using klasa_lucznik;
using klasa_mag;
using klasa_rycerz;
using kupiec;


namespace Ork{
    public class Enemy {
    public    int Enemy_hp = 20;
    public    int Enemy_mana = 20;
    public    string  Enemy_name = "ORK";
    public    string Enemy_rasa = "ORKOWIE";

        public override string ToString(){
            return "Postać: " + Enemy_name + "hp: " + Enemy_hp;
        }

        public Character attack(Character character_to_kill){
            character_to_kill.hp -= 10;
            return character_to_kill;
        }
        

    
    }
}