using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindBalanceDisrupting : MonoBehaviour
{
    float windForce = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        windForce += Random.Range(-10, 10);
        windForce *= Random.Range(0.5f, 1.2f);
        windForce = Mathf.Sign(windForce) * Mathf.Min(100, Mathf.Abs(windForce));

        GetComponent<Balancing>().ApplyForce(windForce * Time.deltaTime);
    }
}
