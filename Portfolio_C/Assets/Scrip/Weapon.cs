using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Car_Shooter
{

    [CreateAssetMenu(fileName = "Weapon", menuName = "Item/Weapon", order = 1)]

    public class Weapon : ScriptableObject
    {
        public int amount;
        public int damage;
    }
}
