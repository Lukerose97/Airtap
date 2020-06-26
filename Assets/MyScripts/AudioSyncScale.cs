using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSyncScale : AudioSyncer
{
    public Vector3 beatScale;
    public Vector3 restScale;
    /*un-comment when recording notes for a new song
    public GameObject MovingItems;
    public Transform newPosition;
    */

    private IEnumerator MoveToScale(Vector3 _target)
    {
        Vector3 current = transform.localScale;
        Vector3 initial = current;
        float _timer = 0;

        while (current != _target)
        {
            current = Vector3.Lerp(initial, _target, _timer / timeToBeat);
            _timer += Time.deltaTime;

            transform.localScale = current;

            yield return null;
        }
        isBeat = false;
    }

    public override void OnUpdate()
    {
        base.OnUpdate();

        if (isBeat) return;

        transform.localScale = Vector3.Lerp(transform.localScale, restScale, restSmoothTime * Time.deltaTime);
    }

    public override void OnBeat()
    {
        base.OnBeat();

        StopCoroutine("MoveToScale");
        StartCoroutine("MoveToScale", beatScale);
        /*un-comment when recording notes for a new song
        Instantiate(MovingItems, newPosition.position, Quaternion.identity);
        MovingItems.SetActive(true);
        */
    }
}
