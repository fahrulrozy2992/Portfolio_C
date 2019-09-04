using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Car_Shooter;

namespace Car_Shooter
{

    public class GunRotate : MonoBehaviour
    {

        public Transform GunSpoon;
        public GameObject bullet;
        float Minimuangel = -45f;
        float Maxmuangel = 45f;
        float CurrentAngel = 0f;
        float timer = 0;
        float fireRate = 0.1f;
        public Weapon currentWeapon;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            RotateGun();
            Shooting();            
        }

        void RotateGun()
        {
            if (Input.GetKey(KeyCode.W))
            {
                CurrentAngel += 1;
                CurrentAngel = Mathf.Clamp(CurrentAngel, Minimuangel, Maxmuangel);
                transform.rotation = Quaternion.Euler(0, 0, CurrentAngel);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                CurrentAngel -= 1;
                CurrentAngel = Mathf.Clamp(CurrentAngel, Minimuangel, Maxmuangel);
                transform.rotation = Quaternion.Euler(0, 0, CurrentAngel);
            }
        }
        void Shooting()
        {
            timer += Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space) && timer >= fireRate)
                SpownBullet();
        }
        void SpownBullet()
        {
            if(currentWeapon.amount <= 0)
            {
                return;
            }                         
            Instantiate(bullet, transform.position, transform.rotation);            
            currentWeapon.amount--;
            Debug.Log(string.Format("Current Amount: {0}", currentWeapon.amount));
        }
        public void ChangeWeapon(Weapon data)
        {
            currentWeapon = new Weapon();
            currentWeapon.amount = data.amount;
            currentWeapon.damage = data.damage;
        }
    }
}
