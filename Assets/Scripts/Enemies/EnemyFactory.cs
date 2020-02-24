using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public GameObject mobile;

    public float minimumFrequency = 1;
    public float maximumFrequency = 5;

    private float timeLeft;

    public Animator animator;

    private void Start()
    {
        timeLeft = generateRandom(minimumFrequency, maximumFrequency);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            float yPosition = generateYPosition();
            GameObject instance = Instantiate(mobile, new Vector3(transform.position.x, yPosition, 0), Quaternion.identity) as GameObject;
            instance.AddComponent<HorizontalMovement>();
            instance.GetComponent<Animator>().SetBool("Moving", true);
            timeLeft = generateRandom(minimumFrequency, maximumFrequency);
        }
    }

    float generateYPosition()
    {
        Vector2 screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        return generateRandom(2, 7);
    }

    float generateRandom(float lower, float upper)
    {
        float value = Random.Range(lower, upper);
        Debug.Log(value.ToString());
        return value;
    }
}
