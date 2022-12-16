using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasteTime : MonoBehaviour
{
    [SerializeField] GameObject TimeWaste;

    private bool wasteTime;
    private bool wasted;


    // Start is called before the first frame update
    void Start()
    {
        wasteTime = false;
        wasted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (wasteTime && !wasted)
        {
            Waste();
            wasted = true;
        }
    }

    public void Enter()
    {
        wasteTime = true;
    }

    void Waste()
    {
        PersistentData.Instance.IncreasePenaltyCount();
        Vector2 pos = new Vector2(558.8197f, 274.1418f);
        Instantiate(TimeWaste, pos, Quaternion.identity);
    }

    public void Back()
    {
        Destroy(GameObject.FindWithTag("TimeWaste"));
        wasteTime = false;
        wasted = false;
    }
}
