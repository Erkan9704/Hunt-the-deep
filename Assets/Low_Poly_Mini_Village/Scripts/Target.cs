
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public ParticleSystem impactEffect;
    public AudioSource Deathsoundeffect;


    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }


    }

    void Die()
    {
        Deathsoundeffect.Play();
        impactEffect.Play();
        Destroy(gameObject);
        
    }

}
