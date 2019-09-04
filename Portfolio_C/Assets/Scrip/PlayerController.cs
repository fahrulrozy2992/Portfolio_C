using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Car_Shooter;

namespace Car_Shooter
{
    public class PlayerController : MonoBehaviour
    {

        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("ShopTigger"))
                OpenShop();

        }

        void OpenShop()
        {
            Time.timeScale = 0;
            ShopPanelUi.instance.gameObject.SetActive(true);
            ShopPanelUi.instance.SetupShop(this);
        }
    }
}
