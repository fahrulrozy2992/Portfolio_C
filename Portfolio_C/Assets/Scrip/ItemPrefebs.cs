using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Car_Shooter;

namespace Car_Shooter
{
    public class ItemPrefebs : MonoBehaviour
    {

        [SerializeField] Text titleText;
        public Weapon weaponData;

        public void SetData(string title, Weapon data)
        {
            titleText.text = title;
            weaponData = new Weapon();
            weaponData.amount = data.amount;
            weaponData.damage = data.damage;
        }

        public void SetOnclick(PlayerController pc)
        {
            GetComponent<Button>();
        }
    }
}
