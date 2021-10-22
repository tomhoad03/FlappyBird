using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public int y;
    public bool top;

    void Start() {
        Vector3 pos = transform.position;
        if (top) {
            pos.y += (float) Random.Range(-2.5f, 0.5f);
        } else{
            pos.y += (float) Random.Range(-0.5f, 2.5f);
        }
        transform.position = pos;
    }

    void FixedUpdate() {
        Vector3 pos = transform.position;
        pos.x -= (float) 0.05 * Time.deltaTime * 100;

        if (pos.x < -10) {
            pos.x = 8;
            pos.y = y;
            if (top) {
                pos.y += (float) Random.Range(-2.5f, 0.5f);
            } else{
                pos.y += (float) Random.Range(-0.5f, 2.5f);
            }
        }
        transform.position = pos;
    }
}