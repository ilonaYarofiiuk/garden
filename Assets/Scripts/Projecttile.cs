using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projecttile : MonoBehaviour
{
    [SerializeField] int damage = 100;
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] float rotationSpeed = 1f;

    public int GetDamage() { return damage; } 

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime); ;
        //transform.Rotate(0,0,rotationSpeed * Time.deltaTime, Space.Self);
        //transform.Rotate(Vector3.forward * Time.deltaTime* moveSpeed, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var enemyHeath = otherCollider.GetComponent<Health>();
        Enamy enamy = otherCollider.GetComponent<Enamy>();
        if (enemyHeath && enamy)
        {
            enemyHeath.DealDamage(damage);
            Destroy(gameObject);
        }
    }
}
