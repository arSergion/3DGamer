using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [NonSerialized]public Vector3 position;
    public float speed = 30f;
    public int damage = 20;
    private void Update() 
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, position, step);
        if(transform.position == position)
            Destroy(gameObject);
    }
private void OnTriggerEnter(Collider other) {
    CarAttack attack = other.GetComponent<CarAttack>();
    if (attack != null) {
        attack._health -= damage;
        Transform healthBar = other.transform.GetChild(0).transform;
        healthBar.localScale = new Vector3(healthBar.localScale.x - 0.3f, healthBar.localScale.y, healthBar.localScale.z);
        if (attack._health <= 0) 
        {
            Destroy(other.gameObject);
        }
    }
    CarAttack1 attack1 = other.GetComponent<CarAttack1>();
    if (attack1 != null) {
        attack1._health -= damage;
        Transform healthBar = other.transform.GetChild(0).transform;
        healthBar.localScale = new Vector3(healthBar.localScale.x - 0.3f, healthBar.localScale.y, healthBar.localScale.z);
        if (attack1._health <= 0) 
        {
            Destroy(other.gameObject);
        }
    }
    }
}
