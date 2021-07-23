using UnityEngine;
using System.Collections;

public class PlayerWeapon : MonoBehaviour {

    #region Public Properties
    public GameObject projectile;
    public NinjaAnimation ninjaAnimation;
	public float speed = 50f;
	public float reload = 0f;
    private Vector3 facing;
    
    
    
    #endregion

    #region Private Properties
    private bool fired = false;
    private int used = 0;
    private bool destroy = false;
    #endregion

    void Update () {

        //fire command
        if ((ninjaAnimation.IsThrowing()) && !fired)
        {
            Fire();
            used += 1;
            
        }

       
            facing = transform.right * speed;

        //shoot left or right **WORK ON THIS
        if (ninjaAnimation.IsRight() == false)
        {
            facing = transform.right * -speed;
        }

    }

    //fire weapon
    public void Fire() {
		if (!fired && used<5)
        {
			fired = true;

			GameObject instance = Instantiate (projectile, transform.position, transform.rotation) as GameObject;

            Rigidbody rbInstance = instance.GetComponent<Rigidbody>();
            rbInstance.AddForce(facing);
            StartCoroutine(Reload (rbInstance));
            
        }

        

    }

    //reload timer
    private IEnumerator Reload(Rigidbody instance)
    {
        yield return new WaitForSeconds(reload);
        if (destroy)
        {
            Destroy(instance.gameObject, 3);
            used -= 1;
            fired = false;
        }
        //Destroy(instance.gameObject,3);
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        destroy = true;
        Debug.Log(destroy);
    }
}
