using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{
    
    public class Health : MonoBehaviour
    {
        [SerializeField] private int currentHealth;

        void Start ()
        {

        }
        

         void TakeDamage(int damageAmount)
        {
            currentHealth -= damageAmount;

            if (currentHealth < 1)
            {
                Destroy(gameObject);
            }
        }
        public static void TryDamage(GameObject target, int damageAmount)
        {
            Health health = target.GetComponent<Health>();
            if(health != null)
            {
                health.TakeDamage(damageAmount);
            }
        }
    }
}

