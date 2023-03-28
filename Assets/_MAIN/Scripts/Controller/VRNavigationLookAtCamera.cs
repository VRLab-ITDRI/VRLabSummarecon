using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRNavigationLookAtCamera : MonoBehaviour
{
    private GameObject nav;
    private GameObject cam;

    private void Start()
    {
        nav = this.gameObject;
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        ChangeParent();
    }

    void ChangeParent()
    {
        nav.transform.parent = cam.transform;
    }

    //Revert the parent of object 2.
    public void DestroyNavigation()
    {
        Destroy(gameObject);
    }

        //public Transform target;
        //public float speed;

        //private Coroutine LookCoroutine;

        //private void Update()
        //{
        //    StartRotating();
        //}

        //public void StartRotating()
        //{
        //    if (LookCoroutine != null)
        //    {
        //        StopCoroutine(LookCoroutine);
        //    }
        //}

        //private IEnumerator DelayLookAt()
        //{
        //    Quaternion lookRotation = Quaternion.LookRotation(target.position - transform.position);

        //    float time = 0;

        //    while (time < 1)
        //    {
        //        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, time);

        //        time += Time.deltaTime * speed;

        //        yield return null;
        //    }
        //}

        //public float speed;
        //public Transform target = null;

        //private void FixedUpdate()
        //{
        //    transform.LookAt(target.position);
        //    transform.rotation = Quaternion.LookRotation(target.forward);

        //    Quaternion rotTarget = Quaternion.LookRotation(target.position + this.transform.position);
        //    this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, rotTarget, speed * Time.fixedDeltaTime);
        //}
    }
