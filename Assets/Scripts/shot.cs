using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distance; 
    public int damage;
    public LayerMask whatIsSolid;

    // Start is called before the first frame update
    void Start()
    {
        // Получаем позицию мыши в мировых координатах
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Направление от текущей позиции объекта к позиции мыши
        Vector2 direction = (mousePosition - transform.position).normalized;
    }
      void Update(){
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if(hitInfo.collider !=null)
        {
            if(hitInfo.collider.CompareTag("Enemy"))
            {
                hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
            }
             Destroy(gameObject);
        }
       
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    
}
