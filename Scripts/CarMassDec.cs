using UnityEngine;

public class CarMassDec : MonoBehaviour
{
    public string carName;
    public float drag;
    GameObject go;

    void Start()
    {
        carName = "car";
        drag = 0.5f;

        updateDrag();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.J))
        {
            if(drag > 0.2f)
            {
                drag -= 0.1f;
                updateDrag();

            }
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            drag += 0.1f;
            updateDrag();
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 100, 50), "Drag: " + drag);
    }

    void updateDrag()
    {
        try
        {
            go = GameObject.Find(carName);
            go.GetComponent<Rigidbody>().drag = drag;
            OnGUI();
        }
        catch (System.Exception ex)
        {
            Debug.Log("Bir hata oluştu! -> " + ex);
        }
    }
}
